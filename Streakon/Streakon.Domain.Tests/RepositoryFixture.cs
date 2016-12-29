using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ploeh.AutoFixture;
using Moq;
using Streakon.Domain.Reposotories;

namespace Streakon.Domain.Tests
{
    internal class RepositoryFixture : Fixture
    {
        public RepositoryFixture()
        {
            this.Register(() => new Mock<ScoreRepository>().Object);
        }
    }
}
