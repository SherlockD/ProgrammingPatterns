using System;
using ProgrammingPatters.Patterns.MVP.Interfaces;

namespace ProgrammingPatters.Patterns.MVP
{
    public class CalculatorModel : IModel
    {
        private Func<float, float, float> _calculateMethod;

        public Action<float> OnCalculate { get; set; }

        public void Calculate(string equation)
        {
            var predicates = equation.Split(' ');
            
            SwitchMode(Convert.ToChar(predicates[1]));

            OnCalculate?.Invoke((float)_calculateMethod?.Invoke(Convert.ToSingle(predicates[0]), Convert.ToSingle(predicates[2])));
        }

        public void SwitchMode(char sign)
        {
            switch(sign)
            {
                case '+':
                    _calculateMethod = PlusMethod;
                    break;
                case '-':
                    _calculateMethod = MinusMethod;
                    break;
                case '*':
                    _calculateMethod = MultiplyMethod;
                    break;
                case '/':
                    _calculateMethod = DivideMethod;
                    break;
            }
        }

        private float PlusMethod(float num1, float num2) => num1 + num2;
        private float MinusMethod(float num1, float num2) => num1 - num2;
        private float MultiplyMethod(float num1, float num2) => num1 * num2;
        private float DivideMethod(float num1, float num2) => num1 / num2;
    }
}