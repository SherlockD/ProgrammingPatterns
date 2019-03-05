/*
 * Паттерн Factory
 * 
 * В примере предствлена реализация фабрик для постройки домов
 * 
            PanelFactory panelFactory = new PanelFactory("Газпромстрой");
            WoodenFactory woodenFactory = new WoodenFactory("Дереводомстрой");

            PanelHouse panelHouse = panelFactory.Create() as PanelHouse;

            WoodenHouse woodenHouse = woodenFactory.Create() as WoodenHouse;

            Console.WriteLine(panelHouse.GetHouse());
            Console.WriteLine(woodenHouse.GetHouse());

            Console.ReadKey();
 */

namespace ProgrammingPatters.Patterns.Creational
{
    abstract class House { }

    abstract class Factory
    {
        public string Name;

        public Factory(string name)
        {
            Name = name;
        }

        abstract public House Create();
    }

    class PanelHouse : House
    {
        public string GetHouse() => "Panel house";
    }

    class WoodenHouse : House
    {
        public string GetHouse() => "Wooden house";
    }

    class PanelFactory : Factory
    {
        public PanelFactory(string name):base(name)
        {}

        public override House Create() => new PanelHouse();
    }

    class WoodenFactory : Factory
    {
        public WoodenFactory(string name) : base(name)
        { }

        public override House Create() => new WoodenHouse();
    }
}
