using System;

namespace ConsoleLommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            do
            {
                menu.printMenuItems();
                menu.awaitInput();
                menu.executeSelection();
            }
            while (menu.IsRunning);
        }
    }
}
