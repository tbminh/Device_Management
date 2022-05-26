using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using BarcodeLib;
using QRCoder;
using System.Drawing;
using System.IO;

namespace Device_Managament2804
{
    internal class Data_User
    {
        public string Device_ID { get; set; }
        public string Device_serial_key { get; set; }
        public string Device_Name { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
        public string barcode { get; set; }
        public string User_Serial_Key { get; set; }
        public string Note { get; set; }
        //GET DATA DEVICE
       // public string User_serial_key { get; set; }
        public string User_id { get; set; }
        public string User_serial_key { get; set; }
        public string Userpass { get; set; }
        public string Full_name { get; set; }
        public string Update_day { get; set; }
        public string Level_id { get; set; }
        public string Updater { get; set; }
        public string Level_name { get; set; }

        //GET DATA USER
        public string Oder_Serial_Key { get; set; }
        public string Order_ID { get; set; }
        public string Order_Expected_Date { get; set; }
        public string Order_Date { get; set; }
        public string Order_Quantity { get; set; }
        public string Order_Status { get; set; }
        public string Order_Modify_Date { get; set; }
        public string Order_Note { get; set; }
        public string Position_ID { get; set; }
        // GET DATA ORDERS
        //public void Get_Data_Orders (DataGridView dgv)
        //{
        //    ConectDB db = new ConectDB();
        //    //cls_KetNoi connect = new cls_KetNoi();
        //    string sqlOrders = @"SELECT O.Order_Serial_Key,
		      //                          O.Suggest_id,
		      //                          O.Device_serial_key,
		      //                          O.Order_Quantity,
		      //                          O.Order_Expected_Date,
		      //                          O.Order_Date,
		      //                          O.Order_Status,
		      //                          O.Order_Modify_Date,
		      //                          O.Department_ID,
		      //                          O.User_serial_key,
		      //                          O.ID_reciever,
		      //                          O.Reciever,
		      //                          O.Buyer,
		      //                          O.Tel_buyer,                               
		      //                          O.Order_Note
        //                        FROM Orders O";
        //    OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
        //    OleDbCommand cmd = new OleDbCommand(sqlOrders, conn);
        //    try
        //    {
        //        conn.Open();              
        //        OleDbDataReader reader = cmd.ExecuteReader();
        //        dgv.Rows.Clear();
        //        while(reader.Read())
        //        {
        //            dgv.Rows.Add(new object[]
        //            {
        //                reader["Order_Serial_Key"].ToString(),
        //                reader["Order_ID"].ToString(),
        //                reader["Device_serial_Key"].ToString(),
        //                reader["Order_Expected_Date"].ToString(),
        //                reader["Order_Date"].ToString(),
        //                reader["Order_Quantity"].ToString(),
        //                reader["Order_Status"].ToString(),
        //                reader["Order_Modify_Date"].ToString(),
        //                reader["Department_ID"].ToString(),
        //                reader["User_Serial_Key"].ToString(),
        //                reader["ID_reciever"].ToString(),
        //                reader["Reciver"].ToString(),
        //                reader["Buyer"].ToString(),
        //                reader["Tel_buyer"].ToString(),                       
        //                reader["Order_Note"].ToString()
        //            });
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        if (ex != null)
        //        {
        //            if (cmd != null) cmd.Dispose();
        //            if (conn != null) conn.Dispose();
        //        }
        //    }
        //    finally
        //    {
        //        if (cmd != null) cmd.Dispose();
        //        if (conn != null) conn.Dispose();
        //    }

        //}
        public void Get_Data_User (DataGridView dgv)
        {
            ConectDB db = new ConectDB();
            string sqlU = @"SELECT U.User_serial_key,
	                       U.User_id,
	                       U.Userpass,
	                       U.Full_name,
	                       L.Level_id,
                           L.Level_name,
	                       U.Update_day,
                           U.Updater
                    FROM Data_User U, level_user L
                    WHERE U.Level_id = L.Level_id";
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            OleDbCommand cmd = new OleDbCommand(sqlU, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                dgv.Rows.Clear();
                while (reader.Read())
                {
                    dgv.Rows.Add( new object[]
                    {
                        reader["User_serial_key"].ToString(),
                        reader["User_id"].ToString(),
                        reader["Userpass"].ToString(),
                        reader["Full_name"].ToString(),
                        reader["Level_id"].ToString(),
                        reader["Level_name"].ToString(),
                        reader["Update_day"].ToString(),
                        reader["Updater"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (cmd != null) cmd.Dispose();
                    if (conn != null) conn.Dispose();
                }
            }
            finally
            {    
                    if (cmd != null) cmd.Dispose();
                    if (conn != null) conn.Dispose();
            }
            
        }
        public void Get_Data_Device( DataGridView dgv)
        {
            
            ConectDB db = new ConectDB();
            string sSQL = @"SELECT
                                D.Device_serial_key,
                                D.DEVICE_ID, 
                                D.Name_device,                               
                                D.Quantity,
                                D.Unit,
                                D.Note,
                                U.[User_id],
                                U.Full_name
                                FROM Device D, Data_User U 
                                WHERE D.User_serial_key = U.User_serial_key";
           
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            
            try
            {
                
                conn.Open();
                OleDbDataReader oleReader = cmd.ExecuteReader();
                dgv.Rows.Clear();
                while (oleReader.Read())
                {
                    

                    dgv.Rows.Add(new object[]
                    {

                        oleReader["Device_serial_key"].ToString(),
                        oleReader["DEVICE_ID"].ToString(),
                        oleReader["Name_device"].ToString(),
                        oleReader["Quantity"].ToString(),
                        oleReader["Unit"].ToString(),
                        oleReader["Note"].ToString(),
                        oleReader["User_id"].ToString(),
                        oleReader["Full_name"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                if(ex != null)
                {
                    if (cmd != null) cmd.Dispose();
                    if (conn != null) conn.Dispose();
                }

            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conn != null) conn.Dispose();
            }
        }
        public void Get_Data_Device_Search(DataGridView dgv)
        {
            ConectDB db = new ConectDB();
            string sSQL = @"SELECT
                                D.DEVICE_ID, 
                                D.Name_device,
                                D.Unit,
                                D.Quantity,
                                D.Note,
                                u.[User_id]
                                FROM Device D, Data_User U 
                                WHERE D.User_serial_key = U.User_serial_key
                                --group by 
                                --D.DEVICE_ID, 
                                --D.Name_device,
                                --D.Unit,
                                --D.Note,
                                --u.[User_id]";

            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);

            try
            {
                conn.Open();
                OleDbDataReader oleReader = cmd.ExecuteReader();
                dgv.Rows.Clear();
                while (oleReader.Read())
                {

                    dgv.Rows.Add(new object[]
                    {
                        oleReader["Device_serial_key"].ToString(),
                        oleReader["DEVICE_ID"].ToString(),
                        oleReader["Name_device"].ToString(),
                        oleReader["Quantity"].ToString(),
                        oleReader["Unit"].ToString(),
                        oleReader["Note"].ToString(),
                        oleReader["User_id"].ToString()
                    });
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (cmd != null) cmd.Dispose();
                    if (conn != null) conn.Dispose();
                }

            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conn != null) conn.Dispose();
            }
        }
        private static string GenerateHash(string value)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(value);
            data = System.Security.Cryptography.MD5.Create().ComputeHash(data);
            return Convert.ToBase64String(data);
        }
        public bool Login(string userid, string password)
        {
            bool result = false;
            //string pass = GenerateHash(password);
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string sql = "SELECT User_id, Userpass   FROM Data_User WHERE User_id = " +
                "'" + userid.ToString() + "' and Userpass = '" + password.ToString() + "' ";
            OleDbCommand sqlcommand = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = sqlcommand.ExecuteReader();
                while(reader.Read())
                {
                    result = true;

                }
                conn.Close();
            }
            catch(Exception ex)
            {
               
            }
            return result;
        }
    }
}
