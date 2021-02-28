using MernisServiceReference;
using OOPGun5Odev4.Abstract;
using OOPGun5Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGun5Odev4.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
