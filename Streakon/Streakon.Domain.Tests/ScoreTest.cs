using System;
using Xunit;
using Ploeh.AutoFixture;
using Streakon.Domain.Models;

namespace Streakon.Domain.Tests
{

    public class ScoreTest
    {
        [Fact]
        public void CreateWithNullNameWillThrow()
        {
            var fixture = new Fixture();
            string nullName = null;
            
            Assert.Throws<ArgumentNullException>(() =>
                fixture.Build<Score>()
                    .FromFactory((int score, int kills, int blocks, int misses) => new Score(score, kills, blocks, misses, nullName))
                    .Create());
        }

        [Fact]
        public void CreateWithEmptyNameWillThrow()
        {
            var fixture = new Fixture();
            string emptyName = string.Empty;

            Assert.Throws<ArgumentException>(() =>
                fixture.Build<Score>()
                    .FromFactory((int score, int kills, int blocks, int misses) => new Score(score, kills, blocks, misses, emptyName))
                    .Create());
        }

        [Fact]
        public void CreateWithNegativeScoreWillThrow()
        {

            var fixture = new Fixture();
            int negativeScore = -1;

            Assert.Throws<ArgumentException>(() =>
                fixture.Build<Score>()
                    .FromFactory((int kills, int blocks, int misses, string name) => new Score(negativeScore, kills, blocks, misses, name))
                    .Create());
        }

        [Fact]
        public void CreateWithNegativeKillsWillThrow()
        {
            var fixture = new Fixture();
            int negativeKills = -1;

            Assert.Throws<ArgumentException>(() =>
                fixture.Build<Score>()
                    .FromFactory((int score, int blocks, int misses, string name) => new Score(score, negativeKills, blocks, misses, name))
                    .Create());
        }

        [Fact]
        public void CreateWithNegativeBlocksWillThrow()
        {
            var fixture = new Fixture();
            int negativeBlocks = -1;

            Assert.Throws<ArgumentException>(() =>
                fixture.Build<Score>()
                    .FromFactory((int score, int kills, int misses, string name) => new Score(score, kills, negativeBlocks, misses, name))
                    .Create());
        }

        [Fact]
        public void CreateWithNegativeMissesWillThrow()
        {
            var fixture = new Fixture();
            int negativeMisses = -1;

            Assert.Throws<ArgumentException>(() =>
                fixture.Build<Score>()
                    .FromFactory((int score, int kills, int blocks, string name) => new Score(score, kills, blocks, negativeMisses, name))
                    .Create());
        }

        [Fact]
        public void ScoreWillMatchConstructorArgument()
        {
            var fixture = new Fixture();
            int expectedScore = fixture.Create<int>();
            var sut = fixture.Build<Score>()
                .FromFactory((int kills, int blocks, int misses, string name) => new Score(expectedScore, kills, blocks, misses, name))
                .OmitAutoProperties()
                .Create();
            
            int result = sut.PlayerScore;
           
            Assert.Equal<int>(expectedScore, result);
        }

        [Fact]
        public void KillsWillMatchConstructorArgument()
        {
            var fixture = new Fixture();
            int expectedKills = fixture.Create<int>();
            var sut = fixture.Build<Score>()
                .FromFactory((int score, int blocks, int misses, string name) => new Score(score, expectedKills, blocks, misses, name))
                .OmitAutoProperties()
                .Create();

            int result = sut.Kills;

            Assert.Equal<int>(expectedKills, result);
        }

        [Fact]
        public void BlocksWillMatchConstructorArgument()
        {
            var fixture = new Fixture();
            int expectedBlocks = fixture.Create<int>();
            var sut = fixture.Build<Score>()
                .FromFactory((int score, int kills, int misses, string name) => new Score(score, kills, expectedBlocks, misses, name))
                .OmitAutoProperties()
                .Create();

            int result = sut.Blocks;

            Assert.Equal<int>(expectedBlocks, result);
        }

        [Fact]
        public void MissesWillMatchConstructorArgument()
        {
            var fixture = new Fixture();
            int expectedMisses = fixture.Create<int>();
            var sut = fixture.Build<Score>()
                .FromFactory((int score, int kills, int blocks, string name) => new Score(score, kills, blocks, expectedMisses, name))
                .OmitAutoProperties()
                .Create();

            int result = sut.Misses;

            Assert.Equal<int>(expectedMisses, result);
        }

        [Fact]
        public void NameWillMatchConstructoArgument()
        {
            var fixture = new Fixture();
            string expectedName = fixture.Create<string>();
            var sut = fixture.Build<Score>()
                .FromFactory((int score, int kills, int blocks, int misses) => new Score(score, kills, blocks, misses, expectedName))
                .OmitAutoProperties()
                .Create();

            string result = sut.Name;

            Assert.Equal<string>(expectedName, result);
        }
    }

}
