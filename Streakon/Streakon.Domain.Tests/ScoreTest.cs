using System;
using NUnit.Framework;

namespace Streakon.Domain.Tests
{
    [TestFixture]
    public class ScoreTest
    {
        
        [Test]
        public void CreateWithNullNameWillThrow()
        {
            var ex = Assert.Throws<ArgumentNullException>(
                new TestDelegate(CreateScoreWithNullName)
            );
            Assert.That(ex.Message, Is.EqualTo("Value cannot be null.\r\nParameter name: name"));
        }

        [Test]
        public void CreateWithEmptyNameWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(
                new TestDelegate(CreateScoreWithEmptyName));
            Assert.That(ex.Message, Is.EqualTo("name cannot be empty."));
        }

        [Test]
        public void CreateWithNegativeScoreWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(
                new TestDelegate(CreateScoreWithNegativeScore));
            Assert.That(ex.Message, Is.EqualTo("score cannot be negative."));
        }

        [Test]
        public void CreateWithNegativeKillsWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(
                new TestDelegate(CreateScoreWithNegativeKills));
            Assert.That(ex.Message, Is.EqualTo("kills cannot be negative."));
        }

        [Test]
        public void CreateWithNegativeBlocksWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(
                new TestDelegate(CreateScoreWithNegativeBlocks));
            Assert.That(ex.Message, Is.EqualTo("blocks cannot be negative."));
        }

        [Test]
        public void CreateWithNegativeMissesWillThrow()
        {
            var ex = Assert.Throws<ArgumentException>(
                new TestDelegate(CreateScoreWithNegativeMisses));
            Assert.That(ex.Message, Is.EqualTo("misses cannot be negative."));
        }

        [Test]
        public void ScoreWillMatchConstructorArgument()
        {
            int expectedScore = 1;
            var score = new Models.Score(expectedScore, 0, 0, 0, "a");
            Assert.That(expectedScore, Is.EqualTo(score.PlayerScore));
        }

        [Test]
        public void KillsWillMatchConstructorArgument()
        {
            int expectedKills = 100;
            var score = new Models.Score(0, expectedKills, 0, 0, "a");
            Assert.That(expectedKills, Is.EqualTo(score.Kills));
        }

        [Test]
        public void BlocksWillMatchConstructorArgument()
        {
            int expectedBlocks = 1;
            var score = new Models.Score(0, 0, expectedBlocks, 0, "a");
            Assert.That(expectedBlocks, Is.EqualTo(score.Blocks));
        }

        [Test]
        public void MissesWillMatchConstructorArgument()
        {
            int expectedMisses = 12;
            var score = new Models.Score(0, 0, 0, expectedMisses, "a");
            Assert.That(expectedMisses, Is.EqualTo(score.Misses));
        }

        [Test]
        public void NameWillMatchConstructoArgument()
        {
            string expectedName = "Jimmy Babs";
            var score = new Models.Score(0, 0, 0, 0, expectedName);
            Assert.That(expectedName, Is.EqualTo(score.Name));
        }

        #region TestDelegates
        void CreateScoreWithNullName()
        {
            var modelScore = new Models.Score(0, 0, 0, 0, null);
        }

        void CreateScoreWithEmptyName()
        {
            var modelScore = new Models.Score(0, 0, 0, 0, string.Empty);
        }

        void CreateScoreWithNegativeScore()
        {
            var modelScore = new Models.Score(-1, 0, 0, 0, "a");
        }

        void CreateScoreWithNegativeKills()
        {
            var modelScore = new Models.Score(0, -1, 0, 0, "a");
        }

        void CreateScoreWithNegativeBlocks()
        {
            var modelScore = new Models.Score(0, 0, -1, 0, "a");
        }

        void CreateScoreWithNegativeMisses()
        {
            var modelScore = new Models.Score(0, 0, 0, -1, "a");
        }
        #endregion
    }

}
