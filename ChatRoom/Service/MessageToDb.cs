using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatRoom.Models
{
    public class MessageToDb
    {
        public List<TextMessage> GetMessages(int chatroomId)
        {
            //var messages =  new List <TextMessage>();

            //open connection to db
            //read the messages
            //close conn

            //return messages;
            throw new NotImplementedException();
        }

        public void CreateNewMessage(int chatroomID, string messageTxt, int userId)
        {
            //open connection
            //query if user has permissions

            //create the messages
            //close conn
        }
    }
}