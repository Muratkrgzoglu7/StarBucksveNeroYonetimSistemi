using StarBucksveNeroYönetimSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarBucksveNeroYönetimSistemi.Abstract
{
	public abstract class BaseCustomerManager : ICustomerService
	{
		public virtual void Save(Customer customer)
		{
			Console.WriteLine("save to db : "+customer.FirstName);
		}
	}
}
