using System;
using System.Collections.Generic;
using System.Text;

namespace CloudAlliance.MTChat.Dto
{
   public class MessageDto
    {

        public MessageDto()
        {
        }
        public Guid UserId { get; set; }

        public string Nickname { get; set; }

        public string Message { get; set; }


    }
}
