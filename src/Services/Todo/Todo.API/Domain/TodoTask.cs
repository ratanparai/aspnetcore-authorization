using System;

namespace Todo.API.Domain
{
    public class TodoTask
        : IEntity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Guid Id { get; } = Guid.NewGuid();

        private TodoTask(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public static TodoTask AddNew(string title, string description)
        {
            return new TodoTask(title, description);
        }
    }
}