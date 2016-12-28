using System;
using Xunit;

namespace Streakon.Domain.Tests
{

    public class ScoreTest
    {
        [Fact]
        public void CreateWithNullNameWillThrow()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new Models.Score(0, 0, 0, 0, null));
            Assert.Equal("Value cannot be null.\r\nParameter name: name", ex.Message);
        }

        [Fact]
        public void CreateWithEmptyNameWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Models.Score(0, 0, 0, 0, string.Empty));
            Assert.Equal("name cannot be empty.", ex.Message);
        }

        [Fact]
        public void CreateWithNegativeScoreWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Models.Score(-1, 0, 0, 0, "a"));
            Assert.Equal("score cannot be negative.", ex.Message);
        }

        [Fact]
        public void CreateWithNegativeKillsWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Models.Score(0, -1, 0, 0, "a"));
            Assert.Equal("kills cannot be negative.", ex.Message);
        }

        [Fact]
        public void CreateWithNegativeBlocksWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Models.Score(0, 0, -1, 0, "a"));
            Assert.Equal("blocks cannot be negative.", ex.Message);
        }

        [Fact]
        public void CreateWithNegativeMissesWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Models.Score(0, 0, 0, -1, "a"));
            Assert.Equal("misses cannot be negative.", ex.Message);
        }

        [Fact]
        public void ScoreWillMatchConstructorArgument()
        {
            int expectedScore = 1;
            var score = new Models.Score(expectedScore, 0, 0, 0, "a");
            Assert.Equal(expectedScore, score.PlayerScore);
        }

        [Fact]
        public void KillsWillMatchConstructorArgument()
        {
            int expectedKills = 100;
            var score = new Models.Score(0, expectedKills, 0, 0, "a");
            Assert.Equal(expectedKills, score.Kills);
        }

        [Fact]
        public void BlocksWillMatchConstructorArgument()
        {
            int expectedBlocks = 1;
            var score = new Models.Score(0, 0, expectedBlocks, 0, "a");
            Assert.Equal(expectedBlocks, score.Blocks);
        }

        [Fact]
        public void MissesWillMatchConstructorArgument()
        {
            int expectedMisses = 12;
            var score = new Models.Score(0, 0, 0, expectedMisses, "a");
            Assert.Equal(expectedMisses, score.Misses);
        }

        [Fact]
        public void NameWillMatchConstructoArgument()
        {
            string expectedName = "Jimmy Babs";
            var score = new Models.Score(0, 0, 0, 0, expectedName);
            Assert.Equal(expectedName, score.Name);
        }

    }

}
