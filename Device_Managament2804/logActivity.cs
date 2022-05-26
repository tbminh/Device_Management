using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Diagnostics;

namespace Device_Managament2804
{
    public partial class Frm_history : Form
    {
        public Frm_history()
        {
            InitializeComponent();
        }
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_history_Load(object sender, EventArgs e)
        {
            dgv_history_device.Hide();
            dgv_history_order.Hide();
            dgv_log_user.Hide();
        }
        //enum dgvenumshow : int
        //{
        //    log_stt,user_id,user_full_name,status_name,IP_address,MAC_address,Host_name,time_log
        //}
        private void button1_Click(object sender, EventArgs e)
        {
            dgv_log_user.Show();
            dgv_history_device.Hide();
            dgv_history_order.Hide();
            ///////////////////////////////////////////////////////////
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql_show_log_user = @"SELECT row_number() OVER (ORDER BY log_stt)stt,
                                                user_id,user_full_name,status_name,
                                                IP_address,MAC_address,Host_name,time_log
                                        FROM log_user";   
            OleDbCommand cmd_show_log_user = new OleDbCommand(sql_show_log_user, conn);
            OleDbDataReader read_log_user = cmd_show_log_user.ExecuteReader();
            dgv_log_user.Rows.Clear();
            while (read_log_user.Read())
            {
                dgv_log_user.Rows.Add(new object[]
                {
                    read_log_user["stt"].ToString(),
                    read_log_user["user_id"].ToString(),
                    read_log_user["user_full_name"].ToString(),
                    read_log_user["status_name"].ToString(),
                    read_log_user["IP_address"].ToString(),
                    read_log_user["MAC_address"].ToString(),
                    read_log_user["Host_name"].ToString(),
                    read_log_user["time_log"].ToString()
                });
            }
            conn.Dispose();
        }

        private void btn_Order_show_Click(object sender, EventArgs e)
        {
            dgv_history_order.Show();
            dgv_log_user.Hide();
            dgv_history_device.Hide();
            /////////////////////////////////////////
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql_history_order_show = @"SELECT   row_number() OVER (ORDER BY Hod_serial_key)stt,
	                                                    H.Device_serial_key,
	                                                    H.suggest_id,
	                                                    D.Name_device,
	                                                    H.Order_Quantity,
                                                        H.Department_ID,
	                                                    H.Order_expect_date,
	                                                    H.Order_date,
	                                                    H.Order_Modify_Date,
	                                                    H.Order_Status,
	                                                    H.Order_Note,
	                                                    H.time_update,
	                                                    H.IP_address,
	                                                    H.MAC_address,
	                                                    H.Host_name,
	                                                    H.Action,
                                                        U.User_id,
	                                                    U.Full_name
                                        FROM  History_orders as H, Data_User as U, Device as D
                                        WHERE H.user_serial_key = U.user_serial_key AND
                                              H.Device_serial_key = D.Device_serial_key";
            dgv_history_order.Rows.Clear();
            OleDbCommand cmd_history_order_show = new OleDbCommand(sql_history_order_show, conn);
            OleDbDataReader read_history_order = cmd_history_order_show.ExecuteReader();
            while (read_history_order.Read())
            {
                dgv_history_order.Rows.Add(new object[]
                {
                    read_history_order["stt"].ToString(),
                    read_history_order["Name_device"].ToString(),
                    read_history_order["suggest_id"].ToString(),
                    read_history_order["Department_ID"].ToString(),
                    read_history_order["Order_expect_date"].ToString(),
                    read_history_order["Order_date"].ToString(),
                    read_history_order["Order_Quantity"].ToString(),
                    read_history_order["Order_Status"].ToString(),
                    read_history_order["Order_Modify_Date"].ToString(),
                    read_history_order["IP_address"].ToString(),
                    read_history_order["MAC_address"].ToString(),
                    read_history_order["Host_name"].ToString(),
                    read_history_order["Order_Note"].ToString(),
                    read_history_order["User_id"].ToString(),
                    read_history_order["Full_name"].ToString(),
                    read_history_order["Action"].ToString(),
                    read_history_order["time_update"].ToString()
                });
            }
            conn.Dispose();
        }

        private void btn_device_show_Click(object sender, EventArgs e)
        {
            dgv_history_device.Show();
            dgv_log_user.Hide();
            dgv_history_order.Hide();
            /////////////////////////////////////////
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql_history_device_show = @"SELECT  row_number() OVER (ORDER BY hd_serial_key)stt,
                                                       H.hd_serial_key,
	                                                   --Device_serial_key,
	                                                   H.device_id,
	                                                   H.device_name,
	                                                   H.device_quantity,
	                                                   H.device_unit,
	                                                   H.status_log,
	                                                   H.time_update,
	                                                   H.IP_address,
	                                                   H.MAC_address,
	                                                   H.Host_name,
                                                       U.User_id,
	                                                   U.Full_name
                                                FROM History_device H, Data_User U
                                                WHERE U.User_id = '" + FrmLogin.id.ToString()+"'";
            dgv_history_device.Rows.Clear();
            OleDbCommand cmd_history_device_show = new OleDbCommand(sql_history_device_show, conn);
            OleDbDataReader read_history_device = cmd_history_device_show.ExecuteReader();
            while(read_history_device.Read())
            {
                dgv_history_device.Rows.Add(new object[]
                {
                    read_history_device["stt"].ToString(),
                    read_history_device["device_id"].ToString(),
                    read_history_device["device_name"].ToString(),
                    read_history_device["device_quantity"].ToString(),
                    read_history_device["device_unit"].ToString(),
                    read_history_device["status_log"].ToString(),
                    read_history_device["time_update"].ToString(),
                    read_history_device["IP_address"].ToString(),
                    read_history_device["MAC_address"].ToString(),
                    read_history_device["Host_name"].ToString(),
                    read_history_device["User_id"].ToString(),
                    read_history_device["Full_name"].ToString()
                });
            }
            conn.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void btn_search_show_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql_show_log_user = @"SELECT log_stt,user_id,user_full_name,status_name,
                                                IP_address,MAC_address,Host_name,time_log
                                        FROM log_user
                                        WHERE user_id LIKE '%'+'" + txt_search.Text.Trim() + "'+'%'";
            OleDbCommand cmd_show_log_user = new OleDbCommand(sql_show_log_user, conn);
            OleDbDataReader read_log_user = cmd_show_log_user.ExecuteReader();
            dgv_log_user.Rows.Clear();
            while (read_log_user.Read())
            {
                dgv_log_user.Rows.Add(new object[]
                {
                    read_log_user["log_stt"].ToString(),
                    read_log_user["user_id"].ToString(),
                    read_log_user["user_full_name"].ToString(),
                    read_log_user["status_name"].ToString(),
                    read_log_user["IP_address"].ToString(),
                    read_log_user["MAC_address"].ToString(),
                    read_log_user["Host_name"].ToString(),
                    read_log_user["time_log"].ToString()
                });
            }
            ////////////////////////////////////////////////////
            string sql_history_order_show = @"SELECT   H.Hod_serial_key,
	                                                    H.Device_serial_key,
	                                                    H.suggest_id,
	                                                    D.Name_device,
	                                                    H.Order_Quantity,
                                                        H.Department_ID,
	                                                    H.Order_expect_date,
	                                                    H.Order_date,
	                                                    H.Order_Modify_Date,
	                                                    H.Order_Status,
	                                                    H.Order_Note,
	                                                    H.time_update,
	                                                    H.IP_address,
	                                                    H.MAC_address,
	                                                    H.Host_name,
	                                                    H.Action,
                                                        U.User_id,
	                                                    U.Full_name
                                        FROM  History_orders as H, Data_User as U, Device as D
                                        WHERE H.user_serial_key = U.user_serial_key AND
                                              H.Device_serial_key = D.Device_serial_key AND 
                                              U.User_id LIKE '%'+'" + txt_search.Text.Trim() + "'+'%'";
            dgv_history_order.Rows.Clear();
            OleDbCommand cmd_history_order_show = new OleDbCommand(sql_history_order_show, conn);
            OleDbDataReader read_history_order = cmd_history_order_show.ExecuteReader();
            while (read_history_order.Read())
            {
                dgv_history_order.Rows.Add(new object[]
                {
                    read_history_order["Hod_serial_key"].ToString(),
                    read_history_order["Name_device"].ToString(),
                    read_history_order["suggest_id"].ToString(),
                    read_history_order["Department_ID"].ToString(),
                    read_history_order["Order_expect_date"].ToString(),
                    read_history_order["Order_date"].ToString(),
                    read_history_order["Order_Quantity"].ToString(),
                    read_history_order["Order_Status"].ToString(),
                    read_history_order["Order_Modify_Date"].ToString(),
                    read_history_order["IP_address"].ToString(),
                    read_history_order["MAC_address"].ToString(),
                    read_history_order["Host_name"].ToString(),
                    read_history_order["Order_Note"].ToString(),
                    read_history_order["User_id"].ToString(),
                    read_history_order["Full_name"].ToString(),
                    read_history_order["Action"].ToString(),
                    read_history_order["time_update"].ToString(),

                });
            }
            ///////////////////////////////////////////////
            string sql_history_device_show = @"SELECT  H.hd_serial_key,
	                                                   --Device_serial_key,
	                                                   H.device_id,
	                                                   H.device_name,
	                                                   H.device_quantity,
	                                                   H.device_unit,
	                                                   H.status_log,
	                                                   H.time_update,
	                                                   H.IP_address,
	                                                   H.MAC_address,
	                                                   H.Host_name,
                                                       U.User_id,
	                                                   U.Full_name
                                                FROM History_device H, Data_User U
                                                WHERE U.User_id = '" + FrmLogin.id.ToString() + "' AND U.User_id LIKE '%'+'" + txt_search.Text.Trim() + "'+'%'";
            dgv_history_device.Rows.Clear();
            OleDbCommand cmd_history_device_show = new OleDbCommand(sql_history_device_show, conn);
            OleDbDataReader read_history_device = cmd_history_device_show.ExecuteReader();
            while (read_history_device.Read())
            {
                dgv_history_device.Rows.Add(new object[]
                {
                    read_history_device["hd_serial_key"].ToString(),
                    read_history_device["device_id"].ToString(),
                    read_history_device["device_name"].ToString(),
                    read_history_device["device_quantity"].ToString(),
                    read_history_device["device_unit"].ToString(),
                    read_history_device["status_log"].ToString(),
                    read_history_device["time_update"].ToString(),
                    read_history_device["IP_address"].ToString(),
                    read_history_device["MAC_address"].ToString(),
                    read_history_device["Host_name"].ToString(),
                    read_history_device["User_id"].ToString(),
                    read_history_device["Full_name"].ToString(),

                });
            }
            conn.Dispose();
        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            if(txt_search.Text =="")
            {
                txt_search.Text = "Tìm kiếm theo MÃ NV";
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql_show_log_user = @"SELECT log_stt,user_id,user_full_name,status_name,
                                                IP_address,MAC_address,Host_name,time_log
                                        FROM log_user
                                        WHERE user_id LIKE '%'+'" + txt_search.Text.Trim() + "'+'%'";
            OleDbCommand cmd_show_log_user = new OleDbCommand(sql_show_log_user, conn);
            OleDbDataReader read_log_user = cmd_show_log_user.ExecuteReader();
            dgv_log_user.Rows.Clear();
            while (read_log_user.Read())
            {
                dgv_log_user.Rows.Add(new object[]
                {
                    read_log_user["log_stt"].ToString(),
                    read_log_user["user_id"].ToString(),
                    read_log_user["user_full_name"].ToString(),
                    read_log_user["status_name"].ToString(),
                    read_log_user["IP_address"].ToString(),
                    read_log_user["MAC_address"].ToString(),
                    read_log_user["Host_name"].ToString(),
                    read_log_user["time_log"].ToString()
                });
            }
            ////////////////////////////////////////////////////
            string sql_history_order_show = @"SELECT   H.Hod_serial_key,
	                                                    H.Device_serial_key,
	                                                    H.suggest_id,
	                                                    D.Name_device,
	                                                    H.Order_Quantity,
                                                        H.Department_ID,
	                                                    H.Order_expect_date,
	                                                    H.Order_date,
	                                                    H.Order_Modify_Date,
	                                                    H.Order_Status,
	                                                    H.Order_Note,
	                                                    H.time_update,
	                                                    H.IP_address,
	                                                    H.MAC_address,
	                                                    H.Host_name,
	                                                    H.Action,
                                                        U.User_id,
	                                                    U.Full_name
                                        FROM  History_orders as H, Data_User as U, Device as D
                                        WHERE H.user_serial_key = U.user_serial_key AND
                                              H.Device_serial_key = D.Device_serial_key AND 
                                              U.User_id LIKE '%'+'" + txt_search.Text.Trim() + "'+'%'";
            dgv_history_order.Rows.Clear();
            OleDbCommand cmd_history_order_show = new OleDbCommand(sql_history_order_show, conn);
            OleDbDataReader read_history_order = cmd_history_order_show.ExecuteReader();
            while (read_history_order.Read())
            {
                dgv_history_order.Rows.Add(new object[]
                {
                    read_history_order["Hod_serial_key"].ToString(),
                    read_history_order["Name_device"].ToString(),
                    read_history_order["suggest_id"].ToString(),
                    read_history_order["Department_ID"].ToString(),
                    read_history_order["Order_expect_date"].ToString(),
                    read_history_order["Order_date"].ToString(),
                    read_history_order["Order_Quantity"].ToString(),
                    read_history_order["Order_Status"].ToString(),
                    read_history_order["Order_Modify_Date"].ToString(),
                    read_history_order["IP_address"].ToString(),
                    read_history_order["MAC_address"].ToString(),
                    read_history_order["Host_name"].ToString(),
                    read_history_order["Order_Note"].ToString(),
                    read_history_order["User_id"].ToString(),
                    read_history_order["Full_name"].ToString(),
                    read_history_order["Action"].ToString(),
                    read_history_order["time_update"].ToString(),

                });
            }
            ///////////////////////////////////////////////
            string sql_history_device_show = @"SELECT  H.hd_serial_key,
	                                                   --Device_serial_key,
	                                                   H.device_id,
	                                                   H.device_name,
	                                                   H.device_quantity,
	                                                   H.device_unit,
	                                                   H.status_log,
	                                                   H.time_update,
	                                                   H.IP_address,
	                                                   H.MAC_address,
	                                                   H.Host_name,
                                                       U.User_id,
	                                                   U.Full_name
                                                FROM History_device H, Data_User U
                                                WHERE U.User_id = '" + FrmLogin.id.ToString() + "' AND U.User_id LIKE '%'+'" + txt_search.Text.Trim() + "'+'%'";
            dgv_history_device.Rows.Clear();
            OleDbCommand cmd_history_device_show = new OleDbCommand(sql_history_device_show, conn);
            OleDbDataReader read_history_device = cmd_history_device_show.ExecuteReader();
            while (read_history_device.Read())
            {
                dgv_history_device.Rows.Add(new object[]
                {
                    read_history_device["hd_serial_key"].ToString(),
                    read_history_device["device_id"].ToString(),
                    read_history_device["device_name"].ToString(),
                    read_history_device["device_quantity"].ToString(),
                    read_history_device["device_unit"].ToString(),
                    read_history_device["status_log"].ToString(),
                    read_history_device["time_update"].ToString(),
                    read_history_device["IP_address"].ToString(),
                    read_history_device["MAC_address"].ToString(),
                    read_history_device["Host_name"].ToString(),
                    read_history_device["User_id"].ToString(),
                    read_history_device["Full_name"].ToString(),

                });
            }
            conn.Dispose();
        }

         
        private void txt_search_Leave_1(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                //txt_search.Text = "Nhập thông tin tìm kiếm...";
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql_show_log_user = @"SELECT log_stt,user_id,user_full_name,status_name,
                                                IP_address,MAC_address,Host_name,time_log
                                        FROM log_user
                                        WHERE user_id LIKE '%'+'" + txt_search.Text.Trim() + "'+'%'";
            OleDbCommand cmd_show_log_user = new OleDbCommand(sql_show_log_user, conn);
            OleDbDataReader read_log_user = cmd_show_log_user.ExecuteReader();
            dgv_log_user.Rows.Clear();
            while (read_log_user.Read())
            {
                dgv_log_user.Rows.Add(new object[]
                {
                    read_log_user["log_stt"].ToString(),
                    read_log_user["user_id"].ToString(),
                    read_log_user["user_full_name"].ToString(),
                    read_log_user["status_name"].ToString(),
                    read_log_user["IP_address"].ToString(),
                    read_log_user["MAC_address"].ToString(),
                    read_log_user["Host_name"].ToString(),
                    read_log_user["time_log"].ToString()
                });
            }
            ////////////////////////////////////////////////////
            string sql_history_order_show = @"SELECT   H.Hod_serial_key,
	                                                    H.Device_serial_key,
	                                                    H.suggest_id,
	                                                    D.Name_device,
	                                                    H.Order_Quantity,
                                                        H.Department_ID,
	                                                    H.Order_expect_date,
	                                                    H.Order_date,
	                                                    H.Order_Modify_Date,
	                                                    H.Order_Status,
	                                                    H.Order_Note,
	                                                    H.time_update,
	                                                    H.IP_address,
	                                                    H.MAC_address,
	                                                    H.Host_name,
	                                                    H.Action,
                                                        U.User_id,
	                                                    U.Full_name
                                        FROM  History_orders as H, Data_User as U, Device as D
                                        WHERE H.user_serial_key = U.user_serial_key AND
                                              H.Device_serial_key = D.Device_serial_key AND 
                                              H.time_update BETWEEN '" + dpk_from.Value + "' AND '" + dpk_to.Value + "'";
            dgv_history_order.Rows.Clear();
            OleDbCommand cmd_history_order_show = new OleDbCommand(sql_history_order_show, conn);
            OleDbDataReader read_history_order = cmd_history_order_show.ExecuteReader();
            while (read_history_order.Read())
            {
                dgv_history_order.Rows.Add(new object[]
                {
                    read_history_order["Hod_serial_key"].ToString(),
                    read_history_order["Name_device"].ToString(),
                    read_history_order["suggest_id"].ToString(),
                    read_history_order["Department_ID"].ToString(),
                    read_history_order["Order_expect_date"].ToString(),
                    read_history_order["Order_date"].ToString(),
                    read_history_order["Order_Quantity"].ToString(),
                    read_history_order["Order_Status"].ToString(),
                    read_history_order["Order_Modify_Date"].ToString(),
                    read_history_order["IP_address"].ToString(),
                    read_history_order["MAC_address"].ToString(),
                    read_history_order["Host_name"].ToString(),
                    read_history_order["Order_Note"].ToString(),
                    read_history_order["User_id"].ToString(),
                    read_history_order["Full_name"].ToString(),
                    read_history_order["Action"].ToString(),
                    read_history_order["time_update"].ToString(),

                });
            }
            ///////////////////////////////////////////////
            string sql_history_device_show = @"SELECT  H.hd_serial_key,
	                                                   --Device_serial_key,
	                                                   H.device_id,
	                                                   H.device_name,
	                                                   H.device_quantity,
	                                                   H.device_unit,
	                                                   H.status_log,
	                                                   H.time_update,
	                                                   H.IP_address,
	                                                   H.MAC_address,
	                                                   H.Host_name,
                                                       U.User_id,
	                                                   U.Full_name
                                                FROM History_device H, Data_User U
                                                WHERE U.User_id = '" + FrmLogin.id.ToString() + "' AND H.time_update BETWEEN '" + dpk_from.Value + "' AND '" + dpk_to.Value + "'";
            dgv_history_device.Rows.Clear();
            OleDbCommand cmd_history_device_show = new OleDbCommand(sql_history_device_show, conn);
            OleDbDataReader read_history_device = cmd_history_device_show.ExecuteReader();
            while (read_history_device.Read())
            {
                dgv_history_device.Rows.Add(new object[]
                {
                    read_history_device["hd_serial_key"].ToString(),
                    read_history_device["device_id"].ToString(),
                    read_history_device["device_name"].ToString(),
                    read_history_device["device_quantity"].ToString(),
                    read_history_device["device_unit"].ToString(),
                    read_history_device["status_log"].ToString(),
                    read_history_device["time_update"].ToString(),
                    read_history_device["IP_address"].ToString(),
                    read_history_device["MAC_address"].ToString(),
                    read_history_device["Host_name"].ToString(),
                    read_history_device["User_id"].ToString(),
                    read_history_device["Full_name"].ToString(),

                });
            }
            string sql_select_log_user = @"select * from log_user where time_log BETWEEN '" + dpk_from.Value + "' AND '" + dpk_to.Value + "'";
            OleDbCommand cmd_select_log_user = new OleDbCommand(sql_select_log_user, conn);
            dgv_log_user.Rows.Clear();
            OleDbDataReader reader_log_user = cmd_select_log_user.ExecuteReader();
            while(reader_log_user.Read())
            {
                dgv_log_user.Rows.Add(new object[]
                {
                    reader_log_user["log_stt"].ToString(),
                    reader_log_user["user_id"].ToString(),
                    reader_log_user["user_full_name"].ToString(),
                    reader_log_user["status_name"].ToString(),
                    reader_log_user["IP_address"].ToString(),
                    reader_log_user["MAC_address"].ToString(),
                    reader_log_user["Host_name"].ToString(),
                    reader_log_user["time_log"].ToString(),
                });
            }    
            conn.Dispose();
            
        }

        private void dgv_history_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
