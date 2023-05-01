using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
namespace MvcStaryApp.Models.Db
{
    public class RequestRepository: IRequestRepository
    {        
        public BlogContext _context;
        public RequestRepository(BlogContext context) 
        { 
            _context = context; 
        }

        public async Task addRequest(Request request)
        {            
            request.Date = DateTime.Now;
            request.Id = Guid.NewGuid();

            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
                await _context.requestPosts.AddAsync(request);

            // Сохранение изенений
            await _context.SaveChangesAsync();
        }
    }
}
