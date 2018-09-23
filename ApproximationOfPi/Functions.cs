using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproximationOfPi
{

    // process 2.

    class Functions
    {
        public static double ProvideHypotenus(Coordinates coordinates)
        {
            return Math.Sqrt(Math.Pow(coordinates.getX(), 2)
                + Math.Pow(coordinates.getY(), 2));
        }




        // process 3

        public static Coordinates[] GenerateCoordinates(int len)
        {
            Random rnd = new Random();
            Coordinates[] array = new Coordinates[len];
            for (int i = 0; i < len; i++)
            {
                double x = rnd.NextDouble();
                double y = rnd.NextDouble();
                array[i] = new Coordinates(x, y);
            }
            return array;
        }

       
        // process 4.


        public static int GenerateCounter(Coordinates[] array)
        {
            int counter = 0;
            int size = array.Length;

            for (int i = 0; i < size; i++)
            {
                if (ProvideHypotenus(array[i]) <= 1)
                {
                    counter++;
                }
            }
            return counter;



        }

        // process 5. 


        public static double ProvideRatio(int counter, int size)
        {

            return 4 * (double)counter / size;
        }


        // process 6.
        public static void PrintResults(int counter, double ratio)

        {
            Console.WriteLine($" Number of overlaps: {counter}");

            Console.WriteLine($" Pi Approximation:  {ratio}");

            Console.WriteLine($" Difference from the actual value of Pi: {Math.Abs(Math.PI - ratio)}");
        }

        // process 7

        public static void RunSimulation(int size)
        {
            Coordinates[] array = Functions.GenerateCoordinates(size);
            int counter = Functions.GenerateCounter(array);
            double ratio = Functions.ProvideRatio(counter, size);
            Functions.PrintResults(counter, ratio);



        }

        public static void RunPresets()

        {
            int[] runs = { 10, 100, 1000, 10000 };
            Console.Clear();
            Console.WriteLine("\nHere are the Pi approximation results for running the simulation for 10, 100, 1000, and 10000 points.");

            

        }
    }
}