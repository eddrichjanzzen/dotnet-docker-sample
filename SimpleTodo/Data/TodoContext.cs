using SimpleTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace SimpleTodo.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        
        }
        
        // Add attributes we want to customize here
        protected override void OnModelCreating(ModelBuilder builder){
            // eg. to specify length of Name property in todo item: 
            //builder.Entity<TodoItem>.property(p => p.Name).hasMaxLength(40);
        }

        // We are generating these artifacts into the db
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}