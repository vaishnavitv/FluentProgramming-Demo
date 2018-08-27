using System;

namespace FluentProgramming_Demo
{

    class Program
    {
        static void Main(string[] args)
        {
            //Fluent Pattern
            var finalList = new ListBuilder<int>()
                .AddItem(1)
                .AddItem(2)
                .AddItem(1000)
                .RemoveItem(2)
                .ToList();

            foreach (var item in finalList)
            {
                Console.WriteLine($"{item}");
            }

            //Builder Pattern
            var marutiZen = Car.BasicCar();
            var marutiZenAdvanced = Car.BasicCar().SetModel("Zen Advanced");
            var bmwX3 = Car.BasicCar().SetMake("BMW").SetModel("X3");
            Console.WriteLine(marutiZen);
            Console.WriteLine(marutiZenAdvanced);
            Console.WriteLine(bmwX3);

            Console.ReadLine();
        }


    }
}
