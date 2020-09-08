using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GameServer
{
    class GameLogic
    {
        public static void Update()
        {
            ThreadManager.UpdateMain();
        }
    }
}
