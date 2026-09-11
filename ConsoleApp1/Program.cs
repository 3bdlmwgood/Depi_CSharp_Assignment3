using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void PrintHeader(string Header)
        {
            Console.WriteLine($"\n=========== {Header} ===========\n");
        }

        static void PrintLineSpace()
        {
            Console.WriteLine("\n--------------------------------------------------------\n");
        }

        private static void _PassWithValue(int value) 
        {
            value = 1000;
        }

        private static void _PassWithRef(ref int value)
        {
            value = 1000;
        }

        static void Q1()
        {
            int value = 1;

            PrintHeader("Passing By Value");
            
            Console.WriteLine($"Value Before Passing: {value}");
            
            _PassWithValue(value);

            Console.WriteLine($"Value After Passing: {value}");


            PrintHeader("Passing By Ref");
            
            Console.WriteLine($"Value Before Passing: {value}");

            _PassWithRef(ref value);

            Console.WriteLine($"Value After Passing: {value}");


        }

        private static void _PassWithValue(string value)
        {
            value = "3bdlmwgood";
        }

        private static void _PassWithRef(ref string value)
        {
            value = "3bdlmwgood";
        }

        static void Q2()
        {
            string text = "Abdallah";

            PrintHeader("Passing By Value");

            Console.WriteLine($"Value Before Passing: {text}");

            _PassWithValue(text);

            Console.WriteLine($"Value After Passing: {text}");


            PrintHeader("Passing By Ref");

            Console.WriteLine($"Value Before Passing: {text}");

            _PassWithRef(ref text);

            Console.WriteLine($"Value After Passing: {text}");

        }

        private static int _ReadNumberFromUser(int index=1)
        {
            int Number;
            bool flag;
            do
            {
                Console.Write($"Enter Number [{index}]: ");
                flag = int.TryParse(Console.ReadLine(),out Number);

            } while (!flag);

            return Number;
        }

        private static void _ReturnSumandSub4Parameters(int num1,int num2,int num3,int num4,out int sum,out int sub)
        {
            sum = num1 + num2 ;
            sub = num3 - num4 ;
        }

        static void Q3()
        {
            int num1 = _ReadNumberFromUser(1);
            int num2 = _ReadNumberFromUser(2);
            int num3 = _ReadNumberFromUser(3);
            int num4 = _ReadNumberFromUser(4);

            _ReturnSumandSub4Parameters(num1,num2,num3,num4,out int Sum , out int Sub);

            Console.WriteLine($"Sum: {num1} + {num2} = {Sum}");
            Console.WriteLine($"Sub: {num3} - {num4} = {Sub}");
        }

        private static int _ReadNumberWithoutIndex()
        {
            int Number;
            bool flag;
            do
            {
                Console.Write($"Enter Number: ");
                flag = int.TryParse(Console.ReadLine(), out Number);

            } while (!flag);

            return Number;
        }

        static void Q4()
        {
            int Number = _ReadNumberWithoutIndex();

            int Sum = 0;

            do
            {
                Sum += Number % 10;
                Number = Number / 10;
                    
            } while (Number!=0);

            Console.WriteLine($"The Sum of the Digits of the Number [{Number}]  = {Sum}");
        }

        private static bool _IsPrime(int num)
        {
            if ( num <= 1 ) return false;

            if ( num == 2 || num ==3 ) return true;
            
            for (int i = 2; i <= num / 2; i++) 
            {
                if (num % i == 0) 
                    return false;
            }

            return true;
        }

        static void Q5()
        {
            int number = _ReadNumberWithoutIndex();

            Console.WriteLine((_IsPrime(number)) ? "Prime" : "Not Prime");

        }

        static void Main(string[] args)
        {
            #region Functions

            PrintHeader("Question 1 (Value Parameters)");
            Q1();
            PrintLineSpace();

            PrintHeader("Question 2 (Ref Parameters)");
            Q2();
            PrintLineSpace();

            PrintHeader("Question 3 (4 Parameters from User)");
            Q3();
            PrintLineSpace();

            PrintHeader("Question 4 (Digits Sum)");
            Q4();
            PrintLineSpace();

            PrintHeader("Question 5 (Check Prime)");
            Q5();
            PrintLineSpace();

            PrintHeader("Question 5 (Check Prime)");
            Q6();
            PrintLineSpace();



            #endregion
        }
    }
}
