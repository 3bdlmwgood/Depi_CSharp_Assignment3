using System.Xml.Linq;
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


        //---------------------------------------------------------------------------------------

        enum WeekDays
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
        }

        static void Q1_()
        {
            Console.Write("All Days Week : ");

            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.Write(day + " ");
            }
        }

        struct Person
        {
            public string Name;
            public int Age;

            public Person(string Name,int Age)
            {
                this.Name = Name;
                this.Age = Age;
            }
        }

        static void Q2_()
        {
            Person[] People =
            {
                new Person("Abdallah",21),
                new Person("Mohamed",45),
                new Person("Ahmed",33)
            };

            foreach (Person person in People)
            {
                Console.WriteLine($"Name: {person.Name} - Age: {person.Age}");
            }
        }

        enum Season
        {
            Spring,Summer,Autumn,Winter
        }

        private static string _ReadSeasonFromUser()
        {
            string Season;
            do
            {
                Console.Write($"Enter Season: ");
                Season = Console.ReadLine();
                Season.ToLower();

            } while (Season!= "spring" && Season!= "summer" && Season!="autumn" && Season !="winter");

            return Season;
        }

        private static Season _CovertTextToSeason(string season)
        {
            if (season == "summer")
                return Season.Summer;
            if (season == "winter")
                return Season.Winter;
            if (season == "spring")
                return Season.Spring;
            else
                return Season.Autumn;
        }

        private static string _ReturnRangeForSeason(Season Season)
        {
            switch (Season)
            {       
                case Season.Spring:
                    return "March to May";
                    break;
                case Season.Summer:
                    return "June to August";
                    break;
                case Season.Autumn:
                    return "September to November";
                    break;
                case Season.Winter:
                    return "December to February";
                    break;
                default:
                    return "No Range";
                    break;
            }
        }

        static void Q3_()
        {
            string seasonText = _ReadSeasonFromUser();

            Season season = _CovertTextToSeason(seasonText);

            Console.WriteLine($"{seasonText}: " + _ReturnRangeForSeason(season));

        }

        static void Q4_()
        {

        }

        enum Colors
        {
            Red,Green, Blue
        }

        private static string _ReadColorFromUser()
        {
            string Season;
            do
            {
                Console.Write($"Enter Color: ");
                Season = Console.ReadLine();
                Season.ToLower();

            } while (false);

            return Season;
        }

        static void Q5_()
        {
            string colorInput = _ReadColorFromUser();
            
            if (Enum.TryParse(colorInput,true,out Colors color))
                Console.WriteLine($"{color}: Primary Color");
            else
                Console.WriteLine($"{colorInput}: NOT Primary Color");
        }

        struct Point
        {
            public double X {  get; set; }
            public double Y { get; set; }
        }

        private static double _CalculateDistance(Point P1, Point P2)
        {
            double X_Diff = P2.X - P1.X;
            double Y_Diff = P2.Y - P1.Y;

            return Math.Sqrt((X_Diff * X_Diff) +(Y_Diff * Y_Diff));
        }

        private static double _ReadNumberForPoint(string XY)
        {
            double Number;
            bool flag;
            do
            {
                Console.Write($"{XY}:");
                flag = double.TryParse(Console.ReadLine(), out Number);

            } while (!flag);

            return Number;
        }

        static void Q6_() 
        {
            Console.WriteLine("Enter Point[1]:");
            Point P1 = new Point();
            P1.X = _ReadNumberForPoint("X");
            P1.Y = _ReadNumberForPoint("Y");


            Console.WriteLine("Enter Point[2]:");
            Point P2 = new Point();
            P2.X = _ReadNumberForPoint("X");
            P2.Y = _ReadNumberForPoint("Y");

            Console.WriteLine($"Distance = {_CalculateDistance(P1,P2)}");
            
        }

        static void RunFunctions()
        {
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
        }

        static void RunEnums_Structs()
        {
            PrintHeader("Question 1 (WeekDays Enum)");
            Q1_();
            PrintLineSpace();

            PrintHeader("Question 2 (Person Struct)");
            Q2_();
            PrintLineSpace();

            PrintHeader("Question 3 (Season Enum)");
            Q3_();
            PrintLineSpace();

            PrintHeader("Question 4 (Permissions)");
            Q4_();
            PrintLineSpace();

            PrintHeader("Question 5 (Colors Enum)");
            Q5_();
            PrintLineSpace();

            PrintHeader("Question 6 (Point Struct)");
            Q6_();
            PrintLineSpace();
        }

        static void Main(string[] args)
        {
            #region Functions
            //RunFunctions();
            #endregion


            #region Enum & Struct
            RunEnums_Structs();
            #endregion
        }
    }
}