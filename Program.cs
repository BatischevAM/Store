using Магазин;

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Toy("Игрушечный автомобиль", 100, 3),
            new Meat("Говядина", 500, 1.5),
            new Drink("Кока-Кола", 50, 500),
            new Clothing("Футболка", 300, "M"),
            new Hardware("Видеокарта", 4000, "4090ti")
        };

        foreach (Product product in products)
        {
            Console.WriteLine(product.GetInformation());
        }
    }
}
