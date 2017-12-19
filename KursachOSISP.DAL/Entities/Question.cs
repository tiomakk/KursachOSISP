using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachOSISP.DAL.Entities
{
    class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public ICollection<Answer> PossibleAnswers { get; set; }
        public ICollection<Answer> RightAnswers { get; set; }

        public Question()
        {
            PossibleAnswers = new List<Answer>();
            RightAnswers = new List<Answer>();
        }
    }
}
