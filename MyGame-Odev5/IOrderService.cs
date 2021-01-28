using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame_Odev5
{
    interface IOrderService
    {
        void Order(Player player, int count, int price);
    }
}
