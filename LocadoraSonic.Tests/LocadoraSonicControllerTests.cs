using LocadoraSonic.Controllers;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraSonic.Tests
{
  public class LocadoraSonicControllerTests
  {
    private readonly SonicController _locadoraSonicController;
    public LocadoraSonicControllerTests()
    {
      _locadoraSonicController = new SonicController();
    }

    [Theory(DisplayName = "CalculaMaior - Deverá retornar uma string com o maior numero passado entre A e B - o conteudo deve ser 'O valor maior é {numero}")]
    [InlineData(1, 5, 5)]
    [InlineData(5, 10, 10)]
    [InlineData(50, 10, 50)]
    [InlineData(45, 100, 100)]
    public void CalculaMaior(int a, int b, int res)
    {
      //Arrange
      var stringRespostaEsperada = $"O valor maior é {res}";

      //Act
      var response = _locadoraSonicController.CalculaMaior(a, b);

      //Assert
      var responseSuccess = Assert.IsType<OkObjectResult>(response);
      Assert.Equal(stringRespostaEsperada, responseSuccess.Value);
    }
  }
}