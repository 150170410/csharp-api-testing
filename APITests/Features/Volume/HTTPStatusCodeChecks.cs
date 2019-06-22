using System;
using System.Net;
using NUnit.Framework;
using RestSharp;
using FluentAssertions;

namespace APITests.Features.Volume
{
    public class WhenGettingVolumes
    {
        private static string _baseUrl;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _baseUrl = "https://www.googleapis.com/books/v1/";
            
        }

        [Test]
        [TestCase("5W-ChoTedM4C", "OK", TestName = "with valid volume Id")]
        [TestCase("", "BadRequest", TestName = "with no volume Id")]
        public void WithVolumeIdParameterItReturnsCorrectHttpStatusCode(string volumeId, string statusCode)
        {
            //Arrange
            var client = new RestClient(_baseUrl + "volumes/" + volumeId);
            var request = new RestRequest(Method.GET);
            HttpStatusCode expectedHttpStatusCode = (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), statusCode);

            //Act
            IRestResponse response = client.Execute(request);

            //Assert
            response.StatusCode.Should().Be(expectedHttpStatusCode);
        }
    }
}