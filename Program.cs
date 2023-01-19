using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");

            int numRolls = Convert.ToInt32(Console.ReadLine());
            int[] rollResults = new int[13];
            Random r = new Random();

            for (int i = 0; i < numRolls; i++)
            {
                int firstDie = r.Next(1,7);
                int secondDie = r.Next(1, 7);
                int rollTotal = firstDie + secondDie;

                rollResults[rollTotal]++;
            }

            string output = "DICE ROLLING SIMULATION RESULTS \nEach \"*\" represents 1 % of the total number of rolls.\nTotal number of rolls = " + Convert.ToString(numRolls) + ".\n\n";
            

            for (int i = 2; i < 13; i++)
            {
                double pctRolled = ((double)rollResults[i] / numRolls) * 100;
                int stars = (int)Math.Round(pctRolled);
                string starOutput = "";
                for (int iCount = 0; iCount < stars; iCount++)
                {
                    starOutput += "*";
                }

                output += (Convert.ToString(i)) + ": " + starOutput + "\n";
                
            }
            output += "\nThank you for using the dice throwing simulator. Goodbye!";
            Console.WriteLine(output);

        }
    }
}
