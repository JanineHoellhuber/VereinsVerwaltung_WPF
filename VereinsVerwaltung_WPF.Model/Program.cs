using System;

namespace VereinsVerwaltung_WPF.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            DateTime myString = DateTime.Parse("06.09.1999");


            
             Console.WriteLine(myString.ToShortDateString());

            

        }
    }
}
