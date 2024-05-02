using CMP1903_A1_2324;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_game_2_assesment
{
    internal class ThreeOrMore
    {
        Die[] Dice;
        private int totalScore;
        public ThreeOrMore()
        {
           Dice = new Die[5];
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                Dice[i] = new Die(random);
            }
            totalScore = 0;
        }
        private void DiceRoll()
        {
           foreach (var Die in Dice) 
           { 
             Die.Roll();
           }
           Array.Sort(Dice, (x,y) => x.DieValue.CompareTo(y.DieValue));

            int[] counts = new int[6];
            foreach(var Die in Dice)
            {
                counts[Die.DieValue - 1]++;
            }

            int maxCount = 0;
            foreach (int count in counts)
            {
                maxCount = Math.Max(maxCount, count);
            }
                int score = 0;
            if (maxCount >= 3)
            {
                if (maxCount == 3)
                {
                    score = 3;
                }
                else if (maxCount == 4)
                {
                    score = 6;
                }
                else if (maxCount == 5)
                {
                    score = 12;
                }
                totalScore += score;
                Console.WriteLine($"You rolled {maxCount} of a kind and earned {score} points");

            }
            else if( maxCount == 2) 
            {
                Console.WriteLine("you have rolled 2 of a kind and earned 0 point. you may choose to re-roll all the dice or the remaining 3. (all/remaining)");
                string playerChoice = Console.ReadLine().ToLower();

                if (playerChoice == "all")
                {
                    foreach (var Die in Dice)
                    {
                        Die.Roll();
                    }
                    Console.WriteLine("all Dice re-rolled");
                }
                else if (playerChoice == "remaining")
                {
                    for (int i = 0; i < Dice.Length; i++)
                    {
                        if (counts[Dice[i].DieValue - 1] < 2)
                        {
                            Dice[i].Roll();
                        }
                    }
                    Console.WriteLine("re-rolled 3 remainiing dice");
                }
            }
            
            
        }
        public void Play() 
        {
           while (totalScore < 20)
           {
              DiceRoll();
           }

           if (totalScore == 20)
           {
                Console.WriteLine("Congratulations you have won");
           }
        }
        public void ComputerPlay()
        {
            while (totalScore < 20)
            {
                DiceRoll();
            }

            if (totalScore == 20)
            {
                Console.WriteLine("the computer won");
            }
        }

    }
    
}
