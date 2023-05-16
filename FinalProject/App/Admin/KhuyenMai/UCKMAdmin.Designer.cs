﻿namespace FinalProject.App.Admin
{
    partial class UCKMAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKM = new System.Windows.Forms.Label();
            this.kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            this.btnAddKM = new Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKM
            // 
            this.lblKM.AutoSize = true;
            this.lblKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKM.Location = new System.Drawing.Point(65, 26);
            this.lblKM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKM.Name = "lblKM";
            this.lblKM.Size = new System.Drawing.Size(281, 29);
            this.lblKM.TabIndex = 0;
            this.lblKM.Text = "Nhập mã tìm khuyến mãi:";
            // 
            // kryptonTextBox1
            // 
            this.kryptonTextBox1.Location = new System.Drawing.Point(71, 91);
            this.kryptonTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kryptonTextBox1.Name = "kryptonTextBox1";
            this.kryptonTextBox1.Size = new System.Drawing.Size(1284, 47);
            this.kryptonTextBox1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.kryptonTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonTextBox1.StateCommon.Border.Rounding = 30F;
            this.kryptonTextBox1.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.kryptonTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonTextBox1.TabIndex = 4;
            this.kryptonTextBox1.Text = "Search";
            // 
            // btnAddKM
            // 
            this.btnAddKM.CornerRoundingRadius = 30F;
            this.btnAddKM.Location = new System.Drawing.Point(1179, 26);
            this.btnAddKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddKM.Name = "btnAddKM";
            this.btnAddKM.Size = new System.Drawing.Size(176, 57);
            this.btnAddKM.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnAddKM.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.btnAddKM.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddKM.StateCommon.Border.Rounding = 30F;
            this.btnAddKM.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddKM.TabIndex = 6;
            this.btnAddKM.Values.Text = "Thêm";
            this.btnAddKM.Click += new System.EventHandler(this.btnAddKM_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(92, 165);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1261, 762);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(229)))));
            this.picSearch.Image = global::FinalProject.Properties.Resources.searchh;
            this.picSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picSearch.Location = new System.Drawing.Point(1279, 97);
            this.picSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(48, 39);
            this.picSearch.TabIndex = 5;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // UCKMAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAddKM);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.kryptonTextBox1);
            this.Controls.Add(this.lblKM);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCKMAdmin";
            this.Size = new System.Drawing.Size(1440, 985);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKM;
        private System.Windows.Forms.PictureBox picSearch;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton btnAddKM;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
