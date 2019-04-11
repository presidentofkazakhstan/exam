using System;

namespace Exam
{
    public class Product
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Count { get; set; }

        public void AddProduct(string _name, string _price, string _count)
        {

            Console.Write("Введите имя товара: ");
            _name = Console.ReadLine();
            Console.Write("Введите цену товара: ");
            _price = Console.ReadLine();
            Console.Write("Введите количество товаров: ");
            _count = Console.ReadLine();

            Name = _name;
            Price = _price;
            Count = _count;

         

        }
    }
}
