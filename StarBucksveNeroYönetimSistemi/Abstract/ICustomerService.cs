using StarBucksveNeroYönetimSistemi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarBucksveNeroYönetimSistemi.Abstract
{
	public interface ICustomerService
	{
		void Save(Customer customer);
	}
}
