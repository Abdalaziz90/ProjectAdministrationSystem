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

namespace AdministrationSystem.AdministrationSystem.SystemHierarchy.PageCategoryAr
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Page Category Page")]
    [AllureFeature("System Hieracrchy Page")]
    [AllureEpic("Administration System features")]
    public class TestsPageCategoryArPage
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
        public void PageCategoeyPage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));

            // SignUp >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"form3Example3\"]")));
            driver.FindElement(By.XPath("//input[@id='form3Example3']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@id='form3Example4']")).SendKeys("123456");
            driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-lg']")).Click();

            // Click on Administration sytem and SystemHierarchy >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/a")));
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[2]/li/a")).Click();


            // Page Category >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[2]/li/ul[6]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[2]/li/ul[6]/li/a")).Click();

            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("btn")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("btn")).Click();
            Thread.Sleep(5000);

            //Date >>
            IWebElement TransDate = driver.FindElement(By.Id("TRANSDATE"));
            TransDate.Clear();
            TransDate.Clear();
            TransDate.SendKeys("١١/١١/٢٠٢٣");

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement CATEGORYOFPAGE = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            CATEGORYOFPAGE.Click();

            String[] CATEGORYOFPAGEText = { "SELECT", "SIMPLE", "Medium", "COMPLEX", "Ver Complex" };

            if (CATEGORYOFPAGEText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, CATEGORYOFPAGEText.Length);
                Console.WriteLine(CATEGORYOFPAGEText[randNumber]);
                CATEGORYOFPAGE.SendKeys(CATEGORYOFPAGEText[randNumber] + Keys.Enter);
            }

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement ClassSelect = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            ClassSelect.Click();

            String[] ClassSelectText = { "ADMINISTRATION", "PM", "QA", "DEVELOPMENT", "ANALYSIS", "TRAINING", "DOCUMENTATION" };

            if (ClassSelectText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, ClassSelectText.Length);
                Console.WriteLine(ClassSelectText[randNumber]);
                ClassSelect.SendKeys(ClassSelectText[randNumber] + Keys.Enter);
            }

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement PositionSel = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            PositionSel.Click();

            String[] PositionSelText = { "Chairman", "Member of the Board of Directors", "Administration Manager", "QA Team Leader", "Full Stack", "Front End Developer", "Backend Developer", "Mobile Developer", "QA + QC" };

            if (PositionSelText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, PositionSelText.Length);
                Console.WriteLine(PositionSelText[randNumber]);
                PositionSel.SendKeys(PositionSelText[randNumber] + Keys.Enter);
            }

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement PositionLevel = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            PositionLevel.Click();

            String[] PositionLevelText = { "مبتدئ", "متوسط", "خبير", "محترف" };

            if (PositionLevelText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, PositionLevelText.Length);
                Console.WriteLine(PositionLevelText[randNumber]);
                PositionLevel.SendKeys(PositionLevelText[randNumber] + Keys.Enter);
            }

            driver.FindElement(By.Id("NOOFMIN")).SendKeys("20");
            driver.FindElement(By.Id("PASS")).SendKeys("10");
            driver.FindElement(By.Id("FROMNOCTRL")).SendKeys("1");
            driver.FindElement(By.Id("TONOCTRL")).SendKeys("5");
            driver.FindElement(By.Id("FROMNORELATED")).SendKeys("1");
            driver.FindElement(By.Id("TONORELATED")).SendKeys("5");
            driver.FindElement(By.Id("FROMBACKEND")).SendKeys("1");
            driver.FindElement(By.Id("TOBACKEND")).SendKeys("4");
            driver.FindElement(By.Id("BUSSINESWEIGHT")).SendKeys("10");
            driver.FindElement(By.Id("NOTE")).SendKeys("note");


            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")).Click();

            // Edit >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit")));
            driver.FindElement(By.Id("edit")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NOOFMIN")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("NOOFMIN")).Clear();
            driver.FindElement(By.Id("NOOFMIN")).SendKeys("25");
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
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("NOOFMIN")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("NOOFMIN")).Clear();
            driver.FindElement(By.Id("NOOFMIN")).SendKeys("30");
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
            driver.FindElement(By.Id("Grid_ToolbarSearchBox")).SendKeys("Very Complex" + Keys.Enter);
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

            // Report >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(text(),'تقرير')]")));
            driver.FindElement(By.XPath("//button[contains(text(),'تقرير')]")).Click();

            string cardTitleText = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[1]/h4")).Text;

            Assert.Multiple(() =>
            {
                Assert.That(cardTitleText, Is.EqualTo("فئة الصفحة"));
            });

            Assert.Pass();

        }
    }
}
