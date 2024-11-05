using Core._02_Repositorios.Interfaces;
using Core.Entidates;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;

namespace Core.Repositorios
{
    public class EstudantesReposity : IEstudanteRepository
    {
        private readonly string ConnectionString;
        public EstudantesReposity(IConfiguration connection)
        {
            ConnectionString = connection.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Estudante estudante)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert(estudante);
        }

        public List<Estudante> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Estudante>().ToList();
        }

    }
}

