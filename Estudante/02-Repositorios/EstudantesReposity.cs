using Core.Entidates;
using Dapper.Contrib.Extensions;
using System.Data.SQLite;

namespace Core.Repositorios
{
    public class EstudantesReposity
    {
        private readonly string ConnectionString;
        public EstudantesReposity(string connectioString)
        {
            ConnectionString = connectioString;
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

