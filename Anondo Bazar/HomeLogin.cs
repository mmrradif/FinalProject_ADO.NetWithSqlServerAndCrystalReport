using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anondo_Bazar
{
    public partial class HomeLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AnondoBazar;Trusted_connection=True");

        public HomeLogin()
        {
            InitializeComponent();
        }

        //-- For Close Application
        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //-- Placeholder For txtAdminUsername -- START -->>>
        private void txtAdminUsernameEnterEvent(object sender, EventArgs e)
        {
            if (txtAdminUsername.Text == "Admin username")
            {
                txtAdminUsername.Text = "";
                txtAdminUsername.BackColor = Color.White;
                txtAdminUsername.ForeColor = Color.DarkBlue;
            }
        }

        private void txtAdminUsernameLeaveEvent(object sender, EventArgs e)
        {
            if (txtAdminUsername.Text == "")
            {
                txtAdminUsername.Text = "Admin username";

                txtAdminUsername.ForeColor = Color.White;
                txtAdminUsername.BackColor = Color.Red;
            }
        }
        //-- Placeholder For txtAdminUsername -- END -->>>

        //-- Placeholder For txtAdminPassword -- START -->>>
        private void txtAdminPasswordEnterEvent(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == "Admin password")
            {
                txtAdminPassword.Text = "";

                txtAdminPassword.BackColor = Color.White;
                txtAdminPassword.ForeColor = Color.DarkBlue;
            }
        }

        private void txtAdminPasswordLeaveEvent(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == "")
            {
                txtAdminPassword.Text = "Admin password";

                txtAdminPassword.BackColor = Color.Red;
                txtAdminPassword.ForeColor = Color.WhiteSmoke;
            }
        }
        //-- Placeholder For txtAdminPassword -- END -->>>

        //----------------------------------------------------------- btnAdmin_Click -->>>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // textbox -- txtAdminUsername placeholder
            txtAdminUsername.BackColor = Color.White;
            txtAdminUsername.ForeColor = Color.Gray;

            txtAdminPassword.BackColor = Color.White;
            txtAdminPassword.ForeColor = Color.Gray;
            //---------------------------------------

            btnAdmin.BackColor = Color.FromArgb(72, 209, 204);

            btnEmployee.BackColor = Color.Black;

            AdminLoginPanel.Visible = true;
            AdminLoginPanel.BackColor = Color.FromArgb(72, 209, 204);
            EmployeeLoginPanel.Visible = false;
        }


        //----------------------------------------------------------- btnEmployee_Click -->>>
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            // TEXTBOX -- EmployeeUsername PLACEHOLDER
            EmployeeUsername.BackColor = Color.White;
            EmployeeUsername.ForeColor = Color.Gray;

            EmployeePassword.BackColor = Color.White;
            EmployeePassword.ForeColor = Color.Gray;
            //---------------------------------------


            btnEmployee.BackColor = Color.FromArgb(0, 191, 255);

            btnAdmin.BackColor = Color.Black;

            AdminLoginPanel.Visible = false;
            EmployeeLoginPanel.Visible = true;
            EmployeeLoginPanel.BackColor = Color.FromArgb(0, 191, 255);
        }


        //-- Placeholder For EmployeeUsername -- START -->>>
        private void EmployeeUsernameEnterEvent(object sender, EventArgs e)
        {
            if (EmployeeUsername.Text == "Employee username")
            {
                EmployeeUsername.Text = "";

                EmployeeUsername.ForeColor = Color.DarkBlue;
                EmployeeUsername.BackColor = Color.White;
            }
        }
        private void EmployeeUsernameLeaveEvent(object sender, EventArgs e)
        {
            if (EmployeeUsername.Text == "")
            {
                EmployeeUsername.Text = "Employee username";

                EmployeeUsername.ForeColor = Color.White;
                EmployeeUsername.BackColor = Color.Red;
            }
        }
        //-- Placeholder For EmployeeUsername -- END -->>>


        //-- Placeholder For EmployeePassword -- START -->>>
        private void EmployeePasswordEnterEvent(object sender, EventArgs e)
        {
            if (EmployeePassword.Text == "Employee password")
            {
                EmployeePassword.Text = "";

                EmployeePassword.ForeColor = Color.DarkBlue;
                EmployeePassword.BackColor = Color.White;
            }
        }

        private void EmployeePasswordLeaveEvent(object sender, EventArgs e)
        {
            if (EmployeePassword.Text == "")
            {
                EmployeePassword.Text = "Employee password";

                EmployeePassword.ForeColor = Color.White;
                EmployeePassword.BackColor = Color.Red;
            }
        }
        //-- Placeholder For EmployeePassword -- END -->>>



        // --------------------------------------------------------------- ADMIN LOG IN ------>>>>>>>>

        private void AdminReset()
        {
            txtAdminUsername.Text = "Admin username";
            txtAdminUsername.ForeColor = Color.SkyBlue;
            txtAdminUsername.BackColor = Color.White;
            txtAdminPassword.Text = "Admin password";
            txtAdminPassword.ForeColor = Color.SkyBlue;
            txtAdminPassword.BackColor = Color.White;
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminUsername.Text == "Admin username" || txtAdminPassword.Text == "Admin password")
            {
                if (txtAdminUsername.Text == "Admin username")
                {
                    MessageBox.Show("Missing Admin username");
                    txtAdminUsername.Focus();
                    txtAdminUsername.Text = "";
                }
                else if (txtAdminPassword.Text == "Admin password")
                {
                    MessageBox.Show("Missing Admin password");
                    txtAdminPassword.Focus();
                    txtAdminPassword.Text = "";
                }
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tblAdmin WHERE adminUserName=@adminUsername AND adminPassword=@adminPassword", con);
                    cmd.Parameters.AddWithValue("@adminUsername", txtAdminUsername.Text);
                    cmd.Parameters.AddWithValue("@adminPassword", txtAdminPassword.Text);

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        HomeMenu hm = new HomeMenu();
                        hm.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Invalid UserName or Password");
                        AdminReset();
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEmployeeLogin_Click(object sender, EventArgs e)
        {
            HomeMenu h = new HomeMenu();
            h.Show();            
        }
    }
}
