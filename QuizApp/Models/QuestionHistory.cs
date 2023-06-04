namespace QuizApp.Models
{
    public class QuestionHistory
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<AnswerSelected> Answers { get; set; }
    }
}
