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
        var initialGeneration = new List<Cell> { new Cell(3, 3), new Cell(4, 3), new Cell(4, 4) };
        var expectedCells = new List<Cell> { new Cell(3,3), new Cell(4,3), new Cell(3,4), new Cell(4,4) };
        
        var secondGenerationLiveCells = gameEngine.NextGeneration(initialGeneration);
        
        Assert.Equal(expectedCells,secondGenerationLiveCells);
    }

    [Fact]
    public void GetNextGenerationWithJustOneCellAliveWillReturnAGenerationWithAllCellDead()
    {
        GameEngine gameEngine = new GameEngine();

        var expectedCells = Enumerable.Empty<Cell>();
        var currentGeneration = new List<Cell>{new Cell(1,1)};
        
        Assert.Equal(expectedCells,gameEngine.NextGeneration(currentGeneration));
    }
    
    
}   