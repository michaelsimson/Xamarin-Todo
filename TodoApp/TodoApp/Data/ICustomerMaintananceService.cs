using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Data
{
  public interface ICustomerMaintananceService
    {
        Task<List<CustomerMaintananceService>> GetMaintananceList();
    }
}
