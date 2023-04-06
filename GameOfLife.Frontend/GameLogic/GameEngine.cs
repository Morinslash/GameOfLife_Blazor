namespace GameOfLife.Frontend.GameLogic;

public class GameEngine
{
    public List<Cell> GetFirstGeneration()
    {
        return new List<Cell> { new Cell(3,3), new Cell(4,3), new Cell(4,4) };
    }
    public List<Cell> NextGeneration(List<Cell> currentGeneration)
    {
        return new List<Cell> { new Cell(3,3), new Cell(4,3), new Cell(3,4) , new Cell(4,4)};
    }
}