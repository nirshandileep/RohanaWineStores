using RWS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RWS.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public int SupplierId { get; set; }
        public string Description { get; set; }
        public decimal NetAmount { get; set; }
        public SelectList Supplier { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public static int UpdateOrderHeader(Order order)
        {
            int orderId;

            using (SqlConnection conn = new SqlConnection(Connection.DBConnectionString))
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    using (SqlCommand cmd = new SqlCommand("UpdatePurchaseOrder", conn, tran))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                        cmd.Parameters.AddWithValue("@SupplierId", order.SupplierId);
                        cmd.Parameters.AddWithValue("@NetAmount", order.NetAmount);
                        cmd.Parameters.AddWithValue("@CreatedUserId", 1);
                        cmd.Parameters.Add("@OrderId", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();

                        orderId = Convert.ToInt32(cmd.Parameters["@OrderId"].Value);
                    }

                    foreach (OrderDetail orderDetail in order.OrderDetail)
                    {
                        orderDetail.OrderId = orderId;
                        RWS.Models.OrderDetail.UpdateOrderDetail(orderDetail, tran);
                    }

                    tran.Commit();
                }
            }
            return orderId;
        }
    }

    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDesc { get; set; }
        public string UnitSize { get; set; }
        public string ProductTypeDesc { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal UnitPrice { get; set; }
        //public decimal CostPrice { get; set; }
        public decimal Qty { get; set; }
        public decimal LineTotal { get; set; }
        public int LineId { get; set; }

        public static int UpdateOrderDetail(OrderDetail orderDetail, SqlTransaction tran)
        {
            using (SqlCommand cmd = new SqlCommand("UpdatePurchaseOrderDetail", tran.Connection, tran))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@OrderId", orderDetail.OrderId);
                cmd.Parameters.AddWithValue("@ProductId", orderDetail.ProductId);
                cmd.Parameters.AddWithValue("@Qty", orderDetail.Qty);
                cmd.Parameters.AddWithValue("@UnitPrice", orderDetail.UnitPrice);
                cmd.Parameters.AddWithValue("@CostPrice", orderDetail.PurchasePrice);
                cmd.Parameters.AddWithValue("@LineTotal", orderDetail.LineTotal);

                return cmd.ExecuteNonQuery();
            }
        }
    }
}