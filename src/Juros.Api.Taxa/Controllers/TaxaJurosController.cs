using Microsoft.AspNetCore.Mvc;

namespace Juros.Api.Taxa
{
    [Produces("application/json")]
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private const decimal TAXA_JUROS = 0.01M;

        /// <summary>
        /// Retorna o juros de 1% ou 0,01
        /// </summary>
        [HttpGet]
        public ActionResult<decimal> Get() => Ok(TAXA_JUROS);
    }
}
