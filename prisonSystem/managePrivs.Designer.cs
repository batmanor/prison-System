namespace prisonSystem
{
    partial class managePrivs
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
            this.grantBtn = new System.Windows.Forms.Button();
            this.revokeBtn = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.PrivsTextBox = new System.Windows.Forms.TextBox();
            this.TableTextBox = new System.Windows.Forms.TextBox();
            this.RoleRadioButton = new System.Windows.Forms.RadioButton();
            this.privsRadioButton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.privRoleLable = new System.Windows.Forms.Label();
            this.TableLabel = new System.Windows.Forms.Label();
            this.userButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.userRoleButton = new System.Windows.Forms.Button();
            this.userPrivsButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grantBtn
            // 
            this.grantBtn.Font = new System.Drawing.Font("Tahoma", 14F);
            this.grantBtn.Location = new System.Drawing.Point(133, 516);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(187, 66);
            this.grantBtn.TabIndex = 4;
            this.grantBtn.Text = "Grant";
            this.grantBtn.UseVisualStyleBackColor = true;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // revokeBtn
            // 
            this.revokeBtn.Font = new System.Drawing.Font("Tahoma", 14F);
            this.revokeBtn.Location = new System.Drawing.Point(363, 516);
            this.revokeBtn.Name = "revokeBtn";
            this.revokeBtn.Size = new System.Drawing.Size(187, 66);
            this.revokeBtn.TabIndex = 5;
            this.revokeBtn.Text = "Revoke";
            this.revokeBtn.UseVisualStyleBackColor = true;
            this.revokeBtn.Click += new System.EventHandler(this.revokeBtn_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.usernameTextBox.Location = new System.Drawing.Point(134, 136);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(416, 41);
            this.usernameTextBox.TabIndex = 1;
            // 
            // PrivsTextBox
            // 
            this.PrivsTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.PrivsTextBox.Location = new System.Drawing.Point(134, 243);
            this.PrivsTextBox.Name = "PrivsTextBox";
            this.PrivsTextBox.Size = new System.Drawing.Size(416, 41);
            this.PrivsTextBox.TabIndex = 2;
            // 
            // TableTextBox
            // 
            this.TableTextBox.Enabled = false;
            this.TableTextBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.TableTextBox.Location = new System.Drawing.Point(133, 354);
            this.TableTextBox.Name = "TableTextBox";
            this.TableTextBox.Size = new System.Drawing.Size(416, 41);
            this.TableTextBox.TabIndex = 3;
            this.TableTextBox.Visible = false;
            // 
            // RoleRadioButton
            // 
            this.RoleRadioButton.AutoSize = true;
            this.RoleRadioButton.Checked = true;
            this.RoleRadioButton.Font = new System.Drawing.Font("Tahoma", 15F);
            this.RoleRadioButton.Location = new System.Drawing.Point(45, 123);
            this.RoleRadioButton.Name = "RoleRadioButton";
            this.RoleRadioButton.Size = new System.Drawing.Size(111, 40);
            this.RoleRadioButton.TabIndex = 6;
            this.RoleRadioButton.TabStop = true;
            this.RoleRadioButton.Text = "Roles";
            this.RoleRadioButton.UseVisualStyleBackColor = true;
            this.RoleRadioButton.CheckedChanged += new System.EventHandler(this.RoleRadioButton_CheckedChanged);
            // 
            // privsRadioButton
            // 
            this.privsRadioButton.AutoSize = true;
            this.privsRadioButton.Font = new System.Drawing.Font("Tahoma", 15F);
            this.privsRadioButton.Location = new System.Drawing.Point(45, 193);
            this.privsRadioButton.Name = "privsRadioButton";
            this.privsRadioButton.Size = new System.Drawing.Size(166, 40);
            this.privsRadioButton.TabIndex = 7;
            this.privsRadioButton.Text = "Privileges";
            this.privsRadioButton.UseVisualStyleBackColor = true;
            this.privsRadioButton.CheckedChanged += new System.EventHandler(this.privsRadioButton_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(715, 438);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(522, 267);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(129, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // privRoleLable
            // 
            this.privRoleLable.AutoSize = true;
            this.privRoleLable.Font = new System.Drawing.Font("Tahoma", 12F);
            this.privRoleLable.Location = new System.Drawing.Point(129, 211);
            this.privRoleLable.Name = "privRoleLable";
            this.privRoleLable.Size = new System.Drawing.Size(59, 29);
            this.privRoleLable.TabIndex = 9;
            this.privRoleLable.Text = "Role";
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Enabled = false;
            this.TableLabel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TableLabel.Location = new System.Drawing.Point(128, 322);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(71, 29);
            this.TableLabel.TabIndex = 10;
            this.TableLabel.Text = "Table";
            this.TableLabel.Visible = false;
            // 
            // userButton
            // 
            this.userButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.userButton.Location = new System.Drawing.Point(713, 389);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(154, 43);
            this.userButton.TabIndex = 8;
            this.userButton.Text = "Show Users";
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.privsRadioButton);
            this.groupBox1.Controls.Add(this.RoleRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.groupBox1.Location = new System.Drawing.Point(773, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 310);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose what you want to change:";
            // 
            // userRoleButton
            // 
            this.userRoleButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.userRoleButton.Location = new System.Drawing.Point(1070, 389);
            this.userRoleButton.Name = "userRoleButton";
            this.userRoleButton.Size = new System.Drawing.Size(167, 43);
            this.userRoleButton.TabIndex = 10;
            this.userRoleButton.Text = "Show User\'s roles";
            this.userRoleButton.UseVisualStyleBackColor = true;
            this.userRoleButton.Click += new System.EventHandler(this.userRoleButton_Click);
            // 
            // userPrivsButton
            // 
            this.userPrivsButton.Font = new System.Drawing.Font("Tahoma", 9F);
            this.userPrivsButton.Location = new System.Drawing.Point(885, 389);
            this.userPrivsButton.Name = "userPrivsButton";
            this.userPrivsButton.Size = new System.Drawing.Size(167, 43);
            this.userPrivsButton.TabIndex = 9;
            this.userPrivsButton.Text = "Show User\'s privs";
            this.userPrivsButton.UseVisualStyleBackColor = true;
            this.userPrivsButton.Click += new System.EventHandler(this.userPrivsButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "profiles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // managePrivs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1278, 844);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userPrivsButton);
            this.Controls.Add(this.userRoleButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userButton);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.privRoleLable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TableTextBox);
            this.Controls.Add(this.PrivsTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.revokeBtn);
            this.Controls.Add(this.grantBtn);
            this.Name = "managePrivs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "managePrivs";
            this.Load += new System.EventHandler(this.managePrivs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.Button revokeBtn;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox PrivsTextBox;
        private System.Windows.Forms.TextBox TableTextBox;
        private System.Windows.Forms.RadioButton RoleRadioButton;
        private System.Windows.Forms.RadioButton privsRadioButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label privRoleLable;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button userRoleButton;
        private System.Windows.Forms.Button userPrivsButton;
        private System.Windows.Forms.Button button1;
    }
}