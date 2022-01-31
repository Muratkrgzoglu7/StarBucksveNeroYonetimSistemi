using StarBucksveNeroYönetimSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarBucksveNeroYönetimSistemi.Abstract
{
	public interface ICustomerCheckService
	{
		bool CheckIfRealPerson(Customer customer);
	}
}
