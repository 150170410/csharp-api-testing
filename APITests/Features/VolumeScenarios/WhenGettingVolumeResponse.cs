using FluentAssertions;
using FluentAssertions.Execution;
using Infrastructure.GoogleBooksApi;
using NUnit.Framework;
using Shared.Items.Nunit;
using System.Net;
using System.Threading.Tasks;

namespace APITests.Features.VolumeScenarios
{
    [TestFixture]
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
                response.IsSuccessful.Should().BeTrue();
                response.Data.Id.Should().Be(volumeId);
                response.Data.Kind.Should().Be("books#volume");
                response.Data.Etag.Should().NotBeNullOrWhiteSpace();
            }
        }

        [MediumPrio]
        [TestCase("", TestName = "with invalid volume Id")]
        public async Task ItReturnsBadRequestAndResponseWithErrorDetails(string volumeId)
        {
            //Arrange & Act
            var response = await _googleBooksApiProxy.GetVolumeErrorResponse(volumeId);

            //Assert
            using (new AssertionScope())
            {
                response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
                response.IsSuccessful.Should().BeFalse();
                response.Data.Error.Code.Should().Be(400);
                response.Data.Error.Message.Should().Be("Required parameter: q");
            }
        }
    }
}