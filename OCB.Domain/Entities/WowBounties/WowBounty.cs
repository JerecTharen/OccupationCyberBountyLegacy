
using OCB.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OCB.Domain.Entities
{
    public class WowBounty: LoggedEntity
    {
        [Key]
        public int BountyId { get; set; }

        public decimal BountyAmount { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal Balance { get; set; }

    }
}
