using Microsoft.EntityFrameworkCore;
using millioner.VM;
using System;
using System.Collections.Generic;
using System.Text;

namespace millioner.Model
{
    class InitDb
    {
        ModelBuilder modelBuilder;
        public InitDb()
        {
            
        }
    

     public  List<Question> InitQuestion()
        {
            var Complexity1 = new ComplexityOfTheQuestion { Complexity = "Легкий" };
            var Complexity2 = new ComplexityOfTheQuestion { Complexity = "Средний" };
            var Complexity3 = new ComplexityOfTheQuestion { Complexity = "Тяжелый" };

           
                                         
            var Answers1 = new List<Answer> {
                new Answer { AnswerString = "3", IsTrue = true },
                new Answer { AnswerString = "199" },
                new Answer { AnswerString = "-100500" },
                new Answer { AnswerString = "89" },

            };

            var Answers3 = new List<Answer> {
                new Answer { AnswerString = "Ярмошина", IsTrue = true },
                new Answer { AnswerString = "Путин" },
                new Answer { AnswerString = "Василевская" },
                new Answer { AnswerString = "Караев" },

            };

            var Answers2 = new List<Answer> {
                new Answer { AnswerString = "ОНТ"},
                new Answer { AnswerString = "БТ" },
                new Answer { AnswerString = "NEXTA" , IsTrue=true },
                new Answer { AnswerString = "НЕШТА" },

            };

            var question1 = new List<Question> {
                new Question { Answers = Answers1, ComplexityOfTheQuestion = Complexity1, QuestionString = "Сколько у саши процентов" },
                new Question { Answers = Answers2, ComplexityOfTheQuestion = Complexity3, QuestionString = "Главная шлюха страны" },
                new Question { Answers = Answers3, ComplexityOfTheQuestion = Complexity2, QuestionString = "Самый популярный телеграмм канал" },


            };

            return question1;
            
       
        }  

    }







}
