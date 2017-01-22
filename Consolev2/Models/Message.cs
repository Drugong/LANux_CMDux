using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolev2.Models
{
    public class Message
    {
        [Key]
        public int IdMessage { get; set; }

        public int IdChatroom { get; set; }

        public int IdUser { get; set; }

        public string Content { get; set; }

        public string Time { get; set; }
    }
}
