using MernisServiceReference;
using StarBucksveNeroYönetimSistemi.Abstract;
using StarBucksveNeroYönetimSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarBucksveNeroYönetimSistemi.Adapters
{
	public class MernisServiceAdaper : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
			
			return client.TCKimlikNoDogrula(Convert.ToInt64(customer.INationaltyNumber),
				customer.FirstName.ToUpper(), customer.LastName.ToUpper(),
				customer.DateOfBirth.Year);

		}
	}
}
