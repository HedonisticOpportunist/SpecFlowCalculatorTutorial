using System;

// Adapted from * 
// https://docs.specflow.org/projects/
// getting-started/en/latest/GettingStarted/Step2.html
namespace CalculatorSUT
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Divide()
        {
            return FirstNumber / SecondNumber;
        }

        public int Subtract()
        {
            return FirstNumber - SecondNumber;
        }

        public int Mulitiply()
        {
            return FirstNumber * SecondNumber;
        }

        public int Modulo()
        {
            return FirstNumber % SecondNumber;
        }

        // @ Credit: https://stackoverflow.com/questions/
        // 3034604/is-there-an-exponent-operator-in-c/3034607
        public double Exponential()
        {
            return Math.Pow(FirstNumber, SecondNumber);
        }
    }
}
