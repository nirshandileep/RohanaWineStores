using RWS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RWS.Models
{
    public class EmptyCategory
    {
        public int CategoryId { get; set; }
        public string CategoryCode { get; set; }
        public bool AllowAdjustment { get; set; }
        public bool AllowSales { get; set; }
        public bool AllowPurchase { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal CompanyPrice { get; set; }
        public int DisplayOrder { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }

        public static int UpdateEmptyCategory(EmptyCategory emptyCategory)
        {
            using (SqlConnection conn = new SqlConnection(Connection.DBConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateEmptyCategory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@CategoryId", emptyCategory.CategoryId);
                    cmd.Parameters.AddWithValue("@CategoryCode", emptyCategory.CategoryCode);
                    cmd.Parameters.AddWithValue("@AllowAdjustment", emptyCategory.AllowAdjustment);
                    cmd.Parameters.AddWithValue("@AllowSales", emptyCategory.AllowSales);
                    cmd.Parameters.AddWithValue("@AllowPurchase", emptyCategory.AllowPurchase);
                    cmd.Parameters.AddWithValue("@PurchasePrice", emptyCategory.PurchasePrice);
                    cmd.Parameters.AddWithValue("@SellingPrice", emptyCategory.SellingPrice);
                    cmd.Parameters.AddWithValue("@CompanyPrice", emptyCategory.CompanyPrice);
                    cmd.Parameters.AddWithValue("@DisplayOrder", emptyCategory.DisplayOrder);
                    cmd.Parameters.AddWithValue("@CreatedUser", 1);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}