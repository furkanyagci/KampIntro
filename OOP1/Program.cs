using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //case sensitive(harfe duyarlı) -C#'ın küçük büyük harf duyarlılığı vardır
            //PascalCase    //CamelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Topla2(3, 6);//void metot
            int sonuc = productManager.Topla(3, 6);//int metot old. için sonuc değişkenine atadık

            //int, double, bool... değer tip
            //diziler, class, abstract class, interface ...  referans tip
            //ref out
        }
    }
}
