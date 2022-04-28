using System;
namespace InterfacePractice
{
    // Create the IFeedable interface
    // Follow the book to see what methods to put into the IFeedable interface
    // Have the Cat class implement the IFeedable interface
    // Implement the necessary methods defined in the interface
    public class Cat : IFeedable
    {


        // This is an empty constructor, can be ignored for now
        public string Name { get; set; }
        public string Color { get; set; }
        public int Snuggleability { get; set; }
        public bool IsChonk { get; set; }

        public Cat(string name, string color, int snuggleability, bool isChonk)
        {
            Name = name;
            Color = color;
            Snuggleability = snuggleability;
            IsChonk = isChonk;
        }
        public void Eat()
        {
            Console.WriteLine("nya nya nya");
        }
    }
}
