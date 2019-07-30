using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "City")]
        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
    }
}
