using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool gender = true;
            //NB ! means not or negations
            if (!gender)
            {
                Console.WriteLine("Female");

            }
            else
            {
                Console.WriteLine("Male");
            }
            Console.Read();



            bool isMale = true;
            if (isMale)
            {
            Console.WriteLine("You are male");
            }
            else 
            {
                Console.WriteLine("You are female");
            }
            //can also test two conditions that is && in C#, or it is ||
            bool isTall = false;
            if (isTall && isMale)
            {
                Console.WriteLine("You are both male and tall");
            }
            else if (!isTall && isMale)

            {
                Console.WriteLine("You are not tall but you are male");
            }
            else
            {
                Console.WriteLine("You are either not tall or not male");
                               
            }
        }
       
    }
}
