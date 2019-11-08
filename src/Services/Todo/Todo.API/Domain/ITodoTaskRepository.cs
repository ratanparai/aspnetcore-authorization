using System;
using System.Collections.Generic;

namespace Todo.API.Domain
{
    public interface ITodoTaskRepository
    {
        TodoTask GetById(Guid id);
        IEnumerable<TodoTask> GetAll();
        void Save(TodoTask task);
    }
}