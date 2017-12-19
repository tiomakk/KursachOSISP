using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KursachOSISP.DAL.Entities.Identities
{
    [Table("Students")]
    class Student: UserProfile
    {
        public ICollection<ClassRoom> ClassRooms { get; set; }
        public ICollection<PassedTest> PassedTests { get; set; }

        public Student()
        {
            ClassRooms = new List<ClassRoom>();
            PassedTests = new List<PassedTest>();
        }
    }
}
