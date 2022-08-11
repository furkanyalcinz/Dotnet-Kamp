
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    // T bir class olmalı
    // T IEntity implemente eden bir class veya IEntity olmalı
    // T new'lenebilir olmalı bu sayede interface ekleyemiyoruz.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
      
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
