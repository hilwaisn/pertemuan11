﻿namespace pertemuan11
{
    partial class Form1
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDelete2 = new System.Windows.Forms.TextBox();
            this.txtDelete3 = new System.Windows.Forms.TextBox();
            this.txtDelete4 = new System.Windows.Forms.TextBox();
            this.txtDelete1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBarang = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.printDocumentBarang = new System.Drawing.Printing.PrintDocument();
            this.printDialogBarang = new System.Windows.Forms.PrintDialog();
            this.txtForSearch = new System.Windows.Forms.TextBox();
            this.btn_Print = new System.Windows.Forms.Button();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(313, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 43);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDelete2
            // 
            this.txtDelete2.ForeColor = System.Drawing.Color.Transparent;
            this.txtDelete2.Location = new System.Drawing.Point(6, 59);
            this.txtDelete2.Name = "txtDelete2";
            this.txtDelete2.Size = new System.Drawing.Size(100, 26);
            this.txtDelete2.TabIndex = 16;
            // 
            // txtDelete3
            // 
            this.txtDelete3.ForeColor = System.Drawing.Color.Transparent;
            this.txtDelete3.Location = new System.Drawing.Point(136, 11);
            this.txtDelete3.Name = "txtDelete3";
            this.txtDelete3.Size = new System.Drawing.Size(100, 26);
            this.txtDelete3.TabIndex = 15;
            // 
            // txtDelete4
            // 
            this.txtDelete4.ForeColor = System.Drawing.Color.Transparent;
            this.txtDelete4.Location = new System.Drawing.Point(136, 52);
            this.txtDelete4.Name = "txtDelete4";
            this.txtDelete4.Size = new System.Drawing.Size(100, 26);
            this.txtDelete4.TabIndex = 14;
            // 
            // txtDelete1
            // 
            this.txtDelete1.ForeColor = System.Drawing.Color.Transparent;
            this.txtDelete1.Location = new System.Drawing.Point(6, 11);
            this.txtDelete1.Name = "txtDelete1";
            this.txtDelete1.Size = new System.Drawing.Size(100, 26);
            this.txtDelete1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(704, 223);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(668, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 41);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(537, 102);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 41);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(422, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 43);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBarang
            // 
            this.lblBarang.AutoSize = true;
            this.lblBarang.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarang.Location = new System.Drawing.Point(414, 30);
            this.lblBarang.Name = "lblBarang";
            this.lblBarang.Size = new System.Drawing.Size(213, 45);
            this.lblBarang.TabIndex = 18;
            this.lblBarang.Text = "Data Barang";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Search.Location = new System.Drawing.Point(670, 149);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(87, 39);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // printDialogBarang
            // 
            this.printDialogBarang.UseEXDialog = true;
            // 
            // txtForSearch
            // 
            this.txtForSearch.Location = new System.Drawing.Point(54, 155);
            this.txtForSearch.Name = "txtForSearch";
            this.txtForSearch.Size = new System.Drawing.Size(607, 26);
            this.txtForSearch.TabIndex = 20;
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.Black;
            this.btn_Print.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Print.Location = new System.Drawing.Point(54, 110);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(87, 39);
            this.btn_Print.TabIndex = 21;
            this.btn_Print.Text = "Print";
            this.btn_Print.UseVisualStyleBackColor = false;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(284, 32);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(77, 32);
            this.guna2ToggleSwitch1.TabIndex = 22;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.txtForSearch);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lblBarang);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDelete2);
            this.Controls.Add(this.txtDelete3);
            this.Controls.Add(this.txtDelete4);
            this.Controls.Add(this.txtDelete1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDelete2;
        private System.Windows.Forms.TextBox txtDelete3;
        private System.Windows.Forms.TextBox txtDelete4;
        private System.Windows.Forms.TextBox txtDelete1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBarang;
        private System.Windows.Forms.Button btn_Search;
        private System.Drawing.Printing.PrintDocument printDocumentBarang;
        private System.Windows.Forms.PrintDialog printDialogBarang;
        private System.Windows.Forms.TextBox txtForSearch;
        private System.Windows.Forms.Button btn_Print;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
    }
}

