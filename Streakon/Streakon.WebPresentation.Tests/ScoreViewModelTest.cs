using Xunit;
using Streakon.WebPresentation;
using Streakon.Domain;

namespace Streakon.WebPresentation.Tests
{
    public class ScoreViewModelTest
    {
        [Fact]
        public void NameWillMatchConstructor()
        {
            string expectedName = "Jamie";
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(0, 0, 0, 0, expectedName));
            Assert.Equal(expectedName, vm.PlayerName);
        }

        [Fact]
        public void ScoreWillMatchConstructor()
        {
            int expectedPlayerScore = 123;
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(expectedPlayerScore, 0, 0, 0, "Jamie"));
            Assert.Equal(expectedPlayerScore, vm.PlayerScore);
        }

        [Fact]
        public void KillsWillMatchConstructor()
        {
            int expectedKills = 3;
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(0, expectedKills, 0, 0, "Jamie"));
            Assert.Equal(expectedKills, vm.Kills);
        }

        [Fact]
        public void BlocksWillMatchConstructor()
        {
            int expectedBlocks = 83;
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(0, 0, expectedBlocks, 0, "Jamie"));
            Assert.Equal(expectedBlocks, vm.Blocks);
        }

        [Fact]
        public void MissesWillMatchConstructor()
        {
            int expectedMisses = 19;
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(0, 0, 0, expectedMisses, "Jamie"));
            Assert.Equal(expectedMisses, vm.Misses);
        }

        [Fact]
        public void NameIsWellBehavedWritableProperty()
        {
            var expectedName = "Jamie";
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(0, 0, 0, 0, "Test"));
            vm.PlayerName = expectedName;
            Assert.Equal(expectedName, vm.PlayerName);
        }

        [Fact]
        public void ScoreIsWellBehavedWritableProperty()
        {
            int expectedPlayerScore = 10;
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(0, 0, 0, 0, "Jamie"));
            vm.PlayerScore = expectedPlayerScore;
            Assert.Equal(expectedPlayerScore, vm.PlayerScore);
        }

        [Fact]
        public void KillsIsWellBehavedWritableProperty()
        {
            int expectedKills = 3;
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(0, 0, 0, 0, "Jamie"));
            vm.Kills = expectedKills;
            Assert.Equal(expectedKills, vm.Kills);
        }

        [Fact]
        public void BlocksIsWellBehavedWritableProperty()
        {
            int expectedBlocks = 12;
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(0, 0, 0, 0, "Jamie"));
            vm.Blocks = expectedBlocks;
            Assert.Equal(expectedBlocks, vm.Blocks);
        }

        [Fact]
        public void MissesIsWellBehavedWritableProperty()
        {
            int expectedMisses = 9823;
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(0, 0, 0, 0, "Jamie"));
            vm.Misses = expectedMisses;
            Assert.Equal(expectedMisses, vm.Misses);
        }

        [Fact]
        public void SummaryTextWillBeCorrect()
        {
            Models.ScoreViewModel vm = new Models.ScoreViewModel(new Domain.Models.Score(16, 2, 0, 19, "Jamie"));
            string expectedSummary = "Jamie scored 16 points, killed the opponent 2 times, blocked them 0 times and missed 19 times.";
            Assert.Equal(expectedSummary, vm.SummaryText());
        }
    }
}
