using StarBucksveNeroYönetimSistemi.Abstract;
using StarBucksveNeroYönetimSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarBucksveNeroYönetimSistemi.Concreta
{
	public class StarbucksCustomerManager:BaseCustomerManager
	{
		private ICustomerCheckService _customerCheckService;

		public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
		{
			_customerCheckService = customerCheckService;
		}	

		public override void Save(Customer customer)
		{
			if (_customerCheckService.CheckIfRealPerson(customer))
			{
				base.Save(customer);
			}
			else
			{
				throw new Exception("not a valid person");
			}
		}
	}
}
