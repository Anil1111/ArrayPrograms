using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

   class Program
    {
        static ref int FirstElement(int[] array)
        {
            // Return ref to first element in array.
            return ref array[0];
        }

        static void Main()
        {
            int[] codes = { 10, 20, 30 };

            // Change first element to a new value.
            FirstElement(codes) = 60;

            // Display modified array.
            for (int i = 0; i < codes.Length; i++)
            {
                System.Console.WriteLine(codes[i]);
            }
        }
    }

