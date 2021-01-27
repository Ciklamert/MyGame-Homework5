using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame_Odev5
{
    class NormalSale : PlayerCheckManager , SaleManager
    {
        

        public void Sale(Player player, int price)
        {
            bool IsPerson = CheckIfRealPerson(player);
            if (IsPerson == true)
            {
                Console.WriteLine(player.FirstName + ", The normal price for you is : " + price);
                Console.WriteLine("The sale  is finished. Thank you for prefering us.");
            }
            else
            {
                Console.WriteLine("Please, enter real person's datas");
            }
        }
    }
}
