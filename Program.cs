using System;

namespace SRossGCDeliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double slicesPerLoaf = 28d;
            const double tblsPerPeanutButterJar = 32d;
            const double tspsPerJellyJar = 48d;

            int numPeople;
            double PeanutButterNeeded;
            double JellyNeeded;
            double breadNeeded;

            int breadSlices;
            int tblsPeanutButter;
            int tspsJelly;

            bool restart = true;

            do
            {
                Console.Write("Please Enter Number of People: ");
                string input = Console.ReadLine();
                bool isValidInt = int.TryParse(input, out numPeople);

                if (isValidInt && numPeople >= 0)
                {
                    breadSlices = numPeople * 2;
                    tblsPeanutButter = numPeople * 2;
                    tspsJelly = numPeople * 4;

                    breadNeeded = Math.Ceiling(breadSlices / slicesPerLoaf);

                    PeanutButterNeeded = Math.Ceiling(tblsPeanutButter / tblsPerPeanutButterJar);

                    JellyNeeded = Math.Ceiling(tspsJelly / tspsPerJellyJar);

                    Console.WriteLine("You need:");
                    Console.WriteLine(Convert.ToInt32(breadSlices) + " slices of bread");
                    Console.WriteLine(tblsPeanutButter + " tablespoons of peanut butter");
                    Console.WriteLine(tspsJelly + " teaspoons of jelly");
                    Console.WriteLine();

                    Console.WriteLine(" which is ...");
                    Console.WriteLine(breadNeeded + " loaves of bread");
                    Console.WriteLine(PeanutButterNeeded + " jars of peanut butter");
                    Console.WriteLine(JellyNeeded + " jars of jelly");
                    Console.WriteLine();

                    Console.WriteLine("Would you like to restart ? Enter yes or y to continue, or enter any other key to exit. ");
                    var restartResponse = Console.ReadLine();

                    if(restartResponse.ToLower() == "y" || restartResponse.ToLower() == "yes")
                    {
                        restart = true;
                    }
                    else
                    {
                        restart = false;
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write(input + " is not a valid entry. Would you like to try again? Enter yes or y to continue, or enter any other key to exit. ");
                    var restartResponse = Console.ReadLine();

                    if (restartResponse.ToLower() == "y" || restartResponse.ToLower() == "yes")
                    {
                        restart = true;
                    }
                    else
                    {
                        restart = false;
                        Console.WriteLine("Goodbye!");
                        Console.ReadLine();
                    }                   
                }
            } while (restart == true);    
        }
    }
}