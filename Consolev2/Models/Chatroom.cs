using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolev2.Models
{
    public class Chatroom
    {
        [Key]
        public int IdChatroom { get; set; }

        public int IdUser { get; set; }

        public string Name { get; set; }
    }
}
