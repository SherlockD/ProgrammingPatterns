using ProgrammingPatters.Patterns.Creational;

namespace ProgrammingPatters
{
    internal class Program
    {
        public static void Main()
        {
            Rect rect = new Rect(10,20);
            var rectClone = rect.Clone();
            rect.GetInfo();
        }
    }
}