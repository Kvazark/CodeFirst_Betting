using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace Betting.Data.Models
{
    public class Game
    {
        public Game()
        {
            Bets = new HashSet<Bet>();
            PlayerStatistics = new HashSet<PlayerStatistic>();
        }
        
        [Key]
        public int GameId { get; set; }
        
        public int AwayTeamBetRate { get; set; }
        
        public int AwayTeamGoals { get; set; }
        
        [ForeignKey("AwayTeam")]
        public int AwayTeamId { get; set; }
        
        public int DrawBetRate { get; set; }

        public int HomeTeamBetRate { get; set; }
        
        [ForeignKey("HomeTeam")]
        public int HomeTeamId { get; set; }
        
        public int Result { get; set; }
        
        public DateTime DataTime { get; set; }
        
        public virtual Team AwayTeam { get; set; }
        public virtual Team HomeTeam { get; set; }
        
        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
        public virtual ICollection<Bet> Bets { get; set; }
    }
}