using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace XunitTests
{
    public class UnitTest1
    {

        [Fact]
        public void GameBoardTestsForWinners()
        {

            Player playerone = new Player("playerOneName", "O");
            Player playertwo = new Player("playerTwoName", "X");
            Game game = new Game(playerone, playertwo);
            game.Board.GameBoard = new string[,]
        {
            {"O", "2", "3"},
            {"O", "5", "6"},
            {"O", "8", "9"},
        };
            Board boardOne = new Board();
            bool test = game.CheckForWinner(boardOne);

            Assert.True(test);
        }

        [Fact]
        public void TestForSwitch()
        {
            Player playerone = new Player("playerOneName", "O");
            Player playertwo = new Player("playerTwoName", "X");
            Game game = new Game(playerone, playertwo);
            game.Board.GameBoard = new string[,]
        {
            {"O", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };
            Player test2 = game.NextPlayer();
            Board boardOne = new Board();
            Assert.Equal(playertwo, test2);
        }
        [Fact]
        public void ComfirmPlayerInputDisplaysOnBoard()
        {
            Player playerone = new Player("playerOneName", "O");
            Player playertwo = new Player("playerTwoName", "X");
            Game game = new Game(playerone, playertwo);
            game.Board.GameBoard = new string[,]
        {
            {"O", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };
            Position testPosition = new Position(0, 0);

            Assert.Equal(testPosition.Column, Player.PositionForNumber(1).Column);
            Assert.Equal(testPosition.Row, Player.PositionForNumber(1).Row);

        }

        [Fact]
        public void GameBoardTestsForDraw()
        {

            Player playerone = new Player("playerOneName", "O");
            Player playertwo = new Player("playerTwoName", "X");
            Game game = new Game(playerone, playertwo);
            game.Board.GameBoard = new string[,]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };
            Board boardOne = new Board();
            bool test = game.CheckForWinner(boardOne);

            Assert.False(test);
        }
    }


    }
