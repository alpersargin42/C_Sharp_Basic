using System;

namespace QuestionOOP
{

    class Questions
    {
        public string Text { get; set; }

        public string[] Choices  { get; set; }

        public string Answer { get; set; }

  
        public Questions(string text, string[] choices,string answer)
        {
            this.Text = text;
            this.Choices = choices;
            this.Answer = answer;
        }

        public bool checkAnswer(string answer)
        {
            return this.Answer.ToLower() == answer;

        }
    }

    class Quiz
    { //soruları kontrol eden uygulama 
        public Quiz(Questions[] questions)
        {
            this.Questions = questions;

            this.QuestionIndex = 0;

            this.Score = 0;
        }

        //quiz uygulaması dışarıdan gelsin question alsın 
        private Questions[] Questions { get; set; }

        private int QuestionIndex { get; set; }

        private int Score { get; set; }

        public Questions GetQuestions()
        {
            return this.Questions[this.QuestionIndex];
        }
        public void DisplayQuestion()
        {//soruyu kullanıcının karşısına çıkarsın
            var question = this.GetQuestions();

            this.DisplayProgress();

            Console.WriteLine($"soru {this.QuestionIndex + 1}:{question.Text}");

            foreach (var c in question.Choices)
            {//cevap secenekleri gelicek
                Console.WriteLine($"-{c}");
            }
            Console.Write("Cevap :");
            var cevap = Console.ReadLine();
            this.Guess(cevap);
        }
        public void Guess(string answer)
        {
            var question = this.GetQuestions();
            if (question.checkAnswer(answer)) ; //skorumuzu tutacak)
            {
                this.Score++;
            }
           

            this.QuestionIndex++;

            if (this.Questions.Length == this.QuestionIndex)
            {
                //skor bilgisini göster 
                this.DisplayScore();
            }
            else
            {
               
                this.DisplayQuestion();
            }

            
        }

        private void DisplayProgress()
        {
            int totalQuestion = this.Questions.Length;
            int questionNumber = this.QuestionIndex + 1;

            if (totalQuestion>=questionNumber)
            {
                Console.WriteLine($"Question {questionNumber} of {totalQuestion}");

            }
        }

        private void DisplayScore()
        {
            Console.WriteLine($"Score: {this.Score}");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Questions("Türkiye'nin başkenti neresidir =", new string[] { "Ankara", "Tokat", "Mersin", "Karaman" },"ANKARA");

            var q2 = new Questions("Osmanlı Devleti Başkenti neresi =", new string[] {"Edirne ","İstanbul","Sivas","Konya "},"EDİRNE");

            var q3 = new Questions("Cumhurbaşkanı kimdir =", new string[] { "RTE ", "Kılıçdaroğlu","Yavaş", "İmamoğlu" },"RTE");

            var questions = new Questions[] { q1, q2, q3 };

            var quiz = new Quiz(questions);

            quiz.DisplayQuestion();

        }
    }
}
