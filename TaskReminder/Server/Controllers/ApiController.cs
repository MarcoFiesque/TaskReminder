using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskReminder.Server.Services;
using TaskReminder.Shared;

namespace TaskReminder.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private TodoService _todoService;

        public ApiController(TodoService todoService)
        {
            _todoService = todoService;
        }

        // GET: api/
        [HttpGet]
        public ActionResult<List<TodoItem>> GetTodos()
        {
            return _todoService.GetTodos();
        }

        // GET: api/5
        [HttpGet("{id:length(24)}", Name = "Get")]
        public ActionResult<TodoItem> GetTodoById(string id)
        {
            return _todoService.GetTodo(id);
        }

        // POST: api/
        [HttpPost]
        public TodoItem Post(TodoItem todo)
        {
            _todoService.PostTodo(todo);
            return todo;
        }

        // PUT: api/5
        [HttpPut("{id:length(24)}")]
        public TodoItem Put(string id, TodoItem newTodo)
        {
            return _todoService.PutTodo(id, newTodo);

        }

        // DELETE: api/5
        [HttpDelete("{id:length(24)}")]
        public TodoItem Delete(string id)
        {
           return _todoService.DeleteTodo(id);
        }
    }
}
