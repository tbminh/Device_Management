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
using BarcodeLib;
using QRCoder;
namespace Device_Managament2804
{
    public partial class frmDevice : Form
    {
        public frmDevice()
        {
            InitializeComponent();
        }
        Data_User user = new Data_User();
        public static string id; // khai báo biến id gán giá trị của username để thực hiện truyền biến
        public static string Get_IP = Get_IP_Address();

        public static string Get_MAC = Get_Mac_Address();

        public static string Get_HostName = Dns.GetHostName();

        public static string FilterEnterLine(string values)
        {
            bool flag = string.IsNullOrEmpty(values);
            string result;
            if (flag)
            {
                result = ",";
            }
            else
            {
                string[] value = values.Split(new char[]
                {
                    '\n',
                    '\r'
                }, StringSplitOptions.RemoveEmptyEntries);
                result = string.Join(",", value);
            }
            return result;
        }

        public static DateTime StrToDate(string sDate)
        {
            DateTime now = DateTime.Now;
            bool flag = sDate.Length == 8;
            if (flag)
            {
                sDate = string.Concat(new string[]
                {
                    sDate.Substring(0, 4),
                    "-",
                    sDate.Substring(4, 2),
                    "-",
                    sDate.Substring(6, 2),
                    " 00:00:00"
                });
            }
            bool flag2 = sDate.Length == 10;
            if (flag2)
            {
                sDate = string.Concat(new string[]
                {
                    sDate.Substring(0, 4),
                    "-",
                    sDate.Substring(4, 2),
                    "-",
                    sDate.Substring(6, 2),
                    " ",
                    sDate.Substring(8, 2),
                    ":00:00"
                });
            }
            bool flag3 = sDate.Length == 12;
            if (flag3)
            {
                sDate = string.Concat(new string[]
                {
                    sDate.Substring(0, 4),
                    "-",
                    sDate.Substring(4, 2),
                    "-",
                    sDate.Substring(6, 2),
                    " ",
                    sDate.Substring(8, 2),
                    ":",
                    sDate.Substring(10, 2),
                    ":00"
                });
            }
            bool flag4 = sDate.Length == 14;
            if (flag4)
            {
                sDate = string.Concat(new string[]
                {
                    sDate.Substring(0, 4),
                    "-",
                    sDate.Substring(4, 2),
                    "-",
                    sDate.Substring(6, 2),
                    " ",
                    sDate.Substring(8, 2),
                    ":",
                    sDate.Substring(10, 2),
                    ":",
                    sDate.Substring(12, 2)
                });
            }
            bool flag5 = sDate.Length == 17;
            if (flag5)
            {
                sDate = string.Concat(new string[]
                {
                    sDate.Substring(0, 4),
                    "-",
                    sDate.Substring(4, 2),
                    "-",
                    sDate.Substring(6, 2),
                    " ",
                    sDate.Substring(8, 2),
                    ":",
                    sDate.Substring(10, 2),
                    ":",
                    sDate.Substring(12, 2),
                    ".",
                    sDate.Substring(14, 3)
                });
            }
            return Convert.ToDateTime(sDate);
        }

        public static string Get_IP_Address()
        {
            IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
            StringCollection stringCollection = new StringCollection();
            IPAddress[] array = hostAddresses;
            for (int i = 0; i < array.Length; i++)
            {
                IPAddress iPAddress = array[i];
                bool flag = iPAddress.AddressFamily == AddressFamily.InterNetwork;
                if (flag)
                {
                    stringCollection.Add(iPAddress.ToString());
                }
            }
            string[] array2 = new string[stringCollection.Count];
            stringCollection.CopyTo(array2, 0);
            string result = "";
            for (int j = 0; j < stringCollection.Count; j++)
            {
                bool flag2 = Check_IP(array2[j]);
                if (flag2)
                {
                    result = array2[j];
                }
            }
            return result;
        }

        private static bool Check_IP(string IPAddress)
        {
            bool result = false;
            bool flag = IPAddress.Substring(0, 7) == "192.168";
            if (flag)
            {
                result = true;
            }
            bool flag2 = IPAddress.Substring(0, 3) == "172";
            if (flag2)
            {
                result = true;
            }
            return result;
        }

