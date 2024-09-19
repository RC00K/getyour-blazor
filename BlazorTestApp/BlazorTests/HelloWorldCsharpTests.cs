using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlazorTestApp.Components.Pages;

namespace BlazorTests
{
    [TestClass]
    public class HelloWorldCsharpTests
    {
        private Bunit.TestContext _testContext = null!;

        [TestInitialize]
        public void Setup()
        {
            _testContext = new Bunit.TestContext();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _testContext.Dispose();
        }

        [TestMethod]
        public void HelloWorldComponentRendersCorrectly()
        {
            // Act
            var cut = _testContext.RenderComponent<HelloWorld>();
            
            // Assert
            cut.MarkupMatches("<h1>Hello world from Blazor</h1>");
        }
    }
}