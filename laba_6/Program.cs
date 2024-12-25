using System;
using System.Collections.Generic;

namespace laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выберите номер задания (1 или 2): ");
            int taskNumber = int.Parse(Console.ReadLine() ?? "1");

            switch (taskNumber)
            {
                case 1:
                    HandleTask1();
                    break;
                case 2:
                    HandleTask2();
                    break;
                default:
                    Console.WriteLine("Неправильный номер задания.");
                    break;
            }
        }

        static void HandleTask1()
        {
            var barsik = new MeowTracker(new Cat("Барсик"));
            var vasiya = new MeowTracker(new Cat("Вася"));
            var asteroidDestroyer = new MeowTracker(new Duck("Asteroid Destroyer"));

            var animals = new List<IMeowable> { barsik, vasiya, asteroidDestroyer };

            barsik.Meow();

            MakeAllAnimalsMeow(animals, 3);

            vasiya.Meow(5);
            asteroidDestroyer.Meow();

            var trackers = new List<MeowTracker> { barsik, vasiya, asteroidDestroyer };

            PrintMeowCounts(trackers);
        }

        static void MakeAllAnimalsMeow(IEnumerable<IMeowable> animals, int times)
        {
            foreach (var animal in animals)
            {
                animal.Meow(times);
            }
        }

        static void PrintMeowCounts(List<MeowTracker> trackers)
        {
            foreach (var tracker in trackers)
            {
                Console.WriteLine($"{tracker.GetName()} meowed {tracker.GetMeowCount()} times.");
            }
        }

        static void HandleTask2()
        {
            var fraction1 = new Fraction(1, 4);
            var fraction2 = new Fraction(2, 4);
            var fraction3 = new Fraction(5, 4);

            Console.WriteLine($"{fraction1} + {fraction2} = {fraction1.Add(fraction2)}");
            Console.WriteLine($"{fraction1} - {fraction2} = {fraction1.Subtract(fraction2)}");
            Console.WriteLine($"{fraction1} * {fraction2} = {fraction1.Multiply(fraction2)}");
            Console.WriteLine($"{fraction1} / {fraction2} = {fraction1.Divide(fraction2)}");

            var result = fraction1.Add(fraction2).Divide(fraction3).Subtract(5);
            Console.WriteLine($"Result of chained operations: {result}");

            var clonedFraction = (Fraction)fraction1.Clone();
            Console.WriteLine($"Cloned fraction: {clonedFraction}");

            Console.WriteLine($"Decimal value of {fraction1}: {fraction1.ToDecimal()}");
        }
    }
}
