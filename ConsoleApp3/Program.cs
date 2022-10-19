using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            int n = 0;
            for(int i = 0; b == true; )
            {
                Console.WriteLine("Vill du skriva in ett heltal? y/n");
                string svar = Console.ReadLine();
                if (svar == "y")
                {
                    n = int.Parse(Console.ReadLine());
                    if (n > i)
                    {
                        i = n;
                    }
                }
                else
                {
                    Console.WriteLine("Detta är det största talet du skrev: " + i);
                    b = false;
                }
            }

           
            
        }
    }
}
