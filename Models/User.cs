namespace DotNetHW2;

public class User 
{
    public string Name { get; set; }
    public string Id { get; set; }
    public string Type { get; set; }
    public double Money { get; set; }
    public List<Item> Items { get; set; }

    public User(string name,string id,string type,double money,List<Item> items)
    {
        Name = name;
        Id = id;
        Type = type;
        Money = money;
        Items = items;
    }
}