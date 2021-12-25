using AutoMapper;
using Northwind.Entity.DTOs.CategoryDto;
using Northwind.Entity.DTOs.CustomerDto;
using Northwind.Entity.DTOs.EmployeeDto;
using Northwind.Entity.DTOs.InvoiceDto;
using Northwind.Entity.DTOs.OrderDto;
using Northwind.Entity.DTOs.PhotoDto;
using Northwind.Entity.DTOs.ProductDto;
using Northwind.Entity.DTOs.RegionDto;
using Northwind.Entity.DTOs.SalesDto;
using Northwind.Entity.DTOs.SupplierDto;
using Northwind.Entity.DTOs.TerritoryDto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region CategoryDto
            CreateMap<Category, DtoCategory>().ReverseMap();
            CreateMap<CategorySalesFor1997, DtoCategorySalesFor1997>().ReverseMap();
            #endregion

            #region Customer Dto
            CreateMap<Customer, DtoCustomer>().ReverseMap();
            CreateMap<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>().ReverseMap();
            CreateMap<CustomerCustomerDemo, DtoCustomerCustomerDemo>().ReverseMap();
            CreateMap<CustomerDemographic, DtoCustomerDemographic>().ReverseMap();
            #endregion

            #region EmployeeDto
            CreateMap<Employee, DtoEmployee>().ReverseMap();
            CreateMap<EmployeeTerritory, DtoEmployeeTerritory>().ReverseMap();
            #endregion

            #region InvoiceDto
            CreateMap<Invoice, DtoInvoice>().ReverseMap();

            #endregion

            #region OrderDto
            CreateMap<Order, DtoOrder>().ReverseMap();
            CreateMap<OrderDetail, DtoOrderDetail>().ReverseMap();
            CreateMap<OrderDetailsExtended, DtoOrderDetailsExtended>().ReverseMap();
            CreateMap<OrdersQry, DtoOrdersQry>().ReverseMap();
            CreateMap<OrderSubtotal, DtoOrderSubtotal>().ReverseMap();
            CreateMap<QuarterlyOrder, DtoQuarterlyOrder>().ReverseMap();
            #endregion

            #region PhotoDto
            CreateMap<Photo, DtoPhoto>().ReverseMap();

            #endregion

            #region ProductDto
            CreateMap<Product, DtoProduct>().ReverseMap();
            CreateMap<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>().ReverseMap();
            CreateMap<ProductSalesFor1997, DtoProductSalesFor1997>().ReverseMap();
            CreateMap<ProductsByCategory, DtoProductsByCategory>().ReverseMap();
            #endregion

            #region RegionDto
            CreateMap<Region, DtoRegion>().ReverseMap();

            #endregion
            
            #region SalesDto
            CreateMap<SalesByCategory, DtoSalesByCategory>().ReverseMap();
            CreateMap<SalesTotalsByAmount, DtoSalesTotalsByAmount>().ReverseMap();
            CreateMap<SummaryOfSalesByQuarter, DtoSummaryOfSalesByQuarter>().ReverseMap();
            CreateMap<SummaryOfSalesByYear, DtoSummaryOfSalesByYear>().ReverseMap();

            #endregion

            #region SupplierDto
            CreateMap<Supplier, DtoSupplier>().ReverseMap();


            #endregion

            #region TerritoryDto
            CreateMap<Territory, DtoTerritory>().ReverseMap();


            #endregion












        }
    }
}
