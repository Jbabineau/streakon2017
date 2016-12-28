using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Streakon.Domain.Models;

namespace Streakon.WebPresentation.Models
{
    public class ScoreViewModel
    {
        public ScoreViewModel(Score score)
        {
            PlayerScore = score.PlayerScore;
            Kills = score.Kills;
            Blocks = score.Blocks;
            Misses = score.Misses;
            PlayerName = score.Name;
        }

        public int PlayerScore { get; set; }
        public int Kills { get; set; }
        public int Blocks { get; set; }
        public int Misses { get; set; }
        public string PlayerName { get; set; }


        public string SummaryText()
        {
            string result = $"{PlayerName} scored {PlayerScore} points, killed the opponent {Kills} times, blocked them {Blocks} times and missed {Misses} times.";
            return result;
        }
    }
}
