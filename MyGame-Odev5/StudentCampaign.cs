using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame_Odev5
{
    //Price for Students
    class StudentCampaign : PlayerCheckManager, SaleManager, CampaignManager
    {
        public StudentCampaign()
        {
            Console.WriteLine("If you are under 25, you can buy the game with either 20% discount or 10% discount.");
        }
        public void Add(Player player, int price)
        {
           
            if (CheckIfRealPerson(player) == true)
            {
                if ((2021 - player.YearofBirth) < 18)
                {
                    
                    Console.WriteLine("The price of game for you: " + (price - (price * 20 / 100)));
                }
                else if((2021 - player.YearofBirth) > 18 && (2021- player.YearofBirth) < 25)
                {
                    
                    Console.WriteLine("The price of game for you: " + (price - (price * 10 / 100)));
                }
                
            }
            else
            {
                Console.WriteLine("Please, enter real person's datas");
            };
            
        }

        

        public void Delete(Player player, int price)
        {
            Console.WriteLine("The limited time for this campaign is finished. Now you can buy with the normal price: " + price); ;
        }

        public void Sale(Player player, int price)
        {
            Console.WriteLine("The sale is finished. Thank you for prefering us."); 
        }

        public void Update(Player player, int price)
        {
            Console.WriteLine("Wait for new discounts. We will make a new update in our campaigns"); 
        }
    }
}
