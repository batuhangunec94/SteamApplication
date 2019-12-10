namespace SteamApplication.UI
{
    partial class AdminPanel
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
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnEditGame = new System.Windows.Forms.Button();
            this.btnEditAppUser = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(25, 12);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(122, 46);
            this.btnEditCategory.TabIndex = 0;
            this.btnEditCategory.Text = "Edit Category";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnEditGame
            // 
            this.btnEditGame.Location = new System.Drawing.Point(173, 12);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(122, 46);
            this.btnEditGame.TabIndex = 0;
            this.btnEditGame.Text = "Edit Game";
            this.btnEditGame.UseVisualStyleBackColor = true;
            this.btnEditGame.Click += new System.EventHandler(this.btnEditGame_Click);
            // 
            // btnEditAppUser
            // 
            this.btnEditAppUser.Location = new System.Drawing.Point(333, 12);
            this.btnEditAppUser.Name = "btnEditAppUser";
            this.btnEditAppUser.Size = new System.Drawing.Size(115, 46);
            this.btnEditAppUser.TabIndex = 0;
            this.btnEditAppUser.Text = "Edit App User";
            this.btnEditAppUser.UseVisualStyleBackColor = true;
            this.btnEditAppUser.Click += new System.EventHandler(this.btnEditAppUser_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(945, 440);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Game Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(982, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnEditAppUser);
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.btnEditCategory);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnEditGame;
        private System.Windows.Forms.Button btnEditAppUser;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}