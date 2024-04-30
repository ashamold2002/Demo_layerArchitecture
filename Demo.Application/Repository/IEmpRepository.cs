using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo;

namespace Demo.Core.Repository
{
    public interface IEmpRepository
    {
        Task<IEnumerable<Employeedetail>> Get();
    }
}
