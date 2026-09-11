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

        private static void _ExplanisionQ1()
        {
            Console.WriteLine("\nThe idea in Value Type Passing by Value is that a copy of the value is passed," +
                "so changing the value inside the function does not change the original value." +
                "But by ref, the original variable is passed, so we can change its value.");
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

            _ExplanisionQ1 ();

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

            _ExplanisionQ2 ();

        }

        private static int _ReadNumberFromUser(int index = 1)
        {
            int Number;
            bool flag;
            do
            {
                Console.Write($"Enter Number [{index}]: ");
                flag = int.TryParse(Console.ReadLine(), out Number);

            } while (!flag);

            return Number;
        }

        private static void _ReturnSumandSub4Parameters(int num1, int num2, int num3, int num4, out int sum, out int sub)
        {
            sum = num1 + num2;
            sub = num3 - num4;
        }

        private static void _ExplanisionQ2()
        {
            Console.WriteLine("\nThe idea in Reference Type Passing by Value is that a copy of the reference is passed," +
                "so changing the reference inside the function does not change the original reference." +
                "But by ref, the original reference is passed, so we can change what the original reference refers to.");
        }

        static void Q3()
        {
            int num1 = _ReadNumberFromUser(1);
            int num2 = _ReadNumberFromUser(2);
            int num3 = _ReadNumberFromUser(3);
            int num4 = _ReadNumberFromUser(4);

            _ReturnSumandSub4Parameters(num1, num2, num3, num4, out int Sum, out int Sub);

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

        private static int _GetDigitsSum(int Number)
        {
            int Sum = 0;

            do
            {
                Sum += Number % 10;
                Number = Number / 10;

            } while (Number != 0);

            return Sum;
        }

        static void Q4()
        {
            int Number = _ReadNumberWithoutIndex();

            int Sum = _GetDigitsSum(Number);

            Console.WriteLine($"The Sum of the Digits of the Number [{Number}]  = {Sum}");
        }

        private static bool _IsPrime(int num)
        {
            if (num <= 1) return false;

            if (num == 2 || num == 3) return true;

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

        static void _MinMaxArray(int[] Arr, ref int Min, ref int Max)
        {
            for (int i = 1; i < Arr.Length; i++)
            {
                if (Arr[i] < Min)
                    Min = Arr[i];

                if (Arr[i] > Max)
                    Max = Arr[i];
            }

        }

        static void Q6()
        {
            int[] StoredArray = { 90, 50, 70, 30, 80, 100, 60, 20, 40, 10 };

            int Min = StoredArray[0], Max = StoredArray[0];

            _MinMaxArray(StoredArray, ref Min, ref Max);

            Console.Write("Array Elements : [ ");
            foreach (int element in StoredArray)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine("]\n");
            Console.WriteLine($"Minimum in Array = {Min}");
            Console.WriteLine($"Maximum in Array = {Max}");

        }

        private static int _IterativeFactorial(int number)
        {
            if (number < 0) return -1;

            if (number < 2) return 1;

            int factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static void Q7()
        {
            int number = _ReadNumberWithoutIndex();

            int factorial = _IterativeFactorial(number);

            Console.WriteLine($"Factorial for [{number}] is = {factorial}");
        }

        private static string _ChangeChar(string text, int position, char newChar)
        {
            char[] textChars = text.ToCharArray();

            textChars[position] = newChar;

            return new string(textChars);
        }

        static void Q8()
        {
            string text = "Abdallah";
            int position = 3;
            char newChar = 'u';

            string NewText = _ChangeChar(text, position, newChar);

            Console.WriteLine($"Text Before Changing: {text}");
            Console.WriteLine($"Position To Change: {position}");
            Console.WriteLine($"New Char To Change: {newChar}");
            Console.WriteLine($"Text After Changing: {NewText}");
        }

        static void Main(string[] args)
        {
            #region Functions

            PrintHeader("Question 1 (Value Type - Value vs Ref)");
            Q1();
            PrintLineSpace();

            PrintHeader("Question 2 (Reference Type - Value vs Ref)"); 
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

            PrintHeader("Question 6 (MinMaxArray)");
            Q6();
            PrintLineSpace();

            PrintHeader("Question 7 (Iterative Factorial)");
            Q7();
            PrintLineSpace();

            PrintHeader("Question 8 (Change Char)");
            Q8();
            PrintLineSpace();

            #endregion


            #region Enum & Struct

            #endregion
        }
    }
}