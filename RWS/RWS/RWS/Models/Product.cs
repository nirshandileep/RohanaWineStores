using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

//using Microsoft.Practices.EnterpriseLibrary.Data;
//using RWS.DAL;
using System.Data.Common;
using System.ComponentModel.DataAnnotations;
using RWS.DAL;

namespace RWS.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }
        [Display(Name = "Description")]
        public string ProductDesc { get; set; }
        public int SupplierId { get; set; }
        [Display(Name = "Purchase Price")]
        public decimal PurchasePrice { get; set; }
        [Display(Name = "Selling Price")]
        public decimal SellingPrice { get; set; }
        public decimal Margin { get; set; }
        [Display(Name = "Minimum Qty")]
        public decimal MinimumQty { get; set; }
        public int UomId { get; set; }
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
        public int ProductType { get; set; }
        public int AllowSales { get; set; }
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        public int CreatedUser { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string UnitSize { get; set; }

        public static int UpdateProduct(Product product)
        {
            using (SqlConnection conn = new SqlConnection(Connection.DBConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateProduct", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                    cmd.Parameters.AddWithValue("@ProductCode", product.ProductCode);
                    cmd.Parameters.AddWithValue("@ProductDesc", product.ProductDesc);
                    cmd.Parameters.AddWithValue("@SupplierId", product.SupplierId);
                    cmd.Parameters.AddWithValue("@PurchasePrice", product.PurchasePrice);
                    cmd.Parameters.AddWithValue("@SellingPrice", product.SellingPrice);
                    cmd.Parameters.AddWithValue("@Margin", product.Margin);
                    cmd.Parameters.AddWithValue("@MinimumQty", product.MinimumQty);
                    cmd.Parameters.AddWithValue("@UomId", product.UomId);
                    cmd.Parameters.AddWithValue("@DisplayOrder", product.DisplayOrder);
                    cmd.Parameters.AddWithValue("@ProductType", product.ProductType);
                    cmd.Parameters.AddWithValue("@AllowSales", product.AllowSales);
                    cmd.Parameters.AddWithValue("@IsActive", product.IsActive);
                    cmd.Parameters.AddWithValue("@CreatedUser", 1);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }
}