using System;

namespace Todo.API.Domain
{
    public interface IEntity
    {
        Guid Id { get; }
    }
}