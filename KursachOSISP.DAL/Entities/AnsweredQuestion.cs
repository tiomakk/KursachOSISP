using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachOSISP.DAL.Entities
{
    class AnsweredQuestion
    {
        public int Id { get; set; }
        public int PassedTestId { get; set; }
        public PassedTest Test { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public ICollection<Answer> Answers { get; set; }

        public AnsweredQuestion()
        {
            Answers = new List<Answer>();
        }
    }
}
