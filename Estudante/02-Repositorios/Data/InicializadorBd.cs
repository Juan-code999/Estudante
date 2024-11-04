using Dapper;
using System.Data.SQLite;

namespace Crud_Estudante._02_Repositorios.Data
{
    public static class InicializadorBd
    {
        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=Escola.db");

            string commandoSQL = @"
                CREATE TABLE IF NOT EXISTS Estudantes(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome STRING NOT NULL,
                    Altura INTEGER NOT NULL,
                    Peso REAL NOT NULL,
                    Idade INTEGER NOT NULL
                );";

            connection.Execute(commandoSQL);
        }
    }
}







