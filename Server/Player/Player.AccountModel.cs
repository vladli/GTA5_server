using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Server.Player
{
    public class AccountModel
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public AccountModel()
        {
            Name = "Unknown";
            Password = "Unknown";
        }
        public static List<AccountModel> List = new List<AccountModel>();
    }
}