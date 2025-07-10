namespace prisonSystem
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRISONERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new prisonSystem.DataSet1();
            this.pRISONERTableAdapter = new prisonSystem.DataSet1TableAdapters.PRISONERTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.prisonerRadioButton = new System.Windows.Forms.RadioButton();
            this.cellRadioButton = new System.Windows.Forms.RadioButton();
            this.guardRadioButton = new System.Windows.Forms.RadioButton();
            this.jobRadioButton = new System.Windows.Forms.RadioButton();
            this.pjRadioButton = new System.Windows.Forms.RadioButton();
            this.pcRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sectionRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRISONERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.Location = new System.Drawing.Point(0, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1236, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // pRISONERBindingSource
            // 
            this.pRISONERBindingSource.DataMember = "PRISONER";
            this.pRISONERBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRISONERTableAdapter
            // 
            this.pRISONERTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1117, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "view";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prisonerRadioButton
            // 
            this.prisonerRadioButton.AutoSize = true;
            this.prisonerRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.prisonerRadioButton.Location = new System.Drawing.Point(14, 328);
            this.prisonerRadioButton.Name = "prisonerRadioButton";
            this.prisonerRadioButton.Size = new System.Drawing.Size(135, 33);
            this.prisonerRadioButton.TabIndex = 7;
            this.prisonerRadioButton.TabStop = true;
            this.prisonerRadioButton.Text = "prisoners";
            this.prisonerRadioButton.UseVisualStyleBackColor = true;
            // 
            // cellRadioButton
            // 
            this.cellRadioButton.AutoSize = true;
            this.cellRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cellRadioButton.Location = new System.Drawing.Point(203, 262);
            this.cellRadioButton.Name = "cellRadioButton";
            this.cellRadioButton.Size = new System.Drawing.Size(83, 33);
            this.cellRadioButton.TabIndex = 8;
            this.cellRadioButton.TabStop = true;
            this.cellRadioButton.Text = "cells";
            this.cellRadioButton.UseVisualStyleBackColor = true;
            // 
            // guardRadioButton
            // 
            this.guardRadioButton.AutoSize = true;
            this.guardRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.guardRadioButton.Location = new System.Drawing.Point(714, 328);
            this.guardRadioButton.Name = "guardRadioButton";
            this.guardRadioButton.Size = new System.Drawing.Size(110, 33);
            this.guardRadioButton.TabIndex = 9;
            this.guardRadioButton.TabStop = true;
            this.guardRadioButton.Text = "guards";
            this.guardRadioButton.UseVisualStyleBackColor = true;
            // 
            // jobRadioButton
            // 
            this.jobRadioButton.AutoSize = true;
            this.jobRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.jobRadioButton.Location = new System.Drawing.Point(203, 328);
            this.jobRadioButton.Name = "jobRadioButton";
            this.jobRadioButton.Size = new System.Drawing.Size(82, 33);
            this.jobRadioButton.TabIndex = 10;
            this.jobRadioButton.TabStop = true;
            this.jobRadioButton.Text = "jobs";
            this.jobRadioButton.UseVisualStyleBackColor = true;
            // 
            // pjRadioButton
            // 
            this.pjRadioButton.AutoSize = true;
            this.pjRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.pjRadioButton.Location = new System.Drawing.Point(372, 328);
            this.pjRadioButton.Name = "pjRadioButton";
            this.pjRadioButton.Size = new System.Drawing.Size(290, 33);
            this.pjRadioButton.TabIndex = 11;
            this.pjRadioButton.TabStop = true;
            this.pjRadioButton.Text = "prisoners and thier jobs";
            this.pjRadioButton.UseVisualStyleBackColor = true;
            // 
            // pcRadioButton
            // 
            this.pcRadioButton.AutoSize = true;
            this.pcRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.pcRadioButton.Location = new System.Drawing.Point(372, 262);
            this.pcRadioButton.Name = "pcRadioButton";
            this.pcRadioButton.Size = new System.Drawing.Size(211, 33);
            this.pcRadioButton.TabIndex = 12;
            this.pcRadioButton.TabStop = true;
            this.pcRadioButton.Text = "prisoners in cell:";
            this.pcRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.Location = new System.Drawing.Point(626, 261);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 36);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.Location = new System.Drawing.Point(1067, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sectionRadioButton
            // 
            this.sectionRadioButton.AutoSize = true;
            this.sectionRadioButton.Font = new System.Drawing.Font("Tahoma", 12F);
            this.sectionRadioButton.Location = new System.Drawing.Point(12, 264);
            this.sectionRadioButton.Name = "sectionRadioButton";
            this.sectionRadioButton.Size = new System.Drawing.Size(112, 33);
            this.sectionRadioButton.TabIndex = 15;
            this.sectionRadioButton.TabStop = true;
            this.sectionRadioButton.Text = "section";
            this.sectionRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::prisonSystem.Properties.Resources.person_making_notes;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 650);
            this.Controls.Add(this.sectionRadioButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pcRadioButton);
            this.Controls.Add(this.pjRadioButton);
            this.Controls.Add(this.jobRadioButton);
            this.Controls.Add(this.guardRadioButton);
            this.Controls.Add(this.cellRadioButton);
            this.Controls.Add(this.prisonerRadioButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRISONERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pRISONERBindingSource;
        private DataSet1TableAdapters.PRISONERTableAdapter pRISONERTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton prisonerRadioButton;
        private System.Windows.Forms.RadioButton cellRadioButton;
        private System.Windows.Forms.RadioButton guardRadioButton;
        private System.Windows.Forms.RadioButton jobRadioButton;
        private System.Windows.Forms.RadioButton pjRadioButton;
        private System.Windows.Forms.RadioButton pcRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton sectionRadioButton;
    }
}