using Microsoft.EntityFrameworkCore;

namespace MvcStaryApp.Models.Db
{
    /// <summary>
    /// Класс контекста, предоставляющий доступ к сущностям базы данных
    /// </summary>
    public class BlogContext: DbContext
    {
        // Ссылка на таблицу User
        public DbSet<User> Users { get; set; }
        
        // Ссылка на таблицу UserPost
        public DbSet<UserPost> userPosts { get; set; }

        // Ссылка на таблицу Request
        public DbSet<Request> requestPosts { get; set; }

        // Логика для взаимодействия с таблицей в БД
        public BlogContext(DbContextOptions<BlogContext> options): base(options)
        { 
            Database.EnsureCreated();
        }
    }
}
