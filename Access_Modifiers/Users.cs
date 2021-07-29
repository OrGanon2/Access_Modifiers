using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{

    class Users
    {
        string Username;
        string Password;
        bool Islogin;
        public premission Top;
        public enum premission
        {
            none,
            user,
            admin,
            super_admin

        }


        public Users(string username, string password, bool islogin, premission S)
        {
            Username = username;
            Password = password;
            Islogin = islogin;
            Top = S;
        }
        public static Users[] Arr = new Users[3];
        public static premission Login(string Username, string password)
        {

            for (int i = 0; i < Arr.Length; i++)
            {
                if (Username == Arr[i].Username && password == Arr[i].Password)
                {
                    return Arr[i].Top;
                }

            }
            return premission.none;
        }
        public void Logout(string Username, string password)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Username == Arr[i].Username && password == Arr[i].Password)
                {
                     Islogin = false;
                    break;
                }

            }
           
        }
        

      
        
    }
    
}
