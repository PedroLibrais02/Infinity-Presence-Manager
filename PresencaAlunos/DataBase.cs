using System;
using System.Data.SQLite;
using System.IO;

namespace PresencaAlunos
{
    public class Database
    {
        private SQLiteConnection _connection;
        private string _databaseFile;

        public Database(string databaseDirectory)
        {
            _databaseFile = Path.Combine(databaseDirectory, "alunos.db");
            string cs = $"Data Source={_databaseFile};Version=3;";
            _connection = new SQLiteConnection(cs);

            // Certifique-se de criar o diretório se ele não existir
            string directory = Path.GetDirectoryName(_databaseFile);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            // Verifique se o arquivo do banco de dados existe, se não existir, crie-o
            if (!File.Exists(_databaseFile))
            {
                SQLiteConnection.CreateFile(_databaseFile);
                CriarTabelas();
            }
            else
            {
                _connection.Open(); // Abra a conexão se o arquivo já existir
            }
        }

        private void CriarTabelas()
        {
            _connection.Open();
            string stm = "CREATE TABLE IF NOT EXISTS Alunos (ID INTEGER PRIMARY KEY AUTOINCREMENT, Nome TEXT, Codigo TEXT)";
            using var cmd = new SQLiteCommand(stm, _connection);
            cmd.ExecuteNonQuery();

            stm = "CREATE TABLE IF NOT EXISTS Presencas (ID INTEGER PRIMARY KEY AUTOINCREMENT, Codigo TEXT, Session TEXT)";
            using var cmdPresenca = new SQLiteCommand(stm, _connection);
            cmdPresenca.ExecuteNonQuery();
        }

        public void AddAluno(string nome, string codigoPresenca)
        {
            string sql = "INSERT INTO Alunos (Nome, Codigo) VALUES (@nome, @codigoPresenca)";
            SQLiteCommand command = new SQLiteCommand(sql, _connection);
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@codigoPresenca", codigoPresenca);
            command.ExecuteNonQuery();
        }

        public void MarcarPresenca(string codigo, string session)
        {
            string sql = "INSERT INTO Presencas (Codigo, Session) VALUES (@codigo, @Session)";
            SQLiteCommand command = new SQLiteCommand(sql, _connection);
            command.Parameters.AddWithValue("@codigo", codigo);
            command.Parameters.AddWithValue("@Session", session);
            command.ExecuteNonQuery();
        }

        public SQLiteDataReader GetAlunosPresentes(string session)
        {
            string sql = @"SELECT DISTINCT Alunos.Nome FROM Alunos 
                   JOIN Presencas ON Presencas.Codigo = Alunos.Codigo
                   WHERE Presencas.Session = @Session";
            SQLiteCommand command = new SQLiteCommand(sql, _connection);
            command.Parameters.AddWithValue("@Session", session);
            return command.ExecuteReader();
        }

        public void Close()
        {
            _connection.Close();
        }
    }
}
