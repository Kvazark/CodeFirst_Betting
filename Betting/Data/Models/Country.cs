using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models
{
    public class Country
    {
        public Country()
        {
            Towns = new HashSet<Town>();
        }
        
        [Key]
        public int CountryId { get; set; }
        
        [Required, MaxLength(64)]
        public string Name { get; set; }
        
        public virtual ICollection<Town> Towns { get; set; }
    }
}