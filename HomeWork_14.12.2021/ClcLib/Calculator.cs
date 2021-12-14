using System;

namespace ClcLib
{
    public class Calculator
    {
        public void ClcMetod()
        {
            Console.WriteLine("\nUzerinde riyazi emeliyyatlar aparmaq ucun ededleri ve riyazi emeliyyatlarin acar karakterlerini daxil edin:");
            double result = 0;
            Console.Write("       1 ci ededi daxil edin: ");
            double n = int.Parse(Console.ReadLine());

            Console.Write("riyazi emeliyyati daxil edin: ");
            char op = char.Parse(Console.ReadLine());

            Console.Write("       2 ci ededi daxil edin: ");
            double m = int.Parse(Console.ReadLine());



            switch (op)

            {

                case '+':
                    result = n + m;
                    Console.WriteLine($"       Cavab: {n}+{m}=" + result); break;
                case '-':
                    result = n - m;
                    Console.WriteLine($"       Cavab: {n}-{m}=" + result); break;
                case '*':
                    result = n * m;
                    Console.WriteLine($"       Cavab: {n}*{m}=" + result); break;
                case '/':
                    result = n / m;
                    Console.WriteLine($"       Cavab: {n}/{m}=" + result); break;

                default:
                    Console.WriteLine("       Duzgun emeliyyat daxil etmediniz\n");
                    break;

            }
            Console.ReadLine();


        }

    }
}
