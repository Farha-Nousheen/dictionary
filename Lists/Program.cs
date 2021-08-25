using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Farha");//using add() method
            names.Add("Nousheen");
            foreach (var name in names)
            {

                Console.WriteLine(name);
            }
        }
    }
}
