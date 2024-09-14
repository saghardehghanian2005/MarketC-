using DotNetHW2;
using Service;

class Program
{
    static User user;
    static void Main(string[] args)
    {
        User admin = new User("Saghar","1384","Admin",200,new List<Item>());
        Item item;
        string[] dastor2,dastor3;
        UserService userService = new UserService();
        ItemService itemService = new ItemService();
        Console.WriteLine("Please enter a number of dastor you want     1.Register     2.Login    exit");
        string dastor = Console.ReadLine();
        while (dastor!="exit")
        {
            switch (dastor)
            {
                case "1": Console.WriteLine("Please enter your name and your ID ");
                    string[] dastor1= Console.ReadLine().Split(' ');
                    user = userService.Register(dastor1[0],dastor1[1],"Adi");
                    Console.WriteLine("Please enter a number of dastor you want     1.Login     exit");
                        dastor= Console.ReadLine();
                    switch (dastor)
                        {
                            case "1":
                                Console.WriteLine("Please enter your name and your ID ");
                                dastor2 = Console.ReadLine().Split(' ');
                                bool B = Login(dastor2, userService);
                                if (B)
                                {
                                    dastor = Console.ReadLine();
                                    while (dastor != "exit")
                                    {
                                        switch (dastor)
                                        {
                                            case "1":
                                                Console.WriteLine("Please enter your name, your money and your ID ");
                                                dastor3 = Console.ReadLine().Split(' ');
                                                userService.ChangeTheInformation(user, dastor3[0], Convert.ToDouble(dastor3[1]), dastor3[2]);
                                                dastor = Console.ReadLine();
                                                break;
                                            case "2":
                                                Console.WriteLine("Please enter your item's name and this price");
                                                dastor3 = Console.ReadLine().Split(' ');
                                                item = new Item(dastor3[0], Convert.ToDouble(dastor3[1]));
                                                Console.WriteLine(itemService.BuyItem(item, user));
                                                dastor = Console.ReadLine();
                                                break;
                                            case "3":
                                                Console.WriteLine("Please enter your item's name and this price");
                                                dastor3 = Console.ReadLine().Split(' ');
                                                item = new Item(dastor3[0], Convert.ToDouble(dastor3[1]));
                                                Console.WriteLine(itemService.Add(item, user));
                                                dastor = Console.ReadLine();
                                                break;
                                            case "4":
                                                Console.WriteLine("Please enter your item's name and this price");
                                                dastor3 = Console.ReadLine().Split(' ');
                                                item = new Item(dastor3[0], Convert.ToDouble(dastor3[1]));
                                                Console.WriteLine(itemService.Remove(item,
                                                    userService.Login(dastor2[0], dastor2[1])));
                                                dastor = Console.ReadLine();
                                                break;
                                            case "exit":
                                                Environment.Exit(1);
                                                break;
                                            default:
                                                Console.WriteLine(
                                                    "Please enter a number of dastor you want     1.Register     2.Login    exit");
                                                dastor = Console.ReadLine();
                                                break;
                                        }
                                    }
                                }

                                break;
                            case "exit":
                                Environment.Exit(1);
                                break;
                            default:
                                Console.WriteLine("Please enter a number of dastor you want     1.Login     exit");
                                dastor = Console.ReadLine();
                                break;
                        }

                    break;
                case "2":Console.WriteLine("Please enter your name and your ID "); 
                    dastor2= Console.ReadLine().Split(' ');
                    bool b=Login(dastor2,userService);
                    if (b)
                    {
                        dastor = Console.ReadLine();
                        while (dastor != "exit")
                        {
                            switch (dastor)
                            {
                                case "1":
                                    Console.WriteLine("Please enter your name, your money and your ID ");
                                    dastor3 = Console.ReadLine().Split(' ');
                                    userService.ChangeTheInformation(user, dastor3[0], Convert.ToDouble(dastor3[1]),
                                        dastor3[2]);
                                    dastor = Console.ReadLine();
                                    break;
                                case "2":
                                    Console.WriteLine("Please enter your item's name and this price");
                                    dastor3 = Console.ReadLine().Split(' ');
                                    item = new Item(dastor3[0], Convert.ToDouble(dastor3[1]));
                                    Console.WriteLine(itemService.BuyItem(item, user));
                                    dastor = Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Please enter your item's name and this price");
                                    dastor3 = Console.ReadLine().Split(' ');
                                    item = new Item(dastor3[0], Convert.ToDouble(dastor3[1]));
                                    Console.WriteLine(itemService.Add(item, user));
                                    dastor = Console.ReadLine();
                                    break;
                                case "4":
                                    Console.WriteLine("Please enter your item's name and this price");
                                    dastor3 = Console.ReadLine().Split(' ');
                                    item = new Item(dastor3[0], Convert.ToDouble(dastor3[1]));
                                    Console.WriteLine(itemService.Remove(item, user));
                                    dastor = Console.ReadLine();
                                    break;
                                case "exit":
                                    Environment.Exit(1);
                                    break;
                                default:
                                    Console.WriteLine(
                                        "Please enter a number of dastor you want     1.Register     2.Login    exit");
                                    dastor = Console.ReadLine();
                                    break;
                            }
                        }
                    }
                    break;
                default:Console.WriteLine("Please enter a number of dastor you want     1.Register     2.Login    exit");
                    dastor = Console.ReadLine();
                    break;
            }
        }
    }

    static Boolean Login(string[] dastor,UserService userService)
    {
        user = userService.Login(dastor[0],dastor[1]);
        if (user!=null)
        {
            Console.WriteLine("Please enter a number of dastor you want     1.Change the information    2.Buy Item      3.Add Item     4.Remove Item");
            return true;
        }
        else
        {
            Console.WriteLine("Error");
            return false;
        }
    }
}