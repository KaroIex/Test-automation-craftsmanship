using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Mock.Classes.Interfaces
{
    public interface IBankService
    {
        bool Transfer(IBankAccount fromAccount, IBankAccount toAccount, decimal amount);
    }
}
