﻿using Cayent.Core.Data.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cayent.Core.Data.Chats
{
    public class ChatReceiver
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ChatReceiverId { get; set; }

        public string ChatId { get; set; }
        public virtual Chat Chat { get; set; }

        public string ReceiverId { get; set; }
        public virtual UserBase Receiver { get; set; }

        public string LastChatMessageId { get; set; }
        public bool IsRemoved { get; set; }
        public string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();
    }
}
