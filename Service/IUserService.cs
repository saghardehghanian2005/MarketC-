using DotNetHW2;

namespace Service;

public interface IUserService
{
    public User Register(string name, string id, string type);

    public User Login(string name, string id);

    public User ChangeTheInformation(User user, string name, double money, string id);
}