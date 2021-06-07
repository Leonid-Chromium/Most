using System;
using System.Drawing;

namespace Most
{
    class Program
    {
        interface WebPage
        {
            public void getContent() { }
        }

        class About :  WebPage
        {
            protected string Theme;
            public About(string WTheme)
            {
                this.Theme = WTheme;
            }
            public void getContent()
            {
                Console.ForegroundColor = (ConsoleColor)ColorTranslator.ToOle(Color.FromName(Theme));
                Console.WriteLine("About page in");
            }
        }

        class Careers:WebPage
        {
            protected string Theme;
            public Careers(string WTheme)
            {
                this.Theme = WTheme;
            }
            public void getContent()
            {
                Console.ForegroundColor =(ConsoleColor)ColorTranslator.ToOle(Color.FromName(Theme));
                Console.WriteLine("Careers page in");
            }
        }

        interface Theme
        {
            string getColor() { return "";}
        }

        class DarkTheme:Theme
        {
            public string getColor()
            {
                return "DarkGrey";
            }
        }

        class LightTheme:Theme
        {
            public string getColor()
            {
                return "White"; 
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Programm is starting.");
            About Page1 = new About("White");
            Careers Page2 = new Careers("DarkGrey");
            Page2.getContent();
        }
    }
}
