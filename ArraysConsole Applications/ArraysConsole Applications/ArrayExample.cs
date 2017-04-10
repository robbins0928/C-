using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConsole_Applications
{
    class ArrayExample
    {
        
        public int[] endArray = new int[100];
        public int[] endArray2 = new int[100];
        public int[,] square = new int[2, 2] { {0, 1}, {0, 1} };

        
        public void ArrayToEnd()
        {
            for (int x = 0; x<100; x++)
            {
                endArray[x] = x;
                Console.WriteLine("For + 1: " + endArray[x].ToString());
            }
        }
        public void ArrayToEndForEach()
        {
            foreach(int number in endArray)
            {
                endArray2[number] = endArray[number] * 2;
                Console.WriteLine( "For Each * 2: " + endArray2[number].ToString());
            }
        }
        //***************************************************************Binary Search***************************************************************//
        
        public void binaryArray()
        {
            string highest;

            StringBuilder s = new StringBuilder();
            //string format
            string xx = String.Format("Text {0}", "x");

            string[] array1 = new String[] { "i", "a", "e", "m", "n", "x", "z" };
            char[] array2 = { 'i', 'a', 'e', 'm', 'n', 'x', 'z' };
            for (int x = 0; x < array2.Count() -1; x++)
            {
                if(array2[x] > array2[x + 1])
                {
                    highest = array2[x].ToString();
                    //Console.WriteLine(highest);
                }
                
            }


            Array.Sort(array1, StringComparer.InvariantCulture);
            int index1 = Array.BinarySearch(array1, "i");

            foreach(string str in array1)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine(index1);
        }

    }
}
