using System;
using System.Collections.Generic;
using Ploeh.AutoFixture;
using Streakon.Domain.Reposotories;
using Streakon.Domain.Services;
using Xunit;
using Streakon.Domain.Models;

namespace Streakon.Domain.Tests.Services
{
    public class ScoreServiceTest
    {
        [Fact]
        public void CreateWithNullRepositoryWillThrow()
        {
            var fixture = new RepositoryFixture();
            ScoreRepository nullRepository = null;

            Assert.Throws<ArgumentNullException>(() =>
                fixture.Build<ScoreService>()
                    .FromFactory(() => new ScoreService(nullRepository))
                    .Create());
        }

        [Fact]
        public void GetHighScoresWillReturnInstance()
        {
            var fixture = new RepositoryFixture();
            var sut = fixture.Create<ScoreService>();

            IEnumerable<Score> result = fixture.Get((int numberOfScores) => sut.GetHighScores(numberOfScores));

            Assert.NotNull(result);
        }
    }
}
