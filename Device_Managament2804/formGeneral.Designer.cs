namespace Device_Managament2804
{
    partial class frmViewAll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAll));
            this.dgv_view_all = new System.Windows.Forms.DataGridView();
            this.Device_serial_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suggest_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Expected_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Modify_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ViewAll = new System.Windows.Forms.Button();
            this.lbl_from = new System.Windows.Forms.Label();
            this.dpk_from = new System.Windows.Forms.DateTimePicker();
            this.dpk_to = new System.Windows.Forms.DateTimePicker();
            this.lbl_to = new System.Windows.Forms.Label();
            this.btn_view_excel = new System.Windows.Forms.Button();
            this.btn_ViewDate = new System.Windows.Forms.Button();
            this.btn_device_managament = new System.Windows.Forms.Button();
            this.btn_user_managament = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_order_manage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_find = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_ex = new System.Windows.Forms.Label();
            this.lbl_im = new System.Windows.Forms.Label();
            this.lbl_im_qty = new System.Windows.Forms.Label();
            this.lbl_ex_qty = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_all)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_view_all
            // 
            this.dgv_view_all.AllowUserToAddRows = false;
            this.dgv_view_all.AllowUserToDeleteRows = false;
            this.dgv_view_all.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_view_all.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_view_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_view_all.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Device_serial_key,
            this.Name_device,
            this.Device_ID,
            this.Quantity,
            this.Unit,
            this.Note,
            this.Suggest_id,
            this.Order_Date,
            this.Order_Expected_Date,
            this.Order_Modify_Date,
            this.Order_Status,
            this.Order_Quantity,
            this.Full_Name,
            this.Department_Name,
            this.Order_Note});
            this.dgv_view_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_view_all.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dgv_view_all.Location = new System.Drawing.Point(3, 16);
            this.dgv_view_all.Name = "dgv_view_all";
            this.dgv_view_all.ReadOnly = true;
            this.dgv_view_all.Size = new System.Drawing.Size(1135, 350);
            this.dgv_view_all.TabIndex = 0;
            this.dgv_view_all.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_view_all_CellClick);
            // 
            // Device_serial_key
            // 
            this.Device_serial_key.HeaderText = "Device Seri";
            this.Device_serial_key.Name = "Device_serial_key";
            this.Device_serial_key.ReadOnly = true;
            // 
            // Name_device
            // 
            this.Name_device.HeaderText = "Device Name";
            this.Name_device.Name = "Name_device";
            this.Name_device.ReadOnly = true;
            // 
            // Device_ID
            // 
            this.Device_ID.HeaderText = "Device ID";
            this.Device_ID.Name = "Device_ID";
            this.Device_ID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Decripstion";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // Suggest_id
            // 
            this.Suggest_id.HeaderText = "Suggest ID";
            this.Suggest_id.Name = "Suggest_id";
            this.Suggest_id.ReadOnly = true;
            // 
            // Order_Date
            // 
            this.Order_Date.HeaderText = "Orders Date";
            this.Order_Date.Name = "Order_Date";
            this.Order_Date.ReadOnly = true;
            // 
            // Order_Expected_Date
            // 
            this.Order_Expected_Date.HeaderText = "Expect Date";
            this.Order_Expected_Date.Name = "Order_Expected_Date";
            this.Order_Expected_Date.ReadOnly = true;
            // 
            // Order_Modify_Date
            // 
            this.Order_Modify_Date.HeaderText = "Modify";
            this.Order_Modify_Date.Name = "Order_Modify_Date";
            this.Order_Modify_Date.ReadOnly = true;
            // 
            // Order_Status
            // 
            this.Order_Status.HeaderText = "Status";
            this.Order_Status.Name = "Order_Status";
            this.Order_Status.ReadOnly = true;
            // 
            // Order_Quantity
            // 
            this.Order_Quantity.HeaderText = "Orders Quantity";
            this.Order_Quantity.Name = "Order_Quantity";
            this.Order_Quantity.ReadOnly = true;
            // 
            // Full_Name
            // 
            this.Full_Name.HeaderText = "Full Name";
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            // 
            // Department_Name
            // 
            this.Department_Name.HeaderText = "Department";
            this.Department_Name.Name = "Department_Name";
            this.Department_Name.ReadOnly = true;
            // 
            // Order_Note
            // 
            this.Order_Note.HeaderText = "Note";
            this.Order_Note.Name = "Order_Note";
            this.Order_Note.ReadOnly = true;
            // 
            // btn_ViewAll
            // 
            this.btn_ViewAll.AutoSize = true;
            this.btn_ViewAll.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ViewAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewAll.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ViewAll.Location = new System.Drawing.Point(17, 18);
            this.btn_ViewAll.Name = "btn_ViewAll";
            this.btn_ViewAll.Size = new System.Drawing.Size(201, 52);
            this.btn_ViewAll.TabIndex = 2;
            this.btn_ViewAll.Text = "Xem Danh Sách";
            this.btn_ViewAll.UseVisualStyleBackColor = false;
            this.btn_ViewAll.Click += new System.EventHandler(this.btn_ViewAll_Click);
            // 
            // lbl_from
            // 
            this.lbl_from.BackColor = System.Drawing.Color.Transparent;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_from.Location = new System.Drawing.Point(24, 22);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(34, 23);
            this.lbl_from.TabIndex = 5;
            this.lbl_from.Text = "Từ:";
            this.lbl_from.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_from.Click += new System.EventHandler(this.label1_Click);
            // 
            // dpk_from
            // 
            this.dpk_from.CalendarFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_from.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dpk_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_from.Location = new System.Drawing.Point(64, 19);
            this.dpk_from.Name = "dpk_from";
            this.dpk_from.Size = new System.Drawing.Size(112, 24);
            this.dpk_from.TabIndex = 6;
            // 
            // dpk_to
            // 
            this.dpk_to.CalendarFont = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_to.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dpk_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpk_to.Location = new System.Drawing.Point(295, 19);
            this.dpk_to.Name = "dpk_to";
            this.dpk_to.Size = new System.Drawing.Size(112, 24);
            this.dpk_to.TabIndex = 6;
            // 
            // lbl_to
            // 
            this.lbl_to.BackColor = System.Drawing.Color.Transparent;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_to.Location = new System.Drawing.Point(240, 22);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(49, 23);
            this.lbl_to.TabIndex = 5;
            this.lbl_to.Text = "Đến:";
            this.lbl_to.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_to.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_view_excel
            // 
            this.btn_view_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_view_excel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_excel.Location = new System.Drawing.Point(256, 18);
            this.btn_view_excel.Name = "btn_view_excel";
            this.btn_view_excel.Size = new System.Drawing.Size(100, 124);
            this.btn_view_excel.TabIndex = 9;
            this.btn_view_excel.Text = "Xuất Excel";
            this.btn_view_excel.UseVisualStyleBackColor = true;
            this.btn_view_excel.Click += new System.EventHandler(this.btn_view_excel_Click);
            // 
            // btn_ViewDate
            // 
            this.btn_ViewDate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_ViewDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewDate.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ViewDate.Location = new System.Drawing.Point(28, 49);
            this.btn_ViewDate.Name = "btn_ViewDate";
            this.btn_ViewDate.Size = new System.Drawing.Size(379, 40);
            this.btn_ViewDate.TabIndex = 4;
            this.btn_ViewDate.Text = "Xem";
            this.btn_ViewDate.UseVisualStyleBackColor = false;
            this.btn_ViewDate.Click += new System.EventHandler(this.btn_ViewDate_Click);
            // 
            // btn_device_managament
            // 
            this.btn_device_managament.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_device_managament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_device_managament.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_device_managament.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_device_managament.Location = new System.Drawing.Point(11, 19);
            this.btn_device_managament.Name = "btn_device_managament";
            this.btn_device_managament.Size = new System.Drawing.Size(143, 38);
            this.btn_device_managament.TabIndex = 10;
            this.btn_device_managament.Text = "Quản lý Vật Tư";
            this.btn_device_managament.UseVisualStyleBackColor = false;
            this.btn_device_managament.Click += new System.EventHandler(this.btn_device_managament_Click);
            // 
            // btn_user_managament
            // 
            this.btn_user_managament.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_user_managament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user_managament.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_managament.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_user_managament.Location = new System.Drawing.Point(160, 19);
            this.btn_user_managament.Name = "btn_user_managament";
            this.btn_user_managament.Size = new System.Drawing.Size(143, 38);
            this.btn_user_managament.TabIndex = 10;
            this.btn_user_managament.Text = "Quản Lý Người Dùng";
            this.btn_user_managament.UseVisualStyleBackColor = false;
            this.btn_user_managament.Click += new System.EventHandler(this.btn_user_managament_Click);
            // 
            // btn_history
            // 
            this.btn_history.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_history.Location = new System.Drawing.Point(11, 63);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(143, 38);
            this.btn_history.TabIndex = 10;
            this.btn_history.Text = "Nhật ký hoạt động";
            this.btn_history.UseVisualStyleBackColor = false;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Location = new System.Drawing.Point(17, 76);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(201, 50);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Đăng Xuất";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_order_manage
            // 
            this.btn_order_manage.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_order_manage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_order_manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_manage.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_order_manage.Location = new System.Drawing.Point(160, 63);
            this.btn_order_manage.Name = "btn_order_manage";
            this.btn_order_manage.Size = new System.Drawing.Size(143, 38);
            this.btn_order_manage.TabIndex = 12;
            this.btn_order_manage.Text = "Quản Lý Đơn Hàngg";
            this.btn_order_manage.UseVisualStyleBackColor = false;
            this.btn_order_manage.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1141, 166);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox4.Controls.Add(this.txt_search);
            this.groupBox4.Controls.Add(this.dpk_to);
            this.groupBox4.Controls.Add(this.lbl_find);
            this.groupBox4.Controls.Add(this.lbl_to);
            this.groupBox4.Controls.Add(this.btn_ViewDate);
            this.groupBox4.Controls.Add(this.lbl_from);
            this.groupBox4.Controls.Add(this.dpk_from);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(312, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 147);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_search.Location = new System.Drawing.Point(83, 103);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(324, 29);
            this.txt_search.TabIndex = 7;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_find
            // 
            this.lbl_find.BackColor = System.Drawing.Color.Transparent;
            this.lbl_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_find.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_find.Location = new System.Drawing.Point(28, 108);
            this.lbl_find.Name = "lbl_find";
            this.lbl_find.Size = new System.Drawing.Size(49, 23);
            this.lbl_find.TabIndex = 5;
            this.lbl_find.Text = "Tìm:";
            this.lbl_find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_find.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox3.Controls.Add(this.btn_ViewAll);
            this.groupBox3.Controls.Add(this.btn_Exit);
            this.groupBox3.Controls.Add(this.btn_view_excel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(773, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(365, 147);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox2.Controls.Add(this.lbl_ex);
            this.groupBox2.Controls.Add(this.lbl_im);
            this.groupBox2.Controls.Add(this.lbl_im_qty);
            this.groupBox2.Controls.Add(this.lbl_ex_qty);
            this.groupBox2.Controls.Add(this.btn_user_managament);
            this.groupBox2.Controls.Add(this.btn_device_managament);
            this.groupBox2.Controls.Add(this.btn_order_manage);
            this.groupBox2.Controls.Add(this.btn_history);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 147);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // lbl_ex
            // 
            this.lbl_ex.AutoSize = true;
            this.lbl_ex.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ex.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_ex.Location = new System.Drawing.Point(191, 114);
            this.lbl_ex.Name = "lbl_ex";
            this.lbl_ex.Size = new System.Drawing.Size(70, 18);
            this.lbl_ex.TabIndex = 14;
            this.lbl_ex.Text = "Đã xuất:";
            // 
            // lbl_im
            // 
            this.lbl_im.AutoSize = true;
            this.lbl_im.BackColor = System.Drawing.Color.Transparent;
            this.lbl_im.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_im.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_im.Location = new System.Drawing.Point(26, 114);
            this.lbl_im.Name = "lbl_im";
            this.lbl_im.Size = new System.Drawing.Size(75, 18);
            this.lbl_im.TabIndex = 14;
            this.lbl_im.Text = "Đã nhập:";
            // 
            // lbl_im_qty
            // 
            this.lbl_im_qty.AutoSize = true;
            this.lbl_im_qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_im_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_im_qty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_im_qty.Location = new System.Drawing.Point(107, 114);
            this.lbl_im_qty.Name = "lbl_im_qty";
            this.lbl_im_qty.Size = new System.Drawing.Size(17, 18);
            this.lbl_im_qty.TabIndex = 13;
            this.lbl_im_qty.Text = "0";
            // 
            // lbl_ex_qty
            // 
            this.lbl_ex_qty.AutoSize = true;
            this.lbl_ex_qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ex_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ex_qty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ex_qty.Location = new System.Drawing.Point(272, 114);
            this.lbl_ex_qty.Name = "lbl_ex_qty";
            this.lbl_ex_qty.Size = new System.Drawing.Size(17, 18);
            this.lbl_ex_qty.TabIndex = 13;
            this.lbl_ex_qty.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox5.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox5.Controls.Add(this.dgv_view_all);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 166);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1141, 369);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // frmViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1141, 535);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Management -MES Office - LHG - Lac Ty 2 Company Limited ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmViewAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_all)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_view_all;
        private System.Windows.Forms.Button btn_ViewAll;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.DateTimePicker dpk_from;
        private System.Windows.Forms.DateTimePicker dpk_to;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Button btn_view_excel;
        private System.Windows.Forms.Button btn_ViewDate;
        private System.Windows.Forms.Button btn_device_managament;
        private System.Windows.Forms.Button btn_user_managament;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_order_manage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_find;
        private System.Windows.Forms.Label lbl_im_qty;
        private System.Windows.Forms.Label lbl_ex_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device_serial_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suggest_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Expected_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Modify_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_Note;
        private System.Windows.Forms.Label lbl_ex;
        private System.Windows.Forms.Label lbl_im;
    }
}