using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author: Joanne (Hyunjung) Jung
 * Student # : 300432364
 * Date Modified: July 20th, 2016
 * Description: DiceRolling class for Assignment4
 * Version: 0.0.1 - Initial commit
 */
namespace DiceRolling
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random(); // random number object
            List<int> diceRolling = new List<int>(); // New List of Type int
            int[] tally = new int[13];
            int maxNumber = 36000;

            // Build the list to store random numbers of dices
            for (int i = 0; i < maxNumber; i++)
            {
                int firstDice = rand.Next(1, 7);
                int secondDice = rand.Next(1, 7);
                int totalValue = firstDice + secondDice;
                tally[totalValue]++;
                diceRolling.Add(totalValue);
            }
            Console.WriteLine("|------------------------|");
            Console.WriteLine("| Roll#  |Number of Rolls|");
            Console.WriteLine("|------------------------|");
            for (int i = 2; i < 13; i++)
            {
                Console.WriteLine("|{0,4}    |{1,10}     |", i, tally[i]);
                Console.WriteLine("|------------------------|");

            }
        }
    }
    }

