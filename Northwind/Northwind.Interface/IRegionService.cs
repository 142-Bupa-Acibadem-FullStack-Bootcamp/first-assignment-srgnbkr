using Northwind.Entity.DTOs.RegionDto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Interface
{
    public interface IRegionService : IGenericService<Region, DtoRegion>
    {
    }
}
