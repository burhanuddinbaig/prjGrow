﻿namespace prjGrow.Reporting
{
    partial class frmSaleSummary
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
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numYear
            // 
            this.numYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // cmbMonth
            // 
            this.cmbMonth.Size = new System.Drawing.Size(66, 26);
            // 
            // dtpDate
            // 
            this.dtpDate.Value = new System.DateTime(2021, 2, 8, 13, 38, 15, 481);
            // 
            // rbYear
            // 
            this.rbYear.TabStop = false;
            // 
            // rbMonth
            // 
            this.rbMonth.Checked = true;
            // 
            // rbDaily
            // 
            this.rbDaily.TabStop = false;
            // 
            // rbAll
            // 
            this.rbAll.TabStop = false;
            // 
            // frmSaleSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 300);
            this.Name = "frmSaleSummary";
            this.Text = "Sale Summary";
            this.Load += new System.EventHandler(this.frmSaleSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.pnlDates.ResumeLayout(false);
            this.pnlDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}