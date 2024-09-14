using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioLibrary.Models
{
    public class PortfolioVersionModel
    {
        public string PortfolioID { get; set; }
        public int PortfolioVersionNumber { get; set; }
        public string Description { get; set; }
        public DateTime OnSaleDate { get; set; }
        public string Theme { get; set; }
        public int ProductClass { get; set; }
        public long PromotionID { get; set; }
        public int CategoryNo { get; set; }
        public int cgno { get; set; }
        public int Scgno { get; set; }
        public string BrandOrALDIPL { get; set; }
        public int? seasonid { get; set; }
        public int Harmonised { get; set; }
        public string SourcingEntity {  get; set; }
        public string NewRepeatEPD { get; set; }

        public int DisplayID { get; set; }
        public int SellableID {get; set; }
        public int Packsize { get; set; }

        public int DBUNo {  get; set; }
        public int GD { get; set; }
        public int BD { get; set; }
        public int EM { get; set; }
        public int BA { get; set; }

        public int CaseLength { get; set; }
        public int CaseWidth { get; set; }
        public int CaseHeight { get; set; }
        public int UnitLength { get; set; }
        public int UnitWidth { get; set; }
        public int UnitHeight { get; set; }


    }
}
