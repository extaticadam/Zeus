using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using PortfolioLibrary.Models;
using Npgsql;

namespace PortfolioLibrary.DataAccess
{
    internal class SQLConnector : IDataConnection
    {
        /// <summary>
        /// Saves a Portfolio to the DB
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        public PortfolioModel CreatePortfolio(PortfolioModel model)
        {
            using (IDbConnection connection = new NpgsqlConnection(GlobalConfig.CnnString("LIVEDB")))
            {
                var p = new DynamicParameters();

                p.Add("@CreationDate", model.CreationDate);
                p.Add("@LastModifiedDate", model.LastModifiedDate);


                // Insert SQL command with parameter placeholders
                string sql = @"
                        INSERT INTO Portfolio (CreationDate, LastModifiedDate)
                        VALUES (@CreationDate, @LastModifiedDate)
                        RETURNING portfolioid";

                var newPortfolioId = connection.ExecuteScalar<Guid>(sql, p);

                // Set the PortfolioID in the model
                model.PortfolioID = newPortfolioId.ToString();

                return model;
            }
        }

        public PortfolioVersionModel CreatePortfolioVersion(PortfolioVersionModel model)
        {
            using (IDbConnection connection = new NpgsqlConnection(GlobalConfig.CnnString("LIVEDB")))
            {

                if (string.IsNullOrEmpty(model.PortfolioID))
                {
                    throw new ArgumentNullException("PortfolioID", "PortfolioID cannot be null or empty when creating a PortfolioVersion.");
                }
                // Convert the string PortfolioID to a Guid
                Guid portfolioIdGuid = Guid.Parse(model.PortfolioID);

                var p = new DynamicParameters();
                p.Add("@PortfolioID", portfolioIdGuid);

                // Set the version number to 1 for a new portfolio
                model.PortfolioVersionNumber = 1;
                p.Add("@PortfolioVersionNumber", model.PortfolioVersionNumber);
                p.Add("@Description", model.Description);

                p.Add("@OnSaleDate", model.OnSaleDate);
                // TODO - Add themeNo
                //p.Add("@Theme", model.Theme);
                
                p.Add("@ProductClass", model.ProductClass);
                p.Add("@PromotionId", model.PromotionID);
                p.Add("@seasonid", model.seasonid);
                p.Add("@CategoryNo", model.CategoryNo);
                p.Add("@cgno", model.cgno);
                p.Add("@Scgno", model.Scgno);
                p.Add("@BrandOrALDIPL", model.BrandOrALDIPL);
                p.Add("@Harmonised", model.Harmonised);
                p.Add("@SourcingEntity", model.SourcingEntity);
                p.Add("@NewRepeatEPD", model.NewRepeatEPD);
                p.Add("@DisplayID", model.DisplayID);
                p.Add("@SellableID", model.SellableID);
                p.Add("@Packsize", model.Packsize);
                p.Add("@DBUNo", model.DBUNo);
                p.Add("@GD", model.GD);
                p.Add("@BD", model.BD);
                p.Add("@EM", model.EM);
                p.Add("@BA", model.BA);
                p.Add("@CaseLength", model.CaseLength);
                p.Add("@CaseWidth", model.CaseWidth);
                p.Add("@CaseHeight", model.CaseHeight);
                p.Add("@UnitLength", model.UnitLength);
                p.Add("@UnitWidth", model.UnitWidth);
                p.Add("@UnitHeight", model.UnitHeight);

                // Insert SQL command with parameter placeholders
                string sql = @"
                             INSERT INTO PortfolioVersion (PortfolioID, PortfolioVersionNumber, Description, OnSaleDate, ProductClass, CategoryNo, cgno, Scgno, BrandOrALDIPL, Seasonid, HarmonisedItem, SourcingEntity, NewRepeatEPD, PromotionID, DisplayID, SingleGenericID, packsize, dbuno, gd, bd, em, ba, CaseLength, CaseWidth, CaseHeight, UnitLength, UnitWidth, UnitHeight)
                            VALUES (@PortfolioID, @PortfolioVersionNumber, @Description, @OnSaleDate, @ProductClass, @CategoryNo, @cgno, @Scgno, @BrandOrALDIPL, @seasonid, @Harmonised, @SourcingEntity, @NewRepeatEPD, @PromotionID, @DisplayID, @SellableID, @Packsize, @DBUNo, @GD, @BD, @EM, @BA, @CaseLength, @CaseWidth, @CaseHeight, @UnitLength, @UnitWidth, @UnitHeight);";

                // Execute the command
                connection.Execute(sql, p);

                // Return the model with the new PortfolioID
                return model;
            }
        }

        public SalesOfficeListingModel CreateSalesOfficeListing(SalesOfficeListingModel model)
        {
            using (IDbConnection connection = new NpgsqlConnection(GlobalConfig.CnnString("LIVEDB")))
            {
                // Convert the string PortfolioID to a Guid
                Guid portfolioIdGuid = Guid.Parse(model.PortfolioID);

                var p = new DynamicParameters();
                p.Add("@PortfolioID", portfolioIdGuid);
                p.Add("@PortfolioVersionNumber", model.PortfolioVersionNumber);
                p.Add("@Sales_office", model.Sales_office);
                p.Add("@Active", model.Active);

                // Insert SQL command with parameter placeholders
                string sql = @"
                INSERT INTO salesofficelisting (PortfolioID, PortfolioVersionNumber, Sales_office, Active)
                VALUES (@PortfolioID, @PortfolioVersionNumber, @Sales_office, @Active)";

                connection.Execute(sql, p);

                return model;
            }
        }

        public ProductCostingsModel CreateProductCostings(ProductCostingsModel model)
        {
            using (IDbConnection connection = new NpgsqlConnection(GlobalConfig.CnnString("LIVEDB")))
            {
                // Convert the string PortfolioID to a Guid
                Guid portfolioIdGuid = Guid.Parse(model.PortfolioID);

                var p = new DynamicParameters();
                p.Add("@PortfolioID", portfolioIdGuid);
                p.Add("@PortfolioVersionNumber", model.PortfolioVersionNumber);
                p.Add("@PlannedQuantity", model.PlannedQuantity);
                p.Add("@ContractedQuantity", model.ContractedQuantity);
                p.Add("@Cost", model.Cost);
                p.Add("@Currency", model.Currency);
                p.Add("@Incoterms", model.Incoterms);
                p.Add("@FreightCost", model.FreightCost);
                p.Add("@Duty", model.Duty);
                p.Add("@EstimatedDeliveredCost", model.EstimatedDeliveredCost);
                p.Add("@Retail", model.Retail);
                p.Add("@MarginPercent", model.MarginPercent);
                p.Add("@Sales", model.Sales);
                p.Add("@Margin", model.Margin);
                p.Add("@GST", model.GST);


                // Insert SQL command with parameter placeholders
                string sql = @"
                INSERT INTO ProductCosting (PortfolioID, PortfolioVersionNumber, PlannedQuantity, ContractedQuantity, Cost, Currency, Incoterms, FreightCost, Duty, EstDeliveredCost, Retail, MarginPercent, Sales, Margin, GST)
                VALUES (@PortfolioID, @PortfolioVersionNumber, @PlannedQuantity, @ContractedQuantity, @Cost, @Currency, @Incoterms, @FreightCost, @Duty, @EstimatedDeliveredCost, @Retail, @MarginPercent, @Sales, @Margin, @GST)";

                connection.Execute(sql, p);

                return model;
            }
        }

    }
}

