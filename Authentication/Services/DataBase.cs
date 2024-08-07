using Authentication.Models;

namespace Authentication.Services;

public static class DataBase
{
    public static List<User>? Users { get; set; }
    
    static DataBase()
    {
        Users = new List<User>()
        {
            new User("User1",10,"user1@gmail.com","1234")
        };
    }

}
