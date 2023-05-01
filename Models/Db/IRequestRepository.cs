using System.Threading.Tasks;

namespace MvcStaryApp.Models.Db
{
    public interface IRequestRepository
    {
        Task addRequest(Request request);
    }
}
