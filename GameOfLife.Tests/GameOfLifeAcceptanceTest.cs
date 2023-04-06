using Bunit;
using GameOfLife.Frontend.Components;
using GameOfLife.Frontend.GameLogic;
using GameOfLife.Frontend.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace GameOfLife.Tests;

public class GameOfLifeAcceptanceTest
{
    [Fact]
    public void ICanSeeNextGenerationLayoutOnTheBoard()
    {
        var testContext = new TestContext();
        testContext.Services.AddScoped(provide => new GameEngine());

        var renderedComponent = testContext.RenderComponent<GameOfLifeBoard>();

        renderedComponent.Find("button").Click();
        
        var renderedLifeCells = renderedComponent.FindComponents<LiveCell>();
        Assert.Equal(4,renderedLifeCells.Count);
    }
}