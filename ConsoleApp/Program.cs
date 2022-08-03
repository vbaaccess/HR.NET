using System;

namespace ConsoleApp
{
    class Program
    {
        static string globalVarialbe = "Zmienna globalna";

        //static void Main(string[] args)
        static void Main()
        {
            Console.Title = "C# How To";
            MainArgs();
            PrintDataTypes();

            Console.ReadLine();
            
        }

        // Basic Consol IO
        static void MainArgs()
        {
            string[] EnvironmentArgs = Environment.GetCommandLineArgs();
            int args_count = EnvironmentArgs.Length;

            Console.WriteLine(EnvironmentArgs[0]);

            if (args_count > 1)
            {
                Console.WriteLine("Environment Command Line Args({0}):", args_count-1);
                for (int argLp = 1; argLp < args_count; argLp++)
                    Console.WriteLine($"{argLp}: {EnvironmentArgs[argLp]}");
                
            } else
                Console.WriteLine($"not given");

        }

        // Basic Data Types
        static void PrintDataTypes()
        {
            LocalVarDeclaration();
            Console.WriteLine($"\nglobalVarialbe: {globalVarialbe}");
            
        }

        static void LocalVarDeclaration()
        {
            Console.WriteLine("\nLocal variable from LocalVarDeclaration()");
            int myInt = 123;
            double myDouble = 34.546;
            char myChar = 'X';
            string myString = "Cial italia";

            Console.WriteLine($" myInt: {myInt} \n myDouble: {myDouble} \n myChar: {myChar} \n myString: {myString} \n");

            DateTime dt = new DateTime(2022, 08, 06);
            Console.WriteLine($"    dt: {dt}");
            dt = DateTime.Today;
            Console.WriteLine($" Today: {dt}");
            dt = DateTime.Now;
            Console.WriteLine($"   Now: {dt}");

            TimeSpan ts = new TimeSpan(14, 15, 49);
            Console.WriteLine($"     TimeSpan: {ts}");
            Console.WriteLine($" TotalMinutes: {ts.TotalMinutes}");
        }
    }
}
