using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace sberbank01
{

    public class Program
    {
        static FirefoxDriver firefox;

        public static void Main()
        {
            firefox = new FirefoxDriver(FirefoxDriverService.CreateDefaultService($"../../../"));
            var request = "Логотип Сбербанка";
            firefox.Navigate().GoToUrl("http://www.yandex.ru/");
            firefox.FindElementByClassName("input__control").SendKeys(request);
            firefox.FindElementByClassName("input__control").SendKeys(Keys.Enter);
            firefox.Navigate().GoToUrl("https://yandex.ru/images/search?text="+request);

            GetCountPic("Сбербанк");
            GetCountPic("Сбербанк12345");
            Console.ReadKey();
            firefox.Quit();
        }

        public static int GetCountPic(string alt)
        {
            var imagesCollection = firefox.FindElements(By.TagName("img"));
            var sberImages = imagesCollection.Where(webElement => webElement.GetAttribute("alt").Contains(alt));
            var count = sberImages.Count();
            Console.WriteLine();
            Console.WriteLine($"нашел {imagesCollection.Count} картинок");
            Console.WriteLine($"из них в {sberImages.Count()} встречается '{alt}'");
            Console.WriteLine(sberImages.Any() ? "Тест пройден" : "Тест не пройден");
            Console.WriteLine();
            return sberImages.Count();
        }
    }
}