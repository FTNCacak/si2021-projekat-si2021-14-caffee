﻿using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class UserRepository
    {
        public List<User> GetAllUsers()
        {
            //Nisam mogao da pronadjem resenje za cuvanje u folderu u 
            string filePath = @"C:\Users\Bane\Desktop\ProjekatSi\si2021-projekat-si2021-14-caffee\CaffeeData\Users.txt";

            List<string> lines = new List<string>();

            List<User> users = new List<User>();

            lines = File.ReadAllLines(filePath).ToList();

            foreach(string line in lines)
            {
                string[] items = line.Split(',');

                User u = new User(items[0], items[1], Convert.ToBoolean(items[2]));

                users.Add(u);
            }

            return users;
        }

        public void InsertNewUser(User u)
        {
            //Banov flie path
            //string filePath = @"C:\Users\Bane\Desktop\ProjekatSi\si2021-projekat-si2021-14-caffee\CaffeeData\Users.txt";

            //Pajov file path
            string filePath = @"~\\si2021-projekat-si2021-14-caffee\\CaffeeData\\Users.txt";

            List<User> users = GetAllUsers();

            users.Add(u);

            List<string> outContents = new List<string>();

            foreach (User user in users)
            {
                outContents.Add(user.ToString());
            }

            File.WriteAllText(filePath, "");

            File.WriteAllLines(filePath, outContents);
        }

        public void InsertNewOwner(Owner owner)
        {
          
                //Banov flie path
                //string filePath = @"C:\Users\Bane\Desktop\ProjekatSi\si2021-projekat-si2021-14-caffee\CaffeeData\Users.txt";

                //Pajov file path
                string filePath = @"~\\si2021-projekat-si2021-14-caffee\\CaffeeData\\Users.txt";

                List<User> users = GetAllUsers();

                users.Add(owner);

                List<string> outContents = new List<string>();

                foreach (User user in users)
                {
                    outContents.Add(user.ToString());
                }

                File.WriteAllText(filePath, "");

                File.WriteAllLines(filePath, outContents);
            
        }

    }
}
