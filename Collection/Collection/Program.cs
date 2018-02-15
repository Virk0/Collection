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
            #region List
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
            #endregion
            Console.WriteLine("\n" + "\n" + "#####End Of List#####" + "\n" + "\n");
            #region Dictionary
            ////Dictionary
            //var openWith = new Dictionary<string, string>();
            ////            key    value
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("jpg", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //openWith["rtf"] = "winword.exe";
            //try
            //{
            //    openWith.Add("txt", "word.exe");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("An element with key \"txt\" already exist");
            //}
            //Console.WriteLine("For key = rtf , value = {0}", openWith["rtf"]);
            ////Console.WriteLine("For key = doc , value = {0}", openWith["doc"]);

            //try
            //{
            //    Console.WriteLine("For key = tif , value = {0}", openWith["tif"]);
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("Key = \"tif\" not found");
            //}
            //string value = "";
            //if(openWith.TryGetValue("tif", out value))
            //{
            //    Console.WriteLine("For key = \"tif\", value = {0}.", value);
            //}
            //else
            //{
            //    Console.WriteLine("Key \"tif\" not found");
            //}

            //if (!openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hyperterm.exe");
            //    Console.WriteLine("Value added for key ht: {0}", openWith["ht"]);
            //}

            //foreach (KeyValuePair<string, string> kvp in openWith)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}

            //Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;
            //foreach (string item in valueCollection)
            //{
            //    Console.WriteLine("Value = {0}", item);
            //}

            //Dictionary<string, string>.KeyCollection keyCollection = openWith.Keys;
            //foreach (string item in keyCollection)
            //{
            //    Console.WriteLine("Key = {0}", item);
            //}

            //openWith.Remove("doc");
            //if (!openWith.ContainsKey("doc"))
            //{
            //    Console.WriteLine("Key \"doc\" is not found");
            //}
            #endregion
            Console.WriteLine("\n" + "\n" + "#####End of Dictionary#####" + "\n" + "\n");
            #region Queue   
            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");

            //foreach (string number in numbers)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(number);

            //}

            //Console.WriteLine();
            //Console.WriteLine("Dequeueing ' {0} '", numbers.Dequeue());
            //Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());
            //Console.WriteLine("Dequeueing ' {0} '", numbers.Dequeue());
            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());
            //Console.WriteLine("Contents of the frist Copy:");
            //foreach (string number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);

            //Queue<string> queueCopy2 = new Queue<string>(array2);
            //Console.WriteLine("\n Contents if the second Copy, with duplicates and nulls");
            //foreach (string number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nqueueCopy contains 'four' = {0}", queueCopy.Contains("four"));

            //queueCopy.Clear();
            //Console.WriteLine("\nqueueCopy count is: {0} ", queueCopy.Count);




            #endregion
            Console.WriteLine("\n" + "\n" + "#####End of Queue#####" + "\n" + "\n");
            #region Stack - Last in first out

            //Stack<string> numbersSt = new Stack<string>();
            //numbersSt.Push("one");
            //numbersSt.Push("two");
            //numbersSt.Push("three");
            //numbersSt.Push("four");
            //numbersSt.Push("five");

            //foreach (string number in numbersSt)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nPopping '{0}'", numbersSt.Pop());
            //Console.WriteLine("Peek at next item to destack: {0}", numbersSt.Peek());
            //Console.WriteLine("\nPopping '{0}'", numbersSt.Pop());










            #endregion
            Console.WriteLine("\n" + "\n" + "#####End of Stack#####" + "\n" + "\n");
            #region LINQ
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var NumQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            foreach (int num in NumQuery)
            {
                Console.WriteLine("{0,1} ", num);
            }
                           #endregion
            Console.ReadLine();
        }
    }
}
