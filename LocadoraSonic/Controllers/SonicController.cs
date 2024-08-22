﻿using LocadoraSonic.Modelos;
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
    public IActionResult CalculaMaior([FromQuery] int a, [FromQuery] int b)
    {
      var maior = a > b ? a : b;
      return Ok($"O valor maior é {maior}");
    }

    [HttpPost("calculalista")]
    public IActionResult CalculaLista([FromBody] List<int> a)
    {
      var somaTotal = 0;
      for (int i = 0; i < a.Count; i++)
      {
        somaTotal += a[i];
      }

      return Ok(somaTotal);
    }

    [HttpPost("retornaobjeto")]
    public IActionResult RetoenaObjeto([FromBody] Sonic sonic)
    {
      var mensagem= $"o nome é {sonic.Nome}";
      var situacao = "jovem";
      if (sonic.Idade >=100) 
      {
        situacao = "velho";
      }
      var resposta = new Resposta
      {
        Mensagem = mensagem,
        Situcao = situacao
      };
      return Ok(resposta);
    }
  }
}
