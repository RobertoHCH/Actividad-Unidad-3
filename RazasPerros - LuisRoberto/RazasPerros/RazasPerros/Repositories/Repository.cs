﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazasPerros.Models;

namespace RazasPerros.Repositories
{
    public class Repository<T> where T : class
    {
        public sistem14_razasContext Context { get; set; }
        public Repository(sistem14_razasContext context)
        {
            Context = context;
        }
        public virtual IEnumerable<T> GetAll()
        {
            return Context.Set<T>();
        }
        public virtual T GetById(object id)
        {
            return Context.Find<T>(id);
        }
        public virtual void Insert(T entidad)
        {
            if (Validate(entidad))
            {
                Context.Add<T>(entidad);
                Context.SaveChanges();
            }
        }
        public virtual void Update(T entidad)
        {
            if (Validate(entidad))
            {
                Context.Update<T>(entidad);
                Context.SaveChanges();
            }
        }
        public virtual void Delete(T entidad)
        {
            Context.Remove<T>(entidad);
            Context.SaveChanges();
        }
        public virtual bool Validate(T entidad)
        {
            return true;
        }
    }
}
