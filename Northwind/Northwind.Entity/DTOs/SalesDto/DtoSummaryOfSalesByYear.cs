﻿using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.DTOs.SalesDto
{
    public class DtoSummaryOfSalesByYear : DtoBase
    {
        public DtoSummaryOfSalesByYear()
        {

        }

        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
