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

        static void Main(string[] args)
        {
            #region Functions

            PrintHeader("Question 1 (Value Parameters)");
            Q1();
            PrintLineSpace();

            PrintHeader("Question 2 (Ref Parameters)");
            Q2();
            PrintLineSpace();



            #endregion
        }
    }
}
