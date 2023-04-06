namespace GameOfLife.Frontend.GameLogic;

public record Cell(int X, int Y)
{
    public int X { get; init; } = X;
    public int Y { get; init; } = Y;
}