using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursachOSISP.DAL.Entities.Identities;

namespace KursachOSISP.DAL.Entities
{
    class PassedTest
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime Date { get; set; }
        public ICollection<AnsweredQuestion> Answers { get; set; }

        public PassedTest()
        {
            Answers = new List<AnsweredQuestion>();
        }
    }
}
