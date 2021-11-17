using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class PlayerStatistic
    {
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        
        [ForeignKey("Game")]
        public int GameId { get; set; }
        
        public int Assists { get; set; }
        
        public int MinutesPlayed { get; set; }
        
        public int ScoredGoals { get; set; }
        
        public virtual Player Player { get; set; }
        public virtual Game Game { get; set; }
    }
}