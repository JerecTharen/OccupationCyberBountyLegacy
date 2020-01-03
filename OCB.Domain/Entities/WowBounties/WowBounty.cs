
using OCB.Domain.Entities.Shared;
using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace OCB.Domain.Entities
{
    public class WowBounty: LoggedEntity
    {
        [PrimaryKey]
        public int BountyId { get; set; }

        public decimal BountyAmount { get; set; }

        public decimal PaidAmount { get; set; }

        public decimal Balance { get; set; }

    }
}
