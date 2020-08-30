using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace millioner.VM
{
    class Question : VMcontext
    {
        string questionString;
        int id;

        public virtual IList<Answer> Answers { get; set; }

        public Question()
        {
          
        }

        public int Id { get => id; set { id = value; OnPropertyChanged(); } }

        public string QuestionString { get => questionString; set { questionString = value; OnPropertyChanged(); } }
   
    }
}
