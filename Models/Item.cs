namespace DotNetHW2;

public class Item
{
    public string Name { get; set; }
    public double Price { get; set; }
    public Item(string name,double price)
    {
        Name = name;
        Price = price;
    }
}

public class Book : Item
{
    public string Level { get; set; }
    public Book(string name, double price,string level) : base(name, price)
    {
        Level = level;
    }
}

public class Pen : Item
{
    public string Color { get; set; }
    public Pen(string name, double price,string color) : base(name, price)
    {
        Color = color;
    }
}