using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamarinUITestProject
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);            

        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            //app.Repl();
           
            AppResult[] results = app.WaitForElement(x => x.Text("Hello World!"));
            app.Screenshot("Welcome screen.");
            Assert.IsTrue(results.Any());
        }

        [Test]
        public void TouchTest()
        {
            //app.Repl();
            AppResult[] results = app.WaitForElement(x => x.Id("points"));

            Assert.IsTrue(results[0].Text.Equals("0"));

            app.Tap(x => x.Id("touchStr"));

            results = app.WaitForElement(x => x.Id("points"));

            Assert.IsTrue(results[0].Text.Equals("1"));
          
        }

    }
}
