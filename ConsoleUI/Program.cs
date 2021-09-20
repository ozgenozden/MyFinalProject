using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //foreach (var product in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }


        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetAllUnitPrice(50, 500))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
