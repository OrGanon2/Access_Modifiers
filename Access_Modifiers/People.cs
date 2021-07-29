using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers
{
    class People
    {
        readonly int id;
        private int phone;
        private string name;
        private static int NumberOfFAMILYS;

        public People(int phone, string name)
        {
            this.phone = phone;
            this.name = name;
            NumberOfFAMILYS++;
            id = NumberOfFAMILYS;
        }
        public static void ChangeName(People P, string name)
        {
            P.name = name;

        }
        public static void ChangePhone(People P, int phone)
        {
            P.phone = phone;

        }
    }
}
