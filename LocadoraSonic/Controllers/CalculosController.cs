using Microsoft.AspNetCore.Mvc;

namespace LocadoraSonic.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CalculosController : ControllerBase
  {
    //Aqui o sonic vai ter que criar um metodo GET igual os outros que o sonic já fez.
    //O caminho do metodo GET vai ser 'parouimpar', sonic deverá se basear nos exercícios anteriores
    //O metodo get tem que receber 1 parâmetro do tipo 'int' [FromQuery] igual aos exercicios anteriores.
    //O metodo tem que ter IActionResult por é uma operação REST. 
    //O metodo precisa validar a variável int que foi passada por parametro se é Par ou Impar. 
    //O método vai retornar um OK(com a resposta dentro). 
    //Boa sorte amigo sonic! 
    [HttpGet("parouimpar")] //Operação REST (GET, POST, DELETE, UPDATE, PATCH) e caminho que é uma string que indica o endereço que vai ser chamado
    public IActionResult ParOuImpar([FromQuery] int numero) //Para montar é sempre [visibilidade] [Tipo] [Nome do metodo] [Entre parenteses os parametros]
    { //Sempre chave parar abrir o bloco do metodo
      if (numero % 2 == 0)
      {
        return Ok("Par");
      }
      else
      {
        return Ok("Ímpar");
      }
    } //Sempre chave invertida para fechar o bloco do metodo.

  }
}
