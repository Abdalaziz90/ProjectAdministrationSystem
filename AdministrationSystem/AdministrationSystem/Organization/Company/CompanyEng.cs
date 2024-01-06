using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace AdministrationSystem.AdministrationSystem.Organization.CompanyEng
{

    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("Company Page")]
    [AllureFeature("Organization Page")]
    [AllureEpic("Administration System features")]
    public class TestsCompanyEng
    {

        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        [AllureStory("Card title, website, bank number card and coordinate X, Y in the page ADD")]
        [AllureStep("Card title, website, bank number card and coordinate X, Y in the page ADD")]
        public void CompanyPage()
        {
            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://app.abuhelwafamily.com/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));

            // SignUp >>
            //Thread.Sleep(30000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"form3Example3\"]")));
            driver.FindElement(By.XPath("//input[@id='form3Example3']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@id='form3Example4']")).SendKeys("123456");
            driver.FindElement(By.XPath("//button[@class='btn btn-primary btn-lg']")).Click();

            //// Language >>
            //Thread.Sleep(30000);
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/nav/div/ul[2]/li[3]/a")));
            //driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/nav/div/ul[2]/li[3]/a")).Click();
            //driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/nav/div/ul[2]/li[3]/div/a")).Click();


            // Click on Administration sytem and Organization >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/a")));
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/a")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[4]/li/a")).Click();

            // Company >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[4]/li/ul[2]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[4]/li/ul[2]/li/a")).Click();

            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")).Click();

            // Category
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement Category = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            Category.Click();

            String[] CategoryText = { "مول", "ملحمة", "النقل", "كتب", "بطاقات" };

            if (CategoryText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, CategoryText.Length);
                Console.WriteLine(CategoryText[randNumber]);
                Category.SendKeys(CategoryText[randNumber] + Keys.Enter);
            }

            // Company code
            driver.FindElement(By.Id("CODE")).SendKeys("s40");
            driver.FindElement(By.Id("COMPANYOFFICIALNO")).SendKeys("5");

            // Group
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement Group = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            Group.Click();

            String[] GroupText = { "Just Development Group For IT-G_JUST_1", "Just Development for CARD-G_JUST_5", "Just Development Group For Insurance-G_JUST_10" };

            if (GroupText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, GroupText.Length);
                Console.WriteLine(GroupText[randNumber]);
                Group.SendKeys(GroupText[randNumber] + Keys.Enter);
            }

            // Parent Company
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement ParentCompany = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            ParentCompany.Click();

            String[] ParentCompanyText = { "TEST-C_JUST_24", "TEST1-C_JUST_30", "test-1", "ابو محمود للبطاقات-C_JUST_3", " " };

            if (ParentCompanyText.Length >= 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, ParentCompanyText.Length);
                Console.WriteLine(ParentCompanyText[randNumber]);
                ParentCompany.SendKeys(ParentCompanyText[randNumber] + Keys.Enter);
            }

            // Arabic Name
            driver.FindElement(By.Id("Arabic-name")).SendKeys("فحص");
            driver.FindElement(By.Id("English-name")).SendKeys("test system 12");

            // Sector
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement Sector = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            Sector.Click();

            String[] SectorText = { "Private Sector", "Government Sector", "Industrial Sector" };

            if (SectorText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0,SectorText.Length);
                Console.WriteLine(SectorText[randNumber]);
                Sector.SendKeys(SectorText[randNumber] + Keys.Enter);
            }

            // Trade name
            driver.FindElement(By.Id("TRADENAME")).SendKeys("csd");
            driver.FindElement(By.Id("English-name")).SendKeys("Email@example.com");
            driver.FindElement(By.Id("MOBILE")).SendKeys("070 0000000");

            // Countries
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement Countries = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            Countries.Click();

            String[] CountriesText = { "فلسطين", "مصر", "باكستان", "لبنان" };

            if (CountriesText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, CountriesText.Length);
                Console.WriteLine(CountriesText[randNumber]);
                Countries.SendKeys(CountriesText[randNumber] + Keys.Enter);
            }

            // Address
            driver.FindElement(By.Id("ADDRESS")).SendKeys("dss");
            driver.FindElement(By.Id("WEBSITE")).SendKeys("www.example.com");
            driver.FindElement(By.Id("ABOUT")).SendKeys("test");
            driver.FindElement(By.Id("ACTUALBRANCHESNUM")).SendKeys("4");
            driver.FindElement(By.Id("ACTUALGALLERIESNUM")).SendKeys("10");
            driver.FindElement(By.Id("ACTUALUSERSNUM")).SendKeys("20");

            // Numbers of transactions
            driver.FindElement(By.Id("NOOFTRAN")).SendKeys("20");
            driver.FindElement(By.Id("RATE")).SendKeys("5");
            driver.FindElement(By.Id("GEOX")).SendKeys("dsds");
            driver.FindElement(By.Id("GEOY")).SendKeys("sd");


            // Bank Definition
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement BankDefinition = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            BankDefinition.Click();

            String[] BankDefinitionText = { "Arab Bank", "BLOM Bank", "بنك القاهرة عمان جاري" };

            if (BankDefinitionText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, BankDefinitionText.Length);
                Console.WriteLine(BankDefinitionText[randNumber]);
                BankDefinition.SendKeys(BankDefinitionText[randNumber] + Keys.Enter);
            }

            // Bank Branch
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement BankBranch = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            BankBranch.Click();

            String[] BankBranchText = { "Arab Bank", "BLOM Bank", "بنك القاهرة عمان جاري" };

            if (BankBranchText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, BankBranchText.Length);
                Console.WriteLine(BankBranchText[randNumber]);
                BankBranch.SendKeys(BankBranchText[randNumber] + Keys.Enter);
            }

            // Bank Account Number
            driver.FindElement(By.Id("BANKACCOUNTNUMBER")).SendKeys("dddddddd2324wwew");

            // Browser image
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"dialog-20d42fb2-e795-4ca2-8644-dbb67271d239_dialog-content\"]/form/div/div/div[28]/div/div/button")).Click();

            string currentHandleImg = driver.CurrentWindowHandle;
            foreach (string handleImg in driver.WindowHandles)
            {
                if (!handleImg.Equals(currentHandleImg))
                {
                    Thread.Sleep(5000);
                    driver.SwitchTo().Window(handleImg).Close();
                }
            }

            driver.SwitchTo().Window(currentHandleImg);

            string website = driver.FindElement(By.Id("WEBSITE")).GetAttribute("placeholder");
            string BanckNumer = driver.FindElement(By.Id("BANKACCOUNTNUMBER")).Text;

            string CoordinatesX = driver.FindElement(By.Id("GEOX")).Text;
            string CoordinatesY = driver.FindElement(By.Id("GEOY")).Text;

            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")));
            driver.FindElement(By.XPath("//button[@type='Syncfusion.Blazor.Popups.ButtonType.Submit']")).Click();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='CANCEL']")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='CANCEL']")).Click();

            // Edit >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("edit")));
            driver.FindElement(By.Id("edit")).Click();
            Thread.Sleep(7000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("CODE")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CODE")).Clear();
            driver.FindElement(By.Id("CODE")).SendKeys("B_Umniah_1");
            Thread.Sleep(3000);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='EDIT']")));
            driver.FindElement(By.XPath("//button[normalize-space()='EDIT']")).Click();
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='CANCEL']")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='CANCEL']")).Click();

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
            Thread.Sleep(5000);


            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[3]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
            Thread.Sleep(5000);

            // POST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[2]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
            Thread.Sleep(5000);


            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();
            Thread.Sleep(5000);

            // Edit >>
            driver.FindElement(By.Id("edit")).Click();
            Thread.Sleep(3000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("CODE")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CODE")).Clear();
            driver.FindElement(By.Id("CODE")).SendKeys("B_2");
            driver.FindElement(By.XPath("//button[normalize-space()='EDIT']")).Click();
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[normalize-space()='CANCEL']")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='CANCEL']")).Click();

            // UNPOST >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[3]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();

            // Delete >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")));
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//*[@id=\"Grid_content_table\"]/tbody/tr[1]/td[1]/div")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[1]/div/button[1]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[normalize-space()='OK']")).Click();


            // Search Input >>
            Thread.Sleep(3000);
            driver.FindElement(By.Id("Grid_ToolbarSearchBox")).SendKeys("test" + Keys.Enter);
            Thread.Sleep(3000);
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

            string currentHandle = driver.CurrentWindowHandle;
            foreach (string handle in driver.WindowHandles)
            {
                if (!handle.Equals(currentHandle))
                {
                    Thread.Sleep(5000);
                    driver.SwitchTo().Window(handle).Close();
                }
            }

            driver.SwitchTo().Window(currentHandle);

            // FAVORITE >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[2]/div[3]/button[2]")));
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[2]/div[3]/button[2]")).Click();

            // Report >>
            Thread.Sleep(5000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[2]/div[3]/button[3]")));
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[2]/div[2]/div[3]/button[3]")).Click();

            string cardTitleText = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[1]/h4")).Text;

            Assert.Multiple(() =>
            {
                Assert.That(cardTitleText, Is.EqualTo("Company"));
                Assert.That(website, Is.EqualTo("www.example.com"));
                Assert.That(BanckNumer, Is.EqualTo("xxxxxxxxxxxxxxxx"), "x : is a number, should be number bank card is 16 numbers not words");
                Assert.That(CoordinatesX, Is.EqualTo("5"), "coordinate is not words but it's numbers");
                Assert.That(CoordinatesX, Is.EqualTo("2"), "coordinate is not words but it's numbers");
            });

            Assert.Pass();
        }
    }
}