using OOPGun5Odev4.Abstract;
using OOPGun5Odev4.Adapters;
using OOPGun5Odev4.Concrete;
using OOPGun5Odev4.Entities;
using System;

namespace OOPGun5Odev4
{
    class Program
    {   //Starbucks ve Nero firması için müşteri yönetimi yapan bir sistem
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1996,10,10), FirstName = "Rana", 
                LastName = "Karatoprak", NationalityId = "55603149700"});

            Console.ReadLine();

        }
    }
}
