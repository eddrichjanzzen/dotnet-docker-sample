using System.Collections.Generic;
using System.Linq;
using SimpleTodo.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleTodo.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<TodoContext>();
                context.Database.EnsureCreated();


                // Look for todo items
                if (context.TodoItems != null && context.TodoItems.Any())
                    return;   // DB has already been seeded

                var todos = DummyData.GetTodos().ToArray();
                context.TodoItems.AddRange(todos);
                context.SaveChanges();
            }
        }


        public static List<TodoItem> GetTodos()
        {
            List<TodoItem> todos = new List<TodoItem>() {
                new TodoItem {Title="Tylenol", Completed = false},
                new TodoItem {Title="Asprin", Completed = false},
                new TodoItem {Title="Advil", Completed = false},
                new TodoItem {Title="Robaxin", Completed = false},
                new TodoItem {Title="Voltaren", Completed = false},
            };
            return todos;
        }

       
    }

}