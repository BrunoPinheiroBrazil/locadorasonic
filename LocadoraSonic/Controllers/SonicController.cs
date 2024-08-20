using Microsoft.AspNetCore.Mvc;

namespace LocadoraSonic.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class SonicController : ControllerBase
  {
    public SonicController() { }

    [HttpGet("sonic")]
    public IActionResult Sonic()
    {
      var resposta = "Ola Mundo Sonic!!!";
      return Ok(resposta);
    }

    [HttpGet("calculamaior")]
    public IActionResult CalculaMaior([FromQuery]int a, [FromQuery]int b)
    {
            var maior= a>b?a:b;
      return Ok($"O valor maior é {maior}");
    }
  }
}
