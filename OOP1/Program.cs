using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(); //101
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product {Id = 2, CategoryId=5, 
                UnitsInStock = 5, ProductName="Kalem", UnitPrice= 35};

            //PascalCase   //camelCase
            //case sensitive
            ProductManager productManager = new ProductManager(); 
            productManager.Add(product1);


            //Product[] products =new Product[] {product1,product2 };
            //foreach (var Product in products)
            //{
            //    Console.WriteLine("ID: "+Product.Id + " //Kategori ID: " + Product.CategoryId + " //Ürün Adı: " + Product.ProductName + " //Birim Fiyatı: " + Product.UnitPrice + " //Ürün Stoğu: " + Product.UnitsInStock);
            //}

            productManager.List(product2);
            productManager.List(product1);

            Console.ReadKey();
            //int,double,bool... değer tip
            //diziler,class, abstract class, interface ... referans tip
            //ref out
        }
    }
}
