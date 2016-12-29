using System;
using Streakon.Domain.Reposotories;
using System.Collections.Generic;
using Streakon.Domain.Models;

namespace Streakon.Domain.Services
{
    public class ScoreService
    {
        private readonly ScoreRepository _repository;

        public ScoreService(ScoreRepository repository)
        {
            if(repository == null)
            {
                throw new ArgumentNullException("repository");
            }
            _repository = repository;
        }

        public IEnumerable<Score> GetHighScores(int numberOfScores)
        {
            return _repository.GetHighScores(numberOfScores);
        }
    }
}
