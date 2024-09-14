using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioLibrary.Models
{
    public class ProductCostingsModel
    {
        public string PortfolioID { get; set; }
        public int PortfolioVersionNumber { get; set; }
        public int PlannedQuantity { get; set; }
        public int ContractedQuantity { get; set; }
        public double Cost { get; set; }
        public string Currency { get; set; }
        public string Incoterms { get; set; }
        public double FreightCost { get; set; }
        public double Duty { get; set; }
        public double EstimatedDeliveredCost { get; set; }
        public double Retail { get; set; }
        public double MarginPercent { get; set; }
        public double Sales { get; set; }
        public double Margin { get; set; }
        public int GST { get; set; }
    }
}
