using Core.Entidates;

namespace Core.Service.Interfaces
{
    public interface IEstudanteService
    {
        void Adicionar(Estudante estudante);
        List<Estudante> Listar();
        void Editar(Estudante estudanteEdit);
        void Remover(int id);
    }
}
