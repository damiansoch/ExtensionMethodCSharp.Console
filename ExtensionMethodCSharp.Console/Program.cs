// See https://aka.ms/new-console-template for more information

public class Product
{
    public string? Name { get; set; }     
    public double Price { get; set; }
}

public class ShoppingCart
{
    public List<Product> Products { get; set; } = new List<Product>();
}

internal class Program
{
    static void Main(string[] args)
    {
        var shoppingCart = new ShoppingCart();

        shoppingCart.Products.Add(new Product
        {
            Name = "whatever",
            Price = 13.37,
        });
        shoppingCart.Products.Add(new Product
        {
            Name = "whatever1",
            Price = 0,
        });
        shoppingCart.Products.Add(new Product
        {
            Name = "whatever2",
            Price = 11,
        });
        shoppingCart.Products.Add(new Product
        {
            Name = "whatever3",
            Price = 132.37,
        });

        Console.WriteLine(shoppingCart.GetTotal(true)); 
    }
}

public static class ShoppingCArtExpentions
{
    public static double GetTotal(this ShoppingCart shoppingCart,bool inEuro)
    {
        double total = 0;   
        foreach(var product in shoppingCart.Products)
        {
            total += product.Price;
        }

        return total;
    }
}


