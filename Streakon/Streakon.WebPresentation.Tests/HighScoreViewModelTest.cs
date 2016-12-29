using Xunit;
using Streakon.WebPresentation.Models;
using Streakon.Domain;
using Ploeh.AutoFixture;
using System.Collections.Generic;

namespace Streakon.WebPresentation.Tests
{
    public class HighScoreViewModelTest
    {
        [Fact]
        public void ScoreIsNotNull()
        {
            var fixture = new Fixture();
            var sut = fixture.Create<HighScoreViewModel>();
            IEnumerable<ScoreViewModel> result = sut.Scores;
            Assert.NotNull(result);
        }
    }
}
