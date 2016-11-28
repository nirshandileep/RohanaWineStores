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
    public class BankAccount
    {
        public int AccountId { get; set; }
        [Display(Name = "Account No")]
        public string AccountNo { get; set; }
        public string Description { get; set; }
        [Display(Name = "Current Balance")]
        public decimal CurrentBalance { get; set; }
        public int CreatedUser { get; set; }
        public DateTime CreatedDate { get; set; }

        public static int UpdateBankAccount(BankAccount bankAccount)
        {
            using (SqlConnection conn = new SqlConnection(Connection.DBConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("UpdateBankAccount", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();

                    cmd.Parameters.AddWithValue("@AccountId", bankAccount.AccountId);
                    cmd.Parameters.AddWithValue("@AccountNo", bankAccount.AccountNo);
                    cmd.Parameters.AddWithValue("@Description", bankAccount.Description);
                    cmd.Parameters.AddWithValue("@CurrentBalance", bankAccount.CurrentBalance);
                    cmd.Parameters.AddWithValue("@CreatedUser", 1);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}