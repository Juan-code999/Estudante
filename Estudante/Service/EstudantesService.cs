using Core._02_Repositorios.Interfaces;
using Core.Entidates;
using Core.Repositorios;
using Core.Service.Interfaces;

namespace Core.Service
{
    public class EstudantesService : IEstudanteService
    {
        private readonly IEstudanteRepository repository;
        public EstudantesService(IEstudanteRepository estudanterepository)
        {
            repository = estudanterepository;
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
