using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioLibrary.Models
{
    public class EmployeeBD
    {
        public int EmployeeNo { get; set; }
        public string FirstName { get; set; } // Ensure the casing matches
        public int PositionNo { get; set; }
        public int DBUNo { get; set; }
    }

}
