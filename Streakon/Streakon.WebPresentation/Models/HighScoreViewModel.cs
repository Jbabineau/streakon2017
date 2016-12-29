using System.Collections.Generic;
using Streakon.Domain.Models;

namespace Streakon.WebPresentation.Models
{
    public class HighScoreViewModel
    {
        private List<ScoreViewModel> _scores;

        public HighScoreViewModel()
        {
            _scores = new List<ScoreViewModel>();
        }

        public IList<ScoreViewModel> Scores
        {
            get
            {
                return _scores;
            }
        }
    }
}
