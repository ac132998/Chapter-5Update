using System;

namespace DisplayMulitplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int product;
            

            for (int i = 1; i < 11; ++i)
            {
                for (int m = 1; m < 11; ++m)
                {
                    product = i * m;
                    Console.Write(product + " ");
                    

                }
            }


        }
    }
}
