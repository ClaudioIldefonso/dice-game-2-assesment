using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace dice_game_2_assesment
{
    internal class SevensOut
    {
        private Die[] dice;
        public SevensOut()
        {
            dice = new Die[2];
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                dice[i] = new Die(random);
            }

        }
        public int RollTotalAddUp()
        {
            int sum = 0;
            foreach (Die die in dice)
            {
                sum += die.Roll();
            }
            if (dice[0].DieValue == dice[1].DieValue)
            {
                sum *= 2;
            }
            return sum;
        }

        public void Play()
        {
            int total = 0;
            
            while (true)
            {
                int roll = RollTotalAddUp(); // Roll the dice
                total += roll; // Add the current roll to the total
                Console.WriteLine($"You rolled a {roll} added to the total which is {total}");

                Console.Write("You rolled: ");
                foreach (var die in dice)
                {
                    Console.Write(die.DieValue + " ");
                }
                Console.WriteLine();

                if (roll == 7)
                {
                    //stop rolling
                    Console.WriteLine($" Adding 7 to your total. but you cna no longer roll");
                    break;
                }

                Console.WriteLine("Roll again? (yes/no)");
                string choice = Console.ReadLine().ToLower();

                if (choice != "yes")
                {
                    break; // Exit the loop if the player doesn't want to roll again
                }
            }

            
                Console.WriteLine($"Your final total is {total}");


        }
        public void ComputerPlay()
        {
            int computerTotal = 0;
            Console.WriteLine("computers turn");
            while (true)
            {
                int roll = RollTotalAddUp();
                computerTotal += roll;

                // Print out the value of each die for the computer
                Console.Write("Computer rolled: ");
                foreach (var die in dice)
                {
                    Console.Write(die.DieValue + " ");
                }
                Console.WriteLine($"Computer rolled a {roll}and added to the total making it {computerTotal}");

                if (roll == 7)
                {
                    Console.WriteLine($"computer rolled a 7 its been added to the total to makee it {computerTotal}. it has finished its turn.");
                    break;
                }
                Console.WriteLine($"computers final total is {computerTotal}.");
            }

        }



    }

    
}
