using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame_Odev5
{
    interface CampaignManager
    {
        void Add(Player player, int price);
        void Update(Player player, int price);

        void Delete(Player player, int price);

    }
}
