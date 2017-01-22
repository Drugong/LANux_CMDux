using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolev2.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        public string Username { get; set; }

        public string Nickname { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }

        public DateTime Added { get; set; }
    }
}
