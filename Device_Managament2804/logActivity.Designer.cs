namespace Device_Managament2804
{
    partial class Frm_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_history));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btn_search_date = new System.Windows.Forms.Button();
            this.dpk_to = new System.Windows.Forms.DateTimePicker();
            this.dpk_from = new System.Windows.Forms.DateTimePicker();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_search_show = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_device_show = new System.Windows.Forms.Button();
            this.btn_Order_show = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_history = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_history_order = new System.Windows.Forms.DataGridView();
            this.Hod_serial_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_expect_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Modify_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP_addressO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAC_addressO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host_nameO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_IDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_updateO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_history_device = new System.Windows.Forms.DataGridView();
            this.hd_serial_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.device_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP_addressD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAC_addressD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host_nameD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_serial_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_log_user = new System.Windows.Forms.DataGridView();
            this.log_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IP_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAC_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Host_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history_device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_log_user)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(224, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(597, 277);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.btn_search_date);
            this.groupBox7.Controls.Add(this.dpk_to);
            this.groupBox7.Controls.Add(this.dpk_from);
            this.groupBox7.Controls.Add(this.lbl_to);
            this.groupBox7.Controls.Add(this.lbl_from);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 149);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(591, 125);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // btn_search_date
            // 
            this.btn_search_date.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_search_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_date.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_search_date.Location = new System.Drawing.Point(412, 40);
            this.btn_search_date.Name = "btn_search_date";
            this.btn_search_date.Size = new System.Drawing.Size(139, 52);
            this.btn_search_date.TabIndex = 4;
            this.btn_search_date.Text = "Tìm";
            this.btn_search_date.UseVisualStyleBackColor = false;
            this.btn_search_date.Click += new System.EventHandler(this.button2_Click);
            // 
            // dpk_to
            // 
            this.dpk_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_to.Location = new System.Drawing.Point(284, 53);
            this.dpk_to.Name = "dpk_to";
            this.dpk_to.Size = new System.Drawing.Size(122, 26);
            this.dpk_to.TabIndex = 2;
            // 
            // dpk_from
            // 
            this.dpk_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_from.Location = new System.Drawing.Point(79, 55);
            this.dpk_from.Name = "dpk_from";
            this.dpk_from.Size = new System.Drawing.Size(119, 26);
            this.dpk_from.TabIndex = 2;
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_to.Location = new System.Drawing.Point(228, 55);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(50, 24);
            this.lbl_to.TabIndex = 3;
            this.lbl_to.Text = "Đến:";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_from.Location = new System.Drawing.Point(35, 57);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(38, 24);
            this.lbl_from.TabIndex = 3;
            this.lbl_from.Text = "Từ:";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.btn_search_show);
            this.groupBox6.Controls.Add(this.txt_search);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 16);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(591, 133);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // btn_search_show
            // 
            this.btn_search_show.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_search_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_show.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_search_show.Location = new System.Drawing.Point(412, 45);
            this.btn_search_show.Name = "btn_search_show";
            this.btn_search_show.Size = new System.Drawing.Size(139, 47);
            this.btn_search_show.TabIndex = 0;
            this.btn_search_show.Text = "Tìm";
            this.btn_search_show.UseVisualStyleBackColor = false;
            this.btn_search_show.Click += new System.EventHandler(this.btn_search_show_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_search.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(22, 45);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(384, 48);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox3.Controls.Add(this.btn_Exit);
            this.groupBox3.Controls.Add(this.btn_device_show);
            this.groupBox3.Controls.Add(this.btn_Order_show);
            this.groupBox3.Controls.Add(this.btn_user);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(821, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 277);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Location = new System.Drawing.Point(6, 197);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(191, 49);
            this.btn_Exit.TabIndex = 0;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_device_show
            // 
            this.btn_device_show.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_device_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_device_show.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_device_show.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_device_show.Location = new System.Drawing.Point(6, 140);
            this.btn_device_show.Name = "btn_device_show";
            this.btn_device_show.Size = new System.Drawing.Size(191, 49);
            this.btn_device_show.TabIndex = 0;
            this.btn_device_show.Text = "DEVICE";
            this.btn_device_show.UseVisualStyleBackColor = false;
            this.btn_device_show.Click += new System.EventHandler(this.btn_device_show_Click);
            // 
            // btn_Order_show
            // 
            this.btn_Order_show.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Order_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order_show.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Order_show.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Order_show.Location = new System.Drawing.Point(6, 85);
            this.btn_Order_show.Name = "btn_Order_show";
            this.btn_Order_show.Size = new System.Drawing.Size(191, 49);
            this.btn_Order_show.TabIndex = 0;
            this.btn_Order_show.Text = "ORDERS";
            this.btn_Order_show.UseVisualStyleBackColor = false;
            this.btn_Order_show.Click += new System.EventHandler(this.btn_Order_show_Click);
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_user.Location = new System.Drawing.Point(6, 30);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(191, 49);
            this.btn_user.TabIndex = 0;
            this.btn_user.Text = "USER";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox2.Controls.Add(this.lbl_history);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbl_history
            // 
            this.lbl_history.BackColor = System.Drawing.Color.Transparent;
            this.lbl_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_history.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_history.Location = new System.Drawing.Point(62, 43);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(96, 198);
            this.lbl_history.TabIndex = 0;
            this.lbl_history.Text = "Nhật ký thao tác";
            this.lbl_history.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox4.Controls.Add(this.dgv_history_order);
            this.groupBox4.Controls.Add(this.dgv_history_device);
            this.groupBox4.Controls.Add(this.dgv_log_user);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1024, 247);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // dgv_history_order
            // 
            this.dgv_history_order.AllowUserToAddRows = false;
            this.dgv_history_order.AllowUserToDeleteRows = false;
            this.dgv_history_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_history_order.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_history_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history_order.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Hod_serial_key,
            this.Order_ID,
            this.Department_Name,
            this.Department_ID,
            this.Order_expect_date,
            this.Order_date,
            this.Order_Quantity,
            this.Order_Status,
            this.Order_Modify_Date,
            this.IP_addressO,
            this.MAC_addressO,
            this.Host_nameO,
            this.Order_Note,
            this.User_IDO,
            this.Full_name,
            this.Action,
            this.time_updateO});
            this.dgv_history_order.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_history_order.Location = new System.Drawing.Point(3, 16);
            this.dgv_history_order.Name = "dgv_history_order";
            this.dgv_history_order.ReadOnly = true;
            this.dgv_history_order.Size = new System.Drawing.Size(1018, 228);
            this.dgv_history_order.TabIndex = 0;
            this.dgv_history_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_history_order_CellContentClick);
            // 
            // Hod_serial_key
            // 
            this.Hod_serial_key.HeaderText = "STT";
            this.Hod_serial_key.Name = "Hod_serial_key";
            this.Hod_serial_key.ReadOnly = true;
            // 
            // Order_ID
            // 
            this.Order_ID.HeaderText = "Mã Đơn Hàng";
            this.Order_ID.Name = "Order_ID";
            this.Order_ID.ReadOnly = true;
            // 
            // Department_Name
            // 
            this.Department_Name.HeaderText = "Tên Bộ Phận";
            this.Department_Name.Name = "Department_Name";
            this.Department_Name.ReadOnly = true;
            // 
            // Department_ID
            // 
            this.Department_ID.HeaderText = "Mã Bộ Phận";
            this.Department_ID.Name = "Department_ID";
            this.Department_ID.ReadOnly = true;
            // 
            // Order_expect_date
            // 
            this.Order_expect_date.HeaderText = "Ngày Dự kiến";
            this.Order_expect_date.Name = "Order_expect_date";
            this.Order_expect_date.ReadOnly = true;
            // 
            // Order_date
            // 
            this.Order_date.HeaderText = "Ngày tạo";
            this.Order_date.Name = "Order_date";
            this.Order_date.ReadOnly = true;
            // 
            // Order_Quantity
            // 
            this.Order_Quantity.HeaderText = "Số Lượng";
            this.Order_Quantity.Name = "Order_Quantity";
            this.Order_Quantity.ReadOnly = true;
            // 
            // Order_Status
            // 
            this.Order_Status.HeaderText = "Trạng thái";
            this.Order_Status.Name = "Order_Status";
            this.Order_Status.ReadOnly = true;
            // 
            // Order_Modify_Date
            // 
            this.Order_Modify_Date.HeaderText = "Ngày Cập Nhật";
            this.Order_Modify_Date.Name = "Order_Modify_Date";
            this.Order_Modify_Date.ReadOnly = true;
            // 
            // IP_addressO
            // 
            this.IP_addressO.HeaderText = "Địa chỉ IP";
            this.IP_addressO.Name = "IP_addressO";
            this.IP_addressO.ReadOnly = true;
            // 
            // MAC_addressO
            // 
            this.MAC_addressO.HeaderText = "Địa chỉ MAC";
            this.MAC_addressO.Name = "MAC_addressO";
            this.MAC_addressO.ReadOnly = true;
            // 
            // Host_nameO
            // 
            this.Host_nameO.HeaderText = "Tên truy cập";
            this.Host_nameO.Name = "Host_nameO";
            this.Host_nameO.ReadOnly = true;
            // 
            // Order_Note
            // 
            this.Order_Note.HeaderText = "Ghi Chú";
            this.Order_Note.Name = "Order_Note";
            this.Order_Note.ReadOnly = true;
            // 
            // User_IDO
            // 
            this.User_IDO.HeaderText = "Mã NV";
            this.User_IDO.Name = "User_IDO";
            this.User_IDO.ReadOnly = true;
            // 
            // Full_name
            // 
            this.Full_name.HeaderText = "Họ và Tên";
            this.Full_name.Name = "Full_name";
            this.Full_name.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Thao tác";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // time_updateO
            // 
            this.time_updateO.HeaderText = "Thời gian";
            this.time_updateO.Name = "time_updateO";
            this.time_updateO.ReadOnly = true;
            // 
            // dgv_history_device
            // 
            this.dgv_history_device.AllowUserToAddRows = false;
            this.dgv_history_device.AllowUserToDeleteRows = false;
            this.dgv_history_device.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_history_device.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgv_history_device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history_device.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hd_serial_key,
            this.device_id,
            this.Name_device,
            this.Quantity,
            this.Unit,
            this.status_log,
            this.time_update,
            this.IP_addressD,
            this.MAC_addressD,
            this.Host_nameD,
            this.Userid,
            this.user_serial_key});
            this.dgv_history_device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_history_device.Location = new System.Drawing.Point(3, 16);
            this.dgv_history_device.Name = "dgv_history_device";
            this.dgv_history_device.ReadOnly = true;
            this.dgv_history_device.Size = new System.Drawing.Size(1018, 228);
            this.dgv_history_device.TabIndex = 0;
            this.dgv_history_device.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // hd_serial_key
            // 
            this.hd_serial_key.HeaderText = "STT";
            this.hd_serial_key.Name = "hd_serial_key";
            this.hd_serial_key.ReadOnly = true;
            // 
            // device_id
            // 
            this.device_id.HeaderText = "Mã Thiết Bị";
            this.device_id.Name = "device_id";
            this.device_id.ReadOnly = true;
            // 
            // Name_device
            // 
            this.Name_device.HeaderText = "Tên Thiết Bị";
            this.Name_device.Name = "Name_device";
            this.Name_device.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Tồn Kho";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Đơn Vị";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // status_log
            // 
            this.status_log.HeaderText = "Thao tác";
            this.status_log.Name = "status_log";
            this.status_log.ReadOnly = true;
            // 
            // time_update
            // 
            this.time_update.HeaderText = "Thời gian";
            this.time_update.Name = "time_update";
            this.time_update.ReadOnly = true;
            // 
            // IP_addressD
            // 
            this.IP_addressD.HeaderText = "Địa chỉ IP";
            this.IP_addressD.Name = "IP_addressD";
            this.IP_addressD.ReadOnly = true;
            // 
            // MAC_addressD
            // 
            this.MAC_addressD.HeaderText = "Địa chỉ MAC";
            this.MAC_addressD.Name = "MAC_addressD";
            this.MAC_addressD.ReadOnly = true;
            // 
            // Host_nameD
            // 
            this.Host_nameD.HeaderText = "Tên truy cập";
            this.Host_nameD.Name = "Host_nameD";
            this.Host_nameD.ReadOnly = true;
            // 
            // Userid
            // 
            this.Userid.HeaderText = "Mã NV";
            this.Userid.Name = "Userid";
            this.Userid.ReadOnly = true;
            // 
            // user_serial_key
            // 
            this.user_serial_key.HeaderText = "Người truy cập";
            this.user_serial_key.Name = "user_serial_key";
            this.user_serial_key.ReadOnly = true;
            // 
            // dgv_log_user
            // 
            this.dgv_log_user.AllowUserToAddRows = false;
            this.dgv_log_user.AllowUserToDeleteRows = false;
            this.dgv_log_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_log_user.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dgv_log_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_log_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.log_stt,
            this.user_id,
            this.user_full_name,
            this.status_name,
            this.IP_address,
            this.MAC_address,
            this.Host_name,
            this.time_log});
            this.dgv_log_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_log_user.Location = new System.Drawing.Point(3, 16);
            this.dgv_log_user.Name = "dgv_log_user";
            this.dgv_log_user.ReadOnly = true;
            this.dgv_log_user.Size = new System.Drawing.Size(1018, 228);
            this.dgv_log_user.TabIndex = 0;
            // 
            // log_stt
            // 
            this.log_stt.HeaderText = "STT";
            this.log_stt.Name = "log_stt";
            this.log_stt.ReadOnly = true;
            // 
            // user_id
            // 
            this.user_id.HeaderText = "User ID";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // user_full_name
            // 
            this.user_full_name.HeaderText = "Họ và Tên";
            this.user_full_name.Name = "user_full_name";
            this.user_full_name.ReadOnly = true;
            // 
            // status_name
            // 
            this.status_name.HeaderText = "Thao tác";
            this.status_name.Name = "status_name";
            this.status_name.ReadOnly = true;
            // 
            // IP_address
            // 
            this.IP_address.HeaderText = "Địa chỉ IP";
            this.IP_address.Name = "IP_address";
            this.IP_address.ReadOnly = true;
            // 
            // MAC_address
            // 
            this.MAC_address.HeaderText = "Địa chỉ MAC";
            this.MAC_address.Name = "MAC_address";
            this.MAC_address.ReadOnly = true;
            // 
            // Host_name
            // 
            this.Host_name.HeaderText = "Tên truy cập";
            this.Host_name.Name = "Host_name";
            this.Host_name.ReadOnly = true;
            // 
            // time_log
            // 
            this.time_log.HeaderText = "Thời gian";
            this.time_log.Name = "time_log";
            this.time_log.ReadOnly = true;
            // 
            // Frm_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1024, 543);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_history";
            this.Text = "Device Management -MES Office - LHG - Lac Ty 2 Company Limited ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_history_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history_device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_log_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_log_user;
        private System.Windows.Forms.DataGridView dgv_history_order;
        private System.Windows.Forms.DataGridView dgv_history_device;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_device_show;
        private System.Windows.Forms.Button btn_Order_show;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_history;
        private System.Windows.Forms.Button btn_search_show;
        private System.Windows.Forms.DataGridViewTextBoxColumn log_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAC_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Host_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn hd_serial_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP_addressD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAC_addressD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Host_nameD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_serial_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hod_serial_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_expect_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Modify_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn IP_addressO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAC_addressO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Host_nameO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_IDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_updateO;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search_date;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.DateTimePicker dpk_from;
        private System.Windows.Forms.DateTimePicker dpk_to;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}