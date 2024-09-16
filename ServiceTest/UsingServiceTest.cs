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
    public Boolean LoginTest1()
    {
        User u = new User("Sahar","1380","Adi",0,new List<Item>());
        _sut.Register("Sahar","1380","Adi");
        User userR = _sut.Login(u.Name,u.Id);
        bool Found = false;
        if(u.Name.Equals(userR.Name) && u.Id.Equals(userR.Id) && u.Money.Equals(userR.Money) && u.Items.Equals(userR.Items)&& u.Type.Equals(userR.Type))
        {
            Found = true;
        }
        return Found;
    }
    
    [Fact]
    public Boolean LoginTest2()
    {
        User u = new User("Sara","1380","Adi",0,new List<Item>());
        //_sut.Register("Sahar","1380","Adi");
        User userR = _sut.Login(u.Name,u.Id);
        bool notFound = true;//;کاربر پیدا نشد
        if (userR == null) ;
        else if(u.Name.Equals(userR.Name) && u.Id.Equals(userR.Id) && u.Money.Equals(userR.Money) && u.Items.Equals(userR.Items)&& u.Type.Equals(userR.Type))
        {
            notFound = false;
        }
        return notFound;
    }
    
    [Fact]
    public Boolean ChangeTheInformationTest1()
    {
        User user = new User("Saghar","1384","Adi",80,new List<Item>());
        User u = _sut.ChangeTheInformation(user,"Sahar",20,"1380");
        bool UserFound = false;
        if(u.Name.Equals("Sahar") && u.Id.Equals("1380") && u.Money.Equals(20) && u.Items.Equals(u.Items)&& u.Type.Equals("Adi"))
        {
            UserFound = true;
        }
        return UserFound;
    }
    
    [Fact]
    public Boolean ChangeTheInformationTest2()
    {
        User user = new User("Maryam","1384","Adi",80,new List<Item>());
        User u = _sut.ChangeTheInformation(user,"Sahar",20,"1380");
        bool UserNotFound = true;
        if (u.Equals(null)) ;
        else if(u.Name.Equals("Sahar") && u.Id.Equals("1380") && u.Money.Equals(20) && u.Items.Equals(u.Items)&& u.Type.Equals("Adi"))
        {
            UserNotFound = false;
        }
        return UserNotFound;
    }
}