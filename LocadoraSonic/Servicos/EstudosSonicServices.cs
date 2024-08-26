namespace LocadoraSonic.Servicos
{
  public class EstudosSonicServices
  {
    
    public int numeroBuscado1;
    public List<int> listaInversa;

    public int? BuscaNumero(int numeroBusca1, List<int> lista1)
    {
      for (int i = +1; i < lista1.Count; i++)
      {
        if (lista1[i] == numeroBusca1)
        {
          numeroBuscado1 = lista1[i];
          return numeroBuscado1; 
        }
      }
      return null; 
    }
    public List<int> InverteListaSemReverse(int[] lista1)
    {
      List<int> listaInversa = new List<int>();

      for (int i = lista1.Length - 1; i >= 0; i--)
      {
        listaInversa.Add(lista1[i]);
      }

      return listaInversa;
    }
  }
}
