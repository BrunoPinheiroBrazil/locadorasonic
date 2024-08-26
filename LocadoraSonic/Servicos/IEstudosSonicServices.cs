
namespace LocadoraSonic.Servicos
{
  public interface IEstudosSonicServices
  {
    object BuscaNumero(int numeroBusca1, List<int> lista1);
    List<int> InverteListaSemReverse(int[] lista1);
  }
}