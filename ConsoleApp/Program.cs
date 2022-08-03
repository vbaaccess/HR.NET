using System;
using System.Text;

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

            SystemStringTypesExamples();

            TypeConversions();

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

            Console.WriteLine($" Czy {dt} nalezy do czasu lteniego? {dt.IsDaylightSavingTime()}");

            TimeSpan ts = new TimeSpan(14, 15, 49);
            Console.WriteLine($"     TimeSpan: {ts}");
            Console.WriteLine($" TotalMinutes: {ts.TotalMinutes}");
        }

        static void SystemStringTypesExamples()
        {
            StringBuilder sb = new StringBuilder("\nLista filmow:");
            sb.Append("\n");
            sb.AppendLine("Breaking bad");
            sb.AppendLine("Fundacja");
            sb.AppendLine("God place");
            sb.AppendLine("Animki");
            Console.WriteLine(sb.ToString());
            sb.Replace("place", "Home");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("Ilosc znakowa: {0}", sb.Length);
        }

        static void TypeConversions()
        {
            short number1 = 30000;
            short number2 = 30000;
            short result = (short)Add(number1, number2);                // Jawne rzutowanie typu int na short

            Console.WriteLine($"Add {number1} + {number2} = {result}");

            ProcessBytes();
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void NarrowingAttempt(int x, int y)
        {
            byte myByte = 0;
            int myInt = 200;
            myByte = (byte)myInt;                                       // Jawne rzutowanie typu int na byte
            Console.WriteLine($"Wartosc myByte: {myByte}");
        }

        static void ProcessBytes()
        {
            byte sum;
            byte b1 = 100;
            byte b2 = 200;

            unchecked
            //checked 
            {

                sum = (byte)Add(b1, b2);
                Console.WriteLine($"suma = {sum}");
            }

            //sum = checked((byte)Add(b1, b2));
        }
    }
}
