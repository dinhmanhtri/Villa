using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villa.Entity.Entities
{
    public class Product : BaseEntity
    {
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public string BedroomCount { get; set; }
        public string BathroomCount { get; set; }
        public string Area { get; set; }
        public string Floor { get; set; }
        public string ParkingCount { get; set; }
    }
}
