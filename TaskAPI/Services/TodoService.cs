using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoService
    {
        // Get Todos 
        public List<Todo> AllTodos()
        {
            var todos = new List<Todo>();

            var todo_1 = new Todo
            {
                Id = 1,
                Title = "Get some books from library",
                Description = "Read all the books and go through the knowledge",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.New
            };
            todos.Add(todo_1);

            var todo_2 = new Todo
            {
                Id = 2,
                Title = "Get some books from library",
                Description = "Read all the books and go through the knowledge",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Inprogress
            };
            todos.Add(todo_2);

            var todo_3 = new Todo
            {
                Id = 3,
                Title = "Get some books from library",
                Description = "Read all the books and go through the knowledge",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(5),
                Status = TodoStatus.Completed
            };
            todos.Add(todo_3);
            return todos;
        }
    }
}
