using System;

namespace MenuShellHemma.View
{
    class VeterinaryMainView
    {
        public virtual void Display()
        {
            Console.WriteLine("Welcome Veterinary!");
            Console.WriteLine();
            Console.WriteLine("(1) Add appointment");
            Console.WriteLine("(2) Search appointment");
            Console.WriteLine("(3) Logout");
            Console.WriteLine("(4) Exit");
        }
    }
}
