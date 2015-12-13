using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoom.Models
{
    public class Room
    {
        public string ChatRoomName { get; set; }
        public int ChatRoomId { get; set; }
        public List<int> UserIds { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}