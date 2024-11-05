using Core.Entidates;

namespace Core.Service.Interfaces
{
    public interface IEstudanteService
    {
        void Adicionar(Estudante estudante);
        List<Estudante> Listar();
    }
}
