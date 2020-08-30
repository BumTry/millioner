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
          var  MillionerDBContext = new MillionerDBContext();
        }

        public string ButtomText { get => buttomText; set { buttomText = value; OnPropertyChanged(); } }
    }
}
