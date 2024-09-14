using DotNetHW2;

namespace Service;

public class UserService
{
    private List<User> users = new List<User>();
    public List<User> Users { get; set; } 

    public User Register(string name,string id,string type)
    {
        User user = new User(name,id,type,0,new List<Item>());
        users.Add(user);
        Users = users;
        return user;
    }
    public User Login(string name,string id)
    {
        User u = null;
        foreach (User user in users)
        {
            if (user.Name==name && user.Id==id)
            {
                u = user;
                break;
            }   
        }

        return u;
    }
    public User ChangeTheInformation(User user,string name,double money,string id)
    {
        if (user!=null)
        {
            users.Remove(user);
            User user1 = new User(name,id,user.Type,money,user.Items);
            users.Add(user1);
            Users = users;
            return user1;
        }
        else
        {
            return null;
        }
    }
}