using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.DTOs.CategoryDto
{
    public class DtoCategorySalesFor1997 : DtoBase
    {
        public DtoCategorySalesFor1997()
        {

        }
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }



    }
}
