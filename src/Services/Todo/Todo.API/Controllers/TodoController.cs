using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Todo.API.Domain;

namespace Todo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        private readonly ITodoTaskRepository _repo;

        public TodoController(
                ILogger<TodoController> logger,
                ITodoTaskRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<TodoTask> Get()
        {
            return _repo.GetAll();
        }

        [HttpPost]
        public void Add(TodoDto dto)
        {
            var task = TodoTask.AddNew(dto.Title, dto.Description);
            _repo.Save(task);
        }

        public class TodoDto
        {
            public string Title { get; set; }
            public string Description { get; set; }
        }
    }
}
