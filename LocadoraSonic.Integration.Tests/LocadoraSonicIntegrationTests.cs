using LocadoraSonic.Integration.Tests.Fixture;
using System.Net;

namespace LocadoraSonic.Integration.Tests
{
  public class LocadoraSonicIntegrationTests : IClassFixture<LocadoraSonicFixture>
  {
    private readonly LocadoraSonicFixture _fixture;

    public LocadoraSonicIntegrationTests(LocadoraSonicFixture fixture)
    {
      _fixture = fixture;
    }

    [Fact(DisplayName = "Get - CalculaMaior - Deve retornar um 200OK, com o texto esperado lá no testes Controller")]
    public async Task Get_CalculaMaior()
    {
      //Arrange
      var a = 50;
      var b = 65;
      var url = $"Sonic/calculamaior/?a={a}&b={b}";

      //Act
      var (response, statusCode) = await _fixture.GetStringInApi(url);

      //Assert
      Assert.Equal(HttpStatusCode.OK, statusCode);
      Assert.IsType<string>(response);
      Assert.Contains("O valor maior é 65", response);
    }
  }
}