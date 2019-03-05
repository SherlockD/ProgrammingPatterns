/*
 * Абстрактная фабрика
 * 
 * В примере фабрика по производству супергероев
 * 
 *          Hero warriorHero = new Hero(new WarriorFactory());

            warriorHero.Hit();
            warriorHero.Move();

            Hero mageHero = new Hero(new MageFactory());

            mageHero.Hit();
            mageHero.Move();

            Console.ReadKey();
 * 
 */


using System;

namespace ProgrammingPatters.Patterns.Creational
{
    abstract class Weapon
    {
        public abstract void Hit();
    }

    abstract class Movement
    {
        public abstract void Move();
    }

    abstract class HeroFactory
    {
        public abstract Weapon CreateWeapon();
        public abstract Movement CreateMovement();
    }

    class Sword : Weapon
    {
        public override void Hit() => Console.WriteLine("Sword hit"); 
    }

    class Magic : Weapon
    {
        public override void Hit() => Console.WriteLine("Magic hit");
    }

    class Runing : Movement
    {
        public override void Move() => Console.WriteLine("Running move");
    }

    class Flying : Movement
    {
        public override void Move() => Console.WriteLine("Flying move");
    }

    class WarriorFactory : HeroFactory
    {
        public override Movement CreateMovement() => new Runing();
        public override Weapon CreateWeapon() => new Sword();
    }

    class MageFactory : HeroFactory
    {
        public override Movement CreateMovement() => new Flying();
        public override Weapon CreateWeapon() => new Magic();
    }

    class Hero
    {
        private Weapon _weapon;
        private Movement _movement;

        public Hero(HeroFactory heroFactory)
        {
            _weapon = heroFactory.CreateWeapon();
            _movement = heroFactory.CreateMovement();
        }

        public void Hit() => _weapon.Hit();

        public void Move() => _movement.Move();
    }
}
