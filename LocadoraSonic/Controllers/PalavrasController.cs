using Microsoft.AspNetCore.Mvc;

namespace LocadoraSonic.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class PalavrasController : ControllerBase
  {
    //Aqui deverá ter um método GET que vai receber um parâmetro chamado palavra do tipo string ([FromQuery]).
    //O caminho do GET deverá ser 'invertepalavra' (se baseia nos anteriores) 
    //Aqui eu já fiz o método, sonic deverá corrigir para que faça o que é pedido. 
    //O método deverá inverter a palavra. Ex: sonic vai ser cinos, mickey vai ser yekcim, e assim por diante. 
    //O metodo deverá retornar a variavel com a palavra invertida dentro do Ok. 
    //Boa sorte! 

    [HttpGet("invertepalavra")]
    public IActionResult InvertePalavra([FromQuery] string palavra)
    {

      // Converte a palavra em um array de caracteres, inverte o array e cria uma nova string
      char[] array = palavra.ToCharArray();
      Array.Reverse(array);
      string palavraInvertida = new string(array);

      // Retorna a palavra invertida
      return Ok(palavraInvertida);
    }
  }
}