        public static string Get_Mac_Address()
        {
            string result = "";
            NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
            NetworkInterface[] array = allNetworkInterfaces;
            for (int i = 0; i < array.Length; i++)
            {
                NetworkInterface networkInterface = array[i];
                bool flag = networkInterface.NetworkInterfaceType.ToString().Equals("Ethernet");
                if (flag)
                {
                    IPInterfaceProperties iPProperties = networkInterface.GetIPProperties();
                    bool flag2 = iPProperties.UnicastAddresses.Count > 0;
                    if (flag2)
                    {
                        PhysicalAddress physicalAddress = networkInterface.GetPhysicalAddress();
                        result = physicalAddress.ToString();
                    }
                }
            }
            return result;
        }
        enum dgvenum : int
        {
            Device_serial_key,
            Device_ID,
            Name_device,
            Quantity,
            Unit,
            Note,
            User_serial_key,
            Full_name
        }
        string a = Get_IP_Address();
        string b = Get_Mac_Address();
        string c = Get_HostName;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            string serial_key = txt_device_serial_key.Text;
            string device_id = txt_device_id.Text;
            string name_device = txt_name.Text;
            string qty = txt_qty.Text;
            string unit = txt_unit.Text;
            if(device_id ==""|| name_device == ""|| unit=="")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!!!");
            }    
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string sql_cmd = @"SELECT Device_serial_key FROM Device WHERE Device_ID = '"+ device_id + "'";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql_cmd, conn);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Thiết bị đã tồn tại!");
                conn.Dispose();
            }
            else
            {
                string sql = @" DECLARE @DEVICE_SERIAL_KEY VARCHAR(10) = '00000',@NEW_NUMBER VARCHAR(10),@USER_SERIAL_KEY VARCHAR(10)
                                SET @USER_SERIAL_KEY = (SELECT User_serial_key FROM Data_User WHERE User_id = '" + FrmLogin.id.ToString() + @"')
                                SELECT @NEW_NUMBER = RIGHT(MAX(Device_serial_key),5) + 1 FROM Device
                                SELECT @NEW_NUMBER = 'DE' + LEFT(@DEVICE_SERIAL_KEY, 5 - LEN(@NEW_NUMBER))+CONVERT(VARCHAR,@NEW_NUMBER)

                                INSERT INTO Device 
                                            (Device_serial_key,
                                            Device_ID,
                                            Name_device,
                                            Quantity,
                                            Unit,
                                            Note,
                                            User_serial_key)
                                VALUES(@NEW_NUMBER,'"+device_id+"',N'"+name_device+"','"+qty+"',N'"+unit+"',N'"+txt_decripstion.Text+"',@USER_SERIAL_KEY)"+
                                "INSERT INTO History_device (Device_serial_key,device_id,device_name,device_quantity,device_unit,status_log,time_update,device_decripstion,IP_address,MAC_address,Host_name,user_serial_key)" +
                                "VALUES(@NEW_NUMBER,'" + device_id + "',N'" +name_device+ "',0,N'" + unit + "','Add',getdate(),N'" + txt_decripstion.Text + "','" + a + "','" + b + "','" + c + "','" + FrmLogin.id.ToString() + "')";
                OleDbConnection connect = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
                connect.Open();
                OleDbCommand cmd2 = new OleDbCommand(sql, connect);
                dgv_device.Rows.Clear();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công!");
                user.Get_Data_Device(dgv_device);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            user.Get_Data_Device(dgv_device);
        }

        private void dgv_device_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgv_device_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            txt_device_serial_key.Text = dgv_device.CurrentRow.Cells[(int)dgvenum.Device_serial_key].Value.ToString();
            txt_device_id.Text = dgv_device.CurrentRow.Cells[(int)dgvenum.Device_ID].Value.ToString();
            txt_name.Text = dgv_device.CurrentRow.Cells[(int)dgvenum.Name_device].Value.ToString();
            txt_qty.Text = dgv_device.CurrentRow.Cells[(int)dgvenum.Quantity].Value.ToString();
            txt_unit.Text = dgv_device.CurrentRow.Cells[(int)dgvenum.Unit].Value.ToString();
            txt_decripstion.Text = dgv_device.CurrentRow.Cells[(int)dgvenum.Note].Value.ToString();
            txt_user_serial_key.Text = dgv_device.CurrentRow.Cells[(int)dgvenum.User_serial_key].Value.ToString();
            txt_device_serial_key.Enabled = false;
        }



        private void btn_Edit_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string sqlEdit = @"DECLARE @DEVICE_SERIAL_KEY VARCHAR(10) = '00000',@NEW_NUMBER VARCHAR(10),@USER_SERIAL_KEY VARCHAR(10)
                              SET @USER_SERIAL_KEY = (SELECT User_serial_key FROM Data_User WHERE User_id = '" + FrmLogin.id.ToString() + @"')
                              SELECT @NEW_NUMBER = RIGHT(MAX(Device_serial_key),5) + 1 FROM Device
                              SELECT @NEW_NUMBER = 'DE' + LEFT(@DEVICE_SERIAL_KEY, 5 - LEN(@NEW_NUMBER))+CONVERT(VARCHAR,@NEW_NUMBER)
                              UPDATE Device SET Name_device = N'" + txt_name.Text + "', Quantity = '" + txt_qty.Text + "'," +
                              " Unit = N'" + txt_unit.Text + "', Note = N'" + txt_decripstion.Text + "',User_serial_key = @USER_SERIAL_KEY" +
                              " WHERE Device_serial_key = '" + txt_device_serial_key.Text + "' AND Device_ID = '" + txt_device_id.Text + "'" +
                              "INSERT INTO History_device (Device_serial_key,device_id,device_name,device_quantity,device_unit,status_log,time_update,device_decripstion,IP_address,MAC_address,Host_name,user_serial_key)" +
                            "VALUES(@NEW_NUMBER,'" + txt_device_id.Text + "',N'" + txt_name.Text + "',0,N'" + txt_unit.Text + "','Edit',getdate(),N'" + txt_decripstion.Text + "','" + a + "','" + b + "','" + c + "','" + FrmLogin.id.ToString() + "')";
            OleDbCommand cmdEdit = new OleDbCommand(sqlEdit, conn);
                conn.Open();
                dgv_device.Rows.Clear();
                cmdEdit.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa thành công!");
                user.Get_Data_Device(dgv_device);
        }

        private void frmDevice_Load(object sender, EventArgs e)
        {      
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql = "Select User_ID from Data_User Where User_ID = '" + FrmLogin.id.ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                txt_user_serial_key.Text = reader["User_ID"].ToString();
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            string de_seri = txt_device_serial_key.Text;
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string sqlDel = @"DELETE FROM Device WHERE Device_serial_key = '" + de_seri + "'" +
                              "INSERT INTO History_device (Device_serial_key,device_id,device_name,device_quantity,device_unit,status_log,time_update,device_decripstion,IP_address,MAC_address,Host_name,user_serial_key)" +
                            "VALUES('"+txt_device_serial_key.Text+"','" + txt_device_id.Text + "',N'" + txt_name.Text + "',0,N'" + txt_unit.Text + "','Del',getdate(),N'" + txt_decripstion.Text + "','" + a + "','" + b + "','" + c + "','" + FrmLogin.id.ToString() + "')";
            OleDbCommand cmdDel = new OleDbCommand(sqlDel, conn);
            dgv_device.Rows.Clear();
                conn.Open(); 
                cmdDel.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                user.Get_Data_Device(dgv_device);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string search_query = txt_search.Text;
            string sSQL = @"SELECT
                                D.Device_serial_key,
                                D.DEVICE_ID, 
                                D.Name_device,                               
                                D.Quantity,
                                D.Unit,
                                D.Note,
                                u.[User_id],
                                u.Full_name
                                FROM Device D, Data_User U 
                                WHERE D.User_serial_key = U.User_serial_key AND
                                Name_device LIKE '%'+N'"+search_query.Trim()+ "'+'%'";

            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            try
            {
                conn.Open();
                OleDbDataReader oleReader = cmd.ExecuteReader();
                dgv_device.Rows.Clear();
                while (oleReader.Read())
                {

                    dgv_device.Rows.Add(new object[]
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

        private void button2_Click(object sender, EventArgs e)
        {
            Order_Manage frm = new Order_Manage();
            frm.Show();
            this.Close();


        }

        private void btn_main_menu_Click(object sender, EventArgs e)
        {
            frmViewAll frm = new frmViewAll();
            frm.Show();
            this.Hide();
        }

        private void btn_create_device_id_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            txt_device_id.Text = "Z" + r.Next(0, 10).ToString() + r.Next(0, 10).ToString() + r.Next(0, 10).ToString() + r.Next(0, 10).ToString() + r.Next(0, 10).ToString() + r.Next(0, 10).ToString() + r.Next(0, 10).ToString();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void export_excel_Click(object sender, EventArgs e)
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
                            ExcelWorksheet worksheet = p.Workbook.Worksheets.Add("TK_ThietBi");
                            //        worksheet.View.ShowGridLines = true;
                            //        worksheet.Name = "Giờ vào ra";
                            //        worksheet.Cells.Style.WrapText = true;
                            worksheet.Cells.Style.Font.Name = "Time New Roman";
                        //        //freeze panes
                        //        worksheet.View.FreezePanes(6, 2);
                        worksheet.Cells["A1:N1"].Merge = true;
                        worksheet.Cells["A1"].Value = "CÔNG TY TNHH LẠC TỶ II";
                        worksheet.Cells["A2:N2"].Merge = true;
                        worksheet.Cells["A2"].Value = "Lô B1, B2 KCN Tân Phú Thạnh - giai đoạn 1, H. Châu Thành A, T. Hậu Giang";
                        worksheet.Cells["A3:N3"].Merge = true;
                        worksheet.Cells["A3"].Value = "BÁO CÁO QUẢN LÝ THIẾT BỊ ";
                        worksheet.Cells["A5:H5"].AutoFilter = true;
                        worksheet.Cells["A1:H1"].Style.Font.Color.SetColor(Color.White);
                        worksheet.Cells["A1:H1"].Style.Font.Bold = true;
                        worksheet.Cells["A1:H1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells["A1:H1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(31, 78, 120));
                        worksheet.Cells["A5:" + "H" + (dgv_device.RowCount + 5)].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells["A5:" + "H" + (dgv_device.RowCount + 5)].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells["A5:" + "H" + (dgv_device.RowCount + 5)].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells["A5:" + "H" + (dgv_device.RowCount + 5)].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        worksheet.Cells["A1:H3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        worksheet.Cells["A1:H3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        worksheet.Cells["A5:H5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells["A5:H5"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 255, 204));

                        worksheet.Cells["B5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells["A1:H5"].Style.Font.Bold = true;
                        worksheet.Cells["A1:H3"].Style.Font.Size = 16;
                        worksheet.Cells["A5:H5"].Style.Font.Size = 12;
                        //Set width for column
                        worksheet.Column(1).Width = 8D;
                        worksheet.Column(2).Width = 15D;
                        worksheet.Column(3).Width = 21D;
                        worksheet.Column(4).Width = 15D;
                        worksheet.Column(5).Width = 18D;
                        worksheet.Column(6).Width = 21D;
                        worksheet.Column(7).Width = 21D;
                        worksheet.Column(8).Width = 25D;


                            //Set header on Row 1
                        worksheet.Cells["A" + 5].Value = "STT";
                        worksheet.Cells["B" + 5].Value = "Mã Vật Tư";
                        worksheet.Cells["C" + 5].Value = "Tên Vật Tư";
                        worksheet.Cells["D" + 5].Value = "Số Lượng";
                        worksheet.Cells["E" + 5].Value = "Đơn Vị Tính";
                        worksheet.Cells["F" + 5].Value = "Mô Tả";
                        worksheet.Cells["G" + 5].Value = "Mã Nhân Viên";
                        worksheet.Cells["H" + 5].Value = "Người Phụ Trách";
                        //worksheet.Cells["I" + 5].Value = "Barcode";
                        //worksheet.Cells["J" + 5].Value = "QR Code";
                            //        //worksheet.Cells["A6"].LoadFromDataTable(cls_BaoCao.BaoCao(query), true);
                            //        //worksheet.Column(15).Width = 20D;
                            //        for (i = 0; i < dgv_GioRaCong.RowCount; i++)
                            //            worksheet.Row(i + 5).Height = 16.00D;

                            // Add value from dataGridView to file Excel
                            for (int i = 0; i < dgv_device.RowCount; i++)
                            {
                                int kq = i;
                                worksheet.Cells["A" + (i + 6)].Value = i + 1;
                                if (dgv_device.Rows[(i)].Cells[(int)dgvenum.Device_ID].Value != "")
                                {
                                    //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                    worksheet.Cells["B" + (i + 6)].Value = dgv_device.Rows[(i)].Cells[(int)dgvenum.Device_ID].Value.ToString();
                                }
                                else worksheet.Cells["B" + (i + 6)].Value = "";
                                if (dgv_device.Rows[(i)].Cells[(int)dgvenum.Name_device].Value != "")
                                {
                                    worksheet.Cells["C" + (i + 6)].Value = dgv_device.Rows[(i)].Cells[(int)dgvenum.Name_device].Value.ToString();
                                }
                                else worksheet.Cells["C" + (i + 6)].Value = "";
                                if (dgv_device.Rows[(i)].Cells[(int)dgvenum.Quantity].Value != "")
                                {
                                    //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                    worksheet.Cells["D" + (i + 6)].Value = dgv_device.Rows[(i)].Cells[(int)dgvenum.Quantity].Value.ToString();
                                }
                                else worksheet.Cells["D" + (i + 6)].Value = "";
                                if (dgv_device.Rows[(i)].Cells[(int)dgvenum.Unit].Value != "")
                                {
                                    //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                    worksheet.Cells["E" + (i + 6)].Value = dgv_device.Rows[(i)].Cells[(int)dgvenum.Unit].Value.ToString();
                                }
                                else worksheet.Cells["E" + (i + 6)].Value = "";
                                if (dgv_device.Rows[(i)].Cells[(int)dgvenum.Note].Value != "")
                                {
                                    worksheet.Cells["F" + (i + 6)].Value = dgv_device.Rows[(i)].Cells[(int)dgvenum.Note].Value.ToString();
                                }
                                else worksheet.Cells["F" + (i + 6)].Value = "";
                                if (dgv_device.Rows[(i)].Cells[(int)dgvenum.User_serial_key].Value != "")
                                {
                                    worksheet.Cells["G" + (i + 6)].Value = dgv_device.Rows[(i)].Cells[(int)dgvenum.User_serial_key].Value.ToString();
                                }
                                else worksheet.Cells["G" + (i + 6)].Value = "";
                            if (dgv_device.Rows[(i)].Cells[(int)dgvenum.Full_name].Value != "")
                                {
                                    worksheet.Cells["H" + (i + 6)].Value = dgv_device.Rows[(i)].Cells[(int)dgvenum.Full_name].Value.ToString();
                                }
                                else worksheet.Cells["H" + (i + 6)].Value = "";
                            //BarcodeLib.Barcode code128 = new Barcode();
                            //Image barcode_device = code128.Encode(BarcodeLib.TYPE.CODE128, dgv_device.Rows[(i)].Cells[(int)dgvenum.Device_ID].Value.ToString());
                            //if (dgv_device.Rows[(i)].Cells[(int)dgvenum.Device_ID].Value != "")
                            //{
                            //    worksheet.Cells["I" + (i + 6)].Value = barcode_device;
                            //}
                            //else worksheet.Cells["I" + (i + 6)].Value = "";
                            //QRCodeGenerator qrGenerator = new QRCodeGenerator();
                            //QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(dgv_device.Rows[(i)].Cells[(int)dgvenum.Device_ID].Value.ToString(), QRCodeGenerator.ECCLevel.Q));
                            ////QRCodeGenerator.ECCLevel.Q là mức chịu lỗi 25%; .L là 7%; .M là 15% và .H là trên 25%
                            //Image QRcode_device = qrCode.GetGraphic(2, Color.Black, Color.White, false);
                            //qrGenerator.Dispose();
                            //qrCode.Dispose();
                            //if (dgv_device.Rows[(i)].Cells[(int)dgvenum.Device_ID].Value != "")
                            //{
                            //    worksheet.Cells["J" + (i + 6)].Value = QRcode_device;
                            //}
                            //else worksheet.Cells["J" + (i + 6)].Value = "";

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

        private void grb_fill_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_Leave(object sender, EventArgs e)
        {
            
        }

        private void grb_top_Enter(object sender, EventArgs e)
        {

        }
    }
}
