using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;  

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product(){ ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15,UnitsInStock=85 },
                new Product(){ ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 25,UnitsInStock=75 },
                new Product(){ ProductId = 3, CategoryId = 2, ProductName = "Telefon", UnitPrice = 35,UnitsInStock=65 },
                new Product(){ ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitPrice = 45,UnitsInStock=55 },
                new Product(){ ProductId = 5, CategoryId = 2, ProductName = "Fare", UnitPrice = 85,UnitsInStock=1 }

                };

                
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete;

            //gönderdiğim ürün id sine sahip ürünü bul demek.
            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

      

        public void Update(Product product)
        {
            Product productToUpdate;

            //gönderdiğim ürün id sine sahip ürünü bul demek.
            productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {

            return _products.Where(p => p.CategoryId == categoryId).ToList();
           // return _products.FindAll(p => p.CategoryId == categoryId);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
