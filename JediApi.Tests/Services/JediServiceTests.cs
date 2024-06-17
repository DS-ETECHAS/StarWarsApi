using JediApi.Models;
using JediApi.Repositories;
using JediApi.Services;
using Moq;

namespace JediApi.Tests.Services
{
    public class JediServiceTests
    {
        // não mexer
        private readonly JediService _service;
        private readonly Mock<IJediRepository> _repositoryMock;

        public JediServiceTests()
        {
            // não mexer
            _repositoryMock = new Mock<IJediRepository>();
            _service = new JediService(_repositoryMock.Object);
        }

        [Fact]
        public async Task GetById_Success()
        {
            Assert.Equal(1, 4);
        }

        [Fact]
        public async Task GetById_NotFound()
        {
            Assert.Equal(1, 4);
        }

        [Fact]
        public async Task GetAll()
        {
            Assert.Equal(1, 4);
        }
    }
}
