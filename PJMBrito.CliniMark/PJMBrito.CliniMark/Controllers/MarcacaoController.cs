using Microsoft.AspNetCore.Mvc;

namespace PJMBrito.CliniMark.Controllers
{
    [ApiController]
    [Route("api/clini-mark/[controller]")]
    public class MarcacaoController : ControllerBase
    {
        private readonly ILogger<MarcacaoController> _logger;

        public MarcacaoController(ILogger<MarcacaoController> logger)
        {
            _logger = logger;
        }

        [HttpGet] 
        public ActionResult<string> Teste()
        {
            return Ok("Funcionando");
        }
    }
}
