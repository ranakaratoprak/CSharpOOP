using OOPGun5Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGun5Odev4.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
