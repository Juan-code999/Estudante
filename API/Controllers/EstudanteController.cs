using Core.Entidates;
using Core.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudanteController : ControllerBase
    {

        private readonly EstudantesService _service;

        public EstudanteController(IConfiguration config)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new EstudantesService(_config);

        }

        [HttpPost("adicionar-Estudante")]
        public void AdicionarFuncionario(Estudante estudante)
        {
            _service.Adicionar(estudante);
        }


        [HttpGet("listar-Estudante")]
        public List<Estudante> ListarAluno()
        {
            return _service.Listar();
        }

    }
}

