using AbstractInterfaceDemos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDemos.Abstracts
{
    internal interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
