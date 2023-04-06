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
        var expectedLifeCellIds = new List<string>() { "3_3", "3_4", "4_3", "4_4" };

        var testContext = new TestContext();
        testContext.Services.AddScoped(provide => new GameEngine());

        var renderedComponent = testContext.RenderComponent<GameOfLifeBoard>();

        renderedComponent.Find("button").Click();

        var renderedLifeCells = renderedComponent.FindComponents<LiveCell>();
        Assert.Equal(4, renderedLifeCells.Count);

        var lifeCellsId = renderedLifeCells.Select(cell => cell.Find("td").Id).ToList();
        var containsExpectedIds = expectedLifeCellIds.All(e => lifeCellsId.Contains(e));
        Assert.True(containsExpectedIds);
    }
}