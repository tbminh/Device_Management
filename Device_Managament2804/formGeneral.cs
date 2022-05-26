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
    public partial class frmViewAll : Form
    {
        Data_User user = new Data_User();
        public frmViewAll()
        {
            InitializeComponent();
        }
        enum dgvenum : int
        {
            Device_serial_key,
            Name_device,
            Device_ID,
            Quantity,
            Unit,
            Note,
            Suggess_id,
            Order_Date,
            Order_Expected_Date,
            Order_Modify_Date,
            Order_Status,
            Order_Quantity,
            Full_Name,
            Department_Name,
            Department_ID,
            Order_Note
        }
        OleDbConnection connn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
        private void btn_ViewAll_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string sql = @"SELECT	D.Device_serial_key,
                                    D.Name_device,
									Device_ID,
									D.Quantity,
									D.Unit,
									D.Note,
									O.Suggest_id,
									O.Order_Date,
									O.Order_Expected_Date,
									O.Order_Modify_Date,
									O.Order_Status,
									O.Order_Quantity,
									U.Full_name,
									DP.Department_Name,
									O.Order_Note
							FROM    Data_User U, Device D, Orders O, Data_Department DP
							WHERE	U.User_serial_key = D.User_serial_key AND
									D.Device_serial_key = O.Device_serial_key AND
									O.Department_ID = DP.Department_ID";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			try
            {
				conn.Open();
				OleDbDataReader reader = cmd.ExecuteReader();
				dgv_view_all.Rows.Clear();
				while(reader.Read())
                {
					dgv_view_all.Rows.Add(new object[]
					{
                        reader["Device_serial_key"].ToString(),
						reader["Name_device"].ToString(),
						reader["Device_ID"].ToString(),
						reader["Quantity"].ToString(),
						reader["Unit"].ToString(),
						reader["Note"].ToString(),
						reader["Suggest_id"].ToString(),
						reader["Order_Date"].ToString(),
						reader["Order_Expected_Date"].ToString(),
						reader["Order_Modify_Date"].ToString(),
						reader["Order_Status"].ToString(),
						reader["Order_Quantity"].ToString(),
						reader["Full_name"].ToString(),
						reader["Department_Name"].ToString(),
						reader["Order_Note"].ToString(),
					});
                }
            }
			catch (Exception ex)
            {
				conn.Dispose();
            }			
        }

        private void btn_toDevice_Click(object sender, EventArgs e)
        {
			frmDevice frm = new frmDevice();
			frm.Show();
			this.Hide();
			
        }

        private void frmViewAll_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string lv_id = "";
            string sql = @"SELECT Level_id FROM Data_User Where User_id = '"+FrmLogin.id.ToString()+"'";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                lv_id = reader["Level_id"].ToString();
                if(lv_id == "6")
                {
                    btn_device_managament.Visible = false;
                    btn_user_managament.Visible = false;
                    btn_history.Visible = false;
                }
                else
                {
                    if(lv_id == "5")
                    {
                        btn_device_managament.Visible = false;
                        btn_user_managament.Visible = false;
                    }
                    else
                    {
                        if(lv_id == "4")
                        {
                            btn_device_managament.Visible = false;
                            btn_user_managament.Visible = false;
                        }
                        else 
                        {
                            if(lv_id == "3")
                            {
                                btn_user_managament.Visible = false;
                            }
                        }
                    }
                }
            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ViewDate_Click(object sender, EventArgs e)
        {
			OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
			string sql1 = @"SELECT  D.Device_serial_key,
                                    D.Name_device,
									Device_ID,
									D.Quantity,
									D.Unit,
									D.Note,
									O.Suggest_id,
									O.Order_Date,
									O.Order_Expected_Date,
									O.Order_Modify_Date,
									O.Order_Status,
									O.Order_Quantity,
									U.Full_name,
									DP.Department_Name,
									O.Order_Note
							FROM    Data_User U, Device D, Orders O, Data_Department DP
							WHERE	U.User_serial_key = D.User_serial_key AND
									D.Device_serial_key = O.Device_serial_key AND
									O.Department_ID = DP.Department_ID AND
									CONVERT(date,o.Order_Date) between '" + dpk_from.Value.ToString("MM/dd/yyyy") + "' and '" + dpk_to.Value.ToString("MM/dd/yyyy") + "'";
									
			OleDbCommand cmd1 = new OleDbCommand(sql1, conn);
			try
			{
				conn.Open();
				OleDbDataReader reader = cmd1.ExecuteReader();
				dgv_view_all.Rows.Clear();
				while (reader.Read())
				{
					dgv_view_all.Rows.Add(new object[]
					{
                        reader["Device_serial_key"].ToString(),
						reader["Name_device"].ToString(),
						reader["Device_ID"].ToString(),
						reader["Quantity"].ToString(),
						reader["Unit"].ToString(),
						reader["Note"].ToString(),
						reader["Suggest_id"].ToString(),
						reader["Order_Date"].ToString(),
						reader["Order_Expected_Date"].ToString(),
						reader["Order_Modify_Date"].ToString(),
						reader["Order_Status"].ToString(),
						reader["Order_Quantity"].ToString(),
						reader["Full_name"].ToString(),
						reader["Department_Name"].ToString(),
						reader["Order_Note"].ToString(),
					});
				}
			}
			catch (Exception ex)
			{
				conn.Dispose();
            }
        }
		private void copyAlltoClipboard()
		{
			dgv_view_all.SelectAll();
			DataObject dataObj = dgv_view_all.GetClipboardContent();
			if (dataObj != null)
				Clipboard.SetDataObject(dataObj);
		}
		private void btn_view_excel_Click(object sender, EventArgs e)
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
                        //worksheet.Cells["A1:J1"].Merge = true;
                        //worksheet.Cells["A1"].Value = "CÔNG TY TNHH LẠC TỶ II";
                        //worksheet.Cells["A2:J2"].Merge = true;
                        //worksheet.Cells["A2"].Value = "Lô B1, B2 KCN Tân Phú Thạnh - giai đoạn 1, H. Châu Thành A, T. Hậu Giang";
                        //worksheet.Cells["A3:J3"].Merge = true;
                        //worksheet.Cells["A3"].Value = "BÁO CÁO THỜI GIAN RA VÀO CỔNG CỦA CB_CNV TỪ NGÀY " ;

                        //        // auto filter
                        //        worksheet.Cells["A5:J5"].AutoFilter = true;

                        //        //border
                        //        worksheet.Cells["A5:" + "J" + (dgv_GioRaCong.RowCount + 4)].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        //        worksheet.Cells["A5:" + "J" + (dgv_GioRaCong.RowCount + 4)].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        //        worksheet.Cells["A5:" + "J" + (dgv_GioRaCong.RowCount + 4)].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        //        worksheet.Cells["A5:" + "J" + (dgv_GioRaCong.RowCount + 4)].Style.Border.Left.Style = ExcelBorderStyle.Thin;



                        //        worksheet.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        //        worksheet.Cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        //        worksheet.Cells["A1:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        //        worksheet.Cells["A1:J3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        //        //worksheet.Cells["A5:J5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        //        //worksheet.Cells["A5:J5"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 255, 204));

                        //        //worksheet.Cells["B5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        //        worksheet.Cells["A1:J5"].Style.Font.Bold = true;
                        //        worksheet.Cells["A1:J3"].Style.Font.Size = 16;
                        //        worksheet.Cells["A5:J5"].Style.Font.Size = 12;


                        worksheet.Cells["A1:P1"].AutoFilter = true;
                        worksheet.Cells["A1:P1"].Style.Font.Color.SetColor(Color.White);
                        worksheet.Cells["A1:P1"].Style.Font.Bold = true;
                        worksheet.Cells["A1:P1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells["A1:P1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(31, 78, 120));

                        //Set width for column
                        worksheet.Row(1).Height = 21D;
                        worksheet.Row(2).Height = 21D;
                        worksheet.Row(3).Height = 21D;
                        worksheet.Row(4).Height = 21D;
                        worksheet.Row(5).Height = 21D;
                        worksheet.Row(6).Height = 21D;
                        worksheet.Row(7).Height = 21D;
                        worksheet.Row(8).Height = 21D;
                        worksheet.Row(9).Height = 21D;
                        worksheet.Column(2).Width = 19D;
                        worksheet.Column(3).Width = 25.29D;
                        worksheet.Column(4).Width = 25.86D;
                        worksheet.Column(5).Width = 20D;
                        worksheet.Column(6).Width = 15D;
                        worksheet.Column(7).Width = 18D;
                        worksheet.Column(8).Width = 15D;
                        worksheet.Column(9).Width = 13D;
                        worksheet.Column(10).Width = 20D;
                        worksheet.Column(11).Width = 26D;
                        worksheet.Column(12).Width = 26D;
                        worksheet.Column(13).Width = 26D;
                        worksheet.Column(14).Width = 26D;
                        worksheet.Column(15).Width = 26D;
                        worksheet.Column(16).Width = 26D;
                        worksheet.Column(17).Width = 26D;

                        //Set header on Row 1
                        worksheet.Cells["A" + 1].Value = "STT";
                        worksheet.Cells["B" + 1].Value = "Tên Thiết Bị";
                        worksheet.Cells["C" + 1].Value = "Mã Thiết Bị";
                        worksheet.Cells["D" + 1].Value = "Tồn Kho";
                        worksheet.Cells["E" + 1].Value = "Đơn Vị Tính";
                        worksheet.Cells["F" + 1].Value = "Mô Tả";
                        worksheet.Cells["G" + 1].Value = "Mã Đơn Hàng";
                        worksheet.Cells["H" + 1].Value = "Ngày Nhập Xuất";
                        worksheet.Cells["I" + 1].Value = "Ngày Dự Kiến";
                        worksheet.Cells["J" + 1].Value = "Ngày Cập Nhật";
                        worksheet.Cells["K" + 1].Value = "Trạng Thái";
                        worksheet.Cells["L" + 1].Value = "Số Lượng Nhập/Xuất";
                        worksheet.Cells["M" + 1].Value = "Người Phụ Trách";
                        worksheet.Cells["N" + 1].Value = "Tên Bộ Phận";
                        worksheet.Cells["O" + 1].Value = "Mã Bộ Phận";
                        worksheet.Cells["P" + 1].Value = "Ghi Chú";
                        //        //worksheet.Cells["A6"].LoadFromDataTable(cls_BaoCao.BaoCao(query), true);
                        //        //worksheet.Column(15).Width = 20D;
                        //        for (i = 0; i < dgv_GioRaCong.RowCount; i++)
                        //            worksheet.Row(i + 5).Height = 16.00D;

                        // Add value from dataGridView to file Excel
                        for (int i = 0; i < dgv_view_all.RowCount; i++)
                        {
                            int kq = i;
                            worksheet.Cells["A" + (i + 2)].Value = i + 1;
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Name_device].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["B" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Name_device].Value.ToString();
                            }
                            else worksheet.Cells["B" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Device_ID].Value != "")
                            {
                                worksheet.Cells["C" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Device_ID].Value.ToString();
                            }
                            else worksheet.Cells["C" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Quantity].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["D" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Quantity].Value.ToString();
                            }
                            else worksheet.Cells["D" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Unit].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["E" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Unit].Value.ToString();
                            }
                            else worksheet.Cells["E" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Note].Value != "")
                            {
                                worksheet.Cells["F" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Note].Value.ToString();
                            }
                            else worksheet.Cells["F" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Suggess_id].Value != "")
                            {
                                worksheet.Cells["G" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Suggess_id].Value.ToString();
                            }
                            else worksheet.Cells["G" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Date].Value != "")
                            {
                                worksheet.Cells["H" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Date].Value.ToString();
                            }
                            else worksheet.Cells["H" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Expected_Date].Value != "")
                            {
                                worksheet.Cells["I" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Expected_Date].Value.ToString();
                            }
                            else worksheet.Cells["I" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Modify_Date].Value != "")
                            {
                                worksheet.Cells["J" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Modify_Date].Value.ToString();
                            }
                            else worksheet.Cells["J" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Status].Value != "")
                            {
                                worksheet.Cells["K" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Status].Value.ToString();
                            }
                            else worksheet.Cells["K" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Quantity].Value != "")
                            {
                                worksheet.Cells["L" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Quantity].Value.ToString();
                            }
                            else worksheet.Cells["L" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Full_Name].Value != "")
                            {
                                worksheet.Cells["M" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Full_Name].Value.ToString();
                            }
                            else worksheet.Cells["M" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Department_Name].Value != "")
                            {
                                worksheet.Cells["N" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Department_Name].Value.ToString();
                            }
                            else worksheet.Cells["N" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Department_ID].Value != "")
                            {
                                worksheet.Cells["O" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Department_ID].Value.ToString();
                            }
                            else worksheet.Cells["O" + (i + 2)].Value = "";
                            if (dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Note].Value != "")
                            {
                                worksheet.Cells["P" + (i + 2)].Value = dgv_view_all.Rows[(i)].Cells[(int)dgvenum.Order_Note].Value.ToString();
                            }
                            else worksheet.Cells["P" + (i + 2)].Value = "";

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
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmlogin = new FrmLogin();
            frmlogin.Show();
        }

        private void btn_device_managament_Click(object sender, EventArgs e)
        {
			frmDevice frmdevice = new frmDevice();
			frmdevice.Show();
			
        }


        private void btn_user_managament_Click(object sender, EventArgs e)
        {
            frmUpdateUser frm = new frmUpdateUser();
            frm.Show();
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            Frm_history frm2 = new Frm_history();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order_Manage frmOrderManage = new Order_Manage();
            frmOrderManage.Show();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text;
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string sql1 = @"SELECT  D.Device_serial_key,
                                    D.Name_device,
									Device_ID,
									D.Quantity,
									D.Unit,
									D.Note,
									O.Suggest_id,
									O.Order_Date,
									O.Order_Expected_Date,
									O.Order_Modify_Date,
									O.Order_Status,
									O.Order_Quantity,
									U.Full_name,
									DP.Department_Name,
									O.Order_Note
							FROM    Data_User U, Device D, Orders O, Data_Department DP
							WHERE	U.User_serial_key = D.User_serial_key AND
									D.Device_serial_key = O.Device_serial_key AND
									O.Department_ID = DP.Department_ID AND
									(D.Name_device LIKE '%'+N'"+search+"'+'%'" +
                                    "OR D.Note LIKE '%'+N'"+search+"'+'%'" +
                                    "OR DP.Department_Name LIKE '%'+N'"+search+"'+'%'" +
                                    "OR DP.Department_ID LIKE '%'+'"+search+"'+'%'" +
                                    "OR U.Full_name LIKE '%'+N'"+search+"'+'%')";

            OleDbCommand cmd1 = new OleDbCommand(sql1, conn);
            try
            {
                conn.Open();
                OleDbDataReader reader = cmd1.ExecuteReader();
                dgv_view_all.Rows.Clear();
                while (reader.Read())
                {
                    dgv_view_all.Rows.Add(new object[]
                    {
                        reader["Device_serial_key"].ToString(),
                        reader["Name_device"].ToString(),
                        reader["Device_ID"].ToString(),
                        reader["Quantity"].ToString(),
                        reader["Unit"].ToString(),
                        reader["Note"].ToString(),
                        reader["Suggest_id"].ToString(),
                        reader["Order_Date"].ToString(),
                        reader["Order_Expected_Date"].ToString(),
                        reader["Order_Modify_Date"].ToString(),
                        reader["Order_Status"].ToString(),
                        reader["Order_Quantity"].ToString(),
                        reader["Full_name"].ToString(),
                        reader["Department_Name"].ToString(),
                        reader["Order_Note"].ToString(),
                    });
                }
            }
            catch (Exception ex)
            {
                conn.Dispose();
            }
        }

        private void dgv_view_all_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string qty1 = @"select sum(Order_Quantity) as tong from Orders where Order_Status = N'In' and Device_serial_key = '" + dgv_view_all.CurrentRow.Cells[(int)dgvenum.Device_serial_key].Value.ToString() + "'";
            string qty2 = @"select sum(Order_Quantity) as tong from Orders where Order_Status = N'Out' and Device_serial_key = '" + dgv_view_all.CurrentRow.Cells[(int)dgvenum.Device_serial_key].Value.ToString() + "'";

            OleDbCommand cmd1 = new OleDbCommand(qty1, conn);
            OleDbCommand cmd2 = new OleDbCommand(qty2, conn);
            OleDbDataReader rd1 = cmd1.ExecuteReader();
            OleDbDataReader rd2 = cmd2.ExecuteReader();
            while (rd1.Read() && rd2.Read())
            {
                lbl_im_qty.Text = rd1["tong"].ToString();
                lbl_ex_qty.Text = rd2["tong"].ToString();
            }
            conn.Dispose();
        }
    }
}
