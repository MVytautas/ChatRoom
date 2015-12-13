using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoom.Models
{
    public class TextMessage
    {

        public string Message { get; set; }
        public int MessageId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}