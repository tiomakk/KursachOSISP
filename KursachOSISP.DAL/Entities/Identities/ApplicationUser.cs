using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace KursachOSISP.DAL.Entities.Identities
{
    class ApplicationUser: IdentityUser
    {
        public UserProfile Profile { get; set; }
    }
}
