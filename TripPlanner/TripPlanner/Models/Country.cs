using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripPlanner.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        [StringLength(30)]
        [Display(Name = "Country")]
        public string Name { get; set; }
        public virtual ICollection<State> States { get; set; }
    }
}
