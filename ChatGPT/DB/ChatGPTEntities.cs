using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT.DB
{
    public partial class ChatGPTEntities
    {
        private static ChatGPTEntities _context;

        public static ChatGPTEntities GetContext()
        {
            if (_context == null)
                _context = new ChatGPTEntities();

            return _context;
        }
    }
}
