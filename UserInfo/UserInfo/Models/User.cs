using System;
using System.Collections.Generic;
using System.Text;

namespace UserInfo.Models
{
    internal class User
    {
        public string UserName;
        private int Age;
        private string Password;

        public User(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }

        public int age 
        {
            get 
            {
                return Age;
            }
            set
            {
                if(value >= 0)
                    Age = value;
                else
                    Console.WriteLine("DIQQET!!! Yash menfi ola bilmez.");
            } 
        }

        public string password 
        {
            get
            {
                return Password;
            }
            set
            {
                if(value != null && value.Length >= 8 )
                    Password = value;
                else
                    Console.WriteLine("Password en azi 8 simvoldan olmalidir!");

                Console.WriteLine(GetNumberChar(password));

                Console.WriteLine(GetUpperChar(password));
                
               

            }
        }




        private bool GetNumberChar (string Password)
        {
            foreach (char num in Password)
            {
                if (char.IsNumber(num))
                    return true;
            }
            return false;
            
        }

        private bool GetUpperChar(string Password)
        {
            foreach (char upper in Password)
            {
                if (char.IsUpper(upper))
                    return true;
            }
            return false;

        }




        public User()
        {

        }
    }
}
