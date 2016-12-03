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
    public class ExpenseType
    {
        public int ExpenseTypeId { get; set; }
        [Display(Name = "Expense")]
        public string ExpenseTypeDesc { get; set; }
        [Display(Name = "Created User")]
        public int CreatedUser { get; set; }
        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }

        public static int UpdateExpenseType(ExpenseType expenseType)
        {
            using (SqlConnection conn = new SqlConnection(Connection.DBConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateExpenseType", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@ExpenseTypeId", expenseType.ExpenseTypeId);
                    cmd.Parameters.AddWithValue("@ExpenseType", expenseType.ExpenseTypeDesc);
                    cmd.Parameters.AddWithValue("@CreatedUser", 1);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}