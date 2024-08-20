using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace LocadoraSonic.Integration.Tests.Fixture
{
  public class CustomWebApplicationFactory<TProgram>
    : WebApplicationFactory<TProgram> where TProgram : class
  {
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
      builder.ConfigureServices(services =>
      {
        //Update fake services and mock services here
      });

      builder.UseEnvironment("Development");
    }
  }

  public class LocadoraSonicFixture
  {
    private readonly CustomWebApplicationFactory<Program> _factory;
    public HttpClient _client;

    public LocadoraSonicFixture()
    {
      _factory = new CustomWebApplicationFactory<Program>();
      _client = _factory.WithWebHostBuilder(builder => builder.UseSolutionRelativeContentRoot("./"))
        .CreateClient();
    }

    public async Task<(T ResponseObject, HttpStatusCode StatusCode)> GetInApi<T>(string url)
    {
      var response = await _client.GetAsync(url);
      var responseContent = await response.Content.ReadAsStringAsync();
      var dto = JToken.Parse(responseContent).ToObject<T>();

      return (dto, response.StatusCode);
    }

    public async Task<(string ResponseObject, HttpStatusCode StatusCode)> GetStringInApi(string url)
    {
      var response = await _client.GetAsync(url);
      var responseContent = await response.Content.ReadAsStringAsync();

      return (responseContent, response.StatusCode);
    }

    public async Task<(T ResponseObject, HttpStatusCode StatusCode)> PostInApi<T>(string url, string jsonBody)
    {
      var request = new HttpRequestMessage(HttpMethod.Post, url);

      request.Content = CreateHttpJsonBody(jsonBody);
      var response = await _client.SendAsync(request);
      var responseContent = await response.Content.ReadAsStringAsync();
      var dto = JToken.Parse(responseContent).ToObject<T>();

      return (dto, response.StatusCode);
    }

    public StringContent CreateHttpJsonBody(string jsonContent)
    {
      return new StringContent(jsonContent, Encoding.UTF8, "application/json");
    }
  }
}
