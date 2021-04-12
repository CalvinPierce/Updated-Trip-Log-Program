using System.Collections.Generic;

namespace Lab11.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }           // PK 
        public string Name { get; set; }

        public ICollection<Trip> Trips { get; set; }     // navigation property
    }
}
