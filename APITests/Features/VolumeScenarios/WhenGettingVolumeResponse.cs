using System.Net;
using FluentAssertions.Execution;
using Infrastructure.GoogleBooksApi;
using NUnit.Framework;
using Shared.Items.Nunit;
using System.Threading.Tasks;
using FluentAssertions;

namespace APITests.Features.VolumeScenarios
{
    //[TestFixture]
    public class WhenGettingVolumeResponse
    {
        private static GoogleBooksApiProxy _googleBooksApiProxy;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _googleBooksApiProxy = new GoogleBooksApiProxy();
        }

        [HighPrio]
        [TestCase("5W-ChoTedM4C", TestName = "with valid volume Id")]
        public async Task ItReturnsOkAndResponseWithVolumeData(string volumeId)
        {
            //Arrange & Act
            var response = await _googleBooksApiProxy.GetVolume(volumeId);

            //Assert
            using (new AssertionScope())
            {
                response.StatusCode.Should().Be(HttpStatusCode.OK);
                response.Data.Id.Should().Be(volumeId);
                response.Data.Kind.Should().Be("books#volume");
                response.Data.Etag.Should().NotBeNullOrWhiteSpace();
            }
        }
    }
}