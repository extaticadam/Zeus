using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioLibrary.Models
{
    public class PortfolioModel123
    {

        /// <summary>
        /// Portfolio Model - A portfolio must contain these fields
        /// </summary>
        /// 
        public string PortfolioID { get; set; }
        public int PfversionID { get; set; }
        public string Description { get; set; }
        public DateTime OnSaleDate { get; set; }
        public string Theme { get; set; }
        public int ProductClass { get; set; }
        public int CategoryNo { get; set; }
        public int cgno { get; set; }
        public int Scgno { get; set; }
        public string BrandOrALDIPL {  get; set; }

        public PortfolioModel123()
        {

        }

    }



}
