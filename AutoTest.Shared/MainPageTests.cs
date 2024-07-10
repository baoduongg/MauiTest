using NUnit.Framework;

namespace AutoTest;

public class MainPageTests : BaseTest
{
    [Test]
    public void AppLaunches()
    {
        // bug https://github.com/appium/dotnet-client/issues/798 => downgrade to dotnet 7.0
        App.GetScreenshot().SaveAsFile($"{nameof(AppLaunches)}.png");
    }
    [Test]
    public void ClickCounterTest()
    {
        // Arrange
        // Find elements with the value of the AutomationId property
        var element = FindUIElement("CounterBtn");

        // Act
        element.Click();
        Task.Delay(500).Wait(); // Wait for the click to register and show up on the screenshot

        element.Click();
        Task.Delay(500).Wait(); // Wait for the click to register and show up on the screenshot

        element.Click();
        Task.Delay(500).Wait(); // Wait for the click to register and show up on the screenshot

        // element.Click();
        // Task.Delay(500).Wait(); // Wait for the click to register and show up on the screenshot
        // Assert
        App.GetScreenshot().SaveAsFile($"{nameof(ClickCounterTest)}.png");
        Assert.That(element.Text, Is.EqualTo("Clicked 3 times"));
    }
}