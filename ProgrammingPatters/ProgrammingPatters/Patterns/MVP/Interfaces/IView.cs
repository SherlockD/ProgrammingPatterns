using System;

namespace ProgrammingPatters.Patterns.MVP.Interfaces
{
    public interface IView
    {
        Action<string> OnInput { get; set; }
        void InputCalculations();
        void PrintCalculations(float result);
    }
}