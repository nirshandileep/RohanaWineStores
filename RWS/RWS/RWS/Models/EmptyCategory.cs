using RWS.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace RWS.Models
{
    public class EmptyCategory
    {
        public int CategoryId { get; set; }
        [Display(Name = "Empty Category")]
        public string CategoryCode { get; set; }
        [Display(Name = "Display in Empty Stock Adjustments")]
        public bool AllowAdjustment { get; set; }
        [Display(Name = "Display in Empty Sales")]
        public bool AllowSales { get; set; }
        [Display(Name = "Display in Empty Purchase")]
        public bool AllowPurchase { get; set; }
        [Display(Name = "Empty Purchase Price")]
        public decimal PurchasePrice { get; set; }
        [Display(Name = "Empty Sales Price")]
        public decimal SellingPrice { get; set; }
        [Display(Name = "Company Price")]
        public decimal CompanyPrice { get; set; }
        [Display(Name = "Display Order")]
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