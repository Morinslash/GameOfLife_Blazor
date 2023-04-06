using GameOfLife.Frontend.GameLogic;

namespace GameOfLife.Tests;

public class GameEngineTest
{
    [Fact]
    public void GetInitialStateOfTheBoardReturnsListOfLiveCells()
    {
        GameEngine gameEngine = new GameEngine();
        var expectedCells = new List<Cell> { new Cell(3,3), new Cell(4,3), new Cell(4,4) };
        var liveCells = gameEngine.GetFirstGeneration();

        Assert.Equal(expectedCells, liveCells);
    }
    
    [Fact]
    public void GetNextGenerationReturnsNewListOfLiveCells()
    {
        GameEngine gameEngine = new GameEngine();
        
        var expectedCells = new List<Cell> { new Cell(3,3), new Cell(4,3), new Cell(3,4), new Cell(4,4) };
        var secondGenerationLiveCells = gameEngine.NextGeneration();
        
        Assert.Equal(expectedCells,secondGenerationLiveCells);
    }
    
    
}   