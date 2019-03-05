/*
 *        В примере создается пекарь, который печет разные виды хлеба
 *
 * 
 *          Baker baker = new Baker();

            var white = baker.Bake(new WheatBreadBuilder());
            var rye = baker.Bake(new RyeBreadBuilder());
            
            Console.WriteLine($"{white}\n{rye}");
 * 
 */

namespace ProgrammingPatters.Patterns.Creational
{
    class Baker
    {
        public Bread Bake(BreadBuilder breadBuilder)
        {
            breadBuilder.CreateBread();
            breadBuilder.SetFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetAdditives();
            
            return breadBuilder.Bread;
        }
    }
    
    class Flour
    {
        public string Sort;
    }

    class Salt
    {
        public float Weight;
    }

    class Additives
    {
        public string Name;
    }

    class Bread
    {
        public Flour Flour;
        public Salt Salt;
        public Additives Additives;

        public override string ToString() => $"Sort: {Flour.Sort}, Salt weight: {Salt.Weight}, Additives: {Additives?.Name}";
    }
    
    abstract class BreadBuilder
    {
        public Bread Bread { get; private set; }

        public void CreateBread()
        {
            Bread = new Bread();
        }

        public abstract void SetFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();
    }

    class RyeBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            Bread.Flour = new Flour() {Sort = "Ржаная мука"};
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt() {Weight = 100};
        }

        public override void SetAdditives()
        {
            
        }
    }

    class WheatBreadBuilder : BreadBuilder
    {
        public override void SetFlour()
        {
            Bread.Flour = new Flour() {Sort = "Пшеничная мука"};
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt() {Weight = 50};
        }

        public override void SetAdditives()
        {
            Bread.Additives = new Additives() {Name = "Разрыхлитель"};
        }
    }
}