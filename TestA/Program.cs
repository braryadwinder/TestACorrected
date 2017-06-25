using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*****************************************************
**              Welcome To Simple Test 1 Version A  
**              Name:
**              ID:
**              Advice: Capitalization matters, CLEAN CODE MATTERS !!!!!!
******************************************************/

namespace TestA
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run Tests by");
            Console.WriteLine("Top Menu: Test->Run->All Test");
            Console.WriteLine("Shortcut Key: Ctrl+R, A");

            Console.ReadKey();
        }

        static public bool IsEven(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false; 
        }

        static public string NoiseFrom(string animal)  
        {
            if (animal == "Cow")
            {
                return "moooo";
            }
            else if (animal == "Cat")
            {
                return "meow";
            }
            else if (animal == "Dog")
            {
                return "wouf";
            }
            else
            {
                return "meh";
            }

            //Cow will say "moooo"
            //Cat will say "meow"
            //Dog will say "wouf"
            //All other animasl would "meh"

        }

        static public int Limitations(int value)
        {
            if (value >= 1 && value <= 10)
                return 1;
            else if (value == 13 || value == 21 || value == 64)
                return 2;
            else
                return 3;
            //1 for values between 1 to 10 inclusif. 
            //2 for values 13, 21, 64
            //3 for rest
        }

        static public string Ask(string question)  
        {
            Console.Write(question);
            return Console.ReadLine();
            //Ask user the Question 
            //return the users answer
            
        }

        static public int AddTo(int max)                   //MUST BE LOOPS
        {
            int total = 0;
            for (int i = 1; i <= max; i++)
            {
                Console.Write(i + " + ");
            }
            return total;
            //Add from 0 to max number
            //Example: if max=10 then add 1 + 2+3+4+5+6+7+8+9+10 +  then return that value
        }

        static public int RecursiveMultiply(int max)       //MUST BE RECURSIVE !!!!!!!!!!!!
        {
            if (max == 1)
                return 1;

            return max * RecursiveMultiply(max - 1);
            //Recurively Multiply from max.
            //Example: if max=10 then you 1*2*3*4*5*6*7*8*9*10 then return that value

        }

    }
}
