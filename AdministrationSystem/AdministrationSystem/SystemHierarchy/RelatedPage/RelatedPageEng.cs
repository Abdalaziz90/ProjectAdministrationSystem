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

namespace AdministrationSystem.AdministrationSystem.SystemHierarchy.RelatedPageEng
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Related Page Page")]
    [AllureFeature("System Hieracrchy Page")]
    [AllureEpic("Administration System features")]
    public class TestsRelatedPageEngPage
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
        public void RelatedpaePage()
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

            // Click on Administration sytem and SystemHierarchy >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/a")));
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[2]/li/a")).Click();


            // Related Page >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[2]/li/ul[5]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[2]/li/ul[5]/li/a")).Click();

            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("btn")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("btn")).Click();
            Thread.Sleep(5000);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement ParentPage = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            ParentPage.Click();

            String[] ParentPageText = { "User", "Role", "Archiving Tree", "Form", "Page Security", "User Role", "Setting Tender", "OfferingTenderItem", "InvoicePayment", "Fine Of Installation", "HCourse Payment Voucher", "MainGrant", "Contract Information", "Evalution Item", "Related Item", "Node Mapping", "First Duration Goods" };

            if (ParentPageText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, ParentPageText.Length);
                Console.WriteLine(ParentPageText[randNumber]);
                ParentPage.SendKeys(ParentPageText[randNumber] + Keys.Enter);
            }

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement RelatedPage = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            RelatedPage.Click();

            String[] RelatedPageText = { "User", "Role", "Archiving Tree", "Form", "Page Security", "User Role", "Setting Tender", "OfferingTenderItem", "InvoicePayment", "Fine Of Installation", "HCourse Payment Voucher", "MainGrant", "Contract Information", "Evalution Item", "Related Item", "Node Mapping", "First Duration Goods" };

            if (RelatedPageText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, RelatedPageText.Length);
                Console.WriteLine(RelatedPageText[randNumber]);
                RelatedPage.SendKeys(RelatedPageText[randNumber] + Keys.Enter);
            }

            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='CANCEL']")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='CANCEL']")).Click();

            // Edit >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit")));
            driver.FindElement(By.Id("edit")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement RelatedPage1 = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            RelatedPage1.Click();

            String[] RelatedPageText1 = { "User", "Role", "Archiving Tree", "Form", "Page Security", "User Role", "Setting Tender", "OfferingTenderItem", "InvoicePayment", "Fine Of Installation", "HCourse Payment Voucher", "MainGrant", "Contract Information", "Evalution Item", "Related Item", "Node Mapping", "First Duration Goods" };

            if (RelatedPageText1.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, RelatedPageText1.Length);
                Console.WriteLine(RelatedPageText1[randNumber]);
                RelatedPage1.SendKeys(RelatedPageText1[randNumber] + Keys.Enter);
            }
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='EDIT']")));
            driver.FindElement(By.XPath("//button[normalize-space()='EDIT']")).Click();
            Thread.Sleep(7000);

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("post")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
            Thread.Sleep(5000);


            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("unpost")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
            Thread.Sleep(5000);

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("post")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
            Thread.Sleep(5000);


            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("del")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
            Thread.Sleep(5000);


            // Edit >>
            driver.FindElement(By.Id("edit")).Click();
            Thread.Sleep(3000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement ParentPage1 = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            ParentPage1.Click();

            String[] ParentPageText1 = { "User", "Role", "Archiving Tree", "Form", "Page Security", "User Role", "Setting Tender", "OfferingTenderItem", "InvoicePayment", "Fine Of Installation", "HCourse Payment Voucher", "MainGrant", "Contract Information", "Evalution Item", "Related Item", "Node Mapping", "First Duration Goods" };

            if (ParentPageText1.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, ParentPageText1.Length);
                Console.WriteLine(ParentPageText1[randNumber]);
                ParentPage1.SendKeys(ParentPageText1[randNumber] + Keys.Enter);
            }
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[normalize-space()='EDIT']")).Click();
            Thread.Sleep(5000);

            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("unpost")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();


            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("del")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();

            // Search Input >>
            Thread.Sleep(5000);
            driver.FindElement(By.Id("Grid_ToolbarSearchBox")).SendKeys("Item" + Keys.Enter);
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
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();

            // Clear filter >>
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_header_table\"]/thead/tr/th[5]/div[3]")).Click();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//li[@aria-label='Clear Filter']")).Click();

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


            string cardTitleText = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[1]/h4")).Text;

            Assert.Multiple(() =>
            {
                Assert.That(cardTitleText, Is.EqualTo("Related Page"));
            });

            Assert.Pass();

        }
    }
}
