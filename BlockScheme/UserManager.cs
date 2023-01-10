class UserManager
{
    
    public static void UserIsInList(User[] users, bool userTrue, string enterLogin)
    {
        if (userTrue)
        {
            int userDataBase = MassiveFounder(enterLogin, users);
            Console.WriteLine("Здраствуйте, " + users[userDataBase].Name);
            if (users[userDataBase].IsPremium)
            {
                Console.WriteLine("Добро пожаловать, у вас подключен премиум аккаунт, программа запущена");
                Program.Start();
            }
            else
            {
                Ads.ShowAds();
                Program.Start();
            }
        }
        else CreateUser(enterLogin, users);
    }
    public static void CreateUser(string login, User[] users)
    {
        User[] newList = users;
        users = new User[newList.Length + 1];
        if (newList.Length > 0)
        {
            for (int i = 0; i < users.Length-1; i++)
            {
                users[i] = newList[i];
            }
        }
        users[users.Length - 1] = new User();
        users[users.Length - 1].Login = login;
        Console.WriteLine("Введите своё имя");
        users[users.Length - 1].Name = Console.ReadLine();        
        Console.WriteLine("Хотите ли вы подключить премиум аккаунт? (Да/Нет)");
        users[users.Length - 1].IsPremium = PremiumCheck(Console.ReadLine());
        Program.userList = users;
        Program.Start();
    }

    public static int MassiveFounder(string login, User[] users)
    {
        for(int i = 0; i < users.Length; i++)
        {
            if (users[i].Login == login)
                return i;   
        }
        return -1;
    }

    static bool PremiumCheck(string answer)
    {
        if(answer == "да" || answer == "Да")
            return true;
        else return false;
    }
}
 