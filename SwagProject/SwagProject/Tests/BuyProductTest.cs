using SwagProject.Driver;
using SwagProject.Page;

namespace SwagProject.Tests
{
    public class Tests
    {
        LoginPage loginPage;
        ProductPage productPage;
        CartPage cartPage;


        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cartPage = new CartPage();


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

        [Test]
        public void TC02_SortByProductPrice_ShouldSortSortByHighPrice()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.SelectOption("Price (high to low)");

            Assert.That(productPage.SortByHighPrice.Displayed);
        }

        [Test]
        public void TC03_GoToAboutPage_ShouldRedactionToNewPage()
        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.MenuClick.Click();
            productPage.AboutClick.Click();
            Assert.That("https://saucelabs.com/", Is.EqualTo(WebDrivers.Instance.Url));
        }

        [Test]

        public void TC04_BuyProduct_ShouldBeFinichedShooping()

        {
            loginPage.Login("standard_user", "secret_sauce");
            productPage.AddBackPack.Click();
            productPage.AddT_Short.Click();
            productPage.ShopCartClick.Click();

            cartPage.Checkout.Click();
            cartPage.FirstName.SendKeys("zika");
            cartPage.LastName.SendKeys("spiric");
            cartPage.ZipCode.SendKeys("1234");
            cartPage.ButtonContinue.Submit();

            cartPage.Finish.Click();
            Assert.That("THANK YOU FOR YOUR ORDER", Is.EqualTo(cartPage.OrderFinished.Text));
        }
    }
}