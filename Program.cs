using System.Collections.Concurrent;

namespace Variable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 3;
            char x = 'a';
            double p = 5.5;
            string o = "hello";
            bool b = false;*/
            //Console.WriteLine(a);
            //Console.WriteLine(x);
            //Console.WriteLine(o);
            //Console.WriteLine(b);
            //Console.WriteLine(p);
            // Console.WriteLine( x + "      " + a);
            // Console.WriteLine( x+ "      " + a + "      " + p  );
            // Console.WriteLine("Ans=  " + a * p);


            //Q2: write a program to swap ?
            int a = 5;
            int b = 3;
            (a, b) = (b, a);
            Console.WriteLine(" a = " + a);
            Console.WriteLine(" b = " + b);

            //**************************
           

            string c = "Hello";
            string d = "World";
            (c , d) = (d, c);

            Console.WriteLine("*****************************");
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}