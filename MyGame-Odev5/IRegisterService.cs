using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame_Odev5
{
    interface IRegisterService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);

    }
}
