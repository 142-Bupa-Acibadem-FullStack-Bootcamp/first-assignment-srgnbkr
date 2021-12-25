using Northwind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entity.DTOs.PhotoDto
{
    public class DtoPhoto : DtoBase
    {
        public DtoPhoto()
        {

        }
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Description { get; set; }
        public bool IsMain { get; set; }
        public string Url { get; set; }
        public string PublicId { get; set; }
    }
}
