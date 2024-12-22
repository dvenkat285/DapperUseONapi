using Dapper;
using DapperUseONapi.DapperContext;
using DapperUseONapi.Interface;
using DapperUseONapi.Models;

namespace DapperUseONapi.Repo
{
    public class DapperRepo : IDapperService
    {
        private readonly DapperDbContext _dbContext;
        public DapperRepo(DapperDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ToDo>> GetAll()
        {
            var sql = "select * from todo";
            using (var connection = _dbContext.CreateConnection())
            {
                var tasks = await connection.QueryAsync<ToDo>(sql);
                return tasks.ToList();
            }
        }
    }
}
