using DotNetHW2;

namespace Service;

public class ItemService
{
    private List<Item> items = new List<Item>();
    public List<Item> Items { get; set; } 

    public string Add(Item item,User user)//Admin
    {
        if (user.Type=="Admin")
        {
            items.Add(item);
            Items = items;
            return "Add was success";   
        }
        else
        {
            return "You aren't admin";
        }
    }
    public string Remove(Item item,User user)//Admin
    {
        if (user.Type=="Admin")
        {
            items.Remove(item);
            Items = items;
            return "Remove was success";   
        }
        else
        {
            return "You aren't admin";
        }
    }
    public string BuyItem(Item item,User user)
    {
        if (item.Price<=user.Money)
        {
            user.Items.Add(item);
            Items = items;
            return "Success";   
        }
        else
        {
            return "Your money isn't enough";
        }
    }
}