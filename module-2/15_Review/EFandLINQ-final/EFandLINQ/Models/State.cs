using System;
using System.Collections.Generic;

#nullable disable

namespace EFandLINQ.Models
{
    public partial class State
    {
        public State()
        {
            Cities = new HashSet<City>();
            ParkStates = new HashSet<ParkState>();
        }

        public string StateAbbreviation { get; set; }
        public string StateName { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
        public int Capital { get; set; }
        public decimal SalesTax { get; set; }
        public string StateNickname { get; set; }
        public string CensusRegion { get; set; }

        public virtual City CapitalNavigation { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<ParkState> ParkStates { get; set; }
    }
}
