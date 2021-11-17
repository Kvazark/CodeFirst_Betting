using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models
{
    public class Position
    {
        public Position()
        {
            Players = new HashSet<Player>();
        }
        [Key]
        public int PositionId { get; set; }
        
        [Required, MaxLength(32)]
        public string Name { get; set; }
        
        public virtual ICollection<Player> Players { get; set; }
    }
}