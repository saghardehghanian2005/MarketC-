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
    public void AddTest1()
    {
        string s = "You aren't admin";
        string r = _sut.Add(new Item("pen",15),new User("Saghar","45","Adi",300,new List<Item>()));
        Assert.Equal(r,s);
    }
    
    [Fact]
    public void AddTest2()
    {
        string s = "Add was success";
        string r = _sut.Add(new Item("pen",15),new User("Saghar","45","Admin",300,new List<Item>()));
        Assert.Equal(r,s);
    }
    
    [Fact]
    public void RemoveTest1()
    {
        string s = "You aren't admin";
        string r = _sut.Remove(new Item("pen",15),new User("Saghar","45","Adi",300,new List<Item>()));
        Assert.Equal(r,s);
    }
    
    [Fact]
    public void RemoveTest2()
    {
        string s = "Remove was success";
        string r = _sut.Remove(new Item("pen",15),new User("Saghar","45","Admin",300,new List<Item>()));
        Assert.Equal(r,s);
    }
    
    [Fact]
    public void BuyItemTest1()
    {
        string s = "Your money isn't enough";
        _sut.Add(new Item("pen",15),new User("Saghar","45","Admin",300,new List<Item>()));
        string r = _sut.BuyItem(new Item("pen",15),new User("Saghar","45","Adi",0,new List<Item>()));
        Assert.Equal(r,s);
    }
    
    [Fact]
    public void BuyItemTest2()
    {
        string s = "Error";
        _sut.Add(new Item("pen",15),new User("Saghar","45","Admin",300,new List<Item>()));
        string r = _sut.BuyItem(new Item("book",30),new User("Saghar","45","Adi",0,new List<Item>()));
        Assert.Equal(r,s);
    }
    
    [Fact]
    public void BuyItemTest3()
    {
        string s = "Success";
        _sut.Add(new Item("pen",15),new User("Saghar","45","Admin",300,new List<Item>()));
        string r = _sut.BuyItem(new Item("pen",15),new User("Saghar","45","Adi",30,new List<Item>()));
        Assert.Equal(r,s);
    }
}