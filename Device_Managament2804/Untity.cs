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
    internal class Untity
    {
		public static string Get_IP = Untity.Get_IP_Address();
		//Lấy địa chỉ IP LAN của máy người đăng nhập

		public static string Get_MAC = Untity.Get_Mac_Address();
		//Lấy địa chỉ MAC của máy người đăng nhập

		public static string Get_HostName = Dns.GetHostName();
		//Lấy tên máy của người đăng nhập
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

		private static string Get_IP_Address()
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
				bool flag2 = Untity.Check_IP(array2[j]);
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

		private static string Get_Mac_Address()
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

	}
}
