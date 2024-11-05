using Core.Entidates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._02_Repositorios.Interfaces
{
    public interface IEstudanteRepository
    {
        void Adicionar(Estudante estudante);
        List<Estudante> Listar();
        void Editar(Estudante editEstudante);
        void Remover(int id);
    }
}
