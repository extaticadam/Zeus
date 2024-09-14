using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioLibrary.Models
{
    public class PortfolioModel
    {

        /// <summary>
        /// Portfolio Model - A portfolio must contain these fields
        /// </summary>
        /// 
        public string PortfolioID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

    }



}
