using System;
using System.Diagnostics;
using System.Xml;

namespace Exam
{
    class Program
    {

        static void Main(string[] args)
        {
            Product product = new Product();
            product.AddProduct(product.Name, product.Price, product.Count);


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Product.xml");

            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement productElem = xDoc.CreateElement("product");

            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            XmlElement priceElem = xDoc.CreateElement("price");
            XmlElement countElem = xDoc.CreateElement("count");

            XmlText nameText = xDoc.CreateTextNode(product.Name);
            XmlText priceText = xDoc.CreateTextNode(product.Price);
            XmlText countText = xDoc.CreateTextNode(product.Count);

            nameAttr.AppendChild(nameText);
            priceElem.AppendChild(priceText);
            countElem.AppendChild(countText);


            productElem.Attributes.Append(nameAttr);
            productElem.AppendChild(priceElem);
            productElem.AppendChild(countElem);
            xRoot.AppendChild(productElem);
            xDoc.Save("Product.xml");

            string OpenXML = @"C:\Users\ТынышбаевА.CORP\source\repos\Exam\Exam\bin\Debug\Product.xml";
           

            Process.Start(OpenXML);

            

            Console.ReadLine();
        }
    }
}
