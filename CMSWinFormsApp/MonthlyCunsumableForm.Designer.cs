﻿namespace CMSWinFormsApp
{
    partial class MonthlyCunsumableForm
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
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CMSWinFormsApp.MonthlyCunsumableReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(660, 411);
            this.reportViewer2.TabIndex = 0;
            // 
            // MonthlyCunsumableForm
            // 
            this.ClientSize = new System.Drawing.Size(660, 411);
            this.Controls.Add(this.reportViewer2);
            this.Name = "MonthlyCunsumableForm";
            this.Load += new System.EventHandler(this.MonthlyCunsumableForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.AnalysisServices.ReportAction reportAction1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}