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
using BarcodeLib;
using QRCoder;
namespace Device_Managament2804
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
			//cls_KetNoi cls = new cls_KetNoi();
			//MessageBox.Show(cls_KetNoi.ConnectionString_DE);
            
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
		private static string GenerateHash(string value)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(value);
            data = System.Security.Cryptography.MD5.Create().ComputeHash(data);
            return Convert.ToBase64String(data);
        }
		
        private void btn_Login_Click(object sender, EventArgs e)
        {
			OleDbConnection conn = new OleDbConnection(cls_KetNoi.ConnectionString_DE);
			conn.Open();
            string username = txt_Username.Text;
            string password = GenerateHash(txt_Password.Text);
            //Lưu thông tin người dùng đã đăng nhập
            
            //Lưu thông tin người dùng đã đăng nhập
            
            //truyền username giữa các form
            id = username.ToString();
            //truyền username giữa các form
            if(username == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
                txt_Password.Text = "";
            }
            else
            {
                if (user.Login(username, password))
                {
					string a = Get_IP_Address();
					string b = Get_Mac_Address();
					string c = Get_HostName;
					string sql1 = @"SELECT Full_name FROM Data_User WHERE User_id = '" + FrmLogin.id.ToString() + "'";
					OleDbCommand cmdname = new OleDbCommand(sql1, conn);
					OleDbDataReader readername = cmdname.ExecuteReader();
					while(readername.Read())
					{
						string name_user = readername["Full_name"].ToString();
						string sql_add_log_user = @"INSERT INTO log_user(user_id,user_full_name,status_name,IP_address,MAC_address,Host_name,time_log)
									VALUES('" + username + "',N'"+name_user+"','Login','" + a + "','" + b + "','" + c + "',getdate())";
						OleDbCommand cmd2 = new OleDbCommand(sql_add_log_user, conn);
						cmd2.ExecuteNonQuery();
					}
					txt_Password.Text = "";
					//MessageBox.Show("Đăng nhập thành công!");
					frmViewAll frm = new frmViewAll();
                    
                    frm.Show();
					
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }

			
		}

        private void chk_Pass_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Pass.Checked == true)
            {
                txt_Password.PasswordChar = '*';
            }
            else
            {
                txt_Password.PasswordChar =(char)0;
            } 
                
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
			//string barcodedevice = oleReader["barcode_device"].ToString();
			
			
			string user = "49051";
			string pass = "26011998";
			string loginQR = "uIT7cTamU183KrwbDbNmHw==";
            txt_Username.Focus();
            chk_Pass.Checked = true;
			//QRCodeGenerator qrGenerator = new QRCodeGenerator();
			//QRCode qrCode = new QRCode(qrGenerator.CreateQrCode(loginQR, QRCodeGenerator.ECCLevel.Q));
			////QRCodeGenerator.ECCLevel.Q là mức chịu lỗi 25%; .L là 7%; .M là 15% và .H là trên 25%
			//pic_QR.Image = qrCode.GetGraphic(5, Color.Black, Color.White, false);
			//qrGenerator.Dispose();
			//qrCode.Dispose();
			//Barcode barcode_device = new BarcodeLib.Barcode();
			//Image barcode = barcode_device.Encode(BarcodeLib.TYPE.CODE128, pass);
			//pic_barcode.Image = barcode;
		}
        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            frmUpdateUser frmUD = new frmUpdateUser();
            frmUD.Show();
            this.Hide();
        }      
        private void btn_userManagament_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!");
            }
            else
            {
                if (user.Login(username, password))
                {
                    //MessageBox.Show("Đăng nhập thành công!");
                    frmUpdateUser frm2 = new frmUpdateUser();
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
			
		}

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
