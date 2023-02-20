
namespace Anondo_Bazar
{
    partial class HomeLogin
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
            this.panelLast = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.AdminLoginPanel = new System.Windows.Forms.Panel();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.EmployeeLoginPanel = new System.Windows.Forms.Panel();
            this.btnEmployeeLogin = new System.Windows.Forms.Button();
            this.EmployeePassword = new System.Windows.Forms.TextBox();
            this.EmployeeUsername = new System.Windows.Forms.TextBox();
            this.panelLast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.AdminLoginPanel.SuspendLayout();
            this.EmployeeLoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLast
            // 
            this.panelLast.BackColor = System.Drawing.Color.Turquoise;
            this.panelLast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLast.Controls.Add(this.btnEmployee);
            this.panelLast.Controls.Add(this.closePictureBox);
            this.panelLast.Controls.Add(this.btnAdmin);
            this.panelLast.Controls.Add(this.EmployeeLoginPanel);
            this.panelLast.Controls.Add(this.AdminLoginPanel);
            this.panelLast.Location = new System.Drawing.Point(43, 34);
            this.panelLast.Name = "panelLast";
            this.panelLast.Size = new System.Drawing.Size(692, 420);
            this.panelLast.TabIndex = 4;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(341, 33);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(180, 50);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // closePictureBox
            // 
            this.closePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePictureBox.Image = global::Anondo_Bazar.Properties.Resources.cancel;
            this.closePictureBox.Location = new System.Drawing.Point(612, 38);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(50, 37);
            this.closePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closePictureBox.TabIndex = 5;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(144)))));
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(155, 33);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(180, 50);
            this.btnAdmin.TabIndex = 0;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // AdminLoginPanel
            // 
            this.AdminLoginPanel.BackColor = System.Drawing.Color.Turquoise;
            this.AdminLoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdminLoginPanel.Controls.Add(this.btnAdminLogin);
            this.AdminLoginPanel.Controls.Add(this.txtAdminPassword);
            this.AdminLoginPanel.Controls.Add(this.txtAdminUsername);
            this.AdminLoginPanel.Location = new System.Drawing.Point(56, 120);
            this.AdminLoginPanel.Name = "AdminLoginPanel";
            this.AdminLoginPanel.Size = new System.Drawing.Size(578, 258);
            this.AdminLoginPanel.TabIndex = 2;
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.btnAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminLogin.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.ForeColor = System.Drawing.Color.White;
            this.btnAdminLogin.Location = new System.Drawing.Point(165, 142);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(242, 51);
            this.btnAdminLogin.TabIndex = 3;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtAdminPassword.Location = new System.Drawing.Point(52, 80);
            this.txtAdminPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtAdminPassword.Multiline = true;
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(466, 34);
            this.txtAdminPassword.TabIndex = 2;
            this.txtAdminPassword.Text = "Admin password";
            this.txtAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdminPassword.Enter += new System.EventHandler(this.txtAdminPasswordEnterEvent);
            this.txtAdminPassword.Leave += new System.EventHandler(this.txtAdminPasswordLeaveEvent);
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtAdminUsername.Location = new System.Drawing.Point(52, 29);
            this.txtAdminUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtAdminUsername.Multiline = true;
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(466, 34);
            this.txtAdminUsername.TabIndex = 1;
            this.txtAdminUsername.Text = "Admin username";
            this.txtAdminUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdminUsername.Enter += new System.EventHandler(this.txtAdminUsernameEnterEvent);
            this.txtAdminUsername.Leave += new System.EventHandler(this.txtAdminUsernameLeaveEvent);
            // 
            // EmployeeLoginPanel
            // 
            this.EmployeeLoginPanel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.EmployeeLoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EmployeeLoginPanel.Controls.Add(this.btnEmployeeLogin);
            this.EmployeeLoginPanel.Controls.Add(this.EmployeePassword);
            this.EmployeeLoginPanel.Controls.Add(this.EmployeeUsername);
            this.EmployeeLoginPanel.Location = new System.Drawing.Point(56, 120);
            this.EmployeeLoginPanel.Name = "EmployeeLoginPanel";
            this.EmployeeLoginPanel.Size = new System.Drawing.Size(578, 258);
            this.EmployeeLoginPanel.TabIndex = 4;
            this.EmployeeLoginPanel.Visible = false;
            // 
            // btnEmployeeLogin
            // 
            this.btnEmployeeLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.btnEmployeeLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployeeLogin.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeLogin.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeLogin.Location = new System.Drawing.Point(165, 142);
            this.btnEmployeeLogin.Name = "btnEmployeeLogin";
            this.btnEmployeeLogin.Size = new System.Drawing.Size(228, 51);
            this.btnEmployeeLogin.TabIndex = 3;
            this.btnEmployeeLogin.Text = "Login";
            this.btnEmployeeLogin.UseVisualStyleBackColor = false;
            this.btnEmployeeLogin.Click += new System.EventHandler(this.btnEmployeeLogin_Click);
            // 
            // EmployeePassword
            // 
            this.EmployeePassword.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeePassword.ForeColor = System.Drawing.Color.Gray;
            this.EmployeePassword.Location = new System.Drawing.Point(64, 80);
            this.EmployeePassword.Margin = new System.Windows.Forms.Padding(5);
            this.EmployeePassword.Multiline = true;
            this.EmployeePassword.Name = "EmployeePassword";
            this.EmployeePassword.Size = new System.Drawing.Size(443, 34);
            this.EmployeePassword.TabIndex = 2;
            this.EmployeePassword.Text = "Employee password";
            this.EmployeePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmployeePassword.Enter += new System.EventHandler(this.EmployeePasswordEnterEvent);
            this.EmployeePassword.Leave += new System.EventHandler(this.EmployeePasswordLeaveEvent);
            // 
            // EmployeeUsername
            // 
            this.EmployeeUsername.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeUsername.ForeColor = System.Drawing.Color.Gray;
            this.EmployeeUsername.Location = new System.Drawing.Point(64, 29);
            this.EmployeeUsername.Margin = new System.Windows.Forms.Padding(5);
            this.EmployeeUsername.Multiline = true;
            this.EmployeeUsername.Name = "EmployeeUsername";
            this.EmployeeUsername.Size = new System.Drawing.Size(443, 34);
            this.EmployeeUsername.TabIndex = 1;
            this.EmployeeUsername.Text = "Employee username";
            this.EmployeeUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmployeeUsername.Enter += new System.EventHandler(this.EmployeeUsernameEnterEvent);
            this.EmployeeUsername.Leave += new System.EventHandler(this.EmployeeUsernameLeaveEvent);
            // 
            // HomeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(777, 489);
            this.Controls.Add(this.panelLast);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeLogin";
            this.panelLast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.AdminLoginPanel.ResumeLayout(false);
            this.AdminLoginPanel.PerformLayout();
            this.EmployeeLoginPanel.ResumeLayout(false);
            this.EmployeeLoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLast;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel AdminLoginPanel;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Panel EmployeeLoginPanel;
        private System.Windows.Forms.Button btnEmployeeLogin;
        private System.Windows.Forms.TextBox EmployeePassword;
        private System.Windows.Forms.TextBox EmployeeUsername;
        private System.Windows.Forms.PictureBox closePictureBox;
    }
}