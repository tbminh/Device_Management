using System;
using System.IO;
using System.Data.OleDb;
using EncryptionQRCode;

namespace Device_Managament2804
{
    public class cls_KetNoi
    {
        //ZXing.QrCode.QRCodeReader QRCodeReader = new ZXing.QrCode.QRCodeReader(); 
        public static string ConnectionString_DE = DatabaseConnection(Encryption.DatabaseConnection("chuoiketnoi.bmp"));
        

        public string Server_IP { get { return IP; } }
        private static string IP;

        

        #region //Database Connection string//
        private static string DatabaseConnection(string EncryptionString)
        {
            string sConnnection = "";
            string[] saConnection = EncryptionString.Split(',');
            sConnnection = @"Provider=SQLOLEDB;Data Source=" + saConnection[0] +
                           @";Initial Catalog=" + saConnection[1] +
                           @";User id=" + saConnection[2] +
                           @";Password=" + saConnection[3];
            IP = saConnection[0];
            return sConnnection;
        }

        #endregion
    }

}
