using Microsoft.EntityFrameworkCore;
using Northwind.DataAccessLayer.Abstract;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccessLayer.Concrete.EntityFramework.Repository
{
    public class EmployeeRepository : GenericRepository<Employee>,IEmployeeRepository
    {
        public EmployeeRepository(DbContext context) : base(context)
        {


        }
    }
}
