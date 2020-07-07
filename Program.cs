using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IQTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IQ Test");
            Thread.Sleep(5000);
            Console.WriteLine("Just Type 'y' for Yes or 'n' for Not");
            Console.WriteLine("READY?");
            string YesorNo = Console.ReadLine();
            if (YesorNo == "y")
            {
                Console.WriteLine("OK LET'S GO");
                Thread.Sleep(5000);
            }
            if (YesorNo == "n")
            {
                Console.WriteLine("now the program exits");
                Thread.Sleep(5000);
            }
            // Please Replace The Question
            string q1 = ("you are Human?");
            string q2 = ("Custom Question true");
            string q3 = ("Custom Question true");
            string q4 = ("Custom Question false");
            string q5 = ("Custom Question false");
            string q6 = ("Custom Question true");
            string q7 = ("Custom Question true");
            string q8 = ("Custom Question False");
            string q9 = ("Custom Question False");
            string q10 = ("Custom Question true");
            // Assign Point Of A Question
            int point = 1;
           //Start The Quiz
            Console.WriteLine(q1);
            string YesorNo1 = Console.ReadLine();
            //Simple Change y To n If Your Question Is False
            if (YesorNo1 == "y")

            {
                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
                
            }

            else

            {
                Console.WriteLine("Not ... your point"+ -point--);
                Thread.Sleep(2000);

            }

            Console.WriteLine(q2);

            string YesorNo2 = Console.ReadLine();
            if (YesorNo2 == "y")
            {

                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
            }

            else

            {
                Console.WriteLine("Not ... your point" + -point--);
                Thread.Sleep(2000);

            }
            Console.WriteLine(q3);

            string YesorNo3 = Console.ReadLine();
            if (YesorNo3 == "y")
            {
                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
            }
            
            else

            {
  
                Console.WriteLine("Not ... your point" + -point--);
                Thread.Sleep(2000);

            }
            Console.WriteLine(q4);
            
            string YesorNo4 = Console.ReadLine();
            if (YesorNo4 == "n")
            {
                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
            }

            else

            {
                Console.WriteLine("Not ... your point" + -point--);
                Thread.Sleep(2000);

            }
            
            Console.WriteLine(q5);

            string YesorNo5 = Console.ReadLine();
            if (YesorNo5 == "n")
            {
           
                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
            }

            else

            {
                Console.WriteLine("Not ... your point" + -point--);
                Thread.Sleep(2000);

            }

            Console.WriteLine(q6);

            string YesorNo6 = Console.ReadLine();
            if (YesorNo6 == "y")
            {
                
                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
            }

            else

            {
                Console.WriteLine("Not ... your point" + -point--);
                Thread.Sleep(2000);

            }

            Console.WriteLine(q7);

            string YesorNo7 = Console.ReadLine();
            if (YesorNo7 == "y")
            {
                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
            }

            else

            {
                Console.WriteLine("Not ... your point" + -point--);
                Thread.Sleep(2000);

            }

            Console.WriteLine(q8);


            string YesorNo8 = Console.ReadLine();
            if (YesorNo8 == "n")
            {

                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
            }

            else

            {
                Console.WriteLine("Not ... your point" + -point--);
                Thread.Sleep(2000);

            }

            Console.WriteLine(q9);

            string YesorNo9 = Console.ReadLine();
            if (YesorNo9 == "n")
            {
                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
            }

            else

            {
                Console.WriteLine("Not ... your point" + -point--);
                Thread.Sleep(2000);

            }

            Console.WriteLine(q10);
            string YesorNo10 = Console.ReadLine();
            if (YesorNo10 == "y")
            {
                Console.WriteLine("OK ... your point" + point++);
                Thread.Sleep(2000);
            }

            else

            {
                Console.WriteLine("Not ... your point" + -point--);
                Thread.Sleep(2000);

            }

            //Sum all Point
            int qallpoint = point;
            Console.WriteLine("... your Total point  " + qallpoint);
            Thread.Sleep(9000);
        }
    }
}
