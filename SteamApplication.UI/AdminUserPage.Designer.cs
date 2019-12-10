namespace SteamApplication.UI
{
    partial class AdminUserPage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAddRole = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.txtAddUserName = new System.Windows.Forms.TextBox();
            this.txtAddEmail = new System.Windows.Forms.TextBox();
            this.txtAddLName = new System.Windows.Forms.TextBox();
            this.txtAddFName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.txtUpdateUserName = new System.Windows.Forms.TextBox();
            this.txtUpdateEmail = new System.Windows.Forms.TextBox();
            this.txtUpdateLName = new System.Windows.Forms.TextBox();
            this.txtUpdateFName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.mskEndDate = new System.Windows.Forms.MaskedTextBox();
            this.mskStartedDate = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbAddRole);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAddPassword);
            this.groupBox1.Controls.Add(this.txtAddUserName);
            this.groupBox1.Controls.Add(this.txtAddEmail);
            this.groupBox1.Controls.Add(this.txtAddLName);
            this.groupBox1.Controls.Add(this.txtAddFName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Role:";
            // 
            // cmbAddRole
            // 
            this.cmbAddRole.FormattingEnabled = true;
            this.cmbAddRole.Location = new System.Drawing.Point(80, 159);
            this.cmbAddRole.Name = "cmbAddRole";
            this.cmbAddRole.Size = new System.Drawing.Size(121, 21);
            this.cmbAddRole.TabIndex = 3;
            this.cmbAddRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAddRole_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(126, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(80, 133);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PasswordChar = '*';
            this.txtAddPassword.Size = new System.Drawing.Size(100, 20);
            this.txtAddPassword.TabIndex = 1;
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Location = new System.Drawing.Point(80, 107);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(100, 20);
            this.txtAddUserName.TabIndex = 1;
            // 
            // txtAddEmail
            // 
            this.txtAddEmail.Location = new System.Drawing.Point(80, 81);
            this.txtAddEmail.Name = "txtAddEmail";
            this.txtAddEmail.Size = new System.Drawing.Size(100, 20);
            this.txtAddEmail.TabIndex = 1;
            // 
            // txtAddLName
            // 
            this.txtAddLName.Location = new System.Drawing.Point(80, 55);
            this.txtAddLName.Name = "txtAddLName";
            this.txtAddLName.Size = new System.Drawing.Size(100, 20);
            this.txtAddLName.TabIndex = 1;
            // 
            // txtAddFName
            // 
            this.txtAddFName.Location = new System.Drawing.Point(80, 29);
            this.txtAddFName.Name = "txtAddFName";
            this.txtAddFName.Size = new System.Drawing.Size(100, 20);
            this.txtAddFName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(866, 186);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUpdateID);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtUpdatePassword);
            this.groupBox2.Controls.Add(this.txtUpdateUserName);
            this.groupBox2.Controls.Add(this.txtUpdateEmail);
            this.groupBox2.Controls.Add(this.txtUpdateLName);
            this.groupBox2.Controls.Add(this.txtUpdateFName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbUpdateRole);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update User";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(89, 23);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateID.TabIndex = 13;
            this.txtUpdateID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateID_KeyPress);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(89, 153);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.PasswordChar = '*';
            this.txtUpdatePassword.Size = new System.Drawing.Size(100, 20);
            this.txtUpdatePassword.TabIndex = 7;
            // 
            // txtUpdateUserName
            // 
            this.txtUpdateUserName.Location = new System.Drawing.Point(89, 127);
            this.txtUpdateUserName.Name = "txtUpdateUserName";
            this.txtUpdateUserName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateUserName.TabIndex = 8;
            // 
            // txtUpdateEmail
            // 
            this.txtUpdateEmail.Location = new System.Drawing.Point(89, 101);
            this.txtUpdateEmail.Name = "txtUpdateEmail";
            this.txtUpdateEmail.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateEmail.TabIndex = 9;
            // 
            // txtUpdateLName
            // 
            this.txtUpdateLName.Location = new System.Drawing.Point(89, 75);
            this.txtUpdateLName.Name = "txtUpdateLName";
            this.txtUpdateLName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateLName.TabIndex = 10;
            // 
            // txtUpdateFName
            // 
            this.txtUpdateFName.Location = new System.Drawing.Point(89, 49);
            this.txtUpdateFName.Name = "txtUpdateFName";
            this.txtUpdateFName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateFName.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Password:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "User Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Last Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ID";
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Location = new System.Drawing.Point(89, 179);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateRole.TabIndex = 0;
            this.cmbUpdateRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUpdateRole_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.txtDelete);
            this.groupBox3.Location = new System.Drawing.Point(529, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 94);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete User";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(79, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(54, 28);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 20);
            this.txtDelete.TabIndex = 0;
            this.txtDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDelete_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnFind);
            this.groupBox4.Controls.Add(this.txtFind);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(529, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 98);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find Users";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(79, 59);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(54, 33);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 20);
            this.txtFind.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.btnGetAll);
            this.groupBox5.Location = new System.Drawing.Point(712, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(166, 94);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Get All Users";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Get All Users";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(50, 52);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGet);
            this.groupBox6.Controls.Add(this.mskEndDate);
            this.groupBox6.Controls.Add(this.mskStartedDate);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Location = new System.Drawing.Point(713, 114);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(165, 107);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Date";
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(81, 77);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 23);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // mskEndDate
            // 
            this.mskEndDate.Location = new System.Drawing.Point(81, 51);
            this.mskEndDate.Mask = "00/00/0000";
            this.mskEndDate.Name = "mskEndDate";
            this.mskEndDate.Size = new System.Drawing.Size(72, 20);
            this.mskEndDate.TabIndex = 3;
            this.mskEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskStartedDate
            // 
            this.mskStartedDate.Location = new System.Drawing.Point(81, 25);
            this.mskStartedDate.Mask = "00/00/0000";
            this.mskStartedDate.Name = "mskStartedDate";
            this.mskStartedDate.Size = new System.Drawing.Size(72, 20);
            this.mskStartedDate.TabIndex = 2;
            this.mskStartedDate.ValidatingType = typeof(System.DateTime);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "End Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Started Date:";
            // 
            // AdminUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 460);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminUserPage";
            this.Text = "AdminUserPage";
            this.Load += new System.EventHandler(this.AdminUserPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAddRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.TextBox txtAddUserName;
        private System.Windows.Forms.TextBox txtAddEmail;
        private System.Windows.Forms.TextBox txtAddLName;
        private System.Windows.Forms.TextBox txtAddFName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.TextBox txtUpdateUserName;
        private System.Windows.Forms.TextBox txtUpdateEmail;
        private System.Windows.Forms.TextBox txtUpdateLName;
        private System.Windows.Forms.TextBox txtUpdateFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.MaskedTextBox mskEndDate;
        private System.Windows.Forms.MaskedTextBox mskStartedDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
    }
}