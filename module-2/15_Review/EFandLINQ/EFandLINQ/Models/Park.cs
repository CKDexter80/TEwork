using System;
using System.Collections.Generic;

#nullable disable

namespace EFandLINQ.Models
{
    public partial class Park
    {
        public Park()
        {
            ParkStates = new HashSet<ParkState>();
        }

        public int ParkId { get; set; }
        public string ParkName { get; set; }
        public DateTime DateEstablished { get; set; }
        public decimal Area { get; set; }
        public bool HasCamping { get; set; }

        public virtual ICollection<ParkState> ParkStates { get; set; }
    }
}
