using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproximationOfPi
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Here are the Pi approximation results for " +
                "running the simulation for 10, 100, 1000, and 10000 points." +
                " Press enter to run the program");

            int size = 0;
            Functions.RunSimulation(size);
            
            Functions.RunPresets();

            Console.ReadLine();



        }

       
    }
}
   