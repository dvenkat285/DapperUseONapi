using DapperUseONapi.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DapperUseONapi.DapperContext
{
    public class DapperDbContext
    {
        internal readonly object ConnectionString;
        private readonly IConfiguration _configuration;
        private readonly string connectionString;

        public DapperDbContext(string? connectionString)
        {
            this.connectionString = connectionString;
        }

        public DapperDbContext(IConfiguration configuration, string connectionString)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("Database");
        }
        public IDbConnection CreateConnection() => new SqlConnection(connectionString);

    }
}
