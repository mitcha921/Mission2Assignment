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
        {   //Intro/prompt
            Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");

            //initialize array and collect number of rolls
            int numRolls = Convert.ToInt32(Console.ReadLine());
            int[] rollResults = new int[13];
            Random r = new Random();

            //Roll Dice and increment array based on total
            for (int i = 0; i < numRolls; i++)
            {
                int firstDie = r.Next(1,7);
                int secondDie = r.Next(1, 7);
                int rollTotal = firstDie + secondDie;

                rollResults[rollTotal]++;
            }
            //Begin output
            string output = "DICE ROLLING SIMULATION RESULTS \nEach \"*\" represents 1 % of the total number of rolls.\nTotal number of rolls = " + Convert.ToString(numRolls) + ".\n\n";
            
            //Make output based on totals of each number rolled
            for (int i = 2; i < 13; i++)
            {
                double pctRolled = ((double)rollResults[i] / numRolls) * 100;
                int stars = (int)Math.Round(pctRolled);
                string starOutput = "";
                //Sets number of * for each number rolled

                for (int iCount = 0; iCount < stars; iCount++)
                {
                    starOutput += "*";
                }

                output += (Convert.ToString(i)) + ": " + starOutput + "\n";
                
            }

            //Final output
            output += "\nThank you for using the dice throwing simulator. Goodbye!";
            Console.WriteLine(output);

        }
    }
}
