using OCB.Domain.Entities.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OCB.Domain.Entities.Shared
{
    public class LoggedEntity
    {
        [ForeignKey("ApplicationUser")]
        public int CreatedByUserId { get; set; }

        [ForeignKey("ApplicationUser")]
        public int UpdatedByUserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
