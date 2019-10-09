using ProgrammingPatters.Patterns.Creational;
using ProgrammingPatters.Patterns.MVP;

namespace ProgrammingPatters
{
    internal class Program
    {
        public static void Main()
        {
            CalculatorMediator calculatorMediator = new CalculatorMediator();
            
            calculatorMediator.Start();
        }
    }
}