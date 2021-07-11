using MarsQA_1.Helpers;
using OpenQA.Selenium;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class Certifications
    {
        private static IWebElement CertiBtn => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Certifications']"));
        private static IWebElement Addnew => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
        private static IWebElement AddCerti => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certificate or Award']"));
        private static IWebElement CertiFrom => Driver.driver.FindElement(By.XPath("//input[@placeholder='Certified From (e.g. Adobe)']"));
        private static IWebElement Year => Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));

        // private static IWebElement SelectYr => Driver.driver.FindElement(By.XPath("//option[@value='2013']"));
        // private static IWebElement UpdatedSelectYr => Driver.driver.FindElement(By.XPath("//option[@value='2016']"));
        private static IWebElement Added => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));

        private static IWebElement EditCertiBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[1]/i[1]"));
        private static IWebElement UpdateCertiBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("//tbody/tr/td[4]/span[2]/i[1]"));

        public static void CeritificationsSteps()
        {
            for (int i = 2; i <= 4; i++)
            {
                System.Threading.Thread.Sleep(5000);
                CertiBtn.Click();
                Addnew.Click();
                AddCerti.SendKeys(ExcelLibHelper.ReadData(i, "Certifications"));
                CertiFrom.SendKeys(ExcelLibHelper.ReadData(i, "From"));
                Year.SendKeys(ExcelLibHelper.ReadData(i, "Year"));
                //SelectYr.Click();
                // Driver.driver.FindElement(By.XPath("//option[@value='2013")).Click();
                Added.Click();
            }
        }

        public static void EditCertification()

        {
            System.Threading.Thread.Sleep(5000);
            CertiBtn.Click();
            EditCertiBtn.Click();
            AddCerti.Clear();
            AddCerti.SendKeys(ExcelLibHelper.ReadData(2, "Certifications"));
            CertiFrom.Clear();
            CertiFrom.SendKeys(ExcelLibHelper.ReadData(2, "From"));
            Year.SendKeys(ExcelLibHelper.ReadData(2, "Year"));
            //UpdatedSelectYr.Click();
            //  Driver.driver.FindElement(By.XPath("//option[@value='2016")).Click();
            UpdateCertiBtn.Click();
        }

        public static void DeleteCertification()
        {
            CertiBtn.Click();
            DeleteBtn.Click();
        }
    }
}