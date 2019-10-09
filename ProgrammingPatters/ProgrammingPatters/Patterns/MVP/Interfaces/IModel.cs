using System;

namespace ProgrammingPatters.Patterns.MVP.Interfaces
{
    public interface IModel
    {
        Action<float> OnCalculate { get; set; }
        void Calculate(string equation);
        void SwitchMode(char sign);
    }
}