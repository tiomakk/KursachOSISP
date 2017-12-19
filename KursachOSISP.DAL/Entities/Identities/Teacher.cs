using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachOSISP.DAL.Entities.Identities
{
    [Table("Teachers")]
    class Teacher
    {
        public ICollection<ClassRoom> ClassRooms { get; set; }

        public Teacher()
        {
            ClassRooms = new List<ClassRoom>();
        }
    }
}
