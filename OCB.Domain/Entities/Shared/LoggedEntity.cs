using OCB.Domain.Entities.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OCB.Domain.Entities.Shared
{
    public class LoggedEntity
    {
        public int CreatedByUserId { get; set; }

        public int UpdatedByUserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
