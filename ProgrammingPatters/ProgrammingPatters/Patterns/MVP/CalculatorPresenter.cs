using System;
using ProgrammingPatters.Patterns.MVP.Interfaces;

namespace ProgrammingPatters.Patterns.MVP
{
    public class CalculatorPresenter : IPresenter
    {
        private readonly IView _view;
        private readonly IModel _model;

        public CalculatorPresenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
            
            Initialize();
        }

        public void Initialize()
        {
            _view.OnInput = _model.Calculate;
            _model.OnCalculate = _view.PrintCalculations;
        }
    }
}