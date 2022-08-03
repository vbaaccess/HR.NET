using System;

namespace ConsoleApp
{
    class Program
    {
        //static void Main(string[] args)
        static void Main()
        {
            Console.Title = "C# How To";
            MainArgs();

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
    }
}
