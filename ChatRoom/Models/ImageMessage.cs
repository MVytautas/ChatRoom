using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoom.Models
{
    public class ImageMessage
    {
        public byte[] ImageData { get; set; }
        public int ImageId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}