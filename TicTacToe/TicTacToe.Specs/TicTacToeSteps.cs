using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TicTacToe.Core;

namespace TicTacToe.Specs
{
    [Binding]
    public class TicTacToeSteps
    {
        private string[,] _board;
        private GameEngine _gameEngine;
        private string _result;
        private static readonly string TieIndicator = string.Empty;

        [BeforeScenario()]
        public void SetupTest()
        {
            _gameEngine = new GameEngine();
        }

        [Given(@"I have an empty Tic Tac Toe board")]
        public void GivenIHaveAnEmptyTicTacToeBoard()
        {
            _board = new string[3, 3]
            {
                {string.Empty, string.Empty, string.Empty}, 
                {string.Empty, string.Empty, string.Empty},
                {string.Empty, string.Empty, string.Empty}
            };
        }
        
        [When(@"I determine a winner")]
        public void WhenIDetermineAWinner()
        {
            _result = _gameEngine.GetWinner(_board);
        }
        
        [Then(@"the result should be a tie")]
        public void ThenTheResultShouldBeATie()
        {
            Assert.AreEqual(TieIndicator, _result);
        }

        [Given(@"I put an '(.*)' in the top left space")]
        public void GivenIPutAnInTheTopLeftSpace(string p0)
        {
            _board[0, 0] = p0;
        }

        [Given(@"I put an '(.*)' in the top middle space")]
        public void GivenIPutAnInTheTopMiddleSpace(string p0)
        {
            _board[0, 1] = p0;
        }

        [Given(@"I put an '(.*)' in the top right space")]
        public void GivenIPutAnInTheTopRightSpace(string p0)
        {
            _board[0, 2] = p0;
        }

        [Then(@"the result should be that '(.*)' wins")]
        public void ThenTheResultShouldBeThatWins(string p0)
        {
            Assert.AreEqual(p0, _result);
        }

        [Given(@"I put an '(.*)' in the middle left space")]
        public void GivenIPutAnInTheMiddleLeftSpace(string p0)
        {
            _board[1, 0] = p0;
        }

        [Given(@"I put an '(.*)' in the bottom left space")]
        public void GivenIPutAnInTheBottomLeftSpace(string p0)
        {
            _board[2, 0] = p0;
        }

        [Given(@"the board looks like this")]
        public void GivenTheBoardLooksLikeThis(Table table)
        {
            var rowIdx = 0;

            foreach (var row in table.Rows)
            {
                _board[rowIdx, 0] = row["col1"];
                _board[rowIdx, 1] = row["col2"];
                _board[rowIdx, 2] = row["col3"];

                rowIdx++;
            }
        }

    }
}
