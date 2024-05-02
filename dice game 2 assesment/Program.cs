using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice_game_2_assesment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome the my Dice Game.");

            Console.WriteLine("choose your game.");
            Console.WriteLine("1. ThreeOrMore");
            Console.WriteLine("2. SevensOut");
            int PickedGame = int.Parse(Console.ReadLine());

            switch (PickedGame) 
            {
                case 1:
                    PlayGame(new ThreeOrMore());
                    break;
                case 2:
                   PlayGame(new SevensOut()); 
                    break;
                default:
                    Console.WriteLine("Invalid input. Closing Game");
                    break;
            }
            Console.WriteLine("thank you for playing");
        }

        static void PlayGame(object game)
        {
            Console.WriteLine($"game {game.GetType().Name}has been choosen");

            Console.WriteLine("Choose:");
            Console.WriteLine("1. PvP");
            Console.WriteLine("2. PvE");

            int GameMode = int.Parse(Console.ReadLine());   
            switch (GameMode)
            {
                case 1:
                    PlayPvP((dynamic)game);
                    break;
                case 2:
                    PlayPvE((dynamic)game);
                break;
                default:
                    Console.WriteLine("invalid choice closing game");
                break;
            }
        }
        static void PlayPvP(dynamic game)
        {
            Console.WriteLine("enter player 1 name: ");
            string Player1 = Console.ReadLine();
            Console.WriteLine("enter player 2 name: ");
            string Player2 = Console.ReadLine();

            dynamic player1 = game;
            dynamic player2 = game;

            Console.WriteLine($"{Player1}'s turn");
            player1.Play();

            Console.WriteLine($"{Player2}'s turn");
            player2.Play();
        }
        static void PlayPvE(dynamic game)
        {
            Console.WriteLine("enter Name:");
            string name = Console.ReadLine();  
            
            dynamic player = game;
            dynamic computer = game;

            Console.WriteLine($"{name}'s turn");
            player.Play();
            Console.WriteLine("computers turn");
            computer.ComputerPlay();

        }
    }
}
