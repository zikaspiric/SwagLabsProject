using SwagProject.Driver;
using SwagProject.Page;

namespace SwagProject.Tests
{
    public class Tests
    {
        LoginPage loginPage;
        ProductPage productPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
        }
        [TearDown]
        public void ClosePage()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_AddTwoProductInCard_ShouldDisplayedToProducts()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddBackPack.Click();
            productPage.AddT_Short.Click();

            Assert.That("2", Is.EqualTo(productPage.Cart.Text));

        }
    }
}