using System;

namespace InterfacePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat antonio = new Cat("Antonio Banderas", "ginger", 8, false);
            antonio.Eat();

            Dog max = new Dog("Max", "White with brown spots", "JackRussell Terrier");
            max.Eat();
        }
    }
}
