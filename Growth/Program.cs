using System;

namespace Growth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your height, please.");
            string height = Console.ReadLine();
            int chosenHeight = 0;
            Int32.TryParse(height, out chosenHeight);

            if ((chosenHeight >140) && (chosenHeight <150))
            {
                Console.WriteLine("You are really small, dwarf.");
            }
            else
            {
                Console.WriteLine("Wow, it's incredible!");
            }
        }
    }

}
