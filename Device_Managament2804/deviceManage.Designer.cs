namespace Device_Managament2804
{
    partial class frmDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevice));
            this.grb_fill = new System.Windows.Forms.GroupBox();
            this.dgv_device = new System.Windows.Forms.DataGridView();
            this.device_serial_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_serial_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_top = new System.Windows.Forms.GroupBox();
            this.export_excel = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_main_menu = new System.Windows.Forms.Button();
            this.btn_order_manage = new System.Windows.Forms.Button();
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.lbl_user_serial_key = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.txt_device_barcode = new System.Windows.Forms.TextBox();
            this.txt_user_serial_key = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.lbl_decripstion = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.txt_device_serial_key = new System.Windows.Forms.TextBox();
            this.btn_Del = new System.Windows.Forms.Button();
            this.lbl_device_name = new System.Windows.Forms.Label();
            this.txt_decripstion = new System.Windows.Forms.RichTextBox();
            this.btn_list_device = new System.Windows.Forms.Button();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.btn_create_device_id = new System.Windows.Forms.Button();
            this.lbl_device_qty = new System.Windows.Forms.Label();
            this.lbl_device_id = new System.Windows.Forms.Label();
            this.lbl_device_serial_key = new System.Windows.Forms.Label();
            this.txt_device_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.grb_fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_device)).BeginInit();
            this.grb_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_fill
            // 
            this.grb_fill.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grb_fill.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.grb_fill.Controls.Add(this.dgv_device);
            this.grb_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_fill.Location = new System.Drawing.Point(0, 180);
            this.grb_fill.Name = "grb_fill";
            this.grb_fill.Size = new System.Drawing.Size(937, 325);
            this.grb_fill.TabIndex = 12;
            this.grb_fill.TabStop = false;
            this.grb_fill.Enter += new System.EventHandler(this.grb_fill_Enter);
            // 
            // dgv_device
            // 
            this.dgv_device.AllowUserToAddRows = false;
            this.dgv_device.AllowUserToDeleteRows = false;
            this.dgv_device.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_device.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_device.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_device.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.device_serial_key,
            this.Device_ID,
            this.Name_device,
            this.Quantity,
            this.Unit,
            this.Note,
            this.User_serial_key,
            this.Full_name});
            this.dgv_device.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_device.Location = new System.Drawing.Point(3, 16);
            this.dgv_device.Name = "dgv_device";
            this.dgv_device.ReadOnly = true;
            this.dgv_device.Size = new System.Drawing.Size(931, 306);
            this.dgv_device.TabIndex = 3;
            this.dgv_device.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_device_CellClick);
            this.dgv_device.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_device_CellContentClick);
            // 
            // device_serial_key
            // 
            this.device_serial_key.HeaderText = "Seri Vật Tư";
            this.device_serial_key.Name = "device_serial_key";
            this.device_serial_key.ReadOnly = true;
            // 
            // Device_ID
            // 
            this.Device_ID.HeaderText = "Mã Vật Tư";
            this.Device_ID.Name = "Device_ID";
            this.Device_ID.ReadOnly = true;
            // 
            // Name_device
            // 
            this.Name_device.HeaderText = "Tên Vật Tư";
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
            this.Unit.HeaderText = "ĐVT";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.HeaderText = "Mô Tả";
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // User_serial_key
            // 
            this.User_serial_key.HeaderText = "Mã NV";
            this.User_serial_key.Name = "User_serial_key";
            this.User_serial_key.ReadOnly = true;
            // 
            // Full_name
            // 
            this.Full_name.HeaderText = "Người Phụ Trách";
            this.Full_name.Name = "Full_name";
            this.Full_name.ReadOnly = true;
            // 
            // grb_top
            // 
            this.grb_top.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grb_top.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.grb_top.Controls.Add(this.export_excel);
            this.grb_top.Controls.Add(this.btn_Exit);
            this.grb_top.Controls.Add(this.btn_search);
            this.grb_top.Controls.Add(this.btn_main_menu);
            this.grb_top.Controls.Add(this.btn_order_manage);
            this.grb_top.Controls.Add(this.lbl_barcode);
            this.grb_top.Controls.Add(this.lbl_user_serial_key);
            this.grb_top.Controls.Add(this.txt_search);
            this.grb_top.Controls.Add(this.lbl_unit);
            this.grb_top.Controls.Add(this.txt_device_barcode);
            this.grb_top.Controls.Add(this.txt_user_serial_key);
            this.grb_top.Controls.Add(this.btn_Add);
            this.grb_top.Controls.Add(this.txt_qty);
            this.grb_top.Controls.Add(this.lbl_decripstion);
            this.grb_top.Controls.Add(this.btn_Edit);
            this.grb_top.Controls.Add(this.txt_device_serial_key);
            this.grb_top.Controls.Add(this.btn_Del);
            this.grb_top.Controls.Add(this.lbl_device_name);
            this.grb_top.Controls.Add(this.txt_decripstion);
            this.grb_top.Controls.Add(this.btn_list_device);
            this.grb_top.Controls.Add(this.txt_unit);
            this.grb_top.Controls.Add(this.btn_create_device_id);
            this.grb_top.Controls.Add(this.lbl_device_qty);
            this.grb_top.Controls.Add(this.lbl_device_id);
            this.grb_top.Controls.Add(this.lbl_device_serial_key);
            this.grb_top.Controls.Add(this.txt_device_id);
            this.grb_top.Controls.Add(this.txt_name);
            this.grb_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_top.ForeColor = System.Drawing.SystemColors.Control;
            this.grb_top.Location = new System.Drawing.Point(0, 0);
            this.grb_top.Name = "grb_top";
            this.grb_top.Size = new System.Drawing.Size(937, 180);
            this.grb_top.TabIndex = 11;
            this.grb_top.TabStop = false;
            this.grb_top.Enter += new System.EventHandler(this.grb_top_Enter);
            // 
            // export_excel
            // 
            this.export_excel.BackColor = System.Drawing.SystemColors.Control;
            this.export_excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export_excel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.export_excel.Location = new System.Drawing.Point(428, 143);
            this.export_excel.Name = "export_excel";
            this.export_excel.Size = new System.Drawing.Size(114, 23);
            this.export_excel.TabIndex = 9;
            this.export_excel.Text = "Xuất Excel";
            this.export_excel.UseVisualStyleBackColor = false;
            this.export_excel.Click += new System.EventHandler(this.export_excel_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Exit.Location = new System.Drawing.Point(811, 142);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(87, 23);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Đóng";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Control;
            this.btn_search.BackgroundImage = global::Device_Managament2804.Properties.Resources.search_icon;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_search.Location = new System.Drawing.Point(383, 144);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(39, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_main_menu
            // 
            this.btn_main_menu.BackColor = System.Drawing.SystemColors.Control;
            this.btn_main_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_main_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_main_menu.Location = new System.Drawing.Point(692, 143);
            this.btn_main_menu.Name = "btn_main_menu";
            this.btn_main_menu.Size = new System.Drawing.Size(113, 23);
            this.btn_main_menu.TabIndex = 6;
            this.btn_main_menu.Text = "Màn Hình Chính";
            this.btn_main_menu.UseVisualStyleBackColor = false;
            this.btn_main_menu.Click += new System.EventHandler(this.btn_main_menu_Click);
            // 
            // btn_order_manage
            // 
            this.btn_order_manage.BackColor = System.Drawing.SystemColors.Control;
            this.btn_order_manage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_manage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_order_manage.Location = new System.Drawing.Point(548, 143);
            this.btn_order_manage.Name = "btn_order_manage";
            this.btn_order_manage.Size = new System.Drawing.Size(138, 23);
            this.btn_order_manage.TabIndex = 5;
            this.btn_order_manage.Text = "Quản Lý Đơn Hàng";
            this.btn_order_manage.UseVisualStyleBackColor = false;
            this.btn_order_manage.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.AutoSize = true;
            this.lbl_barcode.BackColor = System.Drawing.Color.Transparent;
            this.lbl_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barcode.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_barcode.Location = new System.Drawing.Point(463, 82);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(95, 16);
            this.lbl_barcode.TabIndex = 0;
            this.lbl_barcode.Text = "Mã Barcode:";
            // 
            // lbl_user_serial_key
            // 
            this.lbl_user_serial_key.AutoSize = true;
            this.lbl_user_serial_key.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user_serial_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_serial_key.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_user_serial_key.Location = new System.Drawing.Point(444, 108);
            this.lbl_user_serial_key.Name = "lbl_user_serial_key";
            this.lbl_user_serial_key.Size = new System.Drawing.Size(114, 16);
            this.lbl_user_serial_key.TabIndex = 0;
            this.lbl_user_serial_key.Text = "Seri Nhân Viên:";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Control;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_search.Location = new System.Drawing.Point(278, 145);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(99, 20);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // lbl_unit
            // 
            this.lbl_unit.AutoSize = true;
            this.lbl_unit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unit.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_unit.Location = new System.Drawing.Point(517, 16);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(41, 16);
            this.lbl_unit.TabIndex = 0;
            this.lbl_unit.Text = "ĐVT:";
            this.lbl_unit.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_device_barcode
            // 
            this.txt_device_barcode.BackColor = System.Drawing.SystemColors.Control;
            this.txt_device_barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_device_barcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_device_barcode.Location = new System.Drawing.Point(564, 79);
            this.txt_device_barcode.Name = "txt_device_barcode";
            this.txt_device_barcode.Size = new System.Drawing.Size(152, 20);
            this.txt_device_barcode.TabIndex = 7;
            // 
            // txt_user_serial_key
            // 
            this.txt_user_serial_key.BackColor = System.Drawing.SystemColors.Control;
            this.txt_user_serial_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_serial_key.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_user_serial_key.Location = new System.Drawing.Point(564, 105);
            this.txt_user_serial_key.Name = "txt_user_serial_key";
            this.txt_user_serial_key.Size = new System.Drawing.Size(152, 20);
            this.txt_user_serial_key.TabIndex = 1;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Add.Location = new System.Drawing.Point(80, 143);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(58, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.SystemColors.Control;
            this.txt_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_qty.Location = new System.Drawing.Point(122, 102);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(195, 20);
            this.txt_qty.TabIndex = 4;
            // 
            // lbl_decripstion
            // 
            this.lbl_decripstion.AutoSize = true;
            this.lbl_decripstion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_decripstion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_decripstion.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_decripstion.Location = new System.Drawing.Point(509, 53);
            this.lbl_decripstion.Name = "lbl_decripstion";
            this.lbl_decripstion.Size = new System.Drawing.Size(49, 16);
            this.lbl_decripstion.TabIndex = 0;
            this.lbl_decripstion.Text = "Mô tả:";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Edit.Location = new System.Drawing.Point(144, 143);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(61, 23);
            this.btn_Edit.TabIndex = 4;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // txt_device_serial_key
            // 
            this.txt_device_serial_key.BackColor = System.Drawing.SystemColors.Control;
            this.txt_device_serial_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_device_serial_key.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_device_serial_key.Location = new System.Drawing.Point(122, 19);
            this.txt_device_serial_key.Name = "txt_device_serial_key";
            this.txt_device_serial_key.Size = new System.Drawing.Size(195, 20);
            this.txt_device_serial_key.TabIndex = 1;
            // 
            // btn_Del
            // 
            this.btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Del.Location = new System.Drawing.Point(211, 143);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(61, 23);
            this.btn_Del.TabIndex = 4;
            this.btn_Del.Text = "Xóa";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // lbl_device_name
            // 
            this.lbl_device_name.AutoSize = true;
            this.lbl_device_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_device_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_device_name.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_device_name.Location = new System.Drawing.Point(29, 79);
            this.lbl_device_name.Name = "lbl_device_name";
            this.lbl_device_name.Size = new System.Drawing.Size(87, 16);
            this.lbl_device_name.TabIndex = 0;
            this.lbl_device_name.Text = "Tên Vật Tư:";
            // 
            // txt_decripstion
            // 
            this.txt_decripstion.BackColor = System.Drawing.SystemColors.Control;
            this.txt_decripstion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_decripstion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_decripstion.Location = new System.Drawing.Point(564, 42);
            this.txt_decripstion.Name = "txt_decripstion";
            this.txt_decripstion.Size = new System.Drawing.Size(322, 27);
            this.txt_decripstion.TabIndex = 6;
            this.txt_decripstion.Text = "";
            // 
            // btn_list_device
            // 
            this.btn_list_device.BackColor = System.Drawing.SystemColors.Control;
            this.btn_list_device.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_list_device.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_list_device.Location = new System.Drawing.Point(3, 144);
            this.btn_list_device.Name = "btn_list_device";
            this.btn_list_device.Size = new System.Drawing.Size(75, 23);
            this.btn_list_device.TabIndex = 4;
            this.btn_list_device.Text = "DS Vật Tư";
            this.btn_list_device.UseVisualStyleBackColor = false;
            this.btn_list_device.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_unit
            // 
            this.txt_unit.BackColor = System.Drawing.SystemColors.Control;
            this.txt_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_unit.Location = new System.Drawing.Point(564, 12);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(152, 20);
            this.txt_unit.TabIndex = 5;
            // 
            // btn_create_device_id
            // 
            this.btn_create_device_id.BackColor = System.Drawing.SystemColors.Control;
            this.btn_create_device_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_device_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_create_device_id.Location = new System.Drawing.Point(323, 47);
            this.btn_create_device_id.Name = "btn_create_device_id";
            this.btn_create_device_id.Size = new System.Drawing.Size(65, 23);
            this.btn_create_device_id.TabIndex = 7;
            this.btn_create_device_id.Text = "Tạo Mới";
            this.btn_create_device_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_create_device_id.UseVisualStyleBackColor = false;
            this.btn_create_device_id.Click += new System.EventHandler(this.btn_create_device_id_Click);
            // 
            // lbl_device_qty
            // 
            this.lbl_device_qty.AutoSize = true;
            this.lbl_device_qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_device_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_device_qty.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_device_qty.Location = new System.Drawing.Point(40, 109);
            this.lbl_device_qty.Name = "lbl_device_qty";
            this.lbl_device_qty.Size = new System.Drawing.Size(76, 16);
            this.lbl_device_qty.TabIndex = 0;
            this.lbl_device_qty.Text = "Số Lượng:";
            // 
            // lbl_device_id
            // 
            this.lbl_device_id.AutoSize = true;
            this.lbl_device_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_device_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_device_id.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_device_id.Location = new System.Drawing.Point(36, 49);
            this.lbl_device_id.Name = "lbl_device_id";
            this.lbl_device_id.Size = new System.Drawing.Size(81, 16);
            this.lbl_device_id.TabIndex = 0;
            this.lbl_device_id.Text = "Mã Vật Tư:";
            // 
            // lbl_device_serial_key
            // 
            this.lbl_device_serial_key.AutoSize = true;
            this.lbl_device_serial_key.BackColor = System.Drawing.Color.Transparent;
            this.lbl_device_serial_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_device_serial_key.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_device_serial_key.Location = new System.Drawing.Point(26, 20);
            this.lbl_device_serial_key.Name = "lbl_device_serial_key";
            this.lbl_device_serial_key.Size = new System.Drawing.Size(88, 16);
            this.lbl_device_serial_key.TabIndex = 0;
            this.lbl_device_serial_key.Text = "Seri Vật Tư:";
            // 
            // txt_device_id
            // 
            this.txt_device_id.BackColor = System.Drawing.SystemColors.Control;
            this.txt_device_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_device_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_device_id.Location = new System.Drawing.Point(122, 49);
            this.txt_device_id.Name = "txt_device_id";
            this.txt_device_id.Size = new System.Drawing.Size(195, 20);
            this.txt_device_id.TabIndex = 2;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_name.Location = new System.Drawing.Point(122, 75);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(195, 20);
            this.txt_name.TabIndex = 3;
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(937, 505);
            this.Controls.Add(this.grb_fill);
            this.Controls.Add(this.grb_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDevice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Mangament -MES Office - LHG - Lac Ty 2 Company Limited ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDevice_Load);
            this.grb_fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_device)).EndInit();
            this.grb_top.ResumeLayout(false);
            this.grb_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_device_serial_key;
        private System.Windows.Forms.Label lbl_device_id;
        private System.Windows.Forms.Label lbl_device_name;
        private System.Windows.Forms.Label lbl_device_qty;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.Label lbl_decripstion;
        private System.Windows.Forms.Label lbl_user_serial_key;
        private System.Windows.Forms.TextBox txt_device_serial_key;
        private System.Windows.Forms.TextBox txt_device_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.TextBox txt_user_serial_key;
        private System.Windows.Forms.RichTextBox txt_decripstion;
        private System.Windows.Forms.DataGridView dgv_device;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_list_device;
        private System.Windows.Forms.Button btn_order_manage;
        private System.Windows.Forms.Button btn_main_menu;
        private System.Windows.Forms.Button btn_create_device_id;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.GroupBox grb_top;
        private System.Windows.Forms.GroupBox grb_fill;
        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.TextBox txt_device_barcode;
        private System.Windows.Forms.Button export_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn device_serial_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_serial_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name;
    }
}