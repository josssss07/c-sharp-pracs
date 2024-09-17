using System.Xml.Linq;

namespace prac5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //path to xml file: 
            // C:\Users\Joshua\Dev\c#-pracs\prac5\prac5\myfile.xml

            XDocument pd = XDocument.Load("C:\\Users\\Joshua\\Dev\\c#-pracs\\prac5\\prac5\\myfile.xml");
            var products = pd.Elements();

            // Q1:

            Console.WriteLine("display the products where price > 40000");
            var result = products.Elements("Product").
                Where(x => (int)x.Element("price") > 40000).
                Select(x => new
                {
                    Name = x.Element("Name").Value,
                    price = x.Element("price").Value,
                    dom = x.Element("dom").Value
                });

            foreach(var item in result )
            {
                Console.WriteLine(item);
            }


            //q2: 
            var result2 = products.Elements("Product")
                .Select(x =>
                new
                {
                    Name = x.Element("pname").Value,
                    price = x.Element("price").Value,
                    dom = x.Element("dom").Value,
                }
              );
              foreach (var item in result2 )
            {
                Console.WriteLine(item);
            }

            //q3: 

            var result3 = products.Elements("Product")
                 .Where(x => DateTime.ParseExact((string)x.Element("dom").Value, "dd-mm-yy", null) > DateTime.ParseExact("10-07-14", "dd-mm-yy", null))
                 .Select(x =>
                 new
                 {
                     Name = x.Element("pname").Value,
                     price = x.Element("price").Value,
                     dom = x.Element("dom").Value,
                 }
              );


            Console.WriteLine("display products manufactured after 10-07-14");
            foreach (var r in result3)
            {
                Console.WriteLine(r);
            };
            Console.WriteLine();

            ////////////////Q4////////////////
            Console.WriteLine("display product names manufactured after 10-07-14 using query");
            var pr = from x in products.Elements("Product")
                     where DateTime.ParseExact((string)x.Element("dom").Value, "dd-mm-yy", null) > DateTime.ParseExact("10-07-14", "dd-mm-yy", null)
                     let nm = (string)x.Element("pname")
                     select nm;

            Console.Write("product name is ");
            foreach (var r in pr)
            {
                Console.WriteLine(r);
            };
            Console.WriteLine();

            ////////////////Q5////////////////
            var v = from x in products.Elements("Product")
                    where (int)x.Element("price") > 40000
                    select new { Name = (string)x.Element("pname"), Price = (int)x.Element("price") };

            v.ToList().ForEach(y => Console.WriteLine(y.Name + " " + y.Price));

            Console.WriteLine();

            Console.ReadKey();



        }
    }
}
