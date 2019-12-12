using System;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {


            string salesInitial = null;
            int sale;
            int totalsalePersonD = 0;
            int totalsalePersonE = 0;
            int totalsalePersonF = 0;
            int total = 0;

            while (salesInitial != "Z" || salesInitial != "z")
            {


                Console.WriteLine("Enter Saleperson initial D, E, or F >>> ");
                salesInitial = Console.ReadLine();
                Console.WriteLine("Enter amount sold >>> ");
                sale = Convert.ToInt32(Console.ReadLine());

                if (salesInitial == "D" || salesInitial == "d")
                {
                    totalsalePersonD = totalsalePersonD + sale;
                }
                else if (salesInitial == "E" || salesInitial == "e")
                {
                    totalsalePersonE = totalsalePersonE + sale;
                }
                else if (salesInitial == "F" || salesInitial == "f")
                {
                    totalsalePersonF = totalsalePersonF + sale;
                }

                else
                {
                    Console.WriteLine("Invalid Initial! Try Again");
                }

                total = totalsalePersonD + totalsalePersonE + totalsalePersonF;
            
                Console.WriteLine("The grand total of sales is " + total);

                if (totalsalePersonD > totalsalePersonE && totalsalePersonD > totalsalePersonF)
                {
                    Console.WriteLine("Danielle has the highest sales at " + totalsalePersonD);

                }
                else if (totalsalePersonE > totalsalePersonD && totalsalePersonE > totalsalePersonF)
                {
                    Console.WriteLine("Edward has the highest sales at " + totalsalePersonE);

                }
                else if (totalsalePersonF > totalsalePersonD && totalsalePersonF > totalsalePersonE)
                {
                    Console.WriteLine("Francis has the highest sales at " + totalsalePersonF);
                }
                else
                {
                    Console.WriteLine("All the sales people sold the same amount");
                }

            }       

        }
        
    }
}
