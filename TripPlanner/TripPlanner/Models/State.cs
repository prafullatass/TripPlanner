using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "State")]
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<City> Cities { get; set; }
    }
}
