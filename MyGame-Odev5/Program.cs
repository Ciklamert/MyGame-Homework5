using System;

namespace MyGame_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 500;
            Player player1 = new Player();
            player1.FirstName = "Mert";
            player1.LastName = "Çıkla";
            player1.NationalityId = "1234567890";
            player1.YearofBirth = 2001;
            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(player1);
            int count = 1; //number of entering
            OrderManager orderManager = new OrderManager();
            orderManager.Order(player1, count, price);
        }
    }
}
