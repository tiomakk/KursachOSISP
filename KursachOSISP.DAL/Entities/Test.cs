using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursachOSISP.DAL.Entities.Identities;

namespace KursachOSISP.DAL.Entities
{
    class Test
    {
        public int Id { get; set; }
        public string TestName { get; set; }
        public ICollection<Question> Questions { get; set; }
        public int TeacherId { get; set; }
        public Teacher Author { get; set; }

        public Test()
        {
            Questions = new List<Question>();
        }
    }
}
