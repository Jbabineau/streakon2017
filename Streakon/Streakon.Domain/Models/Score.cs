using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streakon.Domain.Models
{
    public class Score
    {
        private readonly int _score;
        private readonly int _kills;
        private readonly int _blocks;
        private readonly int _misses;
        private readonly string _name;

        public Score (int score, int kills, int blocks, int misses, string name)
        {
            if(name == null)
            {
                throw new ArgumentNullException("name");
            }
            if(name == string.Empty)
            {
                throw new ArgumentException("name cannot be empty.");
            }
            if(score < 0)
            {
                throw new ArgumentException("score cannot be negative.");
            }
            if(blocks < 0)
            {
                throw new ArgumentException("blocks cannot be negative.");
            }
            if(kills < 0)
            {
                throw new ArgumentException("kills cannot be negative.");
            }
            if(misses < 0)
            {
                throw new ArgumentException("misses cannot be negative.");
            }

            _score = score;
            _kills = kills;
            _blocks = blocks;
            _misses = misses;
            _name = name;
        }

        public int PlayerScore
        {
            get
            {
                return _score;
            }
        }

        public int Kills
        {
            get 
            { 
                return _kills; 
            }
        }

        public int Blocks
        {
            get
            {
                return _blocks;
            }
        }

        public int Misses
        {
            get
            {
                return _misses;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

    }
}
