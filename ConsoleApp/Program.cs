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

            //IterationExamples();

            DecistionExamples2();

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

        static void IterationExamples()
        {
            Console.WriteLine("Iteracje: petle for");
            int length = 9;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("Iteracje: petle for");

            string sReadLine = "";

            Console.WriteLine("Rozpoczynam petle WHILE:....");
            int iR = 0;
            while (sReadLine.ToUpper() != "END")
            {
                iR += 1;
                Console.Write($"{iR}) Co robimy? ");
                sReadLine = Console.ReadLine();
            }


            Console.WriteLine("Rozpoczynam petle Do / While:....");
            do
            {
                iR += 1;
                Console.Write($"{iR}) Dzialamy dalej ? :P ? ");
                sReadLine = Console.ReadLine();
            }
            while (sReadLine.ToUpper() != "END");

        }

        static void DecistionExamples()
        {
            int age;
            int pelnoletnosc = 18;

            Console.WriteLine("Podja swoj wiek...");
            age = int.Parse(Console.ReadLine());
            
            if (age >= pelnoletnosc)
                Console.WriteLine("Jestes pelnoletniom osobaom");
            else
                Console.WriteLine("Niepelnoletni !");
        }

        static void DecistionExamples2()
        {
            int grade;


            Console.WriteLine("Podaj ocene od 1 do 6");
            grade = int.Parse(Console.ReadLine());

            StringBuilder ds = new StringBuilder($"\n ({grade}) Ocena ");

            switch (grade)
            {
                case 6:
                case 5:
                case 4:
                case 3:
                    ds.Append("pozytywna");
                    break;
                case 2:
                    ds.Append("dopuszczajaca");
                    break;
                case 1:
                    ds.Append("negatywana");
                    break;
            }
            ds.AppendLine("\n");
            switch (grade)
            {
                case 6:
                    ds.AppendLine(" - celujaca - ");
                    break;
                case 5:
                    ds.AppendLine(" - bardzo dobra - ");
                    break;
                case 4:
                    ds.AppendLine(" - dobra - ");
                    break;
                case 3:
                    ds.AppendLine(" - dostateczna - ");
                    break;
                case 2:
                    ds.AppendLine(" - mierna - ");
                    break;
                case 1:
                    ds.AppendLine(" - niedostateczna - ");
                    break;
            }

            Console.WriteLine(ds.ToString());

        }
    }
}
