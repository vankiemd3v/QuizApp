using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using System;
using System.Diagnostics;

namespace QuizApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Question()
        {
            var questions = new Question().Questions();                             // Tạo list câu hỏi
            var random = new Random();
            var questionsRandom = new List<Question>();
            for(int i = 1; i <= 10; i++)
            {
                int number = random.Next(1, questions.Count()+1);                   // Random từ 1 -> 20
                if (questions.Any(x => x.Id == number))                             // Nếu danh sách câu hỏi có Id = Id random
                {
                    if(questionsRandom.Find(x => x.Id == number) == null)           // Nếu chưa tồn tại question thì add, còn đã tồn tại thì lùi lại lấy question khác
                    {
                        var question = questions.Find(x => x.Id == number);
                        questionsRandom.Add(question);
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            return View(questionsRandom);
        }
        
        [HttpPost]
        public async Task<IActionResult> History(List<AnswerSelected> list)
        {
            var questions = new Question().Questions();                     // Tạo 1 list câu hỏi
            var history = new List<QuestionHistory>();
            foreach (var item in list)
            {
                foreach(var question in questions)
                {
                    var ListAnswer = new List<AnswerSelected>();
                    foreach (var answer in question.Answers)                // Thêm 4 câu trả lời vào câu hỏi, nếu đó là đáp án được chọn thì cho selected = true, ngược lại là false
                    {
                        if (answer.Id == item.Id)
                        {
                            var answerSelected = new AnswerSelected()
                            {
                                Id = answer.Id,
                                Content = answer.Content,
                                Correct = answer.Correct,
                                QuestionId = question.Id,
                                Selected = true
                            };
                            ListAnswer.Add(answerSelected);
                        }
                        else
                        {
                            var answerSelected = new AnswerSelected()
                            {
                                Id = answer.Id,
                                Content = answer.Content,
                                Correct = answer.Correct,
                                QuestionId = question.Id,
                                Selected = false
                            };
                            ListAnswer.Add(answerSelected);
                        }
                    }
                    foreach (var answer in question.Answers)
                    {
                        if (answer.Id == item.Id)
                        {
                            history.Add(new QuestionHistory()               // Thêm câu hỏi đã chọn vào danh sách
                            {
                                Id = question.Id,
                                Content = question.Content,
                                Answers = ListAnswer
                            });
                        }
                    }
                    
                }
            }
            return Json(new {model = history});                             // Trả về 1 danh sách kiểu json
        }
    }
}