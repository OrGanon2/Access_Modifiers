using System;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //People p1 = new People(054345312, "luffy");
            //People p2 = new People(054395096, "sakura sucks");
            //People p3 = new People(054903821, "Orochimaru Is Gay");
            //People p4 = new People(052309403, "dickflamingo");
            //People p5 = new People(052590695, "Eren ya yeger");
            //People p6 = new People(054504902, "david");
            //People p7 = new People(049504932, "daniel");
            //People p8 = new People(054309209, "ravid");
            //People p9 = new People ( 05432412, "shoko" );
            //People p10 = new People(054092092, "dodik");

            Users.Arr[0] = new Users("shokolita","Shukakuuu", true,Users.premission.super_admin);
            Users.Arr[1] = new Users("davidov", "KakiMaster29", true, Users.premission.admin);
            Users.Arr[2] = new Users("Bambale", "Kurammaaa", true, Users.premission.user);

            Console.WriteLine(Users.Login("Bambale", "Kurammaaa")); 
           
        }
    }
}
