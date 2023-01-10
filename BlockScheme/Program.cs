using System.Runtime.CompilerServices;

internal class Program
{
    public static User[] userList;
    static void Main(string[] args)
    {
        userList = new User[0];
        Start();
    }

    public static void Start()
    {
        Console.WriteLine("Добрый день, введите ваш логин:");
        string enterLogin = Console.ReadLine();
        bool userTrue = UserCheck(enterLogin);
        UserManager.UserIsInList(userList, userTrue, enterLogin);
    }

    static bool UserCheck(string userName)
    {
        foreach (var user in userList)
        {
             if (user.Login == userName)
             {
                 return true;
             }  
        }        
        return false;
    }
}
 