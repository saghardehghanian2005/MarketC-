using DotNetHW2;
using Service;
using Xunit;

namespace ServiceTest;

public class UserServiceTest
{
    private UserService _sut;

    public UserServiceTest()
    {
        _sut = new UserService();
    }

    [Fact]
    public void RegisterTest()
    {
        User userR = new User("Saghar","1384","Adi",0,new List<Item>());
        User user = _sut.Register("Saghar","1384","Adi");
        Assert.Equal(userR,user);
    }
    [Fact]
    public void LoginTest()
    {
        User user = new User("Sahar","1380","Adi",0,new List<Item>());
        string r = _sut.Login(user.Name,user.ID);
        Assert.Equal("Login wasn't s",r);
    }
    [Fact]
    public void ChangeTheInformationTest()
    {
        User user = new User("Sahar","1380","Adi",20,new List<Item>());
        User userR = _sut.ChangeTheInformation(user,"Sahar",20,"1380");
        Assert.Equal(userR,user);
    }
}