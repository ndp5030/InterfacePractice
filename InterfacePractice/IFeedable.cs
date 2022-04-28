using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePractice
{

    public interface IFeedable
    {
        void Eat();
        void Nap()
        {
            Console.WriteLine("snooooozzze");
        }
    }
}
