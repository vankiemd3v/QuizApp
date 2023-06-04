namespace QuizApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }
        public List<Question> Questions()
        {
            var answers1 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 1,
                    QuestionId = 1,
                    Content = "A. Miệng",
                    Correct = false
                },
                new Answer()
                {
                    Id = 2,
                    QuestionId = 1,
                    Content = "B. Mặt",
                    Correct = false
                },
                new Answer()
                {
                    Id = 3,
                    QuestionId = 1,
                    Content = "C. Mông",
                    Correct = false
                },
                new Answer()
                {
                    Id = 4,
                    QuestionId = 1,
                    Content = "D. Bụng",
                    Correct = true
                },
            };
            var answers2 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 5,
                    QuestionId = 2,
                    Content = "A. Con trâu",
                    Correct = false
                },
                new Answer()
                {
                    Id = 6,
                    QuestionId = 2,
                    Content = "B. Con bò",
                    Correct = true
                },
                new Answer()
                {
                    Id = 7,
                    QuestionId = 2,
                    Content = "C. Con gà",
                    Correct = false
                },
                new Answer()
                {
                    Id = 8,
                    QuestionId = 2,
                    Content = "D. Con chó",
                    Correct = false
                }
            };
            var answers3 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 9,
                    QuestionId = 3,
                    Content = "A. Chú",
                    Correct = false
                },
                new Answer()
                {
                    Id = 10,
                    QuestionId = 3,
                    Content = "B. Cậu",
                    Correct = false
                },
                new Answer()
                {
                    Id = 11,
                    QuestionId = 3,
                    Content = "C. Mồm",
                    Correct = true
                },
                new Answer()
                {
                    Id = 12,
                    QuestionId = 3,
                    Content = "D. Không biết",
                    Correct = false
                }
            };
            var answers4 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 13,
                    QuestionId = 4,
                    Content = "A. Thứ nhất",
                    Correct = false
                },
                new Answer()
                {
                    Id = 14,
                    QuestionId = 4,
                    Content = "B. Thứ nhì",
                    Correct = true
                },
                new Answer()
                {
                    Id = 15,
                    QuestionId = 4,
                    Content = "C. Thứ ba",
                    Correct = false
                },
                new Answer()
                {
                    Id = 16,
                    QuestionId = 4,
                    Content = "D. Thứ tư",
                    Correct = false
                }
            };
            var answers5 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 17,
                    QuestionId = 5,
                    Content = "A. Đánh răng",
                    Correct = false
                },
                new Answer()
                {
                    Id = 18,
                    QuestionId = 5,
                    Content = "B. Rửa mặt",
                    Correct = false
                },
                new Answer()
                {
                    Id = 19,
                    QuestionId = 5,
                    Content = "C. Uống nước",
                    Correct = false
                },
                new Answer()
                {
                    Id = 20,
                    QuestionId = 5,
                    Content = "D. Mở mắt",
                    Correct = true
                }
            };
            var answers6 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 21,
                    QuestionId = 6,
                    Content = "A. 9",
                    Correct = true
                },
                new Answer()
                {
                    Id = 22,
                    QuestionId = 6,
                    Content = "B. 8",
                    Correct = false
                },
                new Answer()
                {
                    Id = 23,
                    QuestionId = 6,
                    Content = "C. 7",
                    Correct = false
                },
                new Answer()
                {
                    Id = 24,
                    QuestionId = 6,
                    Content = "D. 6",
                    Correct = false
                }
            };
            var answers7 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 25,
                    QuestionId = 7,
                    Content = "A. 12",
                    Correct = false
                },
                new Answer()
                {
                    Id = 26,
                    QuestionId = 7,
                    Content = "B. 8",
                    Correct = false
                },
                new Answer()
                {
                    Id = 27,
                    QuestionId = 7,
                    Content = "C. 4",
                    Correct = true
                },
                new Answer()
                {
                    Id = 28,
                    QuestionId = 7,
                    Content = "D. 10",
                    Correct = false
                }
            };
            var answers8 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 29,
                    QuestionId = 8,
                    Content = "A. 1 chữ C",
                    Correct = true
                },
                new Answer()
                {
                    Id = 30,
                    QuestionId = 8,
                    Content = "B. 2 chữ C",
                    Correct = false
                },
                new Answer()
                {
                    Id = 31,
                    QuestionId = 8,
                    Content = "C. 3 chữ C",
                    Correct = false
                },
                new Answer()
                {
                    Id = 32,
                    QuestionId = 8,
                    Content = "D. 4 chữ C",
                    Correct = false
                }
            };
            var answers9 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 33,
                    QuestionId = 9,
                    Content = "A. Cây đèn",
                    Correct = false
                },
                new Answer()
                {
                    Id = 34,
                    QuestionId = 9,
                    Content = "B. Bếp dầu",
                    Correct = false
                },
                new Answer()
                {
                    Id = 35,
                    QuestionId = 9,
                    Content = "C. Bếp củi",
                    Correct = false
                },
                new Answer()
                {
                    Id = 36,
                    QuestionId = 9,
                    Content = "D. Que diêm",
                    Correct = true
                }
            };
            var answers10 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 37,
                    QuestionId = 10,
                    Content = "A. 1.000 từ",
                    Correct = false
                },
                new Answer()
                {
                    Id = 38,
                    QuestionId = 10,
                    Content = "B. 1.000.000 từ",
                    Correct = false
                },
                new Answer()
                {
                    Id = 39,
                    QuestionId = 10,
                    Content = "C. 2 từ",
                    Correct = true
                },
                new Answer()
                {
                    Id = 40,
                    QuestionId = 10,
                    Content = "D. Vô số từ",
                    Correct = false
                }
            };
            var answers11 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 41,
                    QuestionId = 11,
                    Content = "A. Con sông",
                    Correct = true
                },
                new Answer()
                {
                    Id = 42,
                    QuestionId = 11,
                    Content = "B. Con người",
                    Correct = false
                },
                new Answer()
                {
                    Id = 43,
                    QuestionId = 11,
                    Content = "C. Con voi",
                    Correct = false
                },
                new Answer()
                {
                    Id = 44,
                    QuestionId = 10,
                    Content = "D. Con trâu",
                    Correct = false
                }
            };
            var answers12 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 45,
                    QuestionId = 12,
                    Content = "A. Sự nghiệp",
                    Correct = false
                },
                new Answer()
                {
                    Id = 46,
                    QuestionId = 12,
                    Content = "B. Đẹp trai",
                    Correct = false
                },
                new Answer()
                {
                    Id = 47,
                    QuestionId = 12,
                    Content = "C. Con ciu :v",
                    Correct = false
                },
                new Answer()
                {
                    Id = 48,
                    QuestionId = 12,
                    Content = "D. Ngọc trai",
                    Correct = true
                }
            };
            var answers13 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 49,
                    QuestionId = 13,
                    Content = "A. Tay phải",
                    Correct = true
                },
                new Answer()
                {
                    Id = 50,
                    QuestionId = 13,
                    Content = "B. Tay trái",
                    Correct = false
                },
                new Answer()
                {
                    Id = 51,
                    QuestionId = 13,
                    Content = "C. Chân phải",
                    Correct = false
                },
                new Answer()
                {
                    Id = 52,
                    QuestionId = 13,
                    Content = "D. Chân trái",
                    Correct = false
                }
            };
            var answers14 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 53,
                    QuestionId = 14,
                    Content = "A. Đá bóng",
                    Correct = false
                },
                new Answer()
                {
                    Id = 54,
                    QuestionId = 14,
                    Content = "B. Bóng chuyền",
                    Correct = false
                },
                new Answer()
                {
                    Id = 55,
                    QuestionId = 14,
                    Content = "C. Đua xe đạp",
                    Correct = true
                },
                new Answer()
                {
                    Id = 56,
                    QuestionId = 14,
                    Content = "D. Đua thuyền",
                    Correct = false
                }
            };
            var answers15 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 57,
                    QuestionId = 15,
                    Content = "A. Đỉnh Fansipan",
                    Correct = false
                },
                new Answer()
                {
                    Id = 58,
                    QuestionId = 15,
                    Content = "B. Núi K2",
                    Correct = false
                },
                new Answer()
                {
                    Id = 59,
                    QuestionId = 15,
                    Content = "C. Núi Makalu",
                    Correct = false
                },
                new Answer()
                {
                    Id = 60,
                    QuestionId = 15,
                    Content = "D. Đỉnh Everest",
                    Correct = true
                }
            };
            var answers16 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 61,
                    QuestionId = 16,
                    Content = "A. Con dê",
                    Correct = false
                },
                new Answer()
                {
                    Id = 62,
                    QuestionId = 16,
                    Content = "B. Con ốc",
                    Correct = false
                },
                new Answer()
                {
                    Id = 63,
                    QuestionId = 16,
                    Content = "C. Con dốc",
                    Correct = true
                },
                new Answer()
                {
                    Id = 64,
                    QuestionId = 16,
                    Content = "D. Con ốc bu trên con dê",
                    Correct = false
                }
            };
            var answers17 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 65,
                    QuestionId = 17,
                    Content = "A. Cái hố",
                    Correct = false
                },
                new Answer()
                {
                    Id = 66,
                    QuestionId = 17,
                    Content = "B. Biển",
                    Correct = true
                },
                new Answer()
                {
                    Id = 67,
                    QuestionId = 17,
                    Content = "C. Cái ao",
                    Correct = false
                },
                new Answer()
                {
                    Id = 68,
                    QuestionId = 17,
                    Content = "D. Hầm",
                    Correct = false
                }
            };
            var answers18 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 69,
                    QuestionId = 18,
                    Content = "A. 1 tháng",
                    Correct = false
                },
                new Answer()
                {
                    Id = 70,
                    QuestionId = 18,
                    Content = "B. 5 tháng",
                    Correct = false
                },
                new Answer()
                {
                    Id = 71,
                    QuestionId = 18,
                    Content = "C. 8 tháng",
                    Correct = false
                },
                new Answer()
                {
                    Id = 72,
                    QuestionId = 18,
                    Content = "D. 12 tháng",
                    Correct = true
                }
            };
            var answers19 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 73,
                    QuestionId = 19,
                    Content = "A. Con heo",
                    Correct = false
                },
                new Answer()
                {
                    Id = 74,
                    QuestionId = 19,
                    Content = "B. Con cá mập",
                    Correct = true
                },
                new Answer()
                {
                    Id = 75,
                    QuestionId = 19,
                    Content = "C. Con hà mã",
                    Correct = false
                },
                new Answer()
                {
                    Id = 76,
                    QuestionId = 19,
                    Content = "D. Con voi",
                    Correct = false
                }
            };
            var answers20 = new List<Answer>()
            {
                new Answer()
                {
                    Id = 77,
                    QuestionId = 20,
                    Content = "A. Con dao",
                    Correct = true
                },
                new Answer()
                {
                    Id = 78,
                    QuestionId = 20,
                    Content = "B. Con dơi",
                    Correct = false
                },
                new Answer()
                {
                    Id = 79,
                    QuestionId = 20,
                    Content = "C. Con hải cẩu",
                    Correct = false
                },
                new Answer()
                {
                    Id = 80,
                    QuestionId = 20,
                    Content = "D. Con chim cánh cụt",
                    Correct = false
                }
            };

            var questions = new List<Question>()
            {
                new Question()
                {
                     Id = 1,
                     Content = "Điền vào chỗ trống: Trăng lên mười sau trăng tròn, em lên mười sáu ... tròn hơn trăng :v",
                     Answers = answers1,
                },
                new Question()
                {
                    Id = 2,
                    Content = "Con gì biết đi nhưng người ta vẫn nói nó không đi?",
                    Answers = answers2,
                },
                new Question()
                {
                    Id = 3,
                    Content = "A gọi B bằng bác, B gọi C là ông nội , C kêu D là cậu, D kêu E là dì, E kêu F là chú, F gọi Z là con. Hỏi A gọi Z bằng gì ???",
                    Answers = answers3,
                },
                new Question()
                {
                    Id = 4,
                    Content = "Bạn đang ở trong một cuộc đua và bạn vừa vượt qua người thứ nhì. Vậy bây giờ bạn đang ở vị trí nào trong đoàn đua ấy?",
                    Answers = answers4,
                },
                new Question()
                {
                    Id = 5,
                    Content = "Bạn làm việc gì đầu tiên mỗi sáng?",
                    Answers = answers5,
                },
                new Question()
                {
                    Id = 6,
                    Content = "Bố mẹ có 6 người con trai, mỗi người con trai có 1 em gái. Hỏi gia đình đó có bao nhiêu người?",
                    Answers = answers6,
                },
                new Question()
                {
                    Id = 7,
                    Content = "2 con vịt đi trước 2 con vịt, 2 con vịt đi sau 2 con vịt, 2 con vịt đi giữa 2 con vịt. Hỏi có mấy con vịt?",
                    Answers = answers7,
                },
                new Question()
                {
                    Id = 8,
                    Content = "Đố bạn có bao nhiêu chữ C trong câu sau đây: ”Cơm, canh, cháo gì tớ cũng thích ăn!”",
                    Answers = answers8,
                },
                new Question()
                {
                    Id = 9,
                    Content = "Nếu chỉ có một que diêm, trong một ngày mùa đông giá rét, bạn bước vào căn phòng có một cây đèn, một bếp dầu, và một bếp củi, bạn thắp gì trước tiên?",
                    Answers = answers9,
                },
                new Question()
                {
                    Id = 10,
                    Content = "Từ điển có bao nhiêu từ?",
                    Answers = answers10,
                },
                new Question()
                {
                    Id = 11,
                    Content = "Con gì mang được miếng gỗ lớn nhưng không mang được hòn sỏi?",
                    Answers = answers11,
                },
                new Question()
                {
                    Id = 12,
                    Content = "Con trai có gì quý nhất?",
                    Answers = answers12,
                },
                new Question()
                {
                    Id = 13,
                    Content = "Cái gì tay trái cầm được còn tay phải cầm không được?",
                    Answers = answers13,
                },
                new Question()
                {
                    Id = 14,
                    Content = "Môn gì càng thắng càng thua?",
                    Answers = answers14,
                },
                new Question()
                {
                    Id = 15,
                    Content = "Ai cũng biết đỉnh núi Everest cao nhất thế giới, vậy trước khi đỉnh Everest được khám phá, đỉnh núi nào cao nhất thế giới?",
                    Answers = answers15,
                },
                new Question()
                {
                    Id = 16,
                    Content = "Con gì đầu dê mình ốc?",
                    Answers = answers16,
                },
                new Question()
                {
                    Id = 17,
                    Content = "Cái gì không đào mà sâu?",
                    Answers = answers17,
                },
                new Question()
                {
                    Id = 18,
                    Content = "Mỗi năm có 7 tháng 31 ngày. Đố bạn có bao nhiêu tháng có ngày 28?",
                    Answers = answers18,
                },
                new Question()
                {
                    Id = 19,
                    Content = "Con gì sinh ra đã BÉO?",
                    Answers = answers19,
                },
                new Question()
                {
                    Id = 20,
                    Content = "Con gì có mũi mà không có mắt, có lưỡi mà không có miệng?",
                    Answers = answers20,
                }
            };
            return questions;
        }
    }
}
