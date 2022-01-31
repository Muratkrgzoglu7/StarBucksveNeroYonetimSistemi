using StarBucksveNeroYönetimSistemi.Abstract;
using StarBucksveNeroYönetimSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarBucksveNeroYönetimSistemi.Concreta
{
	public class CustomerCheckManager : ICustomerCheckService
	{
		public bool CheckIfRealPerson(Customer customer)
		{
			return true;
		}
	}
}
