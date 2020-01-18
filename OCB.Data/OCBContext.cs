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
    public class OCBContext : DbContext
    {
        public OCBContext(): base("OCB-Development")
        {

        }
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<WowBounty> WowBounties { get; set; }
    }
}
