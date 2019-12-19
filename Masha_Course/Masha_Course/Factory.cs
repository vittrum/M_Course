using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Masha_Course.Repos;


namespace Masha_Course {
    class Factory : IDisposable {
        public NpgsqlConnection NpgsqlConnection;
        public Connection connection;
              
        public ReposClient client { get; }
        public ReposPositions positions { get; }
        public ReposEmployee employee { get; }
        public ReposService service { get; }
        public ReposSubType type { get; }
        public ReposSubscription sub { get; }
        public ReposSchedule schedule { get; }
        public Login login { get; }

        public Factory(string server, string port, string user, string pass, string dbname) {
            string ConnectionString = "Server=" + server + "; Port=" + port + "; User Id=" + user + "; Password=" + pass + "; Database=" + dbname + ";";
            NpgsqlConnection = new NpgsqlConnection(ConnectionString);
            connection = new Connection(NpgsqlConnection);
            OpenConnection();
            client = new ReposClient(connection);
            positions = new ReposPositions(connection);
            employee = new ReposEmployee(connection);
            service = new ReposService(connection);
            type = new ReposSubType(connection);
            sub = new ReposSubscription(connection);
            schedule = new ReposSchedule(connection);
            login = new Login(connection);

        }

        private bool Disposed = false;

        public void OpenConnection() {
            connection.connection.Open();
        }
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing) {
            if (!Disposed) {
                if (disposing) {
                    connection.connection.Close();
                }
                Disposed = true;
            }
        }
        ~Factory() {
            Dispose(false);
        }
    }
}
