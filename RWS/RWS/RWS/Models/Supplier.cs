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
    public class Supplier
    {
        public int SupplierId { get; set; }
        [Display(Name = "Code")]
        public string SupplierCode { get; set; }
        public string Name { get; set; }
        [Display(Name = "Current Balance")]
        public decimal CurrentBalance { get; set; }
        [Display(Name = "Empty Purchase Balance")]
        public decimal EmptyPurchaseBalance { get; set; }
        [Display(Name = "Display Order")]
        public int DisplayOrder { get; set; }
        [Display(Name = "Created User")]
        public int CreatedUser { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Supplier")]
        public string DisplayName { get; set; }

        public static int UpdateSupplier(Supplier supplier)
        {
            using (SqlConnection conn = new SqlConnection(Connection.DBConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateSupplier", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
                    cmd.Parameters.AddWithValue("@SupplierCode", supplier.SupplierCode);
                    cmd.Parameters.AddWithValue("@Name", supplier.Name);
                    cmd.Parameters.AddWithValue("@CurrentBalance", supplier.CurrentBalance);
                    cmd.Parameters.AddWithValue("@EmptyPurchaseBalance", supplier.EmptyPurchaseBalance);
                    cmd.Parameters.AddWithValue("@DisplayOrder", supplier.DisplayOrder);
                    cmd.Parameters.AddWithValue("@CreatedUser", 1);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
