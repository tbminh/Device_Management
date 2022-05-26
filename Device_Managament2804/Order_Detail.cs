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
using OfficeOpenXml;
using OfficeOpenXml.Style;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Device_Managament2804
{
    public partial class Order_Detail : Form
    {
        public Order_Detail()
        {
            InitializeComponent();           
        }
        
        private void Order_Detail_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql1 = @"select distinct Name_device from Device, Orders where Device.Device_serial_key = Orders.Device_serial_key";
            OleDbCommand cmd1 = new OleDbCommand(sql1, conn);
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                cb_device_in_orders.Items.Add(reader1.GetString(0));
            }
            string sql = @"SELECT   do.details_serial_key,
		                            do.suggest_id,
                                    dv.Name_device,
		                            dp.Department_Name,
		                            od.ID_reciever,
		                            od.Reciever,
		                            do.operating_sys,
		                            do.ip_device,
		                            do.product_key,
		                            do.type_office,
		                            du.user_id,
		                            du.Full_name
                            from details_orders do, Data_User du, Device dv, Orders od, Data_Department dp
                            where od.User_Serial_Key = du.User_serial_key AND
	                              od.Order_Serial_Key = do.order_serial_key AND
	                              dp.Department_ID = od.Department_ID AND
	                              od.Device_serial_key = dv.Device_serial_key AND
                                  od.Order_Status = 'Out'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            show_data.Rows.Clear();
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                show_data.Rows.Add(new object[]
                {
                    reader["details_serial_key"].ToString(),
                    reader["suggest_id"].ToString(),
                    reader["Name_device"].ToString(),
                    reader["Department_Name"].ToString(),
                    reader["ID_reciever"].ToString(),
                    reader["Reciever"].ToString(),
                    reader["operating_sys"].ToString(),
                    reader["ip_device"].ToString(),
                    reader["product_key"].ToString(),
                    reader["type_office"].ToString(),
                    reader["user_id"].ToString(),
                    reader["Full_name"].ToString(),
                });
            }
            conn.Dispose();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql = @"SELECT   do.details_serial_key,
		                            do.suggest_id,
                                    dv.Name_device,
		                            dp.Department_Name,
		                            od.ID_reciever,
		                            od.Reciever,
		                            do.operating_sys,
		                            do.ip_device,
		                            do.product_key,
		                            do.type_office,
		                            du.user_id,
		                            du.Full_name
                            from details_orders do, Data_User du, Device dv, Orders od, Data_Department dp
                            where od.User_Serial_Key = du.User_serial_key AND
	                              od.Order_Serial_Key = do.order_serial_key AND
	                              dp.Department_ID = od.Department_ID AND
	                              od.Device_serial_key = dv.Device_serial_key AND
                                  od.Order_Status = 'Out' AND
                            (do.operating_sys LIKE '%' + N'" + search + @"' + '%' 
                            OR do.ip_device LIKE '%' + N'" + search + @"' + '%' 
                            OR do.type_office LIKE '%' + N'" + search + "' + '%' " +
                            "OR dp.Department_Name LIKE '%' + N'" + search + "' + '%' " +
                            "OR dv.Name_device LIKE '%' + N'" + search + "' + '%' " +
                            "OR od.ID_reciever LIKE '%' + N'" + search + "' + '%' " +
                            "OR od.Reciever LIKE '%' + N'" + search + "' + '%'" +
                            "OR do.suggest_id LIKE '%' + N'" + search + "' + '%') ";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            show_data.Rows.Clear();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_data.Rows.Add(new object[]
                {
                    reader["details_serial_key"].ToString(),
                    reader["suggest_id"].ToString(),
                    reader["Name_device"].ToString(),
                    reader["Department_Name"].ToString(),
                    reader["ID_reciever"].ToString(),
                    reader["Reciever"].ToString(),
                    reader["operating_sys"].ToString(),
                    reader["ip_device"].ToString(),
                    reader["product_key"].ToString(),
                    reader["type_office"].ToString(),
                    reader["user_id"].ToString(),
                    reader["Full_name"].ToString(),
                });
            }
            conn.Dispose();
        }
        

        private void txtSearch_Leave(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter_1(object sender, EventArgs e)
        {
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql = @"SELECT   do.details_serial_key,
		                            do.suggest_id,
                                    dv.Name_device,
		                            dp.Department_Name,
		                            od.ID_reciever,
		                            od.Reciever,
		                            do.operating_sys,
		                            do.ip_device,
		                            do.product_key,
		                            do.type_office,
		                            du.user_id,
		                            du.Full_name
                            FROM details_orders do, Data_User du, Device dv, Orders od, Data_Department dp
                            WHERE od.User_Serial_Key = du.User_serial_key AND
	                              od.Order_Serial_Key = do.order_serial_key AND
	                              dp.Department_ID = od.Department_ID AND
	                              od.Device_serial_key = dv.Device_serial_key AND
                                  od.Order_Status = 'Out'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            show_data.Rows.Clear();
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                show_data.Rows.Add(new object[]
                {
                    reader["details_serial_key"].ToString(),
                    reader["suggest_id"].ToString(),
                    reader["Name_device"].ToString(),
                    reader["Department_Name"].ToString(),
                    reader["ID_reciever"].ToString(),
                    reader["Reciever"].ToString(),
                    reader["operating_sys"].ToString(),
                    reader["ip_device"].ToString(),
                    reader["product_key"].ToString(),
                    reader["type_office"].ToString(),
                    reader["user_id"].ToString(),
                    reader["Full_name"].ToString(),
                });
            }
            conn.Dispose();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        enum dgvenum :int
        {
            details_serial_key,
            suggest_id,
            name_device,
            department_name,
            id_reciever,
            reciever,
            opera_sys,
            ip_device,
            product_key,
            type_office,
            user_id,
            full_name
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            //SaveFileDialog dung de luu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    // nếu tồn tại tên file thì xóa file đó đi (thao tác tập tin và thư mục)
                    if (File.Exists(saveFileDialog.FileName)) File.Delete(saveFileDialog.FileName);
                    FileInfo fiLog = new FileInfo(saveFileDialog.FileName);
                    //su dung excel
                    using (ExcelPackage p = new ExcelPackage(fiLog))
                    {
                        //Create sheet1 with rename "TK_DonHang"    
                        ExcelWorksheet worksheet = p.Workbook.Worksheets.Add("TK_DonHang");
                        //        worksheet.View.ShowGridLines = true;
                        //        worksheet.Name = "Giờ vào ra";
                        //        worksheet.Cells.Style.WrapText = true;
                        worksheet.Cells.Style.Font.Name = "Time New Roman";
                        //        //freeze panes
                        //        worksheet.View.FreezePanes(6, 2);

                        //Title for page
                        worksheet.Cells["A1:N1"].Merge = true;
                        worksheet.Cells["A1"].Value = "CÔNG TY TNHH LẠC TỶ II";
                        worksheet.Cells["A2:N2"].Merge = true;
                        worksheet.Cells["A2"].Value = "Lô B1, B2 KCN Tân Phú Thạnh - giai đoạn 1, H. Châu Thành A, T. Hậu Giang";
                        worksheet.Cells["A3:N3"].Merge = true;
                        worksheet.Cells["A3"].Value = "THÔNG TIN THIẾT BỊ ";

                        // auto filter
                        worksheet.Cells["A5:L5"].AutoFilter = true;

                        //        //border
                        worksheet.Cells["A5:" + "L" + (show_data.RowCount + 5)].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells["A5:" + "L" + (show_data.RowCount + 5)].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells["A5:" + "L" + (show_data.RowCount + 5)].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells["A5:" + "L" + (show_data.RowCount + 5)].Style.Border.Left.Style = ExcelBorderStyle.Thin;



                        worksheet.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        worksheet.Cells["A1:L3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        worksheet.Cells["A1:L3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        worksheet.Cells["A5:L5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells["A5:L5"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 255, 204));

                        worksheet.Cells["B5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells["A1:L5"].Style.Font.Bold = true;
                        worksheet.Cells["A1:L3"].Style.Font.Size = 16;
                        worksheet.Cells["A5:L5"].Style.Font.Size = 12;


                        // worksheet.Cells["A1:P1"].AutoFilter = true;
                        //worksheet.Cells["A1:P1"].Style.Font.Color.SetColor(Color.White);
                        worksheet.Cells["A1:L1"].Style.Font.Bold = true;
                        worksheet.Cells["A1:L1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        //worksheet.Cells["A1:P1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(31, 78, 120));

                        //Set width for column
                        worksheet.Row(1).Height = 30D;
                        worksheet.Row(2).Height = 30D;
                        worksheet.Row(3).Height = 30D;
                        worksheet.Column(2).Width = 19D;
                        worksheet.Column(3).Width = 25.29D;
                        worksheet.Column(4).Width = 25.86D;
                        worksheet.Column(5).Width = 20D;
                        worksheet.Column(6).Width = 25D;
                        worksheet.Column(7).Width = 25D;
                        worksheet.Column(8).Width = 25D;
                        worksheet.Column(9).Width = 25D;
                        worksheet.Column(10).Width = 25D;
                        worksheet.Column(11).Width = 26D;
                        worksheet.Column(12).Width = 26D;
                        worksheet.Column(13).Width = 26D;
                        worksheet.Column(14).Width = 26D;
                        worksheet.Column(15).Width = 26D;
                        worksheet.Column(16).Width = 26D;
                        worksheet.Column(17).Width = 26D;

                        //Set header on Row 1
                        worksheet.Cells["A" + 5].Value = "STT";
                        worksheet.Cells["B" + 5].Value = "Mã Đề Nghị";
                        worksheet.Cells["C" + 5].Value = "Tên Thiết Bị";
                        worksheet.Cells["D" + 5].Value = "Bộ Phận";
                        worksheet.Cells["E" + 5].Value = "Số Thẻ";
                        worksheet.Cells["F" + 5].Value = "NV Sử Dụng";
                        worksheet.Cells["G" + 5].Value = "Hệ Điều Hành";
                        worksheet.Cells["H" + 5].Value = "IP Thiết Bị";
                        worksheet.Cells["I" + 5].Value = "Key Bản Quyền";
                        worksheet.Cells["J" + 5].Value = "Office";
                        worksheet.Cells["K" + 5].Value = "Mã Nhân Viên";
                        worksheet.Cells["L" + 5].Value = "NV Phụ Trách";
                        //        //worksheet.Cells["A6"].LoadFromDataTable(cls_BaoCao.BaoCao(query), true);
                        //        //worksheet.Column(15).Width = 20D;
                        //        for (i = 0; i < dgv_GioRaCong.RowCount; i++)
                        //            worksheet.Row(i + 5).Height = 16.00D;

                        // Add value from dataGridView to file Excel

                        for (int i = 0; i < show_data.RowCount; i++)
                        {
                            int kq = i;
                            //worksheet.Cells["A" + (i + 6)].Value = i + 1;
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.details_serial_key].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["A" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.details_serial_key].Value.ToString();
                            }
                            else worksheet.Cells["A" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.suggest_id].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["B" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.suggest_id].Value.ToString();
                            }
                            else worksheet.Cells["B" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.name_device].Value != "")
                            {
                                worksheet.Cells["C" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.name_device].Value.ToString();
                            }
                            else worksheet.Cells["C" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.department_name].Value != "")
                            {
                                worksheet.Cells["D" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.department_name].Value.ToString();
                            }
                            else worksheet.Cells["D" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.id_reciever].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["E" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.id_reciever].Value.ToString();
                            }
                            else worksheet.Cells["E" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.reciever].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["F" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.reciever].Value.ToString();
                            }
                            else worksheet.Cells["F" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.opera_sys].Value != "")
                            {
                                worksheet.Cells["G" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.opera_sys].Value.ToString();
                            }
                            else worksheet.Cells["G" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.ip_device].Value != "")
                            {
                                worksheet.Cells["H" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.ip_device].Value.ToString();
                            }
                            else worksheet.Cells["H" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.product_key].Value != "")
                            {
                                worksheet.Cells["I" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.product_key].Value.ToString();
                            }
                            else worksheet.Cells["I" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.type_office].Value != "")
                            {
                                worksheet.Cells["J" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.type_office].Value.ToString();
                            }
                            else worksheet.Cells["J" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.user_id].Value != "")
                            {
                                worksheet.Cells["K" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.user_id].Value.ToString();
                            }
                            else worksheet.Cells["K" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.full_name].Value != "")
                            {
                                worksheet.Cells["L" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.full_name].Value.ToString();
                            }
                            else worksheet.Cells["L" + (i + 6)].Value = "";
                            //if (dgv_GioRaCong.Rows[(i)].Cells[(int)eGiora.GhiChu].Value.ToString() != "")
                            //{
                            //    worksheet.Cells["I" + (i + 6)].Value = dgv_GioRaCong.Rows[(i)].Cells[(int)eGiora.GhiChu].Value.ToString();
                            //    worksheet.Row(i + 6).Height = 67D;
                            //}
                            //else worksheet.Cells["I" + (i + 6)].Value = "";
                            //if (dgv_GioRaCong.Rows[(i)].Cells[(int)eGiora.TenCong].Value.ToString() != "")
                            //    worksheet.Cells["J" + (i + 6)].Value = dgv_GioRaCong.Rows[(i)].Cells[(int)eGiora.TenCong].Value.ToString();
                            //else worksheet.Cells["J" + (i + 6)].Value = "";
                        }
                        p.Save();
                        MessageBox.Show("Completed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cursor = Cursors.Default;

                        string argument = "/select, \"" + saveFileDialog.FileName + "\"";
                        var fol = new ProcessStartInfo("explorer.exe", argument);
                        fol.WindowStyle = ProcessWindowStyle.Maximized;
                        Process.Start(fol);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (ex is IOException)
                    {
                        MessageBox.Show("There is an error when exporting excel file! please close all opening excel files and try again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    Cursor = Cursors.Default;
                }
            }
        }

        private void cb_device_in_orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string name_device = cb_device_in_orders.SelectedItem.ToString();
            string sql_show_data = @"SELECT   do.details_serial_key,
		                            do.suggest_id,
                                    dv.Name_device,
		                            dp.Department_Name,
		                            od.ID_reciever,
		                            od.Reciever,
		                            do.operating_sys,
		                            do.ip_device,
		                            do.product_key,
		                            do.type_office,
		                            du.user_id,
		                            du.Full_name
                            from details_orders do, Data_User du, Device dv, Orders od, Data_Department dp
                            where od.User_Serial_Key = du.User_serial_key AND
	                              od.Order_Serial_Key = do.order_serial_key AND
	                              dp.Department_ID = od.Department_ID AND
	                              od.Device_serial_key = dv.Device_serial_key AND
                            (dv.Name_device LIKE '%' + N'" + name_device + "' + '%') ";
            OleDbCommand cmd1 = new OleDbCommand(sql_show_data, conn);
            show_data.Rows.Clear();
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                show_data.Rows.Add(new object[]
                {
                    reader1["details_serial_key"].ToString(),
                    reader1["suggest_id"].ToString(),
                    reader1["Name_device"].ToString(),
                    reader1["Department_Name"].ToString(),
                    reader1["ID_reciever"].ToString(),
                    reader1["Reciever"].ToString(),
                    reader1["operating_sys"].ToString(),
                    reader1["ip_device"].ToString(),
                    reader1["product_key"].ToString(),
                    reader1["type_office"].ToString(),
                    reader1["user_id"].ToString(),
                    reader1["Full_name"].ToString(),
                });
            }
            conn.Dispose();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql = @"UPDATE details_orders
                            SET operating_sys= N'" + txt_hdh.Text + "'," +
                            "   ip_device = N'" + txt_ip.Text + "'," +
                            "   product_key = N'" + txt_key.Text + "'," +
                            "   type_office = N'" + txt_office.Text + "'" +
                            "WHERE details_serial_key = '" + txt_details_serial.Text +"'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã Cập Nhật!");
            Order_Detail_Load(sender, e);
            conn.Dispose();
        }
        private void show_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_details_serial.Text = show_data.CurrentRow.Cells[(int)dgvenum.details_serial_key].Value.ToString();
            txt_hdh.Text = show_data.CurrentRow.Cells[(int)dgvenum.opera_sys].Value.ToString();
            txt_ip.Text = show_data.CurrentRow.Cells[(int)dgvenum.ip_device].Value.ToString();
            txt_key.Text = show_data.CurrentRow.Cells[(int)dgvenum.product_key].Value.ToString();
            txt_office.Text = show_data.CurrentRow.Cells[(int)dgvenum.type_office].Value.ToString();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Order_Manage frm = new Order_Manage();
            frm.Show();
        }
    }
}
