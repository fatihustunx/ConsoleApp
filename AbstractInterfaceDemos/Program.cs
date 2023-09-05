using AbstractInterfaceDemos.Abstracts;
using AbstractInterfaceDemos.Adapters;
using AbstractInterfaceDemos.Conceretes;
using AbstractInterfaceDemos.Entities;

namespace AbstractInterfaceDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { Id = 1, FirstName = "Fatih", LastName = "Üstün", NationalityId = "52897574164", DateOfBirth = new DateTime(2001, 2, 12) });

            Console.WriteLine("Overdesign.");
        }
    }
}