using MarsQA_1.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    public static class LanguageClass
    {
        private static IWebElement LangBtn => Driver.driver.FindElement(By.XPath("//a[normalize-space()='Languages']"));

        private static IWebElement Addnew => Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][normalize-space()='Add New']"));
        private static IWebElement AddLang => Driver.driver.FindElement(By.XPath("//input[@placeholder='Add Language']"));
        private static IWebElement ChooseLevel => Driver.driver.FindElement(By.XPath("//select[@name='level']"));
        private static IWebElement Added => Driver.driver.FindElement(By.XPath("//input[@value='Add']"));
        private static IWebElement EditLangBtn => Driver.driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
        private static IWebElement UpdateLangBtn => Driver.driver.FindElement(By.XPath("//input[@value='Update']"));
        private static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("//i[@class='remove icon']"));
        public static void LanguagesSteps()
        {
            for(int i = 2; i <= 4; i++)
        {
                System.Threading.Thread.Sleep(5000);
                // LangBtn.Click();
                Addnew.Click();
                AddLang.SendKeys(ExcelLibHelper.ReadData(i, "Language"));
                ChooseLevel.Click();
                Driver.driver.FindElement(By.XPath(" //option[@value='Conversational']")).Click();
                Added.Click();
            }
        }
        public static void EditLanguage()
        {
            System.Threading.Thread.Sleep(5000);
            EditLangBtn.Click();
            AddLang.Clear();
            AddLang.SendKeys(ExcelLibHelper.ReadData(4, "Language"));
            ChooseLevel.Click();
            Driver.driver.FindElement(By.XPath("//option[@value='Fluent']")).Click();
            UpdateLangBtn.Click();
        }
        public static void DeleteLang()
        {
            System.Threading.Thread.Sleep(5000);
            DeleteBtn.Click();
        }

    }
}
