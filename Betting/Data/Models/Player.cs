using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Player
    {
        public Player()
        {
            PlayerStatistics = new HashSet<PlayerStatistic>();
        }
        
        [Key]
        public int PlayerId { get; set; }
        
        public bool IsInjured { get; set; }
        
        [Required, MaxLength(64)]
        public string Name { get; set; }
        
        [ForeignKey("PositionId")]
        public int PositionId { get; set; }
        
        [Required]
        public int SquadNumber { get; set; }
        
        [ForeignKey("TeamId")]
        public int TeamId { get; set; }
        
        
        public virtual Position Position { get; set; } 
        public virtual Team Team { get; set; } 
        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
    }
}