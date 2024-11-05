using Core.Entidates;
using Core.Service;
using Core.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstudanteController : ControllerBase
    {

        private readonly IEstudanteService _service;

        public EstudanteController(IEstudanteService estudantesService)
        {
            _service = estudantesService;

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
        [HttpPut("EditarEstudante")] 
        public void EditarEstudante(Estudante estudante)
        {
            _service.Editar(estudante);
        }

        [HttpDelete("RemoverEstudante")] 
        public void RemoverEstudante(int id)
        {
            _service.Remover(id);
        }

    }
}

