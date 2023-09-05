using AbstractInterfaceDemos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInterfaceDemos.Abstracts
{
    internal interface ICustomerService
    {
        void Save(Customer customer);
    }
}
