using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models
{
    public class User
    {
        public User()
        {
            Bets = new HashSet<Bet>();
        }
        
        [Key]
        public int UserId { get; set; }
        
        [Required]
        public string Balance { get; set; }
        
        [MaxLength(64)]
        public string Email { get; set; }
        
        [Required, MaxLength(128)]
        public string Name { get; set; }
        
        [Required]
        public char Password { get; set; }
        
        [Required, MaxLength(128)]
        public char Username { get; set; }
        
        public virtual ICollection<Bet> Bets { get; set; }
    }
}