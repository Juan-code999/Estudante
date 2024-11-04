using Core.Entidates;
using Core.Repositorios;

namespace Core.Service
{
    public class EstudantesService
    {
        public EstudantesReposity repository { get; set; }
        public EstudantesService(string _config)
        {
            repository = new EstudantesReposity(_config);
        }

        public void Adicionar(Estudante estudante)
        {
            repository.Adicionar(estudante);
        }


        public List<Estudante> Listar()
        {
            return repository.Listar();
        }

    }
}
