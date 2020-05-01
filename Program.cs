using System;

namespace BSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare array with 10 elements
            int[] a = new int[11];

            // Ask for how many elements to fill with data            
            Console.WriteLine("How many elements? (2-10)");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++) 
            {
                // Fill elements
                Console.WriteLine("Enter element value");
                int v = Convert.ToInt32(Console.ReadLine());
                a[i] = v;
            }

            // Get length of array
            int l = a.Length;

            // Print array to screen
            for (int i = 0; i < l; i++) 
            {
                if(a[i] != 0)
                Console.WriteLine(a[i] + " ");
            }

            // Sort
            int temp;
            for (int p = 0; p < l; p++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        //temp1 = a[i];
                        //temp2 = a[i + 1];
                        //a[i] = temp2;
                        //a[i + 1] = temp1;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                    }
                }
            }
            // Print array to screen
            Console.WriteLine();            
            for (int i = 0; i < l; i++)
            {
                if (a[i] != 0)
                    Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
