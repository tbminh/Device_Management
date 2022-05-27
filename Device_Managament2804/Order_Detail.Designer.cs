namespace Device_Managament2804
{
    partial class Order_Detail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_Detail));
            this.show_data = new System.Windows.Forms.DataGridView();
            this.Detail_serial_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suggest_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_reciever = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reciever = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_details_serial = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_hdh = new System.Windows.Forms.TextBox();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.cb_device_in_orders = new System.Windows.Forms.ComboBox();
            this.txt_office = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.show_data)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // show_data
            // 
            this.show_data.AllowUserToAddRows = false;
            this.show_data.AllowUserToDeleteRows = false;
            this.show_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.show_data.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.show_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.show_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detail_serial_key,
            this.suggest_id,
            this.Name_device,
            this.Department_Name,
            this.id_reciever,
            this.reciever,
            this.os,
            this.ip,
            this.key,
            this.office,
            this.user_id,
            this.Full_name});
            this.show_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.show_data.Location = new System.Drawing.Point(3, 16);
            this.show_data.Name = "show_data";
            this.show_data.ReadOnly = true;
            this.show_data.Size = new System.Drawing.Size(1010, 211);
            this.show_data.TabIndex = 0;
            this.show_data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.show_data_CellClick);
            // 
            // Detail_serial_key
            // 
            this.Detail_serial_key.HeaderText = "STT";
            this.Detail_serial_key.Name = "Detail_serial_key";
            this.Detail_serial_key.ReadOnly = true;
            this.Detail_serial_key.Visible = false;
            // 
            // suggest_id
            // 
            this.suggest_id.HeaderText = "Mã PĐN";
            this.suggest_id.Name = "suggest_id";
            this.suggest_id.ReadOnly = true;
            // 
            // Name_device
            // 
            this.Name_device.HeaderText = "Tên Thiết Bị";
            this.Name_device.Name = "Name_device";
            this.Name_device.ReadOnly = true;
            // 
            // Department_Name
            // 
            this.Department_Name.HeaderText = "Bộ Phận";
            this.Department_Name.Name = "Department_Name";
            this.Department_Name.ReadOnly = true;
            // 
            // id_reciever
            // 
            this.id_reciever.HeaderText = "Số Thẻ";
            this.id_reciever.Name = "id_reciever";
            this.id_reciever.ReadOnly = true;
            // 
            // reciever
            // 
            this.reciever.HeaderText = "Người Sử Dụng";
            this.reciever.Name = "reciever";
            this.reciever.ReadOnly = true;
            // 
            // os
            // 
            this.os.HeaderText = "Hệ Điều Hành";
            this.os.Name = "os";
            this.os.ReadOnly = true;
            // 
            // ip
            // 
            this.ip.HeaderText = "Địa Chỉ IP";
            this.ip.Name = "ip";
            this.ip.ReadOnly = true;
            // 
            // key
            // 
            this.key.HeaderText = "Key Bản Quyền";
            this.key.Name = "key";
            this.key.ReadOnly = true;
            // 
            // office
            // 
            this.office.HeaderText = "Office Hiện Tại";
            this.office.Name = "office";
            this.office.ReadOnly = true;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "Mã NV";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // Full_name
            // 
            this.Full_name.HeaderText = "Người Thực Hiện";
            this.Full_name.Name = "Full_name";
            this.Full_name.ReadOnly = true;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(297, 150);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(200, 45);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(147, 155);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 38);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter_1);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tìm Kiếm:";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(23, 42);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(583, 91);
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "Xem";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 292);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox5.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox5.Controls.Add(this.btn_close);
            this.groupBox5.Controls.Add(this.btnSelect);
            this.groupBox5.Controls.Add(this.btnExport);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtSearch);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(405, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(608, 210);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(503, 150);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(96, 45);
            this.btn_close.TabIndex = 18;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(405, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(608, 63);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "THÔNG TIN CHI TIẾT THIẾT BỊ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox3.Controls.Add(this.txt_ip);
            this.groupBox3.Controls.Add(this.txt_details_serial);
            this.groupBox3.Controls.Add(this.btn_update);
            this.groupBox3.Controls.Add(this.txt_hdh);
            this.groupBox3.Controls.Add(this.txt_key);
            this.groupBox3.Controls.Add(this.cb_device_in_orders);
            this.groupBox3.Controls.Add(this.txt_office);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 273);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            // 
            // txt_ip
            // 
            this.txt_ip.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_ip.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_ip.Location = new System.Drawing.Point(150, 116);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(205, 20);
            this.txt_ip.TabIndex = 19;
            // 
            // txt_details_serial
            // 
            this.txt_details_serial.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_details_serial.Enabled = false;
            this.txt_details_serial.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_details_serial.Location = new System.Drawing.Point(150, 37);
            this.txt_details_serial.Name = "txt_details_serial";
            this.txt_details_serial.Size = new System.Drawing.Size(100, 20);
            this.txt_details_serial.TabIndex = 23;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(150, 196);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(102, 27);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_hdh
            // 
            this.txt_hdh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_hdh.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_hdh.Location = new System.Drawing.Point(150, 90);
            this.txt_hdh.Name = "txt_hdh";
            this.txt_hdh.Size = new System.Drawing.Size(205, 20);
            this.txt_hdh.TabIndex = 19;
            // 
            // txt_key
            // 
            this.txt_key.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_key.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_key.Location = new System.Drawing.Point(150, 142);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(205, 20);
            this.txt_key.TabIndex = 19;
            // 
            // cb_device_in_orders
            // 
            this.cb_device_in_orders.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cb_device_in_orders.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_device_in_orders.FormattingEnabled = true;
            this.cb_device_in_orders.Location = new System.Drawing.Point(150, 63);
            this.cb_device_in_orders.Name = "cb_device_in_orders";
            this.cb_device_in_orders.Size = new System.Drawing.Size(121, 21);
            this.cb_device_in_orders.TabIndex = 21;
            this.cb_device_in_orders.SelectedIndexChanged += new System.EventHandler(this.cb_device_in_orders_SelectedIndexChanged);
            // 
            // txt_office
            // 
            this.txt_office.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_office.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_office.Location = new System.Drawing.Point(150, 170);
            this.txt_office.Name = "txt_office";
            this.txt_office.Size = new System.Drawing.Size(205, 20);
            this.txt_office.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Mã Chi Tiết:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Chọn Thiết Bị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Office:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Hệ Điều Hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Key Bản Quyền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(111, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "IP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.show_data);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1016, 230);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // Order_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(1016, 522);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Order_Detail";
            this.Text = "Device Management -MES Office - LHG - Lac Ty 2 Company Limited ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Order_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.show_data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView show_data;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail_serial_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn suggest_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_reciever;
        private System.Windows.Forms.DataGridViewTextBoxColumn reciever;
        private System.Windows.Forms.DataGridViewTextBoxColumn os;
        private System.Windows.Forms.DataGridViewTextBoxColumn ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn office;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cb_device_in_orders;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_office;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_hdh;
        private System.Windows.Forms.TextBox txt_details_serial;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_close;
    }
}