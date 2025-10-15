using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XoX_Game
{
    class Player
    {
        private byte id;
        private string userName;

        public byte GetId()
        {
            return id;
        }
        public string GetUserName()
        {
            return userName;
        }

        public Player(byte id, string userName)
        {
            this.id = id;
            this.userName = userName;
        }

        public void SetId(byte id)
        {
            this.id = id;
        }
        public void SetUserName(string userName)
        {
            this.userName = userName;
        }
    }
}
