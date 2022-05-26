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
using System.Collections.Specialized;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
namespace Device_Managament2804
{
    public partial class frmUpdateUser : Form
    {

        Data_User user = new Data_User();
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
				bool flag2 =Check_IP(array2[j]);
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
		public frmUpdateUser()
        {
            InitializeComponent();
        }
        enum dgvenum : int
        {
            User_serial_key,
            User_id,
            Userpass,
            Full_name,
            Level_id,
            Level_name,
            Update_day,
            Updater
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            frm.Show();
            this.Close();
        }
        
        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            txt_userSerial.Enabled = false;
            user.Get_Data_User(dgv_data_user);
        }
		//Băm nhỏ mật khẩu bằng phương thức Hash
        private static string GenerateHash(string value)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(value);
            data = System.Security.Cryptography.MD5.Create().ComputeHash(data);
            return Convert.ToBase64String(data);
        }
		//Băm nhỏ mật khẩu bằng phương thức Hash
		 string a = Get_HostName;
		 string b = Get_IP_Address();
		  string c = Get_Mac_Address();
		private void btn_addUser_Click(object sender, EventArgs e)
		{
			OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
			conn.Open();
			string user_serial = txt_userSerial.Text.Trim().ToString();
			string user_password = GenerateHash(txt_userPass.Text);
			string fullname = txt_userFullname.Text;
			string user_id = txt_userID.Text;
			if (user_id == "" || user_password == "" || fullname == "" || txt_level_id.Text == "")
			{
				MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
			}
			else
			{		
				string sql_select_user = @"SELECT User_id FROM Data_User WHERE User_id = '" + user_id + "'";
				OleDbCommand cmd = new OleDbCommand(sql_select_user, conn);
				//OleDbDataReader reader = cmd.ExecuteReader();
				if (cmd.ExecuteNonQuery() != 0)
				{
					MessageBox.Show("Tài khoản đã tồn tại!");
					conn.Dispose();
				}
				else
				{
					string sql = @"DECLARE  @USER_SERIAL_KEY1 VARCHAR(10) ='000', @USER_SERIAL_KEY VARCHAR(10),@NEW_NUMBER VARCHAR(10)
							SET @USER_SERIAL_KEY = (SELECT User_serial_key FROM Data_User WHERE User_id = '" + FrmLogin.id.ToString() + @"')
							SELECT @NEW_NUMBER = RIGHT(MAX(User_serial_key),4) +1 FROM Data_User
							SELECT @NEW_NUMBER = LEFT(@USER_SERIAL_KEY, 6 - LEN(@NEW_NUMBER)) + CONVERT(VARCHAR, @NEW_NUMBER)
							INSERT INTO Data_User(User_serial_key, User_id, Userpass, Full_name,Level_id,Updater, Update_day)
							VALUES (@NEW_NUMBER,'" + user_id.ToString() + "','" + user_password.ToString() + "', N'" + fullname.ToString() + "','" + txt_level_id.Text + "','" + FrmLogin.id.ToString() + "', getdate())" +
									"INSERT INTO log_user(user_id,user_full_name,status_name,IP_address,MAC_address,Host_name,time_log)" +
									"VALUES ('" + user_id.ToString() + "',N'" + fullname.ToString() + "','add','" + b + "','" + c + "','" + a + "',getdate())";
					OleDbCommand cmd2 = new OleDbCommand(sql, conn);
					cmd2.ExecuteNonQuery();
					MessageBox.Show("Thêm thành công!");
					user.Get_Data_User(dgv_data_user);
					conn.Dispose();
				}
			}
		}
        private void dgv_data_user_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //btn_addUser.Enabled = false;

        }

        private void btn_updateUser_Click(object sender, EventArgs e)
        {
            string Uid = txt_userID.Text;
            string Upass = GenerateHash(txt_userPass.Text);
            string Uname = txt_userFullname.Text;
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            if (Uid==""||Upass==""||Uname==""||txt_level_id.Text==""||txt_level_name.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                conn.Open();
                string sql_Update = @"UPDATE Data_User 
                                      SET User_id ='" + Uid.ToString() + "'," +
                                      "Userpass ='" + Upass.ToString() + "'," +
                                      "Update_day =getdate(),Full_name = N'" + Uname.ToString() + "'," +
                                      "Level_id = '" + txt_level_id.Text + "'," +
                                      "Updater = '" + FrmLogin.id.ToString() + "'" +
                                      "WHERE User_serial_key = '" + txt_userSerial.Text + "'" +
									  "INSERT INTO log_user(user_id,user_full_name,status_name,IP_address,MAC_address,Host_name,time_log)" +
									  "VALUES ('" + Uid + "',N'" + Uname + "','Edit','" + b + "','" + c + "','" + a + "',getdate())";

				OleDbCommand cmd = new OleDbCommand(sql_Update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                user.Get_Data_User(dgv_data_user);
                conn.Dispose();
            }    
        }

        private void btn_delUser_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
            conn.Open();
            if(txt_userID.Text=="")
            {
                MessageBox.Show("Nhập vào ID User");
            }
            else
            {
                //string uSerial = txt_userSerial.Text;
                string sqlDel = @"DELETE Data_User WHERE User_serial_key = '" + txt_userSerial.Text +"'"+
                    "INSERT INTO log_user(user_id, user_full_name, status_name, IP_address,MAC_address,Host_name, time_log)" +
                                        "VALUES ('" + txt_userID.Text + "',N'" + txt_userFullname.Text + "','Del','"+b+"','"+c+"','"+a+"',getdate())";
                OleDbCommand cmd = new OleDbCommand(sqlDel, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công!");
                user.Get_Data_User(dgv_data_user);
                conn.Dispose();
            }
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
			txt_level_id.Text = "";
			txt_level_name.Text = "";
			txt_userID.Text = "";
			txt_userFullname.Text = "";
			txt_userPass.Text = "";
        }

        private void dgv_data_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
			conn.Open();
			txt_userSerial.Text = dgv_data_user.CurrentRow.Cells[(int)dgvenum.User_serial_key].Value.ToString();
			txt_userID.Text = dgv_data_user.CurrentRow.Cells[(int)dgvenum.User_id].Value.ToString();
			txt_userFullname.Text = dgv_data_user.CurrentRow.Cells[(int)dgvenum.Full_name].Value.ToString();
			txt_userPass.Text = dgv_data_user.CurrentRow.Cells[(int)dgvenum.Userpass].Value.ToString();
			txt_level_id.Text = dgv_data_user.CurrentRow.Cells[(int)dgvenum.Level_id].Value.ToString();
			txt_level_name.Text = dgv_data_user.CurrentRow.Cells[(int)dgvenum.Level_name].Value.ToString();
		}
    }
}
