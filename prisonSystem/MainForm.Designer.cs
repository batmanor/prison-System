namespace prisonSystem
{
    partial class MainForm
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.presonerBtn = new System.Windows.Forms.Button();
            this.cellBtn = new System.Windows.Forms.Button();
            this.jobBtn = new System.Windows.Forms.Button();
            this.guardBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox3.Location = new System.Drawing.Point(190, 654);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(297, 36);
            this.textBox3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(79, 657);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // presonerBtn
            // 
            this.presonerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.presonerBtn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.presonerBtn.Location = new System.Drawing.Point(304, 455);
            this.presonerBtn.Name = "presonerBtn";
            this.presonerBtn.Size = new System.Drawing.Size(276, 73);
            this.presonerBtn.TabIndex = 6;
            this.presonerBtn.Text = "presoners";
            this.presonerBtn.UseVisualStyleBackColor = false;
            this.presonerBtn.Click += new System.EventHandler(this.presonerBtn_Click);
            // 
            // cellBtn
            // 
            this.cellBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cellBtn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.cellBtn.Location = new System.Drawing.Point(524, 124);
            this.cellBtn.Name = "cellBtn";
            this.cellBtn.Size = new System.Drawing.Size(276, 73);
            this.cellBtn.TabIndex = 7;
            this.cellBtn.Text = "cells";
            this.cellBtn.UseVisualStyleBackColor = false;
            this.cellBtn.Click += new System.EventHandler(this.cellBtn_Click);
            // 
            // jobBtn
            // 
            this.jobBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.jobBtn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.jobBtn.Location = new System.Drawing.Point(105, 263);
            this.jobBtn.Name = "jobBtn";
            this.jobBtn.Size = new System.Drawing.Size(276, 73);
            this.jobBtn.TabIndex = 8;
            this.jobBtn.Text = "jobs";
            this.jobBtn.UseVisualStyleBackColor = false;
            this.jobBtn.Click += new System.EventHandler(this.jobBtn_Click);
            // 
            // guardBtn
            // 
            this.guardBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardBtn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.guardBtn.Location = new System.Drawing.Point(946, 263);
            this.guardBtn.Name = "guardBtn";
            this.guardBtn.Size = new System.Drawing.Size(276, 73);
            this.guardBtn.TabIndex = 9;
            this.guardBtn.Text = "guards";
            this.guardBtn.UseVisualStyleBackColor = false;
            this.guardBtn.Click += new System.EventHandler(this.guardBtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F);
            this.label5.Location = new System.Drawing.Point(520, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 43);
            this.label5.TabIndex = 11;
            this.label5.Text = "PRISON SYSTEM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button1.Location = new System.Drawing.Point(706, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 73);
            this.button1.TabIndex = 12;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "userName";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::prisonSystem.Properties.Resources.prison_layout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guardBtn);
            this.Controls.Add(this.jobBtn);
            this.Controls.Add(this.cellBtn);
            this.Controls.Add(this.presonerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button presonerBtn;
        private System.Windows.Forms.Button cellBtn;
        private System.Windows.Forms.Button jobBtn;
        private System.Windows.Forms.Button guardBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}