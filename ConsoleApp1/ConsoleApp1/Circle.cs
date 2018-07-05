using System;

namespace ConsoleApp1
{
    class Circle : Motion
    {
        public void Roll(int times)
        {
            //throw new NotImplementedException();
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine("Rolling: " + (i + 1));
            }
        }
    }
}
