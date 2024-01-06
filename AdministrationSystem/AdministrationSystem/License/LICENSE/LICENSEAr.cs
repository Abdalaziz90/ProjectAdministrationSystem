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
using Allure.Commons;

namespace AdministrationSystem.AdministrationSystem.SystemHierarchy.LICENSEAr
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("LICENSE Page")]
    [AllureFeature("License Page")]
    [AllureEpic("Administration System features")]
    public class TestsLICENSEArPage
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
        public void LICENSEPage()
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


            // LICENSE >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[9]/li/ul[2]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[9]/li/ul[2]/li/a")).Click();


            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")));
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")).Click();

            // Cutomers
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement Customers = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            Customers.Click();

            String[] CustomersText = { "-1", "AICC-2", "Sama Amoun-3", "JNL-4", "A Arab-5" };

            if (CustomersText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, CustomersText.Length);
                Console.WriteLine(CustomersText[randNumber]);
                Customers.SendKeys(CustomersText[randNumber] + Keys.Enter);
            }

            // Contract Code 
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement ContractCode = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            ContractCode.Click();

            String[] ContractCodeText = { " ", "AICC", "SamaAmoun", "JNL", "A-Arab" };

            if (ContractCodeText.Length >= 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, ContractCodeText.Length);
                Console.WriteLine(ContractCodeText[randNumber]);
                ContractCode.SendKeys(ContractCodeText[randNumber] + Keys.Enter);
            }

            //Market Plan
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement MarketPlan = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            MarketPlan.Click();

            String[] MarketPlanText = { "test-plan", "test16", "Plan G" };

            if (MarketPlanText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, MarketPlanText.Length);
                Console.WriteLine(MarketPlanText[randNumber]);
                MarketPlan.SendKeys(MarketPlanText[randNumber] + Keys.Enter);
            }

            // SoftWare Version Number
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement SoftWareVersionNumber = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            SoftWareVersionNumber.Click();

            String[] SoftWareVersionNumberText = { "V1_BlazorCore8" };

            if (SoftWareVersionNumberText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, SoftWareVersionNumberText.Length);
                Console.WriteLine(SoftWareVersionNumberText[randNumber]);
                SoftWareVersionNumber.SendKeys(SoftWareVersionNumberText[randNumber] + Keys.Enter);
            }

            // License Status
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement LicenseStatus = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            LicenseStatus.Click();

            String[] LicenseStatusText = { "New Lincense", "ReNew Lincense", "Expired Lincense", "Cancel The Lincense" };

            if (LicenseStatusText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, LicenseStatusText.Length);
                Console.WriteLine(LicenseStatusText[randNumber]);
                LicenseStatus.SendKeys(LicenseStatusText[randNumber] + Keys.Enter);
            }

            // License Type
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement LicenseType = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            LicenseType.Click();

            String[] LicenseTypeText = { "Cloud", "Onpromise" };

            if (LicenseTypeText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, LicenseTypeText.Length);
                Console.WriteLine(LicenseTypeText[randNumber]);
                LicenseType.SendKeys(LicenseTypeText[randNumber] + Keys.Enter);
            }

            // CPU Info
            driver.FindElement(By.Id("CPUINFO")).SendKeys("CPU");
            driver.FindElement(By.Id("MACADDRESS")).SendKeys("MAC");
            driver.FindElement(By.Id("COMPANIESNUM")).SendKeys("5");
            driver.FindElement(By.Id("BRANCHESNUM")).SendKeys("30");
            driver.FindElement(By.Id("NUMBEROFGALLARY")).SendKeys("10");

            // Types Of User
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement TypeOfUser = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            TypeOfUser.Click();

            String[] TypeOfUserText = { "Named Users", "Unlimited Of Users", "Concurrent Users On The System" };

            if (TypeOfUserText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, TypeOfUserText.Length);
                Console.WriteLine(TypeOfUserText[randNumber]);
                TypeOfUser.SendKeys(TypeOfUserText[randNumber] + Keys.Enter);
            }

            // Number of users
            driver.FindElement(By.Id("USERSNUM")).SendKeys("20");

            //Date >>
            IWebElement RegistrationDateEng = driver.FindElement(By.Id("RULINGDATE"));
            RegistrationDateEng.Clear();
            RegistrationDateEng.Clear();
            RegistrationDateEng.SendKeys("١١/١١/٢٠٢٣");

            // Free Duration
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement FreeDuration = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            FreeDuration.Click();

            String[] FreeDurationText = { "ONEMONTH", "Three Month", "Six Months", "Tweilve Month", "Twinty Four Month", "Thirty Six Month" };

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

            String[] RequiredDurationText = { "ONEMONTH", "Three Month", "Six Months", "Tweilve Month", "Twinty Four Month", "Thirty Six Month" };

            if (RequiredDurationText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, RequiredDurationText.Length);
                Console.WriteLine(RequiredDurationText[randNumber]);
                RequiredDuration.SendKeys(RequiredDurationText[randNumber] + Keys.Enter);
            }

            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")));

            driver.FindElement(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")).Click();

            // Edit >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit")));
            driver.FindElement(By.Id("edit")).Click();
            Thread.Sleep(7000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("CPUINFO")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CPUINFO")).Clear();
            driver.FindElement(By.Id("CPUINFO")).SendKeys("Info about cpu");
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(text(),'تعديل')]")));
            driver.FindElement(By.XPath("//button[contains(text(),'تعديل')]")).Click();
            Thread.Sleep(7000);

            if (ContractCodeText[0] == " ")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")));
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")).Click();
                Thread.Sleep(7000);
            }

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);


            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[3]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);


            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();
            Thread.Sleep(5000);


            // Edit >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit")));
            driver.FindElement(By.Id("edit")).Click();
            Thread.Sleep(7000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("USERSNUM")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("USERSNUM")).Clear();
            driver.FindElement(By.Id("USERSNUM")).SendKeys("23");
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[contains(text(),'تعديل')]")));
            driver.FindElement(By.XPath("//button[contains(text(),'تعديل')]")).Click();
            Thread.Sleep(7000);

            if (ContractCodeText[0] == " ")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")));
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("//div[@class='e-footer-content']//button[@class='e-control e-btn e-lib btn btn-outline-danger'][contains(text(),'إلغاء')]")).Click();
                Thread.Sleep(7000);
            }

            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[3]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();

            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[contains(text(),'حسنا')]")).Click();

            // Search Input >>
            Thread.Sleep(5000);
            driver.FindElement(By.Id("Grid_ToolbarSearchBox")).SendKeys("JNL" + Keys.Enter);
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
            bool btnRpt = driver.FindElement(By.XPath("//button[contains(text(),'تقرير')]")).Displayed;


            string cardTitleText = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[1]/h4")).Text;

            Assert.Multiple(() =>
            {
                Assert.That(cardTitleText, Is.EqualTo("الرخصة"));
                Assert.That(btnRpt, Is.EqualTo(true));
            });

            Assert.Pass();

        }
    }
}