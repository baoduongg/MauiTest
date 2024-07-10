using NUnit.Framework;

namespace AutoTest;

public class PlatformSpecificSampleTest : BaseTest
{
    [Test]
    public void SampleTest()
    {
        App.GetScreenshot().SaveAsFile($"{nameof(SampleTest)}.png");
    }
}