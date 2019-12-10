namespace SteamApplication.UI
{
    partial class AdminGamePage
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.pctAddImg = new System.Windows.Forms.PictureBox();
            this.txtAddImg = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogAdd = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpdateID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pctUpdateImg = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbUpdateUser = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUpdateCategory = new System.Windows.Forms.ComboBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.btnUpdateFile = new System.Windows.Forms.Button();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.txtUpdateImg = new System.Windows.Forms.TextBox();
            this.openFileDialogUpdate = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteID = new System.Windows.Forms.Button();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.mskEndDate = new System.Windows.Forms.MaskedTextBox();
            this.mskStartedDate = new System.Windows.Forms.MaskedTextBox();
            this.btnGetDAte = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdateImg)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbUser);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.btnAddFile);
            this.groupBox1.Controls.Add(this.pctAddImg);
            this.groupBox1.Controls.Add(this.txtAddImg);
            this.groupBox1.Controls.Add(this.txtAddDescription);
            this.groupBox1.Controls.Add(this.txtAddName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Game";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(499, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(88, 245);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 21);
            this.cmbUser.TabIndex = 9;
            this.cmbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUser_KeyPress);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(88, 217);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbCategory.TabIndex = 8;
            this.cmbCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCategory_KeyPress);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(195, 55);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(30, 20);
            this.btnAddFile.TabIndex = 7;
            this.btnAddFile.Text = "...";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // pctAddImg
            // 
            this.pctAddImg.Location = new System.Drawing.Point(339, 19);
            this.pctAddImg.Name = "pctAddImg";
            this.pctAddImg.Size = new System.Drawing.Size(235, 191);
            this.pctAddImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctAddImg.TabIndex = 6;
            this.pctAddImg.TabStop = false;
            // 
            // txtAddImg
            // 
            this.txtAddImg.Location = new System.Drawing.Point(88, 55);
            this.txtAddImg.Name = "txtAddImg";
            this.txtAddImg.Size = new System.Drawing.Size(100, 20);
            this.txtAddImg.TabIndex = 5;
            this.txtAddImg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddImg_KeyPress);
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(88, 81);
            this.txtAddDescription.MaxLength = 100;
            this.txtAddDescription.Multiline = true;
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(245, 129);
            this.txtAddDescription.TabIndex = 4;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(88, 29);
            this.txtAddName.MaxLength = 30;
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(100, 20);
            this.txtAddName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Img:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // openFileDialogAdd
            // 
            this.openFileDialogAdd.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1196, 248);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUpdateID);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.pctUpdateImg);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbUpdateUser);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbUpdateCategory);
            this.groupBox2.Controls.Add(this.txtUpdateName);
            this.groupBox2.Controls.Add(this.btnUpdateFile);
            this.groupBox2.Controls.Add(this.txtUpdateDescription);
            this.groupBox2.Controls.Add(this.txtUpdateImg);
            this.groupBox2.Location = new System.Drawing.Point(612, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 298);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Game";
            // 
            // txtUpdateID
            // 
            this.txtUpdateID.Location = new System.Drawing.Point(109, 18);
            this.txtUpdateID.Name = "txtUpdateID";
            this.txtUpdateID.Size = new System.Drawing.Size(78, 20);
            this.txtUpdateID.TabIndex = 27;
            this.txtUpdateID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateID_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(498, 255);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pctUpdateImg
            // 
            this.pctUpdateImg.Location = new System.Drawing.Point(338, 31);
            this.pctUpdateImg.Name = "pctUpdateImg";
            this.pctUpdateImg.Size = new System.Drawing.Size(235, 191);
            this.pctUpdateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUpdateImg.TabIndex = 19;
            this.pctUpdateImg.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "User";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Description:";
            // 
            // cmbUpdateUser
            // 
            this.cmbUpdateUser.FormattingEnabled = true;
            this.cmbUpdateUser.Location = new System.Drawing.Point(87, 257);
            this.cmbUpdateUser.Name = "cmbUpdateUser";
            this.cmbUpdateUser.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateUser.TabIndex = 22;
            this.cmbUpdateUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUpdateUser_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Img:";
            // 
            // cmbUpdateCategory
            // 
            this.cmbUpdateCategory.FormattingEnabled = true;
            this.cmbUpdateCategory.Location = new System.Drawing.Point(87, 229);
            this.cmbUpdateCategory.Name = "cmbUpdateCategory";
            this.cmbUpdateCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateCategory.TabIndex = 21;
            this.cmbUpdateCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbUpdateCategory_KeyPress);
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(87, 41);
            this.txtUpdateName.MaxLength = 30;
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateName.TabIndex = 16;
            // 
            // btnUpdateFile
            // 
            this.btnUpdateFile.Location = new System.Drawing.Point(194, 67);
            this.btnUpdateFile.Name = "btnUpdateFile";
            this.btnUpdateFile.Size = new System.Drawing.Size(30, 20);
            this.btnUpdateFile.TabIndex = 20;
            this.btnUpdateFile.Text = "...";
            this.btnUpdateFile.UseVisualStyleBackColor = true;
            this.btnUpdateFile.Click += new System.EventHandler(this.btnUpdateFile_Click);
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(87, 93);
            this.txtUpdateDescription.MaxLength = 100;
            this.txtUpdateDescription.Multiline = true;
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(245, 129);
            this.txtUpdateDescription.TabIndex = 17;
            // 
            // txtUpdateImg
            // 
            this.txtUpdateImg.Location = new System.Drawing.Point(87, 67);
            this.txtUpdateImg.Name = "txtUpdateImg";
            this.txtUpdateImg.Size = new System.Drawing.Size(100, 20);
            this.txtUpdateImg.TabIndex = 18;
            this.txtUpdateImg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpdateImg_KeyPress);
            // 
            // openFileDialogUpdate
            // 
            this.openFileDialogUpdate.FileName = "openFileDialog1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteID);
            this.groupBox3.Controls.Add(this.txtDeleteID);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(13, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 91);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete";
            // 
            // btnDeleteID
            // 
            this.btnDeleteID.Location = new System.Drawing.Point(74, 53);
            this.btnDeleteID.Name = "btnDeleteID";
            this.btnDeleteID.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteID.TabIndex = 2;
            this.btnDeleteID.Text = "Delete";
            this.btnDeleteID.UseVisualStyleBackColor = true;
            this.btnDeleteID.Click += new System.EventHandler(this.btnDeleteID_Click);
            // 
            // txtDeleteID
            // 
            this.txtDeleteID.Location = new System.Drawing.Point(49, 27);
            this.txtDeleteID.Name = "txtDeleteID";
            this.txtDeleteID.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteID.TabIndex = 1;
            this.txtDeleteID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeleteID_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "ID";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetAll);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(190, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 91);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GetAll";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(37, 53);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(38, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Get All Game";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnFind);
            this.groupBox5.Controls.Add(this.txtFindName);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Location = new System.Drawing.Point(352, 318);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(178, 91);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Find Name";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(79, 50);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(54, 24);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.Size = new System.Drawing.Size(100, 20);
            this.txtFindName.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Name:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.mskEndDate);
            this.groupBox6.Controls.Add(this.mskStartedDate);
            this.groupBox6.Controls.Add(this.btnGetDAte);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(537, 318);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(248, 91);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // mskEndDate
            // 
            this.mskEndDate.Location = new System.Drawing.Point(93, 52);
            this.mskEndDate.Mask = "00/00/0000";
            this.mskEndDate.Name = "mskEndDate";
            this.mskEndDate.Size = new System.Drawing.Size(59, 20);
            this.mskEndDate.TabIndex = 3;
            this.mskEndDate.ValidatingType = typeof(System.DateTime);
            // 
            // mskStartedDate
            // 
            this.mskStartedDate.Location = new System.Drawing.Point(92, 26);
            this.mskStartedDate.Mask = "00/00/0000";
            this.mskStartedDate.Name = "mskStartedDate";
            this.mskStartedDate.Size = new System.Drawing.Size(60, 20);
            this.mskStartedDate.TabIndex = 3;
            this.mskStartedDate.ValidatingType = typeof(System.DateTime);
            // 
            // btnGetDAte
            // 
            this.btnGetDAte.Location = new System.Drawing.Point(162, 53);
            this.btnGetDAte.Name = "btnGetDAte";
            this.btnGetDAte.Size = new System.Drawing.Size(75, 20);
            this.btnGetDAte.TabIndex = 2;
            this.btnGetDAte.Text = "Get";
            this.btnGetDAte.UseVisualStyleBackColor = true;
            this.btnGetDAte.Click += new System.EventHandler(this.btnGetDAte_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "End Date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Started Date:";
            // 
            // AdminGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 683);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminGamePage";
            this.Text = "AdminGamePage";
            this.Load += new System.EventHandler(this.AdminGamePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctAddImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUpdateImg)).EndInit();
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
        private System.Windows.Forms.TextBox txtAddImg;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.PictureBox pctAddImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.PictureBox pctUpdateImg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbUpdateUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUpdateCategory;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Button btnUpdateFile;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogUpdate;
        private System.Windows.Forms.TextBox txtUpdateID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteID;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MaskedTextBox mskEndDate;
        private System.Windows.Forms.MaskedTextBox mskStartedDate;
        private System.Windows.Forms.Button btnGetDAte;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}