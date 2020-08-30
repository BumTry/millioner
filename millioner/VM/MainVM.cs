using millioner.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace millioner.VM
{
    class MainVM: VMcontext, INotifyPropertyChanged
    {

        static Random random = new Random();
        private string buttomText="rrrrrrrrrrrrrrrr";

        private string answer1;
        private string answer2;
        private string answer3;
        private string answer4;


        private string question;

        MillionerDBContext MillionerDBContext = MainDBContext.GetMainContext();

        public MainVM()
        {          
            var InitDb = new InitDb();
            InitDb.InitQuestion().ForEach(Answer => { MillionerDBContext.Questions.Add(Answer); });
            MillionerDBContext.SaveChanges();
            SetQuestion();
        }

        public string ButtomText { get => buttomText; set { buttomText = value; OnPropertyChanged(); } }

        public string Answer1 { get => answer1; set { answer1 = value; OnPropertyChanged(); } }
        public string Answer2 { get => answer2; set { answer2 = value; OnPropertyChanged(); } }
        public string Answer3 { get => answer3; set { answer3 = value; OnPropertyChanged(); } }
        public string Answer4 { get => answer4; set { answer4 = value; OnPropertyChanged(); } }

        public string Question { get => question; set { question = value; } }

        void SetQuestion()
        {
            var mixedIntList = GetRandomAnswer();
            var Answers = MillionerDBContext.Answers.ToList();
            Answer1 = Answers[mixedIntList.Pop()].AnswerString;
            Answer2 = Answers[mixedIntList.Pop()].AnswerString;
            Answer3 = Answers[mixedIntList.Pop()].AnswerString;
            Answer4 = Answers[mixedIntList.Pop()].AnswerString;



        }

       private Stack<int> GetRandomAnswer ()
        {
            
            List<int> intL = new List<int>();
            Stack<int> intLMixed = new Stack<int>();

            for (int i = 0; i < 4; i++)
            {
                intL.Add(i);
            }

            while(intL.Count!=0)
            {
                var u = random.Next(0, 99999999) % intL.Count ;
                var q = intL[u];
                intL.Remove(q);
                intLMixed.Push(q);
            }
            return intLMixed;
        }
   
    
    }

   


}
