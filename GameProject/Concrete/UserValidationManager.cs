using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.BirthYear==1997 && gamer.FirstName == "RANA" &&
                    gamer.LastName == "KARATOPRAK" && gamer.IdentityNumber == 1234567890)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
