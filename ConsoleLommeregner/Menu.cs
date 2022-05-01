using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLommeregner
{
    internal class Menu
    {
        private char selection;
        private double FirstNumber = 0;
        private double SecondNumber = 0;
        private double result = 0;
        private string[] menuItems = { "1. Add", "2. Subtract", "3. Divide", "4. Multiply", "5. Quit" };
        private bool isRunning = true;
        private bool inputFailed;

        public bool IsRunning { get { return isRunning; } set { isRunning = value; } }

        public void printMenuItems()
        {
            foreach (string item in menuItems)
            {
                Console.WriteLine(item);
            }
        }
        public void awaitInput()
        {
            Console.Write("Please select an option (1-5): ");
            try
            {
                selection = char.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void executeSelection()
        {
            inputFailed = false;
            Calculator calculator = new Calculator();
            switch (selection)
            {
                case '1':
                    numbersInput();
                    if (!inputFailed)
                    {
                        result = calculator.Add(FirstNumber, SecondNumber);
                        Console.WriteLine("Result is " + result);
                    }                    
                    break;
                case '2':
                    numbersInput();
                    if (!inputFailed)
                    {
                        result = calculator.Subtract(FirstNumber, SecondNumber);
                        Console.WriteLine("Result is " + result);
                    }                    
                    break;
                case '3':
                    numbersInput();
                    if (!inputFailed)
                    {
                        result = calculator.Divide(FirstNumber, SecondNumber);
                        Console.WriteLine("Result is " + result);
                    }                    
                    break;
                case '4':
                    numbersInput();
                    if (!inputFailed)
                    {
                        result = calculator.Multiply(FirstNumber, SecondNumber);
                        Console.WriteLine("Result is " + result);
                    }                    
                    break;
                case '5':
                    IsRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid entry.");
                    break;
            }
        }

        private void numbersInput()
        {
            Console.Write("Please type first number: ");
            try
            {
                FirstNumber = Double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                inputFailed = true;
                Console.WriteLine(ex.Message);
            }
            if (!inputFailed)
            {
                Console.Write("Please type second number: ");
                try
                {
                    SecondNumber = Double.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    inputFailed = true;
                    Console.WriteLine(ex.Message);
                }
            }
            
        }
    }
}
