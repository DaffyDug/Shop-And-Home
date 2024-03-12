using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        ICommandBasket[] commandBaskets = new ICommandBasket[]
        {
        new AddProduct(),
        new RemoveProduct(),
        new SendProduct()
        };
        ICommandHome[] commandHome = new ICommandHome[]
        {
        new OnSun(),
        new OffSun(),
        new Onvacuum_cleaner(),
        new water_supply(),
        new Onsignaling(),
        new order_food()
        };
        while (true)
        {
            Console.WriteLine($"1--{commandBaskets.ToString()}");
            Console.WriteLine($"2--{commandHome.ToString()}");
            Console.WriteLine($"3--Console.Clear[]");
            Console.WriteLine($"4--Console.break[]");
            int.TryParse(Console.ReadLine(), out int intvalue);
            if (intvalue == 1)
            {
                CommandBasket(commandBaskets);
            }
            else if (intvalue == 2)
            {
                CommandHome(commandHome);
            }
            else if (intvalue == 3)
            {
                Console.Clear();
            }
            else if (intvalue == 4)
            {
                break;
            }
        }
    }
    public static void CommandBasket(ICommandBasket[] commandBaskets)
    {
        for (int i = 0; i < commandBaskets.Length; i++)
        {
            Console.WriteLine($"{i + 1}--{commandBaskets[i]}");
        }
        Console.WriteLine('\n');
        int.TryParse(Console.ReadLine(), out int intvalue);
        commandBaskets[intvalue - 1].Run();
        Console.WriteLine('\n');
    }
    public static void CommandHome(ICommandHome[] commandHome)
    {
        for (int i = 0; i < commandHome.Length; i++)
        {
            Console.WriteLine($"{i + 1}--{commandHome[i]}");
        }
        Console.WriteLine('\n');
        int.TryParse(Console.ReadLine(), out int intvalue);
        commandHome[intvalue - 1].Run();
        Console.WriteLine('\n');
    }
}