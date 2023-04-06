using GameOfLife.Frontend.GameLogic;

namespace GameOfLife.Tests;

public class GameEngineTest
{
    [Fact]
    public void AssertGivenTheSIzeOfBoardWeGetListOfLiveCells()
    {
        GameEngine gameEngine = new GameEngine();
        var expectedCells = new List<Cell> { new Cell(), new Cell() };
        var liveCells = gameEngine.GetFirstGeneration();
        
        Assert.Equal(expectedCells,liveCells);
    }
}