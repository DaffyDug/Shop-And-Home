class HomeManager
{
    public static readonly HomeManager homeManager;
    private HomeManager()
    { }
    static HomeManager()
    {
        homeManager = new HomeManager();
    }
    List<ICommandHome> Icommands = new List<ICommandHome>()
    {
        new OnSun(),
        new OffSun(),
        new Onvacuum_cleaner(),
        new water_supply(),
        new Onsignaling(),
        new order_food()
    };
    public void RunCommand<T>() where T : ICommandHome
    {
        foreach (var item in Icommands)
        {
            if (item.GetType() == typeof(T))
            {
                item.Run();
                break;
            }
        }
    }
}
class OnSun : ICommandHome
{
    public void Run()
    {
        Console.WriteLine("свет включился");
    }
}
class OffSun : ICommandHome
{
    public void Run()
    {
        Console.WriteLine("свет выключился");
    }
}
class Onvacuum_cleaner : ICommandHome
{
    public void Run()
    {
        Console.WriteLine("пылесос работает");
    }
}
class water_supply : ICommandHome
{
    public void Run()
    {
        Console.WriteLine("подача воды");
    }
}
class Onsignaling : ICommandHome
{
    public void Run()
    {
        Console.WriteLine("сигнализация включена");
    }
}
class order_food : ICommandHome
{
    public void Run()
    {
        Console.WriteLine("еда заказана");
    }
}