using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame_Odev5
{
    //The beginning price of game
    class BeginningCampaign : PlayerCheckManager, SaleManager, CampaignManager
    {
        public BeginningCampaign()
        {
            Console.WriteLine("If you will play the game first time, you can buy it with %30 discount.");
        }
        
        public void Add(Player player, int price)
        {
            
            
            
            if (CheckIfRealPerson(player) == true)
            {
                Console.WriteLine(player.FirstName + ", The normal price for you is : " + (price - (price * 30 / 100)));

            }
            else
            {
                Console.WriteLine("Please, enter real person's datas.");
            };
        }

        

        public void Delete(Player player, int price)
        {
            Console.WriteLine("The limited time for this campaign is finished. Now you can buy with the normal price: " + price);
        }

        public void Sale(Player player, int price)
        {
            Console.WriteLine("The sale  is finished. Thank you for prefering us.");
        }

        public void Update(Player player, int price)
        {
            Console.WriteLine("Wait for new discounts. We will make a update in our campaigns");
        }
    }
}
