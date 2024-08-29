namespace LocadoraSonic.Servicos
{
  public static class EstudosLacos
  {
    public static void ExemploLacos()
    {
      int[] l = [1, 2, 3, 4, 5];
      string[] s = { "day", "lol", "void", "sonic" };

      for (int i = 0; i < l.Length; i++)
      {
        Console.WriteLine($"os numeros corresponden as palavras {l[i]}.{s[i]}");
      }
    }

    public static void Exemplo2Lacos()
    {
      int[] b = { 5, 10, 15, 20 };
      string[] p = { "Sonic", "Mickey", "Vacilo", "Pato" };

      for(int a = 0; a < b.Length; a = a + 1)
      {
        Console.WriteLine($"O número da sorte do {p[a]} é {b[a]}");
      }
      Console.WriteLine();
    }

    public static void Exemplo3Lacos()
    {
      string[] s = { "Mickey", "Sonic", "Pato", "Lili" };
      string[] p = { "Pato", "Mickey", "Vacilo", "Lili" };

      //Só fazer aparecer na tela o valor da lista 's' que não encontrar na lista 'p'

    }
  }
}
