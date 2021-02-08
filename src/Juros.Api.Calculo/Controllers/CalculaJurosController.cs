using Juros.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Juros.Api.Calculo
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IRequestHttp _requestHttp;

        public CalculaJurosController(IRequestHttp requestHttp) => _requestHttp = requestHttp;

        /// <summary>
        /// Retorna um cálculo em memória, de juros compostos, 
        /// conforme: Valor Final = Valor Inicial * (1 + juros) ^ Tempo
        /// </summary>
        /// <param name="valorInicial">Um decimal que representa o valor de início</param>
        /// <param name="meses">Um inteiro que representa o número de meses</param>
        [HttpGet]
        public async Task<ActionResult<double>> CalculaAsync(decimal valorInicial, int meses)
        {
            var valorFinal = (double)valorInicial * Math.Pow((double)(1M + await _requestHttp.RetornaTaxaJuros()), meses);
            return Ok(Math.Truncate(100 * valorFinal) / 100);
        }

        /// <summary>
        /// Retorna a url de onde encontra-se o código-fonte
        /// </summary>
        [HttpGet("/showmethecode")]
        public ActionResult<string> RetornaUrlCodigo() => Ok(_requestHttp.RetornaUrlCodigo());
    }
}
