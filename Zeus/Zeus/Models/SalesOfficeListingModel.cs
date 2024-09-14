using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioLibrary.Models
{
    public class SalesOfficeListingModel
    {
        public string PortfolioID { get; set; }
        public int PortfolioVersionNumber { get; set; }
        public string Sales_office { get; set; }
        public int Active {  get; set; }
    }
}
