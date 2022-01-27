

using Microsoft.EntityFrameworkCore;

namespace Api.Model
{
    public class TodoDbContext: DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base (options)
        {

        }
        public DbSet<TodoItems> TodoItems { get; set; } = null!;
    }
}
