using CliniMark.Aplication.Interfaces;
using CliniMark.Aplication.Views;
using Microsoft.AspNetCore.Mvc;

namespace PJMBrito.CliniMark.Controllers
{
    [ApiController]
    [Route("api/clini-mark/[controller]")]
    public class MarcacaoController : ControllerBase
    {
        private readonly ILogger<MarcacaoController> _logger;
        private readonly IService _service;
        

        public MarcacaoController(ILogger<MarcacaoController> logger, IService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet] 
        public ActionResult<string> Teste()
        {
            _logger.LogInformation("Gerado Log de Informação!");
            return Ok("Funcionando");//
        }
     

        [HttpGet("especialidades-com-colaborador")]
        public async Task<ActionResult<List<InformacaoViewModel>>> Buscare()
        {
            var colaboredores = await _service.ObterColaboradoresAsync();

            return Ok(colaboredores);
        }
    }   
}
