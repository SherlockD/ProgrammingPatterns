#region INFO
/*
 Пиццерия с возможностью добавления ингридиентов
 
 Пример в Main()
 
            ItalianPizza italianPizza = new ItalianPizza("Итальянская пицца");
            Console.WriteLine($"{italianPizza.Name}: стоит {italianPizza.GetCost()}");
            CheesePizzaa cheesePizza = new CheesePizzaa(italianPizza);
            Console.WriteLine($"{cheesePizza.Name}: стоит {cheesePizza.GetCost()}");
            TomatoPizza tomatoPizza = new TomatoPizza(italianPizza);
            Console.WriteLine($"{tomatoPizza.Name}: стоит {tomatoPizza.GetCost()}");
            TomatoPizza cheeseWithTomatoPizza = new TomatoPizza(cheesePizza);
            Console.WriteLine($"{cheeseWithTomatoPizza.Name}: стоит {cheeseWithTomatoPizza.GetCost()}");
*/
#endregion

namespace ProgrammingPatters.Patterns.Structural
{
    abstract class Pizza
    {
        public string Name;
        
        public Pizza(string name)
        {
            Name = name;
        }

        public abstract int GetCost();
    }

    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        
        protected PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            this.pizza = pizza;
        }
    }
    
    class ItalianPizza : Pizza
    {
        public ItalianPizza(string name) : base(name)
        {
        }

        public override int GetCost() => 5;
    }

    class CheesePizzaa : PizzaDecorator
    {
        
        public CheesePizzaa(Pizza pizza) : base(pizza.Name+" с сыром,",pizza)
        {
        }

        public override int GetCost() => pizza.GetCost()+3;
    }

    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base(pizza.Name+" с томатами,", pizza)
        {           
        }

        public override int GetCost() => pizza.GetCost() + 4;
    }
}