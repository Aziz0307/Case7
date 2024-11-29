using System;

namespace Case7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - killogram");
            Console.WriteLine("2 - milligram");
            Console.WriteLine("3 - gramm");
            Console.WriteLine("4 - tonna");
            Console.WriteLine("5 - centner");
            Console.WriteLine("Vibirite odnoy iz edenitsi massa:");
            int weightMeasurements = int.Parse(Console.ReadLine());
            while ((weightMeasurements < 1) || (weightMeasurements > 5))
            {
                Console.WriteLine("Vibirite odin iz variantov edinitsi massa ot 1 do 5.");
                weightMeasurements = int.Parse(Console.ReadLine());
            }

            Console.Write("Massa: ");
            double weight = double.Parse(Console.ReadLine());
            double kilogram;
            {
                switch (weightMeasurements)
                {
                    case 1:
                        kilogram = weight;
                        Console.WriteLine($"{weight} kilogram to kilogram = {kilogram} kilogram");
                        break;
                    case 2:
                        kilogram = weight / 1000000;
                        Console.WriteLine($"{weight} milligram to kilogram = {kilogram} kilogram");
                        break;
                    case 3:
                        kilogram = weight / 1000;
                        Console.WriteLine($"{weight} gram to kilogram = {kilogram} kilogram");
                        break;
                    case 4:
                        kilogram = weight * 1000;
                        Console.WriteLine($"{weight} tonna to kilogram = {kilogram} kilogram");
                        break;
                    case 5:
                        kilogram = weight * 100;
                        Console.WriteLine($"{weight} centner to kilogram = {kilogram} kilogram");
                        break;
                }

            }
        }
    }
}