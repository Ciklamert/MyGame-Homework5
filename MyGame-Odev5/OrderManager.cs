using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame_Odev5
{
    class OrderManager : PlayerCheckManager, IOrderService
    {
        public void Order(Player player, int count, int price)
        {
            StudentCampaign studentCampaign = new StudentCampaign();
            BeginningCampaign beginningCampaign = new BeginningCampaign();
            NormalSale normalSale = new NormalSale();
            if ((2021 - player.YearofBirth) < 25)
            {
                studentCampaign.Add(player, price);
                studentCampaign.Sale(player, price);
            }
            else if (count <= 1)
            {
                beginningCampaign.Add(player, price);
                studentCampaign.Sale(player, price);
            }
            else
            {
                normalSale.Sale(player, price);
            }
        }
    }
}
