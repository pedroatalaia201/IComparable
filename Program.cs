using System;
using System.IO;
using System.Collections.Generic;
using Aula202.Entities;

namespace Aula202
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Pedro\Tests\in.txt";

            try
            {
                using(StreamReader stream = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();

                    while (!stream.EndOfStream)
                    {
                        list.Add(new Employee(stream.ReadLine()));
                    }
                    list.Sort();
                    foreach(Employee employ in list)
                    {
                        Console.WriteLine(employ);
                    }
                }
            }
            catch(IOException e)
            {
                Console.Write("Error: ");
                Console.Write(e.Message);
            }
        }
    }
}
