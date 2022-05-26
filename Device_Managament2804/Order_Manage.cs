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
    public partial class Order_Manage : Form
    {
        public Order_Manage()
        {
            InitializeComponent();
            qty_device.Enabled = false;
            Show_combobox();
        }
        public static string id; // khai báo biến id gán giá trị của username để thực hiện truyền biến
        public static string Get_IP = Get_IP_Address();

        public static string Get_MAC = Get_Mac_Address();

        public static string Get_HostName = Dns.GetHostName();

        private void Show_combobox()
        {
            ComboboxItem combo = new ComboboxItem();
            string query = @"IF (OBJECT_ID('tempdb..#device') IS NOT NULL) DROP TABLE #device
 	                        SELECT * INTO #device FROM(
                            SELECT  distinct Device_serial_key, Name_device FROM Device )a
                            SELECT row_number() OVER (ORDER BY Device_serial_key)stt,Device_serial_key, Name_device device_name
                            FROM #device";

            combo.LoadDataToCombobox(device_key, query, "device_name", "stt");
        }

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

        string ip = Get_IP;
        string mac = Get_MAC;
        string hname = Get_HostName;
        enum  dgvenum :int
        {
            stt,
            order_serial_key,
            device_serial_key,
            device_name,
            Suggest_id, 
            department_name,
            order_expect_date,
            order_date_imex,
            qty,
            status,
            ID_reciever,
            reciever,
            Buyer,
            Tel_buyer,
            modify_date,
            txtNote,
            user_serial_key
        }
        public Order_Manage(string userKey)
        {
            InitializeComponent();
            string log_user = userKey;
            //status_order.DisplayMember = "Text";
            //status_order.ValueMember = "Value";

            //status_order.Items.Add(new { Text = "Nhập", Value = "In" });
            //status_order.Items.Add(new { Text = "Xuất", Value = "Out" });
        }
        public class ComboboxItem2
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private void Test()
        {
            ComboboxItem2 item = new ComboboxItem2();
            item.Text = "In";
            status_order.Items.Add(item);

            ComboboxItem2 item1 = new ComboboxItem2();
            item1.Text = "Out";;
            status_order.Items.Add(item1);
            ComboboxItem2 item2 = new ComboboxItem2();
            item2.Text = "Waiting";
            status_order.Items.Add(item2);
        }
        DataTable dt = new DataTable();
        
        private void select_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string sql = @" SELECT row_number() OVER (ORDER BY Order_Serial_Key)stt,
			                        O.Order_Serial_Key,
		                            O.Device_serial_key,
		                            DV.Name_device,
		                            O.Suggest_id,
		                            O.Department_ID,
		                            O.Reciever,
		                            O.Order_Expected_Date,
		                            O.Order_Date, 
		                            O.Order_Quantity, 
                                    O.Order_Status,
		                            O.ID_reciever,
		                            O.Buyer,
		                            O.Tel_buyer,
		                            O.Order_Modify_Date,
		                            O.Order_Note,
		                            D.Full_name
                            FROM    Orders as O,
		                            Data_User as D,
		                            Device as DV
                            WHERE   O.Device_serial_key = DV.Device_serial_key AND
		                            O.User_serial_key = D.User_serial_key";
            OleDbCommand odccomman = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                show_data.Rows.Clear();
                OleDbDataReader odeReader = odccomman.ExecuteReader();
                try
                {
                    while (odeReader.Read())
                    {
                        show_data.Rows.Add(new object[] {
                        odeReader["stt"].ToString().Trim()
                        ,odeReader["Order_Serial_Key"].ToString().Trim()
                        ,odeReader["Device_serial_key"].ToString().Trim()
                        ,odeReader["Name_device"].ToString().Trim()
                        , odeReader["Suggest_id"].ToString().Trim()
                        , odeReader["Department_ID"].ToString().Trim()                       
                        , odeReader["Order_Expected_Date"].ToString().Trim()
                        , odeReader["Order_Date"].ToString().Trim()
                        , odeReader["Order_Quantity"].ToString().Trim()
                        , odeReader["Order_Status"].ToString().Trim()
                        , odeReader["ID_reciever"].ToString().Trim()
                        ,odeReader["Reciever"].ToString().Trim()
                        ,odeReader["Buyer"].ToString().Trim()
                        ,odeReader["Tel_buyer"].ToString().Trim()
                        , odeReader["Order_Modify_Date"].ToString().Trim()                       
                        , odeReader["Order_Note"].ToString().Trim()
                        , odeReader["Full_name"].ToString().Trim()
                        });
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null)
                    {
                        if (odeReader != null) odeReader.Dispose();
                    }
                }
                finally {
                    if (odeReader != null) odeReader.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (odccomman != null) odccomman.Dispose();
                    if (conn != null) conn.Dispose();
                }
            }
            finally
            {
                if (odccomman != null) odccomman.Dispose();
                if (conn != null) conn.Dispose();
            }
        } 

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dg == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
  

        private void Order_Manage_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("IceTea Việt"); 
        }

        private void show_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
               
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void status_order_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(status_order.Text == "In" || status_order.Text == "Waiting") {
                depart_id.Enabled = false;
                txt_hdh.Enabled = false;
                txt_ip.Enabled = false;
                txt_key.Enabled = false;
                txt_office.Enabled = false;
                depart_id.Text = "MES";
            }
            else 
            {
                depart_id.Enabled = true;
                txt_hdh.Enabled = true;
                txt_ip.Enabled = true;
                txt_key.Enabled = true;
                txt_office.Enabled = true;
                txt_hdh.Text = "";
                txt_ip.Text = "";
                txt_key.Text = "";
                txt_office.Text = "";
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string device = device_key.Text;
            string qty = quantity.Text;
            string note = txtNote.Text;
            string depart_name = depart_id.Text;

            if (txt_suggest_id.Text==""||device == "" || qty == "" || status_order.Text == "")//||txt_hdh.Text==""||txt_ip.Text==""||txt_key.Text==""||txt_office.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            } 
            else
            {
                string status = status_order.SelectedItem.ToString();
                int a = 0, b = 0;
                int c = new int();
                string old_qty = "";
                string sSQL = @"SELECT Quantity 
                                FROM Device
                                WHERE Name_device = N'" + device + "'";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sSQL, conn);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    old_qty = reader["Quantity"].ToString();
                }
                conn.Dispose();
                bool result = Int32.TryParse(old_qty, out a);
                bool result2 = Int32.TryParse(qty, out b);

                if (status_order.Text == "Out")
                {
                    if (result & result2)
                    {
                        c = a - b;
                    }
                }
                else
                {
                    if(result & result2 & status_order.Text == "Waiting")
                    {
                        c = a;
                    }
                    else
                    {
                        if (result & result2 & status_order.Text == "In")
                        {
                            c = a + b;
                            depart_name = "MES";
                        }
                    }                  
                }
                if (c < 0)
                {
                    MessageBox.Show("Số lượng hiện tại trong kho không đủ");
                    reset_Click(sender, e);
                }

                else
                {
                    string sql = @"DECLARE @ORDER_SERIAL_KEY VARCHAR(10) = '00000',@NEW_NUMBER VARCHAR(10),@USER_SERIAL_KEY VARCHAR(10),@DEVICE_SERIAL_KEY VARCHAR(10)
                                SET @USER_SERIAL_KEY = (SELECT User_serial_key FROM Data_User WHERE User_id = '" + FrmLogin.id.ToString() + @"')
                                SET @DEVICE_SERIAL_KEY = (SELECT Device_serial_key FROM Device WHERE Name_device = N'" + device + @"')
                                SELECT @NEW_NUMBER = RIGHT(MAX(Order_Serial_Key),5) + 1 FROM Orders
                                SELECT @NEW_NUMBER = 'OD' + LEFT(@ORDER_SERIAL_KEY, 5 - LEN(@NEW_NUMBER))+CONVERT(VARCHAR,@NEW_NUMBER)
                                UPDATE Device SET Quantity = '" + c + "' WHERE Name_device = N'" + device + @"'
                                    
                                INSERT INTO Orders(Order_Serial_Key,
                                                Device_serial_key,
                                                Suggest_id,
                                                Department_ID,
                                                Order_Expected_Date,
                                                Order_Date,
                                                Order_Quantity,
                                                Order_Status,
                                                Order_Modify_Date,
                                                User_Serial_Key,
                                                ID_reciever,
                                                Reciever,
                                                Buyer,
                                                Tel_buyer,
                                                Order_Note)
                                VALUES (@NEW_NUMBER, @DEVICE_SERIAL_KEY ,'" + txt_suggest_id.Text + "',N'" + depart_name + "','" + dpt_expect_date.Value + "','" + dptOrders_imex.Value + "','" + Int32.Parse(qty) + "', '" + status + "',getdate(),@USER_SERIAL_KEY,'" + txt_id_user.Text + "',N'" + txt_name_reciever.Text + "',N'" + txt_name_buyer.Text + "','" + txt_tel_buyer.Text + "', N'" + note.ToString() + @"')
                                  
                                INSERT INTO History_orders(Order_Serial_Key,
                                                        Device_serial_key,
                                                        Suggest_id,
                                                        Department_ID,
                                                        Reciever,
                                                        Order_expect_date,
                                                        Order_Date,
                                                        Order_Quantity,
                                                        Order_Status,
                                                        Order_Modify_Date,
                                                        IP_address,
                                                        MAC_address,
                                                        Host_name,
                                                        User_Serial_Key,
                                                        Order_Note,
                                                        Action,
                                                        time_update)
                                VALUES (@NEW_NUMBER, @DEVICE_SERIAL_KEY ,'" + txt_suggest_id.Text + "',N'" + depart_name + "',N'" + txt_name_reciever.Text + "','" + dpt_expect_date.Value + "','" + dptOrders_imex.Value + "','" + Int32.Parse(qty) + "', '" + status + "',getdate(),'" + ip + "','" + mac + "','" + hname + "',@USER_SERIAL_KEY, N'" + note.ToString() + "','Add',getdate())";

                    OleDbConnection connect = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
                    connect.Open();
                    OleDbCommand cmd1 = new OleDbCommand(sql, connect);
                    cmd1.ExecuteNonQuery();
                    connect.Dispose();
                    MessageBox.Show("Thêm thành công!!");
                    reset_Click(sender, e);
                    select_Click(sender, e);
                }
                
                if (txt_hdh.Text != "" || txt_ip.Text != "" || txt_key.Text != "" || txt_office.Text != "")
                {
                    OleDbConnection conn2 = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
                    string sql2 = @"    DECLARE @ORDER_SERIAL_KEY VARCHAR(10) = '00000'
                                        SELECT @NEW_NUMBER = RIGHT(MAX(Order_Serial_Key),5) + 1 FROM Orders
                                        SELECT @NEW_NUMBER = 'OD' + LEFT(@ORDER_SERIAL_KEY, 5 - LEN(@NEW_NUMBER))+CONVERT(VARCHAR,@NEW_NUMBER)
                                        INSERT INTO details_orders(order_serial_key,
                                                    suggest_id,
                                                    operating_sys,
                                                    ip_device,
                                                    product_key,
                                                    type_office) 
                            VALUES(@NEW_NUMBER, '" + txt_suggest_id.Text + "', '" + txt_hdh.Text + "', '" + txt_ip.Text + "', '" + txt_key.Text + "', '" + txt_office.Text + @"')";
                    conn2.Open();
                    OleDbCommand cmd2 = new OleDbCommand(sql2, conn2);
                    cmd2.ExecuteNonQuery();
                }
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string device = device_key.Text;
            string qty = quantity.Text;
            string status = status_order.Text;
            string order_serial_key = order_key.Text;
            string order = txt_suggest_id.Text;
            string note = txtNote.Text;
            string depart = depart_id.Text;
            string old_qty = "";
            string sSQL = @"SELECT Quantity 
                            FROM   Device
                            WHERE Name_device = N'" + device + "' ";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sSQL, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                old_qty = reader["Quantity"].ToString();
            }
            conn.Dispose();
            int a = 0, b = 0;
            int c = new int();
            bool result = Int32.TryParse(old_qty, out a);
            bool result2 = Int32.TryParse(qty, out b);
            if (status_order.Text == "Out")
            {
                if (result & result2)
                {
                    c = a - b;
                }
            }
            else
            {
                if (result & result2 & status_order.Text == "In")
                {
                    c = a + b;
                    depart = "MES";
                }
            }
            string sql = @" DECLARE @ORDER_SERIAL_KEY VARCHAR(10) = '00000',@DEVICE_SERIAL_KEY VARCHAR(10),@NEW_NUMBER VARCHAR(10),@USER_SERIAL_KEY VARCHAR(10)
                                  SET @USER_SERIAL_KEY = (SELECT User_serial_key FROM Data_User WHERE User_id = '" + FrmLogin.id.ToString() + @"')
                                  SET @DEVICE_SERIAL_KEY = (SELECT Device_serial_key FROM Device WHERE Name_device = N'" + device + @"')
                                  SELECT @NEW_NUMBER = RIGHT(MAX(Order_Serial_Key),5) + 1 FROM Orders
                                  SELECT @NEW_NUMBER = 'OD' + LEFT(@ORDER_SERIAL_KEY, 5 - LEN(@NEW_NUMBER))+CONVERT(VARCHAR,@NEW_NUMBER)

                                INSERT INTO History_orders(Order_Serial_Key,Device_serial_key,Suggest_id,Department_ID,Reciever,Order_expect_date,Order_Date,Order_Quantity,Order_Status,Order_Modify_Date,IP_address,MAC_address,Host_name,User_Serial_Key,Order_Note,Action)
                                VALUES ('" + order_serial_key + "' , @DEVICE_SERIAL_KEY , '" + order.ToString() + "','"+ depart.ToString() +"','"+txt_name_reciever.Text+"','" + dpt_expect_date.Value + "','" + dptOrders_imex.Value + "','" + Int32.Parse(qty) + "', '" + status + "',getdate(),'" + ip + "','" + mac + "','" + hname + "',@USER_SERIAL_KEY, N'" + note.ToString() + @"','Edit')
                                
                                UPDATE Orders SET 
                                                Device_serial_key = '"+txt_device_serial_key.Text+@"',
                                                Department_ID = '" + depart.ToString() + @"',
                                                Order_Expected_Date = '" + dpt_expect_date.Value.ToString("MM/dd/yyyy") + @"',
                                                Order_Date = '" + dptOrders_imex.Value.ToString("MM/dd/yyyy") + @"',
                                                Order_Quantity = '" + qty + @"',
                                                Order_Status = N'" + status + @"',
                                                ID_reciever = '"+txt_id_user.Text+@"',
                                                Buyer = N'"+txt_name_buyer.Text+@"',  
                                                Tel_buyer = '"+txt_tel_buyer.Text+@"',  
                                                Order_Modify_Date = getdate(),
                                                User_serial_key = @USER_SERIAL_KEY,
                                                Reciever = N'"+txt_name_reciever.Text+@"',
                                                Order_Note = N'" + note + @"'
                                WHERE  Order_Serial_Key = '" + order_serial_key + @"'
                                --UPDATE Device SET Quantity = '" + c + "' WHERE Name_device = N'" + device + "' AND " + dpt_expect_date.Text + " - getdate() < 0";

                OleDbConnection connect = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
                connect.Open();
                OleDbCommand cmd2 = new OleDbCommand(sql, connect);
                cmd2.ExecuteNonQuery();
                conn.Dispose();
                MessageBox.Show("Thay đổi thành công!");
                reset_Click(sender, e);
                select_Click(sender, e);
        }

        private void show_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string level_id = "";
                OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
                string query = "SELECT Level_id FROM Data_User WHERE User_id = '" + FrmLogin.id.ToString() + "'";
                conn.Open();
                OleDbCommand odc = new OleDbCommand(query, conn);
                OleDbDataReader reader2 = odc.ExecuteReader();
                while (reader2.Read())
                {
                    level_id = reader2["Level_id"].ToString();
                }

                if (level_id == "1")
                {
                    edit.Enabled = true;
                    delete.Enabled = true;
                    status_order.Enabled = true;
                }
                device_key.Text = show_data.CurrentRow.Cells[(int)dgvenum.device_name].Value.ToString();
                txt_suggest_id.Text = show_data.CurrentRow.Cells[(int)dgvenum.Suggest_id].Value.ToString();
                dpt_expect_date.Value = Convert.ToDateTime(show_data.CurrentRow.Cells[(int)dgvenum.order_expect_date].Value);
                dptOrders_imex.Value = Convert.ToDateTime(show_data.CurrentRow.Cells[(int)dgvenum.order_date_imex].Value);
                quantity.Text = show_data.CurrentRow.Cells[(int)dgvenum.qty].Value.ToString();
                order_key.Text = show_data.CurrentRow.Cells[(int)dgvenum.order_serial_key].Value.ToString(); //Add Order_key từ DataGridView into hide textbox
                txtNote.Text = show_data.CurrentRow.Cells[(int)dgvenum.txtNote].Value.ToString();
                depart_id.Text = show_data.CurrentRow.Cells[(int)dgvenum.department_name].Value.ToString();
                status_order.Text = show_data.CurrentRow.Cells[(int)dgvenum.status].Value.ToString();
                txt_name_reciever.Text = show_data.CurrentRow.Cells[(int)dgvenum.reciever].Value.ToString();
                txt_id_user.Text = show_data.CurrentRow.Cells[(int)dgvenum.ID_reciever].Value.ToString();
                txt_name_buyer.Text = show_data.CurrentRow.Cells[(int)dgvenum.Buyer].Value.ToString();
                txt_tel_buyer.Text = show_data.CurrentRow.Cells[(int)dgvenum.Tel_buyer].Value.ToString();
                txt_device_serial_key.Text = show_data.CurrentRow.Cells[(int)dgvenum.device_serial_key].Value.ToString();
                string qty1 = @"select sum(Order_Quantity) as tong from Orders where Order_Status = N'In' and Device_serial_key = '"+txt_device_serial_key.Text+"'";
                string qty2 = @"select sum(Order_Quantity) as tong from Orders where Order_Status = N'Out' and Device_serial_key = '"+txt_device_serial_key.Text+"'";
                
                OleDbCommand cmd1 = new OleDbCommand(qty1, conn);
                OleDbCommand cmd2 = new OleDbCommand(qty2, conn);
                OleDbDataReader rd1 = cmd1.ExecuteReader();
                OleDbDataReader rd2 = cmd2.ExecuteReader();
                while (rd1.Read() && rd2.Read())
                {
                    lbl_im_qty.Text = rd1["tong"].ToString();
                    lbl_ex_qty.Text = rd2["tong"].ToString();
                }
                if (show_data.CurrentRow.Cells[(int)dgvenum.status].Value.ToString() == "In" || show_data.CurrentRow.Cells[(int)dgvenum.status].Value.ToString() == "Waiting")
                {
                    depart_id.Text = "MES";
                    txt_name_buyer.Enabled = true;
                    txt_tel_buyer.Enabled = true;
                }
                else
                {
                    if(show_data.CurrentRow.Cells[(int)dgvenum.status].Value.ToString() == "Out")
                    {
                        txt_name_buyer.Enabled = false;
                        txt_tel_buyer.Enabled = false;
                    }    
                        
                }
                conn.Dispose();

                string qty = "";
                OleDbConnection connect = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
                string sql = @"SELECT Quantity FROM Device WHERE Name_device = N'" + device_key.Text + "'";
                connect.Open();
                OleDbCommand cmd = new OleDbCommand(sql, connect);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    qty_device.Text = reader.GetString(0);
                }
                //qty_device.Text = qty;

            }
            catch (Exception ex)
            {

            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa? ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
                string order_serial_key = order_key.Text;
                string device = device_key.Text;
                string qty = quantity.Text;
                string note = txtNote.Text;
                string depart = depart_id.Text;
                string order = txt_suggest_id.Text;
                string status = status_order.Text;

                //int a = 0, b = 0;
                //int c = new int();
                //string qty1 = "";
                //string qty2 = "";
                //string order_qty = @"SELECT Order_Quantity 
                //                    FROM Orders 
                //                    WHERE Order_serial_key = '" + order_serial_key + "'";

                //string device_qty = @" SELECT Quantity 
                //                    FROM Device 
                //                    WHERE Name_device = N'" + device + "'";
                //conn.Open();
                //OleDbCommand cmd2 = new OleDbCommand(order_qty, conn);
                //OleDbDataReader reader = cmd2.ExecuteReader();

                //OleDbCommand cmd3 = new OleDbCommand(device_qty, conn);
                //OleDbDataReader reader2 = cmd3.ExecuteReader();
                //while (reader.Read() && reader2.Read())
                //{
                //    qty1 = reader["Order_Quantity"].ToString();
                //    qty2 = reader2["Quantity"].ToString();
                //}
                //conn.Dispose();

                //bool result = Int32.TryParse(qty1, out a);
                //bool result2 = Int32.TryParse(qty2, out b);
                
                //if(status_order.Text == "Xuat")
                //{
                //    delete.Enabled = false;
                //    if (result & result2)
                //    {
                //        c = b + a;
                //    }
                //}
                //else
                //{
                //    if(a>b)
                //    {
                //        c = 0;
                //    }
                //    else if(result & result2)
                //    {
                //        c = b - a;
                //    }
                //}
                OleDbConnection connect = new OleDbConnection(cls_KetNoi.ConnectionString_DE);

                string sql2 = @"  DECLARE @USER_SERIAL_KEY VARCHAR(10),@DEVICE_SERIAL_KEY VARCHAR(10), @STATUS NVARCHAR(50)
                                  SET @USER_SERIAL_KEY = (SELECT User_serial_key FROM Data_User WHERE User_id = '" + FrmLogin.id.ToString() + @"')
                                  SET @DEVICE_SERIAL_KEY = (SELECT Device_serial_key FROM Device WHERE Name_device = '" + device + @"')
                                  SET @STATUS = (SELECT Order_Status FROM Orders WHERE Order_Serial_Key = '"+ order_serial_key + @"')
                                  INSERT INTO History_orders(Order_Serial_Key,Device_serial_key,Suggest_id,Department_ID,Reciever,Order_expect_date,Order_Date,Order_Quantity,Order_Status,Order_Modify_Date,IP_address,MAC_address,Host_name,User_Serial_Key,Order_Note,Action)
                                  VALUES ('" + order_serial_key + "' , @DEVICE_SERIAL_KEY , '" + order.ToString() + "',N'" + depart.ToString() + "',N'"+txt_name_reciever.Text+"','" + dpt_expect_date.Value + "','" + dptOrders_imex.Value + "','" + Int32.Parse(qty) + "', '" + status + "',getdate(),'" + ip + "','" + mac + "','" + hname + "',@USER_SERIAL_KEY, N'" + note.ToString() + @"','Delete')
                                  
                                  DELETE FROM Orders 
                                  WHERE Order_Serial_Key = '" + order_serial_key + @"'";

                connect.Open();
                OleDbCommand cmd = new OleDbCommand(sql2, connect);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                MessageBox.Show("Xóa thành công!!");
                select_Click(sender, e);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            device_key.Text = "";
            quantity.Text = "";
            dpt_expect_date.Value = DateTime.Today;
            dptOrders_imex.Value = DateTime.Today;
            status_order.Text = "";
            txtNote.Text = "";
            depart_id.Text = "";
            show_data.Update();
            show_data.Refresh();
            add.Enabled = true;
            edit.Enabled = false;
            delete.Enabled = false;
            quantity.Enabled = true;
            status_order.Enabled = true;
            depart_id.Enabled = true;
            device_key.Enabled = true;
            Show_combobox();
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void device_key_SelectedIndexChanged(object sender, EventArgs e)
        {
            string qty = "";
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string sql = "SELECT Quantity FROM Device WHERE Name_device = N'"+ device_key.Text+ "'";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                qty = reader["Quantity"].ToString();
            }
            qty_device.Text = qty;
            conn.Dispose();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập thông tin tìm kiếm...")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Nhập thông tin tìm kiếm...";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //var sqlconnectstring = @"Provider = SQLOLEDB; Data Source = 192.168.30.249; Initial Catalog = DEVICE_MANAGAMENT; Persist Security Info=True;User ID=sa;Password=123 ";
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            
            string result = txtSearch.Text;
            if (result != "")
            {
                string sql = @" SELECT  DISTINCT 
                                        row_number() OVER (ORDER BY Order_Serial_Key)stt,
                                        O.Order_Serial_Key,
                                        O.Device_serial_key,
                                        DV.Name_device,
                                        O.Suggest_id,
                                        DD.Department_Name,
                                        O.Order_Expected_Date,
                                        O.Order_Date, 
                                        O.Order_Quantity,
                                        O.Order_Status,
                                        O.Id_reciever,                                       
                                        O.Reciever,
                                        O.Buyer,
                                        O.Tel_buyer,
                                        O.Order_Modify_Date,
                                        O.Order_Note,
                                        D.Full_name
                                FROM    Orders as O,Data_User as D, Data_Department as DD, Device as DV
                                WHERE   O.User_Serial_Key = D.User_Serial_Key AND
                                        O.Department_ID = DD.Department_ID AND
									    DV.Device_serial_key = O.Device_serial_key AND 
                                        (D.Full_name LIKE '%' + N'" + result + @"' + '%' 
                                        OR DV.Name_device LIKE '%' + N'" + result + @"' + '%' 
                                        OR O.Suggest_id LIKE '%' + N'" + result + "' + '%' " +
                                        "OR O.Reciever LIKE '%' + N'" + result + "' + '%' " +
                                        "OR O.Id_reciever LIKE '%' + N'" + result + "' + '%' " +
                                        "OR O.Buyer LIKE '%' + N'" + result + "' + '%' " +
                                        "OR DD.Department_Name LIKE '%' + N'" + result + "' + '%'" +
                                        "OR Order_Status LIKE '%' + '"+result+"' +'%')";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                show_data.Rows.Clear();
                OleDbDataReader odeReader = cmd.ExecuteReader();
                try
                {
                    while (odeReader.Read())
                    {
                        show_data.Rows.Add(new object[] {
                        odeReader["stt"].ToString().Trim()
                        ,odeReader["Order_Serial_Key"].ToString().Trim()
                        ,odeReader["Device_serial_key"].ToString().Trim()
                        ,odeReader["Name_device"].ToString().Trim()
                        , odeReader["Suggest_id"].ToString().Trim()
                        , odeReader["Department_Name"].ToString().Trim()
                        , odeReader["Order_Expected_Date"].ToString().Trim()
                        , odeReader["Order_Date"].ToString().Trim()
                        , odeReader["Order_Quantity"].ToString().Trim()
                        , odeReader["Order_Status"].ToString().Trim()
                        , odeReader["ID_reciever"].ToString().Trim()
                        , odeReader["Reciever"].ToString().Trim()
                        , odeReader["Buyer"].ToString().Trim()
                        , odeReader["Tel_buyer"].ToString().Trim()
                        , odeReader["Order_Modify_Date"].ToString().Trim()
                        , odeReader["Order_Note"].ToString().Trim()
                        , odeReader["Full_name"].ToString().Trim()
                        });
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null)
                    {
                        if (odeReader != null) odeReader.Dispose();
                    }
                }
                finally
                {
                    if (odeReader != null) odeReader.Dispose();
                }
                conn.Dispose();
            }
        }

        private void depart_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void export_Click(object sender, EventArgs e)
        {
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DBConnect db = new DBConnect();
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            string sql = @"SELECT  O.Order_Serial_Key, O.Device_serial_key,
                                    DV.Name_device,
                                    O.Suggest_id,
                                    DD.Department_ID,
                                    O.Order_Expected_Date,
                                    O.Order_Date, 
                                    O.Order_Quantity,
                                    O.Order_Status,
                                    O.ID_reciever,
                                    O.Reciever,
                                    O.Buyer,
                                    O.Tel_buyer,
                                    O.Order_Modify_Date,
                                    O.Order_Note,
                                    D.Full_name
                            FROM    Orders as O,Data_User as D, Data_Department as DD, Device as DV
                            WHERE   O.User_Serial_Key = D.User_Serial_Key AND
                                    O.Department_ID = DD.Department_ID AND
									DV.Device_serial_key = O.Device_serial_key AND
                                    O.Order_Date BETWEEN '" + dateFrom.Value + "' AND '"+dateTo.Value+"'";
            OleDbCommand odccomman = new OleDbCommand(sql, conn);
            try
            {
                conn.Open();
                show_data.Rows.Clear();
                OleDbDataReader odeReader = odccomman.ExecuteReader();
                try
                {
                    while (odeReader.Read())
                    {
                        show_data.Rows.Add(new object[] {
                        odeReader["Order_Serial_Key"].ToString().Trim()
                        ,odeReader["Device_serial_key"].ToString().Trim()
                        ,odeReader["Name_device"].ToString().Trim()
                        , odeReader["Suggest_id"].ToString().Trim()
                        , odeReader["Department_ID"].ToString().Trim()
                        , odeReader["Order_Expected_Date"].ToString().Trim()
                        , odeReader["Order_Date"].ToString().Trim()
                        , odeReader["Order_Quantity"].ToString().Trim()
                        , odeReader["Order_Status"].ToString().Trim()
                        , odeReader["ID_reciever"].ToString().Trim()
                        , odeReader["Reciever"].ToString().Trim()
                        , odeReader["Buyer"].ToString().Trim()
                        , odeReader["Tel_buyer"].ToString().Trim()
                        , odeReader["Order_Modify_Date"].ToString().Trim()
                        , odeReader["Order_Note"].ToString().Trim()
                        , odeReader["Full_name"].ToString().Trim()
                        });
                    }
                }
                catch (Exception ex)
                {
                    if (ex != null)
                    {
                        if (odeReader != null) odeReader.Dispose();
                    }
                }
                finally
                {
                    if (odeReader != null) odeReader.Dispose();
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    if (odccomman != null) odccomman.Dispose();
                    if (conn != null) conn.Dispose();
                }
            }
            finally
            {
                if (odccomman != null) odccomman.Dispose();
                if (conn != null) conn.Dispose();
            }
        }

        private void Order_Manage_Load_1(object sender, EventArgs e)
        {
            txt_hdh.Text = "undefine";
            txt_ip.Text = "undefine";
            txt_key.Text = "undefine";
            txt_office.Text = "undefine";
            Test();
            edit.Enabled = false;
            delete.Enabled = false;
            txtSearch.Text = "Nhập thông tin tìm kiếm...";
            status_order.SelectedItem = status_order.Items[0];
            //if(status_order.Items[0].ToString() == "Out")
            //{
            //    txt_office.Enabled = false;
            //}
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            string sql_select_department_id = @"select Department_ID from Data_Department";
            OleDbCommand cmd = new OleDbCommand(sql_select_department_id, conn);
            OleDbDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                depart_id.Items.Add(read.GetString(0));
            }
            conn.Dispose();
        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void order_id_TextChanged(object sender, EventArgs e)
        {

        }


        private void btn_export_to_excel_Click(object sender, EventArgs e)
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
                        worksheet.Cells["A3"].Value = "BÁO CÁO QUẢN LÝ THIẾT BỊ " ;

                                // auto filter
                        worksheet.Cells["A5:R5"].AutoFilter = true;

                        //        //border
                        worksheet.Cells["A5:" + "R" + (show_data.RowCount + 5)].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells["A5:" + "R" + (show_data.RowCount + 5)].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells["A5:" + "R" + (show_data.RowCount + 5)].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        worksheet.Cells["A5:" + "R" + (show_data.RowCount + 5)].Style.Border.Left.Style = ExcelBorderStyle.Thin;



                        worksheet.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                        worksheet.Cells["A1:J3"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                        worksheet.Cells["A1:J3"].Style.VerticalAlignment = ExcelVerticalAlignment.Center;

                        worksheet.Cells["A5:R5"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells["A5:R5"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(255, 255, 204));

                        worksheet.Cells["B5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Cells["A1:R5"].Style.Font.Bold = true;
                        worksheet.Cells["A1:R3"].Style.Font.Size = 16;
                        worksheet.Cells["A5:R5"].Style.Font.Size = 12;


                       // worksheet.Cells["A1:P1"].AutoFilter = true;
                        //worksheet.Cells["A1:P1"].Style.Font.Color.SetColor(Color.White);
                        worksheet.Cells["A1:N1"].Style.Font.Bold = true;
                        worksheet.Cells["A1:N1"].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        //worksheet.Cells["A1:P1"].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(31, 78, 120));

                        //Set width for column
                        worksheet.Row(1).Height = 30D;
                        worksheet.Row(2).Height = 30D;
                        worksheet.Row(3).Height = 30D;
                        worksheet.Column(2).Width = 19D;
                        worksheet.Column(3).Width = 25.29D;
                        worksheet.Column(4).Width = 25.86D;
                        worksheet.Column(5).Width = 20D;
                        worksheet.Column(6).Width = 15D;
                        worksheet.Column(7).Width = 20D;
                        worksheet.Column(8).Width = 20D;
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
                        worksheet.Cells["A" + 5].Value = "STT";
                        worksheet.Cells["B" + 5].Value = "Mã Đơn Hàng";
                        worksheet.Cells["C" + 5].Value = "Mã Vật Tư";
                        worksheet.Cells["D" + 5].Value = "Tên Vật Tư";
                        worksheet.Cells["E" + 5].Value = "Mã Đề Nghị";
                        worksheet.Cells["F" + 5].Value = "Bộ Phận";
                        worksheet.Cells["G" + 5].Value = "Đã Nhập";
                        worksheet.Cells["H" + 5].Value = "Đã Xuất";
                        worksheet.Cells["I" + 5].Value = "Ngày Dự Kiến";
                        worksheet.Cells["J" + 5].Value = "Ngày Nhập Xuất";
                        worksheet.Cells["K" + 5].Value = "Số Lượng";
                        worksheet.Cells["L" + 5].Value = "Trạng Thái";
                        worksheet.Cells["M" + 5].Value = "Số Thẻ";
                        worksheet.Cells["N" + 5].Value = "Người Nhận";
                        worksheet.Cells["O" + 5].Value = "Người Thu Mua";
                        worksheet.Cells["P" + 5].Value = "Số Điện Thoại";
                        worksheet.Cells["Q" + 5].Value = "Ngày Cập Nhật";
                        worksheet.Cells["R" + 5].Value = "Ghi Chú";
                        worksheet.Cells["S" + 5].Value = "Người Phụ Trách";
                        //        //worksheet.Cells["A6"].LoadFromDataTable(cls_BaoCao.BaoCao(query), true);
                        //        //worksheet.Column(15).Width = 20D;
                        //        for (i = 0; i < dgv_GioRaCong.RowCount; i++)
                        //            worksheet.Row(i + 5).Height = 16.00D;

                        // Add value from dataGridView to file Excel
            
                        for (int i = 0; i < show_data.RowCount; i++)
                        {
                            int kq = i;
                            worksheet.Cells["A" + (i + 6)].Value = i + 1;
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.order_serial_key].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["B" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.order_serial_key].Value.ToString();
                            }
                            else worksheet.Cells["B" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.device_serial_key].Value != "")
                            {
                                worksheet.Cells["C" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.device_serial_key].Value.ToString();
                            }
                            else worksheet.Cells["C" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.device_name].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["D" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.device_name].Value.ToString();
                            }
                            else worksheet.Cells["D" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.Suggest_id].Value != "")
                            {
                                //MessageBox.Show(dgv_GioRaCong.Rows[(i + 6)].Cells[(int)eGiora.Person_ID].Value.ToString());
                                worksheet.Cells["E" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.Suggest_id].Value.ToString();
                            }
                            else worksheet.Cells["E" + (i + 6)].Value = "";

                            if (show_data.Rows[(i)].Cells[(int)dgvenum.department_name].Value != "")
                            {
                                worksheet.Cells["F" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.department_name].Value.ToString();
                            }
                            else worksheet.Cells["F" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.department_name].Value != "")
                            {
                                worksheet.Cells["G" + (i + 6)].Value = lbl_im_qty.Text;
                            }
                            else worksheet.Cells["G" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.department_name].Value != "")
                            {
                                worksheet.Cells["H" + (i + 6)].Value = lbl_ex_qty.Text;
                            }
                            else worksheet.Cells["H" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.order_expect_date].Value != "")
                            {
                                worksheet.Cells["I" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.order_expect_date].Value.ToString();
                            }
                            else worksheet.Cells["I" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.order_date_imex].Value != "")
                            {
                                worksheet.Cells["J" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.order_date_imex].Value.ToString();
                            }
                            else worksheet.Cells["J" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.qty].Value != "")
                            {
                                worksheet.Cells["K" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.qty].Value.ToString();
                            }
                            else worksheet.Cells["K" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.status].Value != "")
                            {
                                worksheet.Cells["L" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.status].Value.ToString();
                            }
                            else worksheet.Cells["L" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.ID_reciever].Value != "")
                            {
                                worksheet.Cells["M" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.ID_reciever].Value.ToString();
                            }
                            else worksheet.Cells["M" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.reciever].Value != "")
                            {
                                worksheet.Cells["N" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.reciever].Value.ToString();
                            }
                            else worksheet.Cells["N" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.Buyer].Value != "")
                            {
                                worksheet.Cells["O" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.Buyer].Value.ToString();
                            }
                            else worksheet.Cells["O" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.Tel_buyer].Value != "")
                            {
                                worksheet.Cells["P" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.Tel_buyer].Value.ToString();
                            }
                            else worksheet.Cells["P" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.modify_date].Value != "")
                            {
                                worksheet.Cells["Q" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.modify_date].Value.ToString();
                            }
                            else worksheet.Cells["Q" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.txtNote].Value != "")
                            {
                                worksheet.Cells["R" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.txtNote].Value.ToString();
                            }
                            else worksheet.Cells["R" + (i + 6)].Value = "";
                            if (show_data.Rows[(i)].Cells[(int)dgvenum.user_serial_key].Value != "")
                            {
                                worksheet.Cells["S" + (i + 6)].Value = show_data.Rows[(i)].Cells[(int)dgvenum.user_serial_key].Value.ToString();
                            }
                            else worksheet.Cells["S" + (i + 6)].Value = "";

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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtq_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Order_Detail frm = new Order_Detail();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            frmViewAll frm = new frmViewAll();
            frm.Show();
        }

        private void order_key_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_im_qty_Click(object sender, EventArgs e)
        {

        }
    }
}
