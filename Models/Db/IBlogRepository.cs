using System.Threading.Tasks;

namespace MvcStaryApp.Models.Db
{
    public interface IBlogRepository
    {
        Task AddUser(User user);

        Task<User[]> GetUsers();
    }
}
