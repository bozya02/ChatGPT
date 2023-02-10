using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT.DB
{
    internal partial class Chatroom
    {
        public DateTime LastMessage => (DateTime)ChatMessages.LastOrDefault().Date;
    }
}
