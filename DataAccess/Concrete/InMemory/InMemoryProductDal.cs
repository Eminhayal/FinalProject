using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle,Sql Server, Postgres , MongoDb
            _products = new List<Product> { 
                new Product {ProductID=1 , CategoryID= 1 ,ProductName="Bardak",UnitPrice=15,UnitInStock=15},
                new Product {ProductID=2 , CategoryID= 1 ,ProductName="Kamera",UnitPrice=500,UnitInStock=3},
                new Product {ProductID=3 , CategoryID= 2 ,ProductName="Telefon",UnitPrice=1500,UnitInStock=2},
                new Product {ProductID=4 , CategoryID= 2 ,ProductName="Klavye",UnitPrice=150,UnitInStock=65},
                new Product {ProductID=5 , CategoryID= 2 ,ProductName="Bardak",UnitPrice=85,UnitInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);
            //singleofdefault foreach gibi diziyi döner ver kurala göre haraket eder. Primery Keyde kullanılır.
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün idsine sahip olan listedeki ürünü bul ki biz onu güncelleyebilelim
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;

        }
    }
}
