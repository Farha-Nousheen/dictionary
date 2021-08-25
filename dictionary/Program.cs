using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //key(unique)-value(any) pairs
            Dictionary<string, string> names = new Dictionary<string, string>();
            names.Add("1", "farha");
            names.Add("2", "fnshn");
            names.Add("3", "nousheen");
            names.Add("4", "nshn");
            

            foreach (KeyValuePair<string, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
