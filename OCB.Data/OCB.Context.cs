using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCB.Domain.Entities;
using OCB.Domain.Entities.Administration;

namespace OCB.Data
{
    class OCB : DbContext
    {
        public OCB(): base("OCB-Development")
        {

        }
        DbSet<ApplicationUser> ApplicationUsers { get; set; }

        DbSet<WowBounty> WowBounties { get; set; }
    }
}
