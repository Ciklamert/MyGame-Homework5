using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame_Odev5
{
    class PlayerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
