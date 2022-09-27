using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model
{
    static class InitData
    {
        public static List<User> GenerateUsers()
        {
            List<User> userList = new List<User>();
            userList.Add(new User(User.Role.Einkauf, "John Buyman", "johnbuyman", "123"));
            userList.Add(new User(User.Role.Hardwarespezialist, "Dana Scully", "danascully", "123"));
            userList.Add(new User(User.Role.Sachbearbeitung, "Fox Mulder", "foxmulder", "123"));
            return userList;
        }
    }
}
