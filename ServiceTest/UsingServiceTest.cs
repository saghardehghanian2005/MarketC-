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
    public Boolean RegisterTest()
    {
        User userR = new User("Saghar","1384","Adi",0,new List<Item>());
        _sut.Register("Saghar","1384","Adi");
        bool B = false;
        foreach (User u in _sut.Users)
        {
            if (u.Name.Equals(userR.Name) && u.Id.Equals(userR.Id) && u.Money.Equals(userR.Money) && u.Items.Equals(userR.Items)&& u.Type.Equals(userR.Type))
            {
                B = true;
               break;
            }
        }
        return B;
    }
    [Fact]
    public Boolean LoginTest()
    {
        User u = new User("Sahar","1380","Adi",0,new List<Item>());
        _sut.Register("Sahar","1380","Adi");
        User userR = _sut.Login(u.Name,u.Id);
        bool B = false;
        if(u.Name.Equals(userR.Name) && u.Id.Equals(userR.Id) && u.Money.Equals(userR.Money) && u.Items.Equals(userR.Items)&& u.Type.Equals(userR.Type))
        {
            B = true;
        }
        return B;
    }
    [Fact]
    public Boolean ChangeTheInformationTest()
    {
        User user = new User("Saghar","1384","Adi",80,new List<Item>());
        User u = _sut.ChangeTheInformation(user,"Sahar",20,"1380");
        bool B = false;
        if(u.Name.Equals("Sahar") && u.Id.Equals("1380") && u.Money.Equals(20) && u.Items.Equals(u.Items)&& u.Type.Equals("Adi"))
        {
            B = true;
        }
        return B;
    }
}