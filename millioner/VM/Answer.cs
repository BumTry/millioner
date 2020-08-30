using System;
using System.Collections.Generic;
using System.Text;

namespace millioner.VM
{
    class Answer : VMcontext
    {
        int id;
        string answerString;
        public virtual Question Question { get; set; }
        public bool IsTrue { get; set; }
      
        public int Id { get => id; set => id = value; }
        public string AnswerString { get => answerString; set { answerString = value; OnPropertyChanged(); } }
    }
}
