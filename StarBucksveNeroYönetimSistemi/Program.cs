using StarBucksveNeroYönetimSistemi.Abstract;
using StarBucksveNeroYönetimSistemi.Adapters;
using StarBucksveNeroYönetimSistemi.Concreta;
using StarBucksveNeroYönetimSistemi.Entities;
using System;

namespace StarBucksveNeroYönetimSistemi
{
	class Program
	{
		static void Main(string[] args)
		{
			BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdaper());
			baseCustomerManager.Save(new Customer
				{
				DateOfBirth = new DateTime(1999, 1, 30),
				FirstName = "Murat",
				LastName = "Karagözoğlu",
				INationaltyNumber = "32467446848"
			});
			Console.ReadLine();
		}
	}
}
