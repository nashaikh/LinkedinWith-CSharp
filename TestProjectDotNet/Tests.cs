using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumTests;

namespace TestProjectDotNet
{


  
    public class Tests : BaseTest
    {

   

        private By usernameField = By.Id("username");
        private By userPasswordField = By.Id("password");
        private By SubmitButton = By.XPath("//button[@aria-label='Sign in']");
        private By SearchBox = By.XPath("//input[@placeholder='Search']");
        public String jobType = "SQA Jobs";
        public String username = "enter your user name";
        public String pwd = "enter your password";



        public void TestSetUp()
        {
          }

        [Test]
        public void Test1()
        {
            var userName = driver.FindElement(usernameField);
            userName.Clear();
            userName.SendKeys(username);

            var userPassword = driver.FindElement(userPasswordField);
            userPassword.Clear();
            userPassword.SendKeys(pwd);

            var LoginSubmit = driver.FindElement(SubmitButton);
            LoginSubmit.Click();

            Assert.AreEqual("Feed | LinkedIn", driver.Title);   
            
}
        [Test]
        public void Test2()
        {
            Thread.Sleep(2000);
            var SearchJob = driver.FindElement(SearchBox);
            SearchJob.Clear();
            SearchJob.SendKeys(jobType);
            SearchJob.SendKeys(Keys.Enter);
            StringAssert.Contains(jobType, driver.Title);







        }


    }

}