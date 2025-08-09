using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day3_C_
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;          
        private readonly List<T> _inMemory = new List<T>();

        public GenericRepository()
        {
            _context = null;
        }

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        private bool UseEf()
        {
            return _context != null;
        }

        public void Add(T item)
        {
            if (UseEf())
            {
                _context.Set<T>().Add(item);
            }
            else
            {
                _inMemory.Add(item);
            }
        }

        public void Remove(T item)
        {
            if (UseEf())
            {
                _context.Set<T>().Remove(item);
            }
            else
            {
                _inMemory.Remove(item);
            }
        }

        public IEnumerable<T> GetAll()
        {
            if (UseEf())
            {
                return _context.Set<T>().ToList();
            }
            else
            {
                return _inMemory;
            }
        }

        public T GetById(int id)
        {
            if (UseEf())
            {
                return _context.Set<T>().Find(id);
            }
            else
            {
                var idProp = typeof(T).GetProperty("Id");
                if (idProp == null)
                {
                    idProp = typeof(T).GetProperty(typeof(T).Name + "Id");
                }

                if (idProp == null)
                {
                    return default;
                }

                foreach (var item in _inMemory)
                {
                    var value = idProp.GetValue(item);
                    if (Equals(value, id))
                    {
                        return item;
                    }
                }

                return default;
            }
        }

        public void save()
        {
            if (UseEf())
            {
                _context.SaveChanges();
            }
        }
    }
}
