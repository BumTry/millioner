using System;
using System.Collections.Generic;
using System.Text;

namespace millioner.VM
{
    class ComplexityOfTheQuestion
    {
        public ComplexityOfTheQuestion()
        {
            Questions = new List<Question>();
        }

        public int Id { get; set; }
        public string Complexity { get; set; }
        public virtual IList<Question> Questions { get; set; }

    }
}
