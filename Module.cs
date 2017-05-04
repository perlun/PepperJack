using Dapper;
using MySql.Data.MySqlClient;
using Nancy;

namespace PepperJack
{
    public class Module : NancyModule
    {
        public Module()
        {
            using (var conn = GetMySqlConnection())
            {
                Get("/api/employees", x =>
                {
                    return conn.Query<Employee>(@"
                        select * from employees limit 100
                    ");
                });
            }
        }

        private static MySqlConnection GetMySqlConnection()
        {
            string cs = "Server=localhost;Database=employees;Uid=test;Pwd=pass";
            var csb = new MySqlConnectionStringBuilder(cs);
            var conn = new MySqlConnection(csb.ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
