namespace prisonSystem
{
    partial class splitForm
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
            this.mainFormButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.dropButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainFormButton
            // 
            this.mainFormButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainFormButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.mainFormButton.Location = new System.Drawing.Point(771, 223);
            this.mainFormButton.Name = "mainFormButton";
            this.mainFormButton.Size = new System.Drawing.Size(276, 73);
            this.mainFormButton.TabIndex = 0;
            this.mainFormButton.Text = "system tables";
            this.mainFormButton.UseVisualStyleBackColor = false;
            this.mainFormButton.Click += new System.EventHandler(this.mainFormButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.createButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.createButton.Location = new System.Drawing.Point(250, 223);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(276, 73);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Create user";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.editButton.Location = new System.Drawing.Point(250, 423);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(276, 73);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "edit roles";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // dropButton
            // 
            this.dropButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dropButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.dropButton.Location = new System.Drawing.Point(771, 423);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(276, 73);
            this.dropButton.TabIndex = 3;
            this.dropButton.Text = "Drop users";
            this.dropButton.UseVisualStyleBackColor = false;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button1.Location = new System.Drawing.Point(1107, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGOUT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prisonSystem.Properties.Resources.prison_layout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dropButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.mainFormButton);
            this.Name = "splitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splitForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.splitForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainFormButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.Button button1;
    }
}