using Xunit;
using Streakon.WebPresentation.Models;
using Streakon.Domain.Models;
using Ploeh.AutoFixture;

namespace Streakon.WebPresentation.Tests
{
    public class ScoreViewModelTest
    {
        [Fact]
        public void NameWillMatchConstructor()
        {
            var fixture = new Fixture();
            var score = fixture.Create<Score>();
            var expectedName = score.Name;
            var sut = fixture.Build<ScoreViewModel>()
                .FromFactory(() => new ScoreViewModel(score))
                .OmitAutoProperties()
                .Create();

            var result = sut.PlayerName;

            Assert.Equal(expectedName, result);
        }

        [Fact]
        public void ScoreWillMatchConstructor()
        {
            var fixture = new Fixture();
            var score = fixture.Create<Score>();
            var expectedScore = score.PlayerScore;
            var sut = fixture.Build<ScoreViewModel>()
                .FromFactory(() => new ScoreViewModel(score))
                .OmitAutoProperties()
                .Create();

            var result = sut.PlayerScore;

            Assert.Equal(expectedScore, result);
        }

        [Fact]
        public void KillsWillMatchConstructor()
        {
            var fixture = new Fixture();
            var score = fixture.Create<Score>();
            var expectedKills = score.Kills;
            var sut = fixture.Build<ScoreViewModel>()
                .FromFactory(() => new ScoreViewModel(score))
                .OmitAutoProperties()
                .Create();

            var result = sut.Kills;

            Assert.Equal(expectedKills, result);
        }

        [Fact]
        public void BlocksWillMatchConstructor()
        {
            var fixture = new Fixture();
            var score = fixture.Create<Score>();
            var expectedBlocks = score.Blocks;
            var sut = fixture.Build<ScoreViewModel>()
                .FromFactory(() => new ScoreViewModel(score))
                .OmitAutoProperties()
                .Create();

            var result = sut.Blocks;

            Assert.Equal(expectedBlocks, result);
        }

        [Fact]
        public void MissesWillMatchConstructor()
        {
            var fixture = new Fixture();
            var score = fixture.Create<Score>();
            var expectedMisses = score.Misses;
            var sut = fixture.Build<ScoreViewModel>()
                .FromFactory(() => new ScoreViewModel(score))
                .OmitAutoProperties()
                .Create();

            var result = sut.Misses;

            Assert.Equal(expectedMisses, result);
        }

        [Fact]
        public void NameIsWellBehavedWritableProperty()
        {
            var fixture = new Fixture();
            var sut = fixture.Create<ScoreViewModel>();
            string expectedName = fixture.Create<string>();

            sut.PlayerName = expectedName;
            string result = sut.PlayerName;

            Assert.Equal(expectedName, result);
        }

        [Fact]
        public void ScoreIsWellBehavedWritableProperty()
        {
            var fixture = new Fixture();
            var sut = fixture.Create<ScoreViewModel>();
            int expectedScore = fixture.Create<int>();

            sut.PlayerScore = expectedScore;
            int result = sut.PlayerScore;

            Assert.Equal(expectedScore, result);
        }

        [Fact]
        public void KillsIsWellBehavedWritableProperty()
        {
            var fixture = new Fixture();
            var sut = fixture.Create<ScoreViewModel>();
            int expectedKills = fixture.Create<int>();

            sut.Kills = expectedKills;
            int result = sut.Kills;

            Assert.Equal(expectedKills, result);
        }

        [Fact]
        public void BlocksIsWellBehavedWritableProperty()
        {
            var fixture = new Fixture();
            var sut = fixture.Create<ScoreViewModel>();
            int expectedBlocks = fixture.Create<int>();

            sut.Blocks = expectedBlocks;
            int result = sut.Blocks;

            Assert.Equal(expectedBlocks, result);
        }

        [Fact]
        public void MissesIsWellBehavedWritableProperty()
        {
            var fixture = new Fixture();
            var sut = fixture.Create<ScoreViewModel>();
            int expectedMisses = fixture.Create<int>();

            sut.Misses = expectedMisses;
            int result = sut.Misses;

            Assert.Equal(expectedMisses, result);
        }

        [Fact]
        public void SummaryTextWillBeCorrect()
        {
            var fixture = new Fixture();
            var sut = fixture.Create<ScoreViewModel>();
            string expectedSummaryText = $"{sut.PlayerName} scored {sut.PlayerScore} points, killed the opponent {sut.Kills} times, blocked them {sut.Blocks} times and missed {sut.Misses} times.";
            
            string result = sut.SummaryText();
            
            Assert.Equal<string>(expectedSummaryText, result);
        }
    }
}
