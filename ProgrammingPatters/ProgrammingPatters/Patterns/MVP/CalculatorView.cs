using System;
using ProgrammingPatters.Patterns.MVP.Interfaces;

namespace ProgrammingPatters.Patterns.MVP
{
    public class CalculatorView : IView
    {
        public Action<string> OnInput { get; set; }

        public void InputCalculations()
        {
            OnInput?.Invoke(Console.ReadLine());
        }

        public void PrintCalculations(float result)
        {
            Console.WriteLine(result);
        }
    }
}