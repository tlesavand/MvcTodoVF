//using Internal;
using System;

namespace perso
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*string c = "";
            for (int i = 1; i <= 50; i++)
            {
                c += (i);
                c += "    ";
                c += ((Math.Pow(2, i) -1) % i) + "\n";
            }
            Console.WriteLine(c);*/

            /*string c = "";
            for (int i = 1; i <= 50; i++)
            {
                c += (i);
                c += "    ";
                c += ((Math.Pow(2, i) - 1) % i) + "\n";
            }
            Console.WriteLine(c);*/

            string c = "";
            for (int i = 1; i <= 50; i++)
            {
                c += (i);
                c += "    ";
                c += ((Math.Pow(2, i) -1 )% i) + "\n";
            }
            Console.WriteLine(c);

            /*Console.Write("u0 = ");
            double u0 = double.Parse(Console.ReadLine());
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());

            double tmp = u0;
            //Console.WriteLine(tmp);
            for (int i=0;i<20;i++){
                Console.WriteLine(tmp);
                tmp = 0.5*(tmp + r/tmp);
            }*/
        }
    }
}
