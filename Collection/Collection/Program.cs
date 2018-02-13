using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //var cars = new List<string>();
            //var car1 = "BMW";
            //var car2 = "Lada";
            //var car3 = "Mercedes";
            //var car4 = "Ferrari";
            //var car5 = "Opel";
            //var car6 = "Saab";

            //cars.Add(car1);
            //cars.Add(car2);
            //cars.Add(car3);
            //cars.Add(car4);
            //cars.Add(car5);
            //cars.Add(car6);

            //var cars = new List<string> { "BMW", "Lada", "Mercede", "Ferrari", "Opel", "Saab" };
            ////foreach (var item in cars)
            //var elementidearv = cars.Count;
            //for (int index = 0; index < cars.Count;index++)
            //{
            //    //Console.WriteLine(item);
            //    Console.WriteLine(cars[index]);
            //}
            //Console.ReadLine();

            //var humans1 = new List<Human>
            //{
            //    new Human(){Name = "Kalle",Age = 20},
            //    new Human(){Name = "Malle",Age = 25},
            //    new Human(){Name = "Mari",Age = 30},
            //    new Human(){Name = "Elmar",Age = 20},
            //    new Human(){Name = "Juku",Age = 20}
            //};

            //var human1 = new Human();
            //human1.Name = "Priit";
            //human1.Age = 25;
            //humans1.Add(human1);

            //var human2 = new Human();
            //Console.WriteLine("Sisestage Nimi");
            //human2.Name = Console.ReadLine();;
            //Console.WriteLine("Sisestage Vanus");
            //human2.Age = int.Parse(Console.ReadLine()); ;
            //humans1.Add(human2);
            //foreach (var item in humans1)
            //{
            //    Console.WriteLine(item.Name+" "+item.Age);
            //}
            //Console.ReadLine();
            //var humans1 = new List<Human>();
            //bool continue0 = true;
            //int index1;
            //while (continue0 = true)
            //{



            //}


            //Dictionary
            var openWith = new Dictionary<string, string>();
            //            key    value
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("jpg", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            Console.WriteLine("For key = rtf , value = {0}", openWith["rtf"]);











            Console.ReadLine();
        }
    }
}
