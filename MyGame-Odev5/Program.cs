using System;

namespace MyGame_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 500;
            StudentCampaign studentCampaign = new StudentCampaign();
            BeginningCampaign beginningCampaign = new BeginningCampaign();
            NormalSale normalSale = new NormalSale();
            Player player1 = new Player();
            player1.FirstName = "Mert";
            player1.LastName = "Çıkla";
            player1.NationalityId = "1234567890";
            player1.YearofBirth = 2001;
            int count = 1; //number of entering
            if ((2021 - player1.YearofBirth) < 25)
            {
                studentCampaign.Add(player1, price);
                studentCampaign.Sale(player1, price);
            }
            else if (count <= 1)
            {
                beginningCampaign.Add(player1, price);
                studentCampaign.Sale(player1, price);
            }
            else
            {
                normalSale.Sale(player1, price);
            }
        }
    }
}
