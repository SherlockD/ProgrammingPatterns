using ProgrammingPatters.Patterns.MVP.Interfaces;

namespace ProgrammingPatters.Patterns.MVP
{
    public class CalculatorMediator : IMediator
    {
        private CalculatorPresenter _calculatorPresenter;
        private CalculatorModel _calculatorModel;
        private CalculatorView _calculatorView;
        
        public CalculatorMediator()
        {
            _calculatorModel = new CalculatorModel();
            _calculatorView = new CalculatorView();
            
            _calculatorPresenter = new CalculatorPresenter(_calculatorView, _calculatorModel);
            
            _calculatorPresenter.Initialize();
        }

        public void Start()
        {
            _calculatorView.InputCalculations();
        }
    }
}