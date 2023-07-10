using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Demo
{
    public class ArrayList_Demo
    {
        public void ArrayList_Prog()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Satya");
            arrayList.Add(1.5);
            arrayList.Add(89.1f);
            arrayList.Add('f');
            Console.WriteLine("ArrayList using foreach loop");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("ArrayList using for loop");

            for (var i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
