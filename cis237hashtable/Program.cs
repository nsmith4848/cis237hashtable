using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            
            HashMap myHashMap = new HashMap();

            Console.SetBufferSize(80, 1200);

            Console.WriteLine("Adding some entries to the HashMap");
            Console.WriteLine("Ex: valleyNumToName.Put(12345, \"David Barnes\" ");
            myHashMap.Put(12345, "Thane");
            myHashMap.Put(23456, "Jon Snow");
            myHashMap.Put(34567, "Mother Theresa");
            myHashMap.Put(45678, "Varric Tethras");
            myHashMap.Put(56789, "Steve Rogers");

            Console.WriteLine("The created hash table");
            Console.WriteLine(myHashMap.ToString());
            Console.WriteLine();

            Console.WriteLine("The full arrays as they got filled out");
            Console.WriteLine(myHashMap.ShowArrays());
            Console.WriteLine();

            Console.WriteLine("*******************************************");

            Console.WriteLine("Get a single value out from the hash table passing in the key");
            Console.WriteLine("myHashMap.Get(45678)");
            Console.WriteLine(myHashMap.Get(45678));
            Console.WriteLine();

            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();

            Console.WriteLine("*************************************************");
            Console.WriteLine();
            Console.WriteLine("What if we add 2 entries to the hash table that map to the same location?");
            Console.WriteLine("myHashMap.Put(26189, \" First Entry\")");
            myHashMap.Put(26189, "FirstEntry");
            Console.WriteLine("myHashMap.Put(26189, \" Second Entry\")");
            myHashMap.Put(26189, "Second Entry");

            Console.WriteLine("Re print the hash table and arrays");
            Console.WriteLine(myHashMap.ToString());
            Console.WriteLine(myHashMap.ShowArrays());
        }
    }
}
