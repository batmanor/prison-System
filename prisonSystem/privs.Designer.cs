namespace prisonSystem
{
    partial class privs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dropButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jobRadioButton = new System.Windows.Forms.RadioButton();
            this.GuardRadioButton = new System.Windows.Forms.RadioButton();
            this.viewerRadioButton = new System.Windows.Forms.RadioButton();
            this.prisonerRadioButton = new System.Windows.Forms.RadioButton();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grantButton = new System.Windows.Forms.Button();
            this.revokeButton = new System.Windows.Forms.Button();
            this.grantRoleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 489);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 331);
            this.dataGridView1.TabIndex = 0;
            // 
            // dropButton
            // 
            this.dropButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.dropButton.Location = new System.Drawing.Point(1065, 419);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(157, 64);
            this.dropButton.TabIndex = 1;
            this.dropButton.Text = "Revoke role";
            this.dropButton.UseVisualStyleBackColor = true;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.button2.Location = new System.Drawing.Point(12, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "show all users";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.Location = new System.Drawing.Point(200, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Tahoma", 16F);
            this.idTextBox.Location = new System.Drawing.Point(377, 94);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(412, 46);
            this.idTextBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jobRadioButton);
            this.groupBox1.Controls.Add(this.GuardRadioButton);
            this.groupBox1.Controls.Add(this.viewerRadioButton);
            this.groupBox1.Controls.Add(this.prisonerRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14F);
            this.groupBox1.Location = new System.Drawing.Point(927, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 309);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Role:";
            // 
            // jobRadioButton
            // 
            this.jobRadioButton.AutoSize = true;
            this.jobRadioButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.jobRadioButton.Location = new System.Drawing.Point(45, 262);
            this.jobRadioButton.Name = "jobRadioButton";
            this.jobRadioButton.Size = new System.Drawing.Size(134, 28);
            this.jobRadioButton.TabIndex = 5;
            this.jobRadioButton.Text = "Job assiger";
            this.jobRadioButton.UseVisualStyleBackColor = true;
            // 
            // GuardRadioButton
            // 
            this.GuardRadioButton.AutoSize = true;
            this.GuardRadioButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.GuardRadioButton.Location = new System.Drawing.Point(45, 200);
            this.GuardRadioButton.Name = "GuardRadioButton";
            this.GuardRadioButton.Size = new System.Drawing.Size(150, 28);
            this.GuardRadioButton.TabIndex = 4;
            this.GuardRadioButton.Text = "prison admin";
            this.GuardRadioButton.UseVisualStyleBackColor = true;
            // 
            // viewerRadioButton
            // 
            this.viewerRadioButton.AutoSize = true;
            this.viewerRadioButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.viewerRadioButton.Location = new System.Drawing.Point(45, 132);
            this.viewerRadioButton.Name = "viewerRadioButton";
            this.viewerRadioButton.Size = new System.Drawing.Size(151, 28);
            this.viewerRadioButton.TabIndex = 3;
            this.viewerRadioButton.Text = "guard viewer";
            this.viewerRadioButton.UseVisualStyleBackColor = true;
            // 
            // prisonerRadioButton
            // 
            this.prisonerRadioButton.AutoSize = true;
            this.prisonerRadioButton.Checked = true;
            this.prisonerRadioButton.Font = new System.Drawing.Font("Tahoma", 10F);
            this.prisonerRadioButton.Location = new System.Drawing.Point(45, 64);
            this.prisonerRadioButton.Name = "prisonerRadioButton";
            this.prisonerRadioButton.Size = new System.Drawing.Size(172, 28);
            this.prisonerRadioButton.TabIndex = 2;
            this.prisonerRadioButton.TabStop = true;
            this.prisonerRadioButton.Text = "prisoner viewer";
            this.prisonerRadioButton.UseVisualStyleBackColor = true;
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Tahoma", 16F);
            this.typeTextBox.Location = new System.Drawing.Point(377, 204);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(412, 46);
            this.typeTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label2.Location = new System.Drawing.Point(281, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "type:";
            // 
            // tableTextBox
            // 
            this.tableTextBox.Font = new System.Drawing.Font("Tahoma", 16F);
            this.tableTextBox.Location = new System.Drawing.Point(377, 298);
            this.tableTextBox.Name = "tableTextBox";
            this.tableTextBox.Size = new System.Drawing.Size(412, 46);
            this.tableTextBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label3.Location = new System.Drawing.Point(273, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 39);
            this.label3.TabIndex = 14;
            this.label3.Text = "table:";
            // 
            // grantButton
            // 
            this.grantButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.grantButton.Location = new System.Drawing.Point(594, 419);
            this.grantButton.Name = "grantButton";
            this.grantButton.Size = new System.Drawing.Size(154, 64);
            this.grantButton.TabIndex = 16;
            this.grantButton.Text = "grant privs";
            this.grantButton.UseVisualStyleBackColor = true;
            this.grantButton.Click += new System.EventHandler(this.grantButton_Click);
            // 
            // revokeButton
            // 
            this.revokeButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.revokeButton.Location = new System.Drawing.Point(422, 419);
            this.revokeButton.Name = "revokeButton";
            this.revokeButton.Size = new System.Drawing.Size(166, 64);
            this.revokeButton.TabIndex = 17;
            this.revokeButton.Text = "revoke privs";
            this.revokeButton.UseVisualStyleBackColor = true;
            this.revokeButton.Click += new System.EventHandler(this.revokeButton_Click);
            // 
            // grantRoleButton
            // 
            this.grantRoleButton.Font = new System.Drawing.Font("Tahoma", 13F);
            this.grantRoleButton.Location = new System.Drawing.Point(905, 419);
            this.grantRoleButton.Name = "grantRoleButton";
            this.grantRoleButton.Size = new System.Drawing.Size(154, 64);
            this.grantRoleButton.TabIndex = 18;
            this.grantRoleButton.Text = "Grant role";
            this.grantRoleButton.UseVisualStyleBackColor = true;
            this.grantRoleButton.Click += new System.EventHandler(this.grantRoleButton_Click);
            // 
            // privs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1272, 832);
            this.Controls.Add(this.grantRoleButton);
            this.Controls.Add(this.revokeButton);
            this.Controls.Add(this.grantButton);
            this.Controls.Add(this.tableTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dropButton);
            this.Name = "privs";
            this.Text = "DropUser";
            this.Load += new System.EventHandler(this.privs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton jobRadioButton;
        private System.Windows.Forms.RadioButton GuardRadioButton;
        private System.Windows.Forms.RadioButton viewerRadioButton;
        private System.Windows.Forms.RadioButton prisonerRadioButton;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tableTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button grantButton;
        private System.Windows.Forms.Button revokeButton;
        private System.Windows.Forms.Button grantRoleButton;
    }
}