/*
            В примере представлено клонирование фигур
 
            Rect rect = new Rect(10,20);
            var rectClone = rect.Clone();
            rect.GetInfo();

 */

using System;

namespace ProgrammingPatters.Patterns.Creational
{
    public interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }

    public class Circle : IFigure
    {
        private int _radius;

        public Circle(int radius)
        {
            _radius = radius;
        }
        
        public IFigure Clone()
        {
            return new Circle(_radius);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Circle radius: {_radius}");
        }
    }

    public class Rect : IFigure
    {
        private int _width;
        private int _height;
        
        public Rect(int w, int h)
        {
            _width = w;
            _height = h;
        }
        
        public IFigure Clone()
        {
            return new Rect(_width,_height);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Rect width:{_width} height:{_height}");
        }
    }
}