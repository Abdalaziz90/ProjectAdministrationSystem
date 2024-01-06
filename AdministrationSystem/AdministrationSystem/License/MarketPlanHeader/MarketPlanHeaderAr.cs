using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationSystem.AdministrationSystem.SystemHierarchy.MarketPlanHeaderAr
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Market Plan Header Page")]
    [AllureFeature("License Page")]
    [AllureEpic("Administration System features")]
    public class TestsMarketPlanHeaderArPage
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://app.abuhelwafamily.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        [AllureStory("Card title in the page")]
        [AllureStep("Card Title in the page")]
        public void MarketPlanHeaderPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // SignUp >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"form3Example3\"]")));
            driver.FindElement(By.XPath("//input[@id='form3Example3']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@id='form3Example4']")).SendKeys("123456");
            driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-lg']")).Click();

            // Language >>
            Thread.Sleep(30000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/nav/div/ul[2]/li[3]/a")));
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/nav/div/ul[2]/li[3]/a")).Click();
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/nav/div/ul[2]/li[3]/div/a")).Click();

            // Click on Administration sytem and License >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/a")));
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[9]/li/a")).Click();


            // Market Plan Header >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[9]/li/ul[5]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[9]/li/ul[5]/li/a")).Click();

            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("btn")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("btn")).Click();
            Thread.Sleep(5000);

            // Plan Category
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement PlanCategory = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            PlanCategory.Click();

            String[] PlanCategoryText = { "أساسي", "متقدمه", "وكيل", "متميز" };

            if (PlanCategoryText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, PlanCategoryText.Length);
                Console.WriteLine(PlanCategoryText[randNumber]);
                PlanCategory.SendKeys(PlanCategoryText[randNumber] + Keys.Enter);
            }

            // Arabic Name
            driver.FindElement(By.Id("ARNAME")).SendKeys("ينن");
            driver.FindElement(By.Id("ENNAME")).SendKeys("dksa");
            driver.FindElement(By.Id("DESCRIPTION")).SendKeys("dslasd");
            driver.FindElement(By.Id("REQUIREDCOMPANIESNUM")).SendKeys("10");
            driver.FindElement(By.Id("REQUIREDBRANCHESNUM")).SendKeys("13");
            driver.FindElement(By.Id("REQUIREDGALLERIESNUM")).SendKeys("5");

            // Types Of User
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement TypeOfUser = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            TypeOfUser.Click();

            String[] TypeOfUserText = { "عدد المستخدمين", "عدد المستخدمين الفعالين على النظام", "عدد غير محدد من المستخدمين" };

            if (TypeOfUserText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, TypeOfUserText.Length);
                Console.WriteLine(TypeOfUserText[randNumber]);
                TypeOfUser.SendKeys(TypeOfUserText[randNumber] + Keys.Enter);
            }

            Thread.Sleep(7000);
            if (TypeOfUserText[0] == "عدد المستخدمين")
            {
                driver.FindElement(By.Id("NUMBEROFUSERS")).SendKeys("23");
                Thread.Sleep(7000);
            }

            Thread.Sleep(7000);
            if (TypeOfUserText[1] == "عدد المستخدمين الفعالين على النظام")
            {
                driver.FindElement(By.Id("NUMBEROFUSERS")).SendKeys("17");
                Thread.Sleep(7000);
            }

            Thread.Sleep(7000);
            // Free Duration
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement FreeDuration = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            FreeDuration.Click();

            String[] FreeDurationText = { "شهر", "3 أشهر", "6 أشهر", "12 شهر", "24 شهر", "36 شهر" };

            if (FreeDurationText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, FreeDurationText.Length);
                Console.WriteLine(FreeDurationText[randNumber]);
                FreeDuration.SendKeys(FreeDurationText[randNumber] + Keys.Enter);
            }

            // Required Duration  
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement RequiredDuration = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            RequiredDuration.Click();

            String[] RequiredDurationText = { "شهر", "3 أشهر", "6 أشهر", "12 شهر", "24 شهر", "36 شهر" };

            if (RequiredDurationText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, RequiredDurationText.Length);
                Console.WriteLine(RequiredDurationText[randNumber]);
                RequiredDuration.SendKeys(RequiredDurationText[randNumber] + Keys.Enter);
            }

            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")).Click();

            // Edit >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit")));
            driver.FindElement(By.Id("edit")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("ENNAME")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("ENNAME")).Clear();
            driver.FindElement(By.Id("ENNAME")).SendKeys("system module");
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(text(),'تعديل')]")));
            driver.FindElement(By.XPath("//button[contains(text(),'تعديل')]")).Click();
            Thread.Sleep(7000);

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("post")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);


            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("unpost")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("post")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);


            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("del")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);


            // Edit >>
            driver.FindElement(By.Id("edit")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("DESCRIPTION")).Clear();
            driver.FindElement(By.Id("DESCRIPTION")).SendKeys("deiovoso osdosp");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[contains(text(),'تعديل')]")).Click();
            Thread.Sleep(5000);

            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("unpost")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();


            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("del")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();

            // Search Input >>
            Thread.Sleep(5000);
            driver.FindElement(By.Id("Grid_ToolbarSearchBox")).SendKeys("test" + Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_search\"]/div/span/span[1]")).Click();

            // Sorting from lowest to highest
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[4]/div[1]")).Click();

            // Filters Selected
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[5]/div[3]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"Gridstring_CheckBoxList\"]/div[2]")).Click();
            driver.FindElement(By.XPath("//*[@id=\"Gridstring_CheckBoxList\"]/div[3]")).Click();
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();

            // Clear filter >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[5]/div[3]")).Click();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//li[@aria-label='مرشح واضح']")).Click();

            // Excel Export >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_excelexport\"]/button")).Click();

            // CSV Export >>
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_csvexport\"]/button")).Click();

            // PDF Export >>
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_pdfexport\"]/button")).Click();

            // Print >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_print\"]/button")).Click();

            string currentHandleRe = driver.CurrentWindowHandle;
            foreach (string handleRe in driver.WindowHandles)
            {
                if (!handleRe.Equals(currentHandleRe))
                {
                    Thread.Sleep(5000);
                    driver.SwitchTo().Window(handleRe).Close();
                }
            }

            driver.SwitchTo().Window(currentHandleRe);

            // Fav >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[2]/div[3]/button[1]")));
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[2]/div[3]/button[1]")).Click();

            string cardTitleText = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[1]/h4")).Text;

            Assert.Multiple(() =>
            {
                Assert.That(cardTitleText, Is.EqualTo("خطة التسويق"));
            });

            Assert.Pass();

        }
    }
}
