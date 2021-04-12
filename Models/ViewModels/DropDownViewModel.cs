using System.Collections.Generic;

namespace Lab11.Models
{
    public class DropDownViewModel
    {
        public IEnumerable<Destination> Destinations { get; set; }
        public IEnumerable<Accommodation> Accommodations { get; set; }
        public IEnumerable<Activity> Activities { get; set; }
    }
}
