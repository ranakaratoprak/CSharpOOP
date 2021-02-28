using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 1997,
                FirstName = "RANA",
                LastName = "KARATOPRAK",
                IdentityNumber = 1234567890 });

            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { GameName = "PUBG", GamePrice = 10.0, Id = 1 });

            SalesManager salesManager = new SalesManager();
            salesManager.CampaignAdd(new Campaign{ CampaignName = "İlkbahar Kampanyası", Id = 1});
            salesManager.Sell(new Gamer { FirstName="RANA"}, new Game { GameName = "PUBG"});
        }
    }
}
