using System;
using System.Collections.Generic;

#nullable disable

namespace EFandLINQ.Models
{
    public partial class City
    {
        public City()
        {
            States = new HashSet<State>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public string StateAbbreviation { get; set; }
        public int Population { get; set; }
        public decimal Area { get; set; }

        public virtual State StateAbbreviationNavigation { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
