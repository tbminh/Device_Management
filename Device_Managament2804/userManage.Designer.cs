namespace Device_Managament2804
{
    partial class frmUpdateUser
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
            this.lbl_user_serial = new System.Windows.Forms.Label();
            this.txt_userSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_userFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_userID = new System.Windows.Forms.TextBox();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.btn_delUser = new System.Windows.Forms.Button();
            this.btn_updateUser = new System.Windows.Forms.Button();
            this.btn_refesh = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.dgv_data_user = new System.Windows.Forms.DataGridView();
            this.User_serial_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Userpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_User = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_level_id = new System.Windows.Forms.Label();
            this.txt_level_name = new System.Windows.Forms.TextBox();
            this.txt_level_id = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_user)).BeginInit();
            this.grb_User.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_user_serial
            // 
            this.lbl_user_serial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_user_serial.AutoSize = true;
            this.lbl_user_serial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user_serial.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_user_serial.Location = new System.Drawing.Point(67, 28);
            this.lbl_user_serial.Name = "lbl_user_serial";
            this.lbl_user_serial.Size = new System.Drawing.Size(100, 20);
            this.lbl_user_serial.TabIndex = 0;
            this.lbl_user_serial.Text = "User serial:";
            this.lbl_user_serial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_userSerial
            // 
            this.txt_userSerial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_userSerial.BackColor = System.Drawing.SystemColors.Control;
            this.txt_userSerial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_userSerial.Location = new System.Drawing.Point(173, 22);
            this.txt_userSerial.Name = "txt_userSerial";
            this.txt_userSerial.Size = new System.Drawing.Size(129, 26);
            this.txt_userSerial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(313, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_userPass
            // 
            this.txt_userPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_userPass.BackColor = System.Drawing.SystemColors.Control;
            this.txt_userPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_userPass.Location = new System.Drawing.Point(410, 54);
            this.txt_userPass.Name = "txt_userPass";
            this.txt_userPass.Size = new System.Drawing.Size(132, 26);
            this.txt_userPass.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(310, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Full Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_userFullname
            // 
            this.txt_userFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_userFullname.BackColor = System.Drawing.SystemColors.Control;
            this.txt_userFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_userFullname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_userFullname.Location = new System.Drawing.Point(410, 22);
            this.txt_userFullname.Name = "txt_userFullname";
            this.txt_userFullname.Size = new System.Drawing.Size(132, 22);
            this.txt_userFullname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(91, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "User ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_userID
            // 
            this.txt_userID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_userID.BackColor = System.Drawing.SystemColors.Control;
            this.txt_userID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_userID.Location = new System.Drawing.Point(173, 54);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.Size = new System.Drawing.Size(129, 26);
            this.txt_userID.TabIndex = 2;
            // 
            // btn_addUser
            // 
            this.btn_addUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_addUser.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_addUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_addUser.Location = new System.Drawing.Point(84, 102);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(117, 33);
            this.btn_addUser.TabIndex = 5;
            this.btn_addUser.Text = "Add";
            this.btn_addUser.UseVisualStyleBackColor = false;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_delUser
            // 
            this.btn_delUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_delUser.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delUser.Location = new System.Drawing.Point(330, 102);
            this.btn_delUser.Name = "btn_delUser";
            this.btn_delUser.Size = new System.Drawing.Size(124, 33);
            this.btn_delUser.TabIndex = 7;
            this.btn_delUser.Text = "Del";
            this.btn_delUser.UseVisualStyleBackColor = false;
            this.btn_delUser.Click += new System.EventHandler(this.btn_delUser_Click);
            // 
            // btn_updateUser
            // 
            this.btn_updateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_updateUser.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_updateUser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_updateUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_updateUser.Location = new System.Drawing.Point(207, 102);
            this.btn_updateUser.Name = "btn_updateUser";
            this.btn_updateUser.Size = new System.Drawing.Size(117, 33);
            this.btn_updateUser.TabIndex = 6;
            this.btn_updateUser.Text = "Edit";
            this.btn_updateUser.UseVisualStyleBackColor = false;
            this.btn_updateUser.Click += new System.EventHandler(this.btn_updateUser_Click);
            // 
            // btn_refesh
            // 
            this.btn_refesh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_refesh.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_refesh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refesh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_refesh.Location = new System.Drawing.Point(576, 101);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(109, 33);
            this.btn_refesh.TabIndex = 8;
            this.btn_refesh.Text = "Refesh";
            this.btn_refesh.UseVisualStyleBackColor = false;
            this.btn_refesh.Click += new System.EventHandler(this.btn_refesh_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_back.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_back.Location = new System.Drawing.Point(691, 101);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(101, 33);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgv_data_user
            // 
            this.dgv_data_user.AllowUserToAddRows = false;
            this.dgv_data_user.AllowUserToDeleteRows = false;
            this.dgv_data_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data_user.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_data_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User_serial_key,
            this.User_id,
            this.Userpass,
            this.Full_name,
            this.level_id,
            this.level_name,
            this.Update_day,
            this.updater});
            this.dgv_data_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_data_user.Location = new System.Drawing.Point(3, 16);
            this.dgv_data_user.Name = "dgv_data_user";
            this.dgv_data_user.ReadOnly = true;
            this.dgv_data_user.Size = new System.Drawing.Size(869, 371);
            this.dgv_data_user.TabIndex = 10;
            this.dgv_data_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_user_CellClick);
            this.dgv_data_user.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_user_CellContentClick);
            // 
            // User_serial_key
            // 
            this.User_serial_key.HeaderText = "User_serial_key";
            this.User_serial_key.Name = "User_serial_key";
            this.User_serial_key.ReadOnly = true;
            // 
            // User_id
            // 
            this.User_id.HeaderText = "User ID";
            this.User_id.Name = "User_id";
            this.User_id.ReadOnly = true;
            // 
            // Userpass
            // 
            this.Userpass.HeaderText = "Userpass";
            this.Userpass.Name = "Userpass";
            this.Userpass.ReadOnly = true;
            // 
            // Full_name
            // 
            this.Full_name.HeaderText = "Full Name";
            this.Full_name.Name = "Full_name";
            this.Full_name.ReadOnly = true;
            // 
            // level_id
            // 
            this.level_id.HeaderText = "Level ID";
            this.level_id.Name = "level_id";
            this.level_id.ReadOnly = true;
            // 
            // level_name
            // 
            this.level_name.HeaderText = "Level Name";
            this.level_name.Name = "level_name";
            this.level_name.ReadOnly = true;
            // 
            // Update_day
            // 
            this.Update_day.HeaderText = "Time Update";
            this.Update_day.Name = "Update_day";
            this.Update_day.ReadOnly = true;
            // 
            // updater
            // 
            this.updater.HeaderText = "Updater";
            this.updater.Name = "updater";
            this.updater.ReadOnly = true;
            // 
            // grb_User
            // 
            this.grb_User.BackColor = System.Drawing.SystemColors.Control;
            this.grb_User.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.grb_User.Controls.Add(this.label1);
            this.grb_User.Controls.Add(this.lbl_level_id);
            this.grb_User.Controls.Add(this.btn_back);
            this.grb_User.Controls.Add(this.btn_refesh);
            this.grb_User.Controls.Add(this.lbl_user_serial);
            this.grb_User.Controls.Add(this.txt_level_name);
            this.grb_User.Controls.Add(this.txt_level_id);
            this.grb_User.Controls.Add(this.txt_userSerial);
            this.grb_User.Controls.Add(this.btn_updateUser);
            this.grb_User.Controls.Add(this.label4);
            this.grb_User.Controls.Add(this.btn_delUser);
            this.grb_User.Controls.Add(this.txt_userID);
            this.grb_User.Controls.Add(this.label3);
            this.grb_User.Controls.Add(this.txt_userFullname);
            this.grb_User.Controls.Add(this.btn_addUser);
            this.grb_User.Controls.Add(this.label2);
            this.grb_User.Controls.Add(this.txt_userPass);
            this.grb_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.grb_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_User.ForeColor = System.Drawing.Color.Black;
            this.grb_User.Location = new System.Drawing.Point(0, 0);
            this.grb_User.Name = "grb_User";
            this.grb_User.Size = new System.Drawing.Size(875, 165);
            this.grb_User.TabIndex = 11;
            this.grb_User.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(552, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_level_id
            // 
            this.lbl_level_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_level_id.AutoSize = true;
            this.lbl_level_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_level_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_level_id.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_level_id.Location = new System.Drawing.Point(579, 28);
            this.lbl_level_id.Name = "lbl_level_id";
            this.lbl_level_id.Size = new System.Drawing.Size(80, 20);
            this.lbl_level_id.TabIndex = 0;
            this.lbl_level_id.Text = "Level ID:";
            this.lbl_level_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_level_name
            // 
            this.txt_level_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_level_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_level_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_level_name.Location = new System.Drawing.Point(665, 54);
            this.txt_level_name.Name = "txt_level_name";
            this.txt_level_name.Size = new System.Drawing.Size(127, 26);
            this.txt_level_name.TabIndex = 6;
            // 
            // txt_level_id
            // 
            this.txt_level_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_level_id.BackColor = System.Drawing.SystemColors.Control;
            this.txt_level_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_level_id.Location = new System.Drawing.Point(665, 22);
            this.txt_level_id.Name = "txt_level_id";
            this.txt_level_id.Size = new System.Drawing.Size(127, 26);
            this.txt_level_id.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.BackgroundImage = global::Device_Managament2804.Properties.Resources.back;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dgv_data_user);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 390);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(875, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_User);
            this.Name = "frmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Device Management -MES Office - LHG - Lac Ty 2 Company Limited ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_user)).EndInit();
            this.grb_User.ResumeLayout(false);
            this.grb_User.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_user_serial;
        private System.Windows.Forms.TextBox txt_userSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_userPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_userFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_userID;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Button btn_delUser;
        private System.Windows.Forms.Button btn_updateUser;
        private System.Windows.Forms.Button btn_refesh;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgv_data_user;
        private System.Windows.Forms.GroupBox grb_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_serial_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Userpass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn level_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn level_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn updater;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_level_id;
        private System.Windows.Forms.TextBox txt_level_name;
        private System.Windows.Forms.TextBox txt_level_id;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}