using OOPGun5Odev4.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGun5Odev4.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db: "+customer.FirstName);
        }
    }
}
