using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            List<string> list = new List<string>();
            list.Add("amama");
            list.Add("ananas");
            list.Add("apelsin");
            list.Add("alma");

            List<int> list2 = new List<int>();
            list2.Add(9);
            list2.Add(3);
            list2.Add(6);
            list2.Add(4);

            //Console.WriteLine(list.Remove("amama"));
            //Console.WriteLine(list.IndexOf("amama"));
            //Console.WriteLine(list.LastIndexOf("ananas"));
            //Console.WriteLine(list.Contains("apelsin"));
            //list2.Reverse();
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}
            //list2.Clear();
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}*/

            Optional<string> optional = new Optional<string>();
            optional.Add("amama");
            optional.Add("ananas");
            optional.Add("apelsin");
            optional.Add("alma");

            Optional<int> optional2 = new Optional<int>();
            optional2.Add(7);
            optional2.Add(9);
            optional2.Add(3);
            optional2.Add(5);

            //Console.WriteLine(optional.Remove("amama"));
            //Console.WriteLine(optional.IndexOf("amama"));
            //Console.WriteLine(optional.LastIndexOf("ananas"));
            //Console.WriteLine(optional.Contains("apelsin"));

            //optional2.Reverse();
            //for (int i = 0; i < optional2.Length(); i++)
            //{
            //    Console.WriteLine(optional2[i]);
            //}

            optional2.Clear();
            Console.WriteLine(optional2.Length());


        }
    }
}