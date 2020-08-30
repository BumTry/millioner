using millioner.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace millioner.VM
{
    class MainVM: VMcontext, INotifyPropertyChanged
    {
        
        private string buttomText="rrrrrrrrrrrrrrrr";

        public MainVM()
        {
            var MillionerDBContext = MainDBContext.GetMainContext();
            var InitDb = new InitDb();
            InitDb.InitQuestion().ForEach(o => { MillionerDBContext.Questions.Add(o); });
            MillionerDBContext.SaveChanges();
        }

        public string ButtomText { get => buttomText; set { buttomText = value; OnPropertyChanged(); } }
    }
}
