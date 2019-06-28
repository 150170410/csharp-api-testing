using System;
using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using Infrastructure.GoogleBooksApi;
using NUnit.Framework;
using Shared.Items.Nunit;

namespace APITests.Features.VolumeScenarios
{
    [TestFixture]
    public class WhenGettingVolumeWithRequiredParameter
    {
        private static GoogleBooksApiProxy _googleBooksApiProxy;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _googleBooksApiProxy = new GoogleBooksApiProxy();          
        }

        [HighPrio]
        [TestCase("5W-ChoTedM4C", "OK", TestName = "with valid volume Id returns OK and response with volume data")]
        [TestCase("", "BadRequest", TestName = "with no volume Id returns BadRequest and response with error details")]
        [TestCase("1", "ServiceUnavailable", TestName = "with invalid volume Id returns Service Unavailable and response with error details")]
        public async Task WithVolumeIdParameterItReturnsCorrectHttpStatusCode(string volumeId, string statusCode)
        {
            //Arrange
            HttpStatusCode expectedHttpStatusCode = (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), statusCode);

            //Act
            var response = await _googleBooksApiProxy.GetVolume(volumeId);

            //Assert
            response.StatusCode.Should().Be(expectedHttpStatusCode);
        }
    }
}