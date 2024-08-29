namespace LocadoraSonic.Servicos
{
  public class EstudosSonicParte2Variaveis
  {
    public int MetodoQueGeraNumeroAleatorio50A250() //Metodo retorna int. Gerado aletoriamente de 0 a 100. 
    {
      var randomizer = new Random();
      var numeroAleatorio = randomizer.Next(0, 100);
      return numeroAleatorio;
    }

    //Complete o método que pega posição do numero numa string.
    public int PegaPosicaoDoNumero(int[] listaNumeros, int numeroProcurado)
    {
      for (int i = 0; i < listaNumeros.Length; i++)
      {
        if (listaNumeros[i] == numeroProcurado)
          return i;
      }
      return -1;
    }

    //Crie um método que gere um numero aleatório de 50 a 250.
    //Aqui.
    public int MetodoQueGeraNumeroAleatorioEntreOsNumero50A250()
    {
      var randomizer = new Random();
      var numeroAleatorio = randomizer.Next(50, 250);
      return numeroAleatorio;
    }

    public static string GeraTexto(string tipoTexto, string nomePessoa)
    {
      switch (tipoTexto.ToLower())
      {
        case "raiva":
          return $"o {nomePessoa} ficou com raiva pois {nomePessoa} não fez os exercicios!";
        case "feliz":
          return $"o {nomePessoa} ficou feliz pois {nomePessoa} fez os exercicios!";
        case "triste":
          return $"o {nomePessoa} ficou triste por quê não passou no teste!";
        default:
          return "Nada";
      }

      var teste = tipoTexto != "raiva";

      if (tipoTexto == "raiva")
      {
        return $"o {nomePessoa} esta com raiva pq não sabe fazer nada!";

      }
      else if (tipoTexto == "feliz")
      {
        return $"o {nomePessoa} esta feliz pq passou os teste!";

      }
      else if (tipoTexto == "triste")
      {
        return $"o {nomePessoa} esta tiste pq rodou!";

      }
      else
      {
        return "nada";
      }

      //Exemplo de Switch
      var a = 2;
      var b = 3;

      switch (a) //Switch(parametro)
      {
        case 1: //Caso a seja igual a 1 cairá nesta condição.
          if (a > b)
            break;
          if (a < b)
            a = a * b;
          a = b - a;
          break;
        case 2: //Caso a seja igual a 2 cairá nesta condição.
          if (a < b)
            break;
          a = b - a;
          break;
        default: //caso não seja igual a nenhuma das condições existentes no Switch, vai cair aqui por padrão.
          a = a;
          break;
      }
    }
    //O seguinte metodo chama uma função desta mesma classe aqui para gerar um texto baseado em RAIVA, FELIZ ou TRISTE
    //Arrume o metodo para que o mesmo funcione.
    public string CriaTexto(string nomePessoa, string tipoTexto)
    {

      //Este metodo ainda não existe, você vai ter que criar um metodo estático para isso! Que retorne string.
      //O método é pra ser criado nesta mesma classe!
      //O texto deverá ser criado juntando o nome da pessoa e o texto de forma criativa! use sua imaginação! 
      //Deverá retornar 1 texto diferente para cada tipo no método GeraTexto.
      var textoCriado = GeraTexto(tipoTexto, nomePessoa);

      return textoCriado;
    }


    //Crie um método que retorne a posição da palavra passada.


  }
}
