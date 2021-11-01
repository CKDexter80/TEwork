using System;
using System.Collections.Generic;

#nullable disable

namespace EFandLINQ.Models
{
    public partial class ParkState
    {
        public int ParkId { get; set; }
        public string StateAbbreviation { get; set; }

        public virtual Park Park { get; set; }
        public virtual State StateAbbreviationNavigation { get; set; }
    }
}
