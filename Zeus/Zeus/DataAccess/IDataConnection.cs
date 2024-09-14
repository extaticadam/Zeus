using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortfolioLibrary.Models;

namespace PortfolioLibrary.DataAccess
{
    public interface IDataConnection
    {
        PortfolioModel CreatePortfolio(PortfolioModel model);
        PortfolioVersionModel CreatePortfolioVersion(PortfolioVersionModel model);

        SalesOfficeListingModel CreateSalesOfficeListing(SalesOfficeListingModel model);

        ProductCostingsModel CreateProductCostings(ProductCostingsModel model);
    }
}
