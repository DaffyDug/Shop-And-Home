class BasketManager
{
    public static readonly BasketManager basketManager;
    List<Product> products = new List<Product>();
    List<Product> products_Basket = new List<Product>();
    private BasketManager()
    { }
    static BasketManager()
    {
        basketManager = new BasketManager();
    }
    public void Add(Product product)
    {
        products.Add(product);
    }
    public void Remuve(Product product)
    {
        foreach (var item in products)
        {
            if (item.Name_Produrt == product.Name_Produrt)
            {
                products.Remove(product);
            }
        }
        products.Remove(product);
    }
    public void Send(Product product)
    {
        products_Basket.Add(product);
    }
}
class Product
{
    public string Name_Produrt { get; }
    private double Price;
    public Product(string name_product, double price)
    {
        Name_Produrt = name_product;
        Price = price;
    }
}
class AddProduct : ICommandBasket
{
    public void Run()
    {
        BasketManager.basketManager.Add(new Product("", 123));
        Console.WriteLine("продукт добавлен");
    }
}
class RemoveProduct : ICommandBasket
{
    public void Run()
    {
        BasketManager.basketManager.Remuve(new Product("", 123));
        Console.WriteLine("продукт удален");
    }
}
class SendProduct : ICommandBasket
{
    public void Run()
    {
        BasketManager.basketManager.Send(new Product("", 123));
        Console.WriteLine("продукт добавлен в корзину");
    }
}
