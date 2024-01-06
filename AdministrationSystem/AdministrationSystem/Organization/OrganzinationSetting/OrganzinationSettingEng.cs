using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Xml;

namespace AdministrationSystem.AdministrationSystem.Organization.OrganzinationSettingEng
{

    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    [AllureNUnit]
    [AllureSuite("OrganzinationSetting Page")]
    [AllureFeature("Organization Page")]
    [AllureEpic("Administration System features")]
    public class TestsOrganzinationSettingEng
    {

        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        [AllureStory("Card title in the page ADD")]
        [AllureStep("Card title in the page ADD")]
        public void OrganzinationSettingPage()
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

            // OrganzinationSetting >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[4]/li/ul[6]/li/a")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/aside/div[2]/nav/ul/li[1]/ul[4]/li/ul[6]/li/a")).Click();

            // ADD >>
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")));
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//button[@class='e-control e-btn e-lib btn btn-outline-success']")).Click();

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

            // Company
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement Company = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            Company.Click();

            String[] CompanyText = { "TEST-C_JUST_24", "TEST1-C_JUST_30", "test-1", "ابو محمود للبطاقات-C_JUST_3", " " };

            if (CompanyText.Length >= 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, CompanyText.Length);
                Console.WriteLine(CompanyText[randNumber]);
                Company.SendKeys(CompanyText[randNumber] + Keys.Enter);
            }

            // Branch
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement Branch = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            Branch.Click();

            String[] BranchText = { "Barah & Etqan-B_JUST_6", "Petra-B_JUST_7", "test-B_JUST_9", " " };

