using Bunit;
using GameOfLife.Frontend.Pages;

namespace GameOfLife.Tests;

public class GameOfLifeAcceptanceTest
{
    [Fact]
    public void ICanSeeNextGenerationLayoutOnTheBoard()
    {
        var testContext = new TestContext();

        var renderedComponent = testContext.RenderComponent<GameOfLifeBoard>();

        renderedComponent.Find("button").Click();

        var renderedLifeCells = renderedComponent.FindComponents<LifeCell>();
        Assert.Equal(4,renderedLifeCells.Count);
    }
}