using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Nike_Shop_Management.DTO
{
    class UserAccountDTO
    {

        private string id;
        private string username;
        private string password;
        private string gender;
        private string email;
        private string phone_number, address, first_name, last_name, url;
        private int point, member_tier;
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_number { get => phone_number; set => phone_number = value; }
        public string Address { get => address; set => address = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public int Member_tier { get => member_tier; set => member_tier = value; }
        public int Point { get => point; set => point = value; }
        public string Url { get => url; set => url = value; }
        public string Id { get => id; set => id = value; }
    }
}
