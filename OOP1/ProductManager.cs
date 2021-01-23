using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)//101
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        public void List(Product product)
        {
            Console.WriteLine("********************");
            Console.WriteLine("ID:           " + product.Id);
            Console.WriteLine("Kategori ID:  " + product.CategoryId);
            Console.WriteLine("Ürün Adı:     " + product.ProductName);
            Console.WriteLine("Birim Fiyatı: " + product.UnitPrice);
            Console.WriteLine("Ürün Stoğu:   " + product.UnitsInStock);
            Console.WriteLine("********************");
            
        }

    }
}
