using System;
using System.Collections.Generic;
using Todo.API.Domain;

namespace Todo.API.Infrastructure
{
    public class TodoTaskRepository
        : ITodoTaskRepository
    {
        private readonly InMemoryDb<TodoTask> _todoTaskDb;

        public TodoTaskRepository(InMemoryDb<TodoTask> todoTaskDb)
        {
            _todoTaskDb = todoTaskDb;

        }
        public IEnumerable<TodoTask> GetAll()
        {
            return _todoTaskDb.GetAll();
        }

        public TodoTask GetById(Guid id)
        {
            return _todoTaskDb.FindById(id);
        }

        public void Save(TodoTask task)
        {
            _todoTaskDb.Save(task);
        }
    }
}