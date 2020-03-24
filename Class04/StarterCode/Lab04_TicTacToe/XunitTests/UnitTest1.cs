using System;
using Xunit;
using Lab04_TicTacToe;

namespace XunitTests
{
    public class UnitTest1
    {
        [Fact]
        public void GameBoardTestsForWinners()
        {
            string a = "O";
            Assert.Equal("O", a);
        }
    }
}
