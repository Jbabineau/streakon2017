using Streakon.Domain.Models;
using System.Collections.Generic;

namespace Streakon.Domain.Reposotories
{
    public abstract class ScoreRepository
    {
        public abstract IEnumerable<Score> GetHighScores(int amount);

        public abstract void DeleteScore(int id);

        public abstract void InsertScore(Score score);

        public abstract Score SelectScore(int id);

        public abstract IEnumerable<Score> SelectAllScores();

        public abstract void UpdateScore(Score score);
    }
}
