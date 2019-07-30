using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Models
{
    public class Trip
    {
        [Key]
        public int TripId { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Trip")]
        public string Name { get; set; }
        public DateTime DepartureDate { get; set; }
        public String Purpose { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
