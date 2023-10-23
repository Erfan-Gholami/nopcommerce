using System;
using System.Collections.Generic;
using System.Text;

namespace Nop.Core.Domain.Vote
{
    public partial class VoteItem:BaseEntity
    {
        public string Name { get; set; }
		public int CustomerId { get; set; }

		public DateTime Birthday { get; set; }
        public decimal Mobile { get; set; }

        public string Email { get; set; }
        public string Tahsilat { get; set; }
        public string FoodQuality { get; set; }
        public string StaffLook { get; set; }
        public string EnviromentPrettiness { get; set; }
        public string WhoIsGuest { get; set; }
        public string SawVip { get; set; }
        public string DrchiaKnowledge { get; set; }
        public string Critisize { get; set; }
        public string HowFindUs { get; set; }




    }
}
