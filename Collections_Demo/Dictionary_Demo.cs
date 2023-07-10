using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    public class Dictionary_Demo
    {
        public void Display()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("One", "Amalapuram");
            keyValuePairs.Add("Two", "Hyderabad");
            keyValuePairs.Add("Three", "Bangalore");
            keyValuePairs.Add("Four", "Chennai");

            //Print the value for key 
            Console.WriteLine("Print the value of key");
            Console.WriteLine(keyValuePairs["Two"]);
            Console.WriteLine("---------------------------------------");


            //Modify the value of key 
            Console.WriteLine("Modify the key value");
            keyValuePairs["Two"] = "Kakinada";
            Console.WriteLine(keyValuePairs["Two"]);
            Console.WriteLine("----------------------------------------");


            Console.WriteLine("Dictionary using for each loop");

            //Remove element from dictionary
            keyValuePairs.Remove("Three");

            foreach (KeyValuePair<string, string> element in keyValuePairs)
            {
                Console.WriteLine(element.Key + ":" + element.Value);
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Dictionary using for loop");
            for (int i = 0; i < keyValuePairs.Count; i++)
            {
                var item = keyValuePairs.ElementAt(i);
                Console.WriteLine(item.Value);
            }
        }
    }
}