            if (BranchText.Length >= 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, BranchText.Length);
                Console.WriteLine(BranchText[randNumber]);
                Branch.SendKeys(BranchText[randNumber] + Keys.Enter);
            }

            // Gallery
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement Gallery = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            Gallery.Click();

            String[] GalleryText = { " " };

            if (GalleryText.Length == 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, GalleryText.Length);
                Console.WriteLine(GalleryText[randNumber]);
                Gallery.SendKeys(GalleryText[randNumber] + Keys.Enter);
            }

            // Language
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement Language = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            Language.Click();

            String[] LanguageText = { "عربي", "انجليزي" };

            if (LanguageText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, LanguageText.Length);
                Console.WriteLine(LanguageText[randNumber]);
                Language.SendKeys(LanguageText[randNumber] + Keys.Enter);
            }

            // Citizen Branch
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement CitizenBranch = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            CitizenBranch.Click();

            String[] CitizenBranchText = { "Barah & Etqan-B_JUST_6", "Petra-B_JUST_7", "test-B_JUST_9", " " };

            if (CitizenBranchText.Length >= 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, CitizenBranchText.Length);
                Console.WriteLine(CitizenBranchText[randNumber]);
                CitizenBranch.SendKeys(CitizenBranchText[randNumber] + Keys.Enter);
            }

            // Customer Role
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement CustomerRole = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            CustomerRole.Click();

            String[] CustomerRoleText = { "SUPPER ADMIN", "Sales Man", "Manager Test", "SOC", " " };

            if (CustomerRoleText.Length >= 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, CustomerRoleText.Length);
                Console.WriteLine(CustomerRoleText[randNumber]);
                CustomerRole.SendKeys(CustomerRoleText[randNumber] + Keys.Enter);
            }

            // Application date format
            driver.FindElement(By.Id("applicationDateFormat")).SendKeys("24");
            driver.FindElement(By.Id("dataBaseDateFormat")).SendKeys("12");
            driver.FindElement(By.Id("connectionLDAB")).SendKeys("LDAB");
            driver.FindElement(By.Id("offSetTime")).SendKeys("6");
            driver.FindElement(By.Id("reportURL")).SendKeys("URL");
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"dialog-d9228269-0726-4873-b79a-9b0423840b47_dialog-content\"]/form/div[1]/div/div[13]/div/label/input")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("confirmationCreateUserURL")).SendKeys("User url");
            driver.FindElement(By.Id("CONFIGURATIONPASSWORD")).SendKeys("***********");
            driver.FindElement(By.Id("resetPasswordURL")).SendKeys("***********");

            // Unique Field
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement UniqueField = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            UniqueField.Click();

            String[] UniqueFieldText = { "All Previous Options Are Unique", "The E-Mail In The User Table Is Unique", "The Mobile In The User Table Is Unique" };

            if (UniqueFieldText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, UniqueFieldText.Length);
                Console.WriteLine(UniqueFieldText[randNumber]);
                UniqueField.SendKeys(UniqueFieldText[randNumber] + Keys.Enter);
            }

            // Use Unified Login
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"dialog-d9228269-0726-4873-b79a-9b0423840b47_dialog-content\"]/form/div[1]/div/div[20]/div/label/input")).Click();
            Thread.Sleep(5000);

            driver.FindElement(By.Id("SMSURLGATEWAY")).SendKeys("SMS");
            driver.FindElement(By.Id("SMSUSERNAME")).SendKeys("SMS USER");
            driver.FindElement(By.Id("SMSPASSWORD")).SendKeys("SMS Password");
            driver.FindElement(By.Id("SMSCLIENTNAME")).SendKeys("SMS Client");

            // SMS Type
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]")));
            Thread.Sleep(5000);
            IWebElement SMSType = driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[2]/form[1]/div[1]/div[1]/div[3]/span[1]"));
            SMSType.Click();

            String[] SMSTypeText = { "Arabia Cell Jordan", "External", "UAE Company" };

            if (SMSTypeText.Length > 0)
            {
                Random rand = new Random();
                int randNumber = rand.Next(0, SMSTypeText.Length);
                Console.WriteLine(SMSTypeText[randNumber]);
                SMSType.SendKeys(SMSTypeText[randNumber] + Keys.Enter);
            }

            // Send SMS When Create User
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"dialog-d9228269-0726-4873-b79a-9b0423840b47_dialog-content\"]/form/div[1]/div/div[27]/div/label/input")).Click();
            Thread.Sleep(5000);

            driver.FindElement(By.Id("SMTP")).SendKeys("SMTP");
            driver.FindElement(By.Id("fromMail")).SendKeys("From mail");
            driver.FindElement(By.Id("smtpPort")).SendKeys("25");
            driver.FindElement(By.Id("smtpUserName")).SendKeys("smtp user name");
            driver.FindElement(By.Id("smtpPassword")).SendKeys("*******");

            // SMTP Enable SSL Protocol
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"dialog-d9228269-0726-4873-b79a-9b0423840b47_dialog-content\"]/form/div[1]/div/div[33]/div/label/input")).Click();
            Thread.Sleep(5000);

            driver.FindElement(By.Id("mailNickName")).SendKeys("Nick name");

            // Send Email When Create User
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id=\"dialog-d9228269-0726-4873-b79a-9b0423840b47_dialog-content\"]/form/div[1]/div/div[36]/div/label/input")).Click();
            Thread.Sleep(5000);

            driver.FindElement(By.Id("domain")).SendKeys("@example.com");
            driver.FindElement(By.Id("DELAYTIMERDAILY")).SendKeys("10");
            driver.FindElement(By.Id("DELAYTIMERMONTHLY")).SendKeys("3");

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
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("dataBaseDateFormat")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("dataBaseDateFormat")).Clear();
            driver.FindElement(By.Id("dataBaseDateFormat")).SendKeys("21");
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
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("DELAYTIMERMONTHLY")));
            Thread.Sleep(3000);
            driver.FindElement(By.Id("DELAYTIMERMONTHLY")).Clear();
            driver.FindElement(By.Id("DELAYTIMERMONTHLY")).SendKeys("2");
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
            driver.FindElement(By.Id("Grid_ToolbarSearchBox")).SendKeys("sd" + Keys.Enter);
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


            string cardTitleText = driver.FindElement(By.XPath("//*[@id=\"app\"]/div[2]/main/div[2]/div/div/div[1]/h4")).Text;

            Assert.Multiple(() =>
            {
                Assert.That(cardTitleText, Is.EqualTo("Organization Setting"));
            });

            Assert.Pass();
        }
    }
}