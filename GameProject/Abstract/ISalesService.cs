﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISalesService
    {
        void Sell(Gamer gamer, Game game);
        void CampaignAdd(Campaign campaign);

    }
}
