﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KursachOSISP.DAL.Entities.Identities;

namespace KursachOSISP.DAL.Entities
{
    class ClassRoom
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Student> Students { get; set; }

        public ClassRoom()
        {
            Students = new List<Student>();
        }
    }
}