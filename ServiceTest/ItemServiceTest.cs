using DotNetHW2;
using Service;
using Xunit;

namespace ServiceTest;

public class ItemServiceTest
{
    private ItemService _sut;

    public ItemServiceTest()
    {
        _sut = new ItemService();
    }

    [Fact]
    public void AddTest()
    {
        string s = "You aren't admin";
        string r = _sut.Add(new Item("pen",15),new User("Saghar","45","Adi",300,new List<Item>()));
        Assert.Equal(r,s);
    }
    [Fact]
    public void RemoveTest()
    {
        string s = "You aren't admin";
        string r = _sut.Remove(new Item("pen",15),new User("Saghar","45","Adi",300,new List<Item>()));
        Assert.Equal(r,s);
    }
    [Fact]
    public void BuyItemTest()
    {
        string s = "Your money isn't enough";
        string r = _sut.BuyItem(new Item("pen",15),new User("Saghar","45","Adi",0,new List<Item>()));
        Assert.Equal(r,s);
    }
}