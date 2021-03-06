﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{ 
    //Core katmanı evrensel katmandır. Bütün projelerde kullanılır
    public interface IEntityRepository<T> where T: class, IEntity, new() 
    {
        // Generic Constraint
        // Class : Referans tip olabilir
        // IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir.
        //New : New'lenebilir olmalidir.
        List<T> GetAll(Expression<Func<T,bool>> filter= null);
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
