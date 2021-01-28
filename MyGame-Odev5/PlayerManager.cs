using System;
using System.Collections.Generic;
using System.Text;

namespace MyGame_Odev5
{
    class PlayerManager : PlayerCheckManager ,IRegisterService
    {
        public void Add(Player player)
        {
            if (CheckIfRealPerson(player))
            {
                Console.WriteLine("Registration succeded");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("The Account was deleted");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Informations updated.");
        }
    }
}
