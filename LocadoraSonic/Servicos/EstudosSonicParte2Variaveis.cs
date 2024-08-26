namespace LocadoraSonic.Servicos
{
  public class EstudosSonicParte2Variaveis
  {
    public int MetodoQueGeraNumeroAleatorio() //Metodo retorna int. Gerado aletoriamente de 0 a 100. 
    {
      var randomizer = new Random();
      var numeroAleatorio = randomizer.Next(0, 100);
      return numeroAleatorio;
    }

    //Complete o método que pega posição do numero numa string.
    public int PegaPosicaoDoNumero(int[] listaNumeros)
    {
      throw new NotImplementedException();
    }

    //Crie um método que gere um numero aleatório de 50 a 250.
    //Aqui.



    //Crie um método que retorne a posição da palavra passada.

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
  }
}
