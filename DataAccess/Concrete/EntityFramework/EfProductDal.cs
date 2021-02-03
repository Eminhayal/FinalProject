﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDısposable pattern implementation of c# 
            // Bellegi hizlica temizleme
            using (NorthwindContext context= new NorthwindContext())
            {
                var addedEntity = context.Entry(entity); // Referansı yakala , veritabaniyla iliskilendir.
                addedEntity.State = EntityState.Added; // Ekleme , set et
                context.SaveChanges(); // Değişikliği kaydet
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity); // Referansı yakala , veritabaniyla iliskilendir.
                deletedEntity.State = EntityState.Deleted; //Silme 
                context.SaveChanges(); // Değişikliği kaydet
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                    return filter == null ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity); // Referansı yakala , veritabaniyla iliskilendir.
                updatedEntity.State = EntityState.Modified; //güncelleme
                context.SaveChanges(); // Değişikliği kaydet
            }
        }
    }
}
