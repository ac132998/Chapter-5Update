using System;

namespace DisplayMulitplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
       
            for (int i = 1; i < 11; ++i)
            {
               

                for (int m = 1; m < 11; ++m)
                {
                   if (m == 10)
                   {
                      Console.WriteLine(" {0}", i * m);
                   }
                   else
                    {
                        Console.Write(" {0} ", i * m);
                    }
                }
                
            }
            


        }
    }
}
