using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PlayerName();
        }
          
    public static void PlayerName()
    {
       Console.WriteLine("Please Enter Your Name");
       string playerOneName = Console.ReadLine();
       Console.WriteLine("Please Enter The Second Players Name");
       string playerTwoName = Console.ReadLine();
        Player playerone = new Player(playerOneName, "O");
        Player playertwo = new Player(playerTwoName, "X");
        Game game = new Game(playerone, playertwo);
            game.Play();
    }
        
    }

        // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
        // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
   
}
