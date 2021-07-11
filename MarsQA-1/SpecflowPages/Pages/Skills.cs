using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class Skills
    {
        private static IWebElement SkillBtn => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Skills']"));
        private static IWebElement Addnew => Driver.driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        private static IWebElement Addskill => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']"));
        private static IWebElement ChooseLevel => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
        private static IWebElement AddBtn => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement EditSkill => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
        private static IWebElement UpdateSkill => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteSkill => Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[2]/i[1]"));

        public static void SkillsSteps()
        {
            for (int i = 2; i <= 4; i++)
            {
                System.Threading.Thread.Sleep(5000);
                SkillBtn.Click();
                Addnew.Click();
                Addskill.SendKeys(ExcelLibHelper.ReadData(i, "Skills"));
                ChooseLevel.Click();
                Driver.driver.FindElement(By.XPath("//option[@value='Beginner']")).Click();
                AddBtn.Click();
            }
        }

        public static void EditSkillSteps()
        {
            System.Threading.Thread.Sleep(5000);
            SkillBtn.Click();
            EditSkill.Click();
            Addskill.Clear();
            Addskill.SendKeys(ExcelLibHelper.ReadData(2, "Skills"));
            ChooseLevel.Click();
            Driver.driver.FindElement(By.XPath("//option[@value='Expert']")).Click();
            UpdateSkill.Click();
        }

        public static void DeleteSkillSteps()
        {
            System.Threading.Thread.Sleep(5000);
            SkillBtn.Click();
            DeleteSkill.Click();
        }
    }
}