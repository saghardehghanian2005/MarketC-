using DotNetHW2;

namespace Service;

public interface IItemService
{
    public string Add(Item item,User user);
    public string Remove(Item item,User user);
    public string BuyItem(Item item, User user);
}