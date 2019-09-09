using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpprograms
{
    class Program
    {
        static void Display(IEnumerable<int> values)
        {
            // This method can be used with arrays or Lists.
            foreach (int value in values)
            {
                Console.WriteLine("IENUMERABLE: " + value);
            }
        }

        static void Main()
        {
            int[] ids = { 10400, 20800, 40100 };
            // Pass the int array to the Display method, which accepts it as an IEnumerable.
            Display(ids);
        }
    }
}
