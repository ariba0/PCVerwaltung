using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCVerwaltung.Model
{
    public class User
    {
        public enum Role {
            Einkauf,
            Sachbearbeitung,
            Hardwarespezialist
        }

        private Role _role;
        private string _name;
        public string Name { get; set; }
        private string _username;
        private string _password;
        private DateTime _lastLogin;
        public DateTime LastLogin { get; set; }

        public User(Role role, string name, string username, string password)
        {
            _role = role;
            _name = name;
            _username = username;
            _password = password;
            _lastLogin = DateTime.Now;
        }

        public Dictionary<string, string> GetUserInfo()
        {
            var userInfo = new Dictionary<string, string>();
            userInfo.Add("name", _name);
            userInfo.Add("username", _username);
            userInfo.Add("role", _role.ToString());
            userInfo.Add("lastlogin", _lastLogin.ToString());
            return userInfo;
        }   
    }
}
