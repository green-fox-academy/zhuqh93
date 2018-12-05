using System.Collections.Generic;
using System.Linq;
using EntityFramworkExercise.Models;
using EntityFramworkExercise.Services;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramworkExercise.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private readonly TodoServices _todoServices;

        public TodoController(TodoServices todoServices)
        {
            this._todoServices = todoServices;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // Create a SQL query in the background
            var todos = _todoServices.ApplicationContext.Todos.ToList();

            return View(todos);
        }

        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult Add(Todo todo)
        {
            _todoServices.Add(todo);

            return RedirectToAction("Index");
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            List<Todo> todoList= new List<Todo>
            {
                new Todo {Id = 1, IsDone = false, IsUrgent = true, Title = "Meeting"},
                new Todo {Id = 2, IsDone = false, IsUrgent = false, Title = "Buy a table"},
                new Todo {Id = 3, IsDone = false, IsUrgent = false, Title = "Learn to cook"},
            };

            return View(todoList);
        }
    }
}