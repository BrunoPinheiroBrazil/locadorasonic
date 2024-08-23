using LocadoraSonic.Integration.Tests.Fixture;
using Newtonsoft.Json;
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

    [Theory(DisplayName = "Post - Envia um calculo e uma operação que deverá ser feita, deverá retornar 200OK com o objeto resposta dentro")]
    [InlineData(5, 5, "SOMA", 10, "5 + 5 = 10")]
    [InlineData(5, 5, "MULTIPLICA", 25, "5 * 5 = 25")]
    [InlineData(2, 6, "MULTIPLICA", 12, "2 * 6 = 12")]
    [InlineData(6, 2, "DIVIDE", 3, "6 / 2 = 3")]
    [InlineData(10, 5, "DIVIDE", 2, "10 / 5 = 2")]
    [InlineData(100, 25, "SUBTRAI", 75, "100 - 25 = 75")]
    public async Task Post_Operacao(int n1, int n2, string op, int res, string resConta)
    {
      //Arrange
      var url = $"Sonic/operacao";
      var operacao = new OperacaoPlaceHolder
      {
        numero1 = n1,
        numero2 = n2,
        operacao = op
      };

      var operacaoJson = JsonConvert.SerializeObject(operacao);

      //Act
      var (response, statusCode) = await _fixture.PostInApi<RespostaPlaceHolder>(url, operacaoJson);

      //Assert
      Assert.Equal(HttpStatusCode.OK, statusCode);
      Assert.Equal(res, response.resposta);
      Assert.Equal(resConta, response.conta);
    }

    [Theory(DisplayName = "GET - Envia um numero na Query(no endereço) e espera receber se é par ou impar")]
    [InlineData(1, "Ímpar")]
    [InlineData(2, "Par")]
    [InlineData(3, "Ímpar")]
    [InlineData(4, "Par")]
    [InlineData(5, "Ímpar")]
    [InlineData(6, "Par")]
    public async Task Get_ParOuImpar(int numero, string respostaEsperada)
    {
      //Arrange
      var url = $"calculos/parouimpar/?numero={numero}";

      //Act
      var (response, statusCode) = await _fixture.GetStringInApi(url);

      //Assert
      Assert.Equal(HttpStatusCode.OK, statusCode);
      Assert.Equal(respostaEsperada, response);
    }
  }

  public class OperacaoPlaceHolder
  {
    public int numero1 { get; set; }
    public int numero2 { get; set; }
    public string operacao { get; set; }
  }

  public class RespostaPlaceHolder
  {
    public string conta { get; set; }
    public int resposta { get; set; }
  }
}