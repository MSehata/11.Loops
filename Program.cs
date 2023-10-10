using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;

            Console.WriteLine("While Loop.");

            while (index <+ 5) 
            {
                Console.WriteLine(index);
                index ++;
            }

            Console.WriteLine("Do Loop. ");
            int secondIndex = 0;

            do
            {                
                Console.WriteLine(secondIndex);
                secondIndex++;
            } 
            while (secondIndex <= 5);


            Console.WriteLine("For Loop.");

            for (int i = 0; i <= 5; i++) 
            { 
                Console.Write(i + ", ");
            }

            Console.ReadKey();

        }
    }
}
