using LocadoraSonic.Servicos;

namespace LocadoraSonic.Tests
{
  public class EstudosSonicServicesTests
  {
    private readonly EstudosSonicServices _servicos;
    public EstudosSonicServicesTests()
    {
      _servicos = new();
    }

    [Fact(DisplayName = "Deverá Inverter a lista sem usar metodos prontos!")]
    public void ValidaListaInvertida()
    {
      //Arrange
      var lista1 = new int[] { 1, 2, 3 };
      var lista2 = new int[] { 10, 20, 30, 40, 50 };

      //Act
      var listaInvertida1 = _servicos.InverteListaSemReverse(lista1);
      var listaInvertida2 = _servicos.InverteListaSemReverse(lista2);

      //Assert
      Assert.Equal(new List<int>{3, 2, 1}, listaInvertida1);
      Assert.Equal(new List<int>{50, 40, 30, 20, 10}, listaInvertida2);
    }

    [Fact(DisplayName = "Deverá buscar o numero passado por parametro e retornar sem metodo pronto!")]
    public void BuscaNumeroPassado()
    {
      //Arrange
      var numeroBusca1 = 10;
      var lista1 = new List<int> { 5, 6, 3, 10, 9, 11}; 
      
      //Act
      var numeroEncontrado = _servicos.BuscaNumero(numeroBusca1, lista1);

      //Assert
      Assert.Equal(10, numeroEncontrado);
    }
  }
}
