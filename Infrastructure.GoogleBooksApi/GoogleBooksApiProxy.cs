using Contracts.GoogleBooksApi.Responses;
using RestSharp;
using System.Threading.Tasks;

namespace Infrastructure.GoogleBooksApi
{
    public class GoogleBooksApiProxy
    {
        const string BaseUrl = "https://www.googleapis.com/books/v1/";
        private readonly IRestClient _client;

	    public GoogleBooksApiProxy()
	    {
            _client = new RestClient(BaseUrl);
	    }
        public async Task<IRestResponse<Volume>> GetVolume(string volumeId)
        {
            var request = new RestRequest("volumes/{volumeId}");
            request.AddParameter("volumeId", volumeId, ParameterType.UrlSegment);
            return await _client.ExecuteGetTaskAsync<Volume>(request);
        }
    }
}