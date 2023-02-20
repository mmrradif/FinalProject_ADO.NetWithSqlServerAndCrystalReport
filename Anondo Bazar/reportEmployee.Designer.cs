
namespace Anondo_Bazar
{
    partial class reportEmployee
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EmployeeReport1 = new Anondo_Bazar.EmployeeReport();
            this.txtSearchEmployeeReport = new System.Windows.Forms.TextBox();
            this.btnLoadEmployeeReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(311, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.EmployeeReport1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(875, 620);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // txtSearchEmployeeReport
            // 
            this.txtSearchEmployeeReport.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchEmployeeReport.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtSearchEmployeeReport.Location = new System.Drawing.Point(37, 80);
            this.txtSearchEmployeeReport.Name = "txtSearchEmployeeReport";
            this.txtSearchEmployeeReport.Size = new System.Drawing.Size(223, 37);
            this.txtSearchEmployeeReport.TabIndex = 1;
            this.txtSearchEmployeeReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoadEmployeeReport
            // 
            this.btnLoadEmployeeReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLoadEmployeeReport.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadEmployeeReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLoadEmployeeReport.Location = new System.Drawing.Point(68, 138);
            this.btnLoadEmployeeReport.Name = "btnLoadEmployeeReport";
            this.btnLoadEmployeeReport.Size = new System.Drawing.Size(164, 47);
            this.btnLoadEmployeeReport.TabIndex = 2;
            this.btnLoadEmployeeReport.Text = "Load Report";
            this.btnLoadEmployeeReport.UseVisualStyleBackColor = false;
            this.btnLoadEmployeeReport.Click += new System.EventHandler(this.btnLoadEmployeeReport_Click);
            // 
            // reportEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 624);
            this.Controls.Add(this.btnLoadEmployeeReport);
            this.Controls.Add(this.txtSearchEmployeeReport);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "reportEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reportEmployee";
            this.Load += new System.EventHandler(this.reportEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private EmployeeReport EmployeeReport1;
        private System.Windows.Forms.TextBox txtSearchEmployeeReport;
        private System.Windows.Forms.Button btnLoadEmployeeReport;
    }
}