using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void CampaignAdd(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası eklendi.");
        }

        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu, " + game.GameName + " oyununu satıyor.");
        }
    }
}
