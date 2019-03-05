/*
 
            Пример менеджера звуков
 *     
            SoundManager soundManager = new SoundManager();          

            Console.WriteLine(SoundManager.Instance.GetSound("sound 1"));
       
 *
 * 
 */

using System;

namespace ProgrammingPatters.Patterns.Creational
{
    class SingletonException : Exception
    {
        public SingletonException(string message):base(message)
        {   }
    }
    
    public class SoundManager
    {
        public static SoundManager Instance;
        
        public SoundManager()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                throw new SingletonException("Нельзя создавать несколько экземпляторов данного класса");
            }
        }

        public string GetSound(string sound) => $"Sound {sound}";
    }
}