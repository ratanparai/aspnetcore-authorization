using System;
using System.Collections.Generic;
using System.Linq;
using Todo.API.Domain;

namespace Todo.API.Infrastructure
{
    public class InMemoryDb<T>
        where T : IEntity
    {
        private Dictionary<Guid, T> _items;

        public InMemoryDb()
        {
            _items = new Dictionary<Guid, T>();
        }

        public void Save(T data)
        {
            _items.Add(data.Id, data);
        }

        public T FindById(Guid id)
        {
            return _items[id];
        }

        public IEnumerable<T> GetAll()
        {
            return _items.Select(i => i.Value);
        }
    }
}