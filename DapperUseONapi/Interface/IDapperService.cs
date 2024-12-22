using DapperUseONapi.Models;

namespace DapperUseONapi.Interface
{
    public interface IDapperService
    {
        Task<List<ToDo>> GetAll();
    }
}
