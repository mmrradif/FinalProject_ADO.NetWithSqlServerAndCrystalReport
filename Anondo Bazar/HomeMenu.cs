using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anondo_Bazar
{
    public partial class HomeMenu : Form
    {
        //------------------------------------------------------------------ SQL CONNECTION ---------------------->>>
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AnondoBazar;Trusted_connection=True");
        public HomeMenu()
        {
            InitializeComponent();
        }

        // ----------------------------------- 
        // --- ADMIN--- FROMMENU -- FORM LOAD
        //

        private void FormMenuLoadEvent(object sender, EventArgs e)
        {
            // -------------------- Admin Report
            loadAdminGrid();
            lblHomeAdminNumber.Text = AdminDataGridView.Rows.Count.ToString() + " Admin";

            // -------------------- Employee Report
            loadEmployeeDataGridView();
            lblEmployeeReport.Text = EmployeeViewDataGridView.Rows.Count.ToString() + " Employees";

            // -------------------- Employee Report
            loadSupplierGrid();
            lblSupplierReport.Text = SupplierDataGridView.Rows.Count.ToString() + " Suppliers";

            // -------------------- Brand Report
            loadBrandDataGrid();
            lblBrandReport.Text = BrandDataGridView.Rows.Count.ToString() + " Brands";

            // -------------------- Category Report
            LoadCategoryDataGridView();
            lblCategoryReport.Text = DataGridViewCategory.Rows.Count.ToString() + " Categories";

            // -------------------- Product Report
            loadProductDataGridView();
            lblProductReport.Text = ProductDataGridView.Rows.Count.ToString() + " Products";

            EmployeesViewPanel.Hide();
            TransactionPanel.Hide();
            ProductsPanel.Hide();
            BrandPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Hide();
            AdminNewPanel.Hide();
            AdminViewPanel.Hide();
            AddEmployeePanel.Hide();
            ViewEmployeePanel.Hide();
            HomePanel.Show();
            HomePanel.Dock = DockStyle.Fill;


            // Transactions
            LoadEditProductDataGridView();
           
        }


        //---------------------------------------------------------->>> BRAND
        private void btnBrand_Click(object sender, EventArgs e)
        {
            btnSupplier.BackColor = Color.Teal;
            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.CornflowerBlue;

            EmployeesViewPanel.Hide();
            ViewEmployeePanel.Hide();
            TransactionPanel.Hide();
            ProductsPanel.Hide();
            HomePanel.Hide();
            AdminViewPanel.Hide();
            AdminNewPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Hide();
            BrandPanel.Show();
            BrandPanel.Dock = DockStyle.Fill;

            dropDownCloseEmployee();
        }

        //---------------------------------------------------------->>> CATEGORY
        private void btnCategory_Click(object sender, EventArgs e)
        {
            LoadCategoryDataGridView();

            btnSupplier.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnCategory.BackColor = Color.MediumSeaGreen;

            ViewEmployeePanel.Hide();
            EmployeesViewPanel.Hide();
            ProductsPanel.Hide();
            HomePanel.Hide();
            AdminViewPanel.Hide();
            AdminNewPanel.Hide();
            SupplierPanel.Hide();
            BrandPanel.Hide();
            CategoryPanel.Show();
            CategoryPanel.Dock = DockStyle.Fill;
            TransactionPanel.Hide();

            dropDownCloseEmployee();
        }

        //---------------------------------------------------------->>> SUPPLIER
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnSupplier.BackColor = Color.LightSeaGreen;

            ViewEmployeePanel.Hide();
            EmployeesViewPanel.Hide();
            AdminViewPanel.Hide();
            AdminNewPanel.Hide();
            BrandPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Show();
            SupplierPanel.Dock = DockStyle.Fill;
            HomePanel.Hide();
            ProductsPanel.Hide();
            TransactionPanel.Hide();

            dropDownCloseEmployee();
        }

        //---------------------------------------------------------->>> EMPLOYEE
        private void EmployeeMenuPictureBox_Click(object sender, EventArgs e)
        {
            EmployeeMenuPanel.Height = 122;
            EmployeeMenuPictureBoxDown.Hide();
            EmployeeMenuPictureBoxUp.Show();

            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnSupplier.BackColor = Color.Teal;
        }

        private void EmployeeMenuPictureBoxUp_Click(object sender, EventArgs e)
        {
            EmployeeMenuPanel.Height = 39;
            EmployeeMenuPictureBoxUp.Hide();
            EmployeeMenuPictureBoxDown.Show();

            btnCategory.BackColor = Color.Teal;
            btnBrand.BackColor = Color.Teal;
            btnSupplier.BackColor = Color.Teal;
        }


        //-- For Employee DorpDown Close
        public void dropDownCloseEmployee()
        {
            if (EmployeeMenuPanel.Height == 122)
            {
                EmployeeMenuPanel.Height = 41;
                EmployeeMenuPictureBoxUp.Hide();
                EmployeeMenuPictureBoxDown.Show();
            }
        }

        //------------------------------------------------------------------------ PLACEHOLDER -->>>

        //------------------------------ txtSupplierName PLACEHOLDER ------------->>>
        private void txtSupplierNameEnterEvent(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "Supplier Name")
            {
                txtSupplierName.Text = "";
                txtSupplierName.ForeColor = Color.Teal;
                txtSupplierName.BackColor = Color.White;
            }
        }

        private void txtSupplierNameLeaveEvent(object sender, EventArgs e)
        {
            if (txtSupplierName.Text == "")
            {
                txtSupplierName.Text = "Supplier Name";
                txtSupplierName.ForeColor = Color.White;
                txtSupplierName.BackColor = Color.Red;
            }
        }

        //------------------------------ txtSupplierName PLACEHOLDER ------------->>>
        private void txtSupplierAddressEnterEvent(object sender, EventArgs e)
        {
            if (txtSupplierAddress.Text == "Supplier Address")
            {
                txtSupplierAddress.Text = "";
                txtSupplierAddress.ForeColor = Color.Teal;
                txtSupplierAddress.BackColor = Color.White;
            }
        }

        private void txtSupplierAddressLeaveEvent(object sender, EventArgs e)
        {
            if (txtSupplierAddress.Text == "")
            {
                txtSupplierAddress.Text = "Supplier Address";
                txtSupplierAddress.ForeColor = Color.White;
                txtSupplierAddress.BackColor = Color.Red;
            }
        }


        //------------------------------ txtSupplierPhoneNumber PLACEHOLDER ------------->>>
        private void txtSupplierPhoneNumberEnterEvent(object sender, EventArgs e)
        {
            if (txtSupplierPhoneNumber.Text == "Supplier Phone Number")
            {
                txtSupplierPhoneNumber.Text = "";
                txtSupplierPhoneNumber.ForeColor = Color.Teal;
                txtSupplierPhoneNumber.BackColor = Color.White;
            }
        }

        private void txtSupplierPhoneNumberLeaveEvent(object sender, EventArgs e)
        {
            if (txtSupplierPhoneNumber.Text == "")
            {
                txtSupplierPhoneNumber.Text = "Supplier Phone Number";
                txtSupplierPhoneNumber.ForeColor = Color.White;
                txtSupplierPhoneNumber.BackColor = Color.Red;
            }
        }

        //------------------------------ txtSupplierRemarks PLACEHOLDER ------------->>>
        private void txtSupplierRemarksEnterEvent(object sender, EventArgs e)
        {
            if (txtSupplierRemarks.Text == "Remarks")
            {
                txtSupplierRemarks.Text = "";
                txtSupplierRemarks.ForeColor = Color.Teal;
                txtSupplierRemarks.BackColor = Color.White;
            }
        }

        private void txtSupplierRemarksLeaveEvent(object sender, EventArgs e)
        {
            if (txtSupplierRemarks.Text == "")
            {
                txtSupplierRemarks.Text = "Remarks";
                txtSupplierRemarks.ForeColor = Color.White;
                txtSupplierRemarks.BackColor = Color.Red;
            }
        }


        //--------------------------------------------------------------- SUPPLIER -- START -->>>
        //--------- SUPPLIER RESET -->>
        private void supplierReset()
        {
            txtSupplierName.Text = "Supplier Name";
            txtSupplierName.ForeColor = Color.SkyBlue;
            txtSupplierAddress.Text = "Supplier Address";
            txtSupplierAddress.ForeColor = Color.SkyBlue;
            txtSupplierPhoneNumber.Text = "Supplier Phone Number";
            txtSupplierPhoneNumber.ForeColor = Color.SkyBlue;
            txtSupplierRemarks.Text = "Remarks";
            txtSupplierRemarks.ForeColor = Color.SkyBlue;
        }

        //-------------------------------------------------------------- SUPPLIER ADD -->>
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (txtSupplierName.Text=="Supplier Name" || txtSupplierAddress.Text== "Supplier Address" || txtSupplierPhoneNumber.Text== "Supplier Phone Number" || txtSupplierRemarks.Text == "Supplier Remarks")
            {
                if (txtSupplierName.Text == "Supplier Name")
                {
                    MessageBox.Show("Missing Supplier Name");
                    txtSupplierName.Focus();
                    txtSupplierName.Text = "";
                }
                else if (txtSupplierAddress.Text == "Supplier Address")
                {
                    MessageBox.Show("Missing Supplier Address");
                    txtSupplierAddress.Focus();
                    txtSupplierAddress.Text = "";
                }
                else if (txtSupplierPhoneNumber.Text == "Supplier Phone Number")
                {
                    MessageBox.Show("Missing Supplier Phone Number");
                    txtSupplierPhoneNumber.Focus();
                    txtSupplierPhoneNumber.Text = "";
                }
                else if (txtSupplierRemarks.Text == "Remarks")
                {
                    MessageBox.Show("Missing Supplier Remarks");
                    txtSupplierRemarks.Focus();
                    txtSupplierRemarks.Text = "";
                }               
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblSupplier(supplierName,supplierAddress,supplierPhone,supplierRemarks) VALUES(@sName,@sAdd,@sPhone,@sRemarks)", con);
                    cmd.Parameters.AddWithValue("@sName", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("@sAdd", txtSupplierAddress.Text);
                    cmd.Parameters.AddWithValue("@sPhone", txtSupplierPhoneNumber.Text);
                    cmd.Parameters.AddWithValue("@sRemarks", txtSupplierRemarks.Text);

                    cmd.ExecuteNonQuery();

                    InsertMessage m = new InsertMessage();
                    m.Show();

                    //MessageBox.Show("Supplier Added Successfully");
                    con.Close();
                    supplierReset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //--------------------------------------------------------- SUPPLIER INSERT, UPDATE, DELETE -->>>
        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierPanel.Visible = true;
            ViewSupplierPanel.Visible = false;

            SupplierPanel.BackColor = Color.LightSeaGreen;
            btnSupplier.BackColor = Color.LightSeaGreen;
            btnNewSupplier.BackColor = Color.LightSeaGreen;
            btnNewSupplier.ForeColor = Color.White;

            btnViewSupplier.BackColor = Color.Black;
            btnViewSupplier.ForeColor = Color.Gray;

            SupplierPanel.BackColor = Color.LightSeaGreen;
        }

        //---------------------------------------------------------------- DATA GRID VIEW -->>>
        private void loadSupplierGrid()
        {
            // METHOD - 1
            //con.Open();
            //string Query = "SELECT * FROM tblSupplier";
            //SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            //SqlCommandBuilder Builder = new SqlCommandBuilder(sda);

            //var ds = new DataSet();
            //sda.Fill(ds);
            //SupplierDataGridView.DataSource = ds.Tables[0];
            //con.Close();

            // METHOD - 2

            con.Open();
            string Query = "SELECT * FROM tblSupplier";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            SupplierDataGridView.Rows.Clear();
            while (reader.Read())
            {
                SupplierDataGridView.Rows.Add(reader["supplierId"], reader["supplierName"], reader["supplierAddress"], reader["supplierPhone"], reader["supplierRemarks"], "EDIT", "DELETE");
            }

            SupplierDataGridView.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            SupplierDataGridView.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            SupplierDataGridView.Columns[2].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            SupplierDataGridView.Columns[3].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            SupplierDataGridView.Columns[4].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            SupplierDataGridView.Columns[5].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            SupplierDataGridView.Columns[6].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            SupplierDataGridView.Columns[5].HeaderCell.Style.BackColor = Color.DarkGreen;
            SupplierDataGridView.Columns[6].HeaderCell.Style.BackColor = Color.Red;

            SupplierDataGridView.Columns[0].Width = 50;
            SupplierDataGridView.Columns[5].Width = 50;
            SupplierDataGridView.Columns[6].Width = 70;

            con.Close();
        }



        private void btnViewSupplier_Click(object sender, EventArgs e)
        {
            AddSupplierPanel.Visible = false;
            ViewSupplierPanel.Visible = true;

            SupplierPanel.BackColor = Color.DodgerBlue;
            btnSupplier.BackColor = Color.DodgerBlue;
            btnViewSupplier.BackColor = Color.DodgerBlue;
            btnViewSupplier.ForeColor = Color.White;

            btnNewSupplier.BackColor = Color.Black;
            btnNewSupplier.ForeColor = Color.Gray;

            SupplierPanel.BackColor = Color.DodgerBlue;

            loadSupplierGrid();
        }

        //--------------------------------------------------------------- DATA SEND DATAGRIDVIEW TO TEXTBOX -->>>

        private void supplierDataGridViewSelectionChangedEvent(object sender, EventArgs e)
        {
            if (this.SupplierDataGridView.SelectedRows.Count > 0)
            {
                int id = (int)this.SupplierDataGridView.SelectedRows[0].Cells[0].Value;
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblSupplier WHERE supplierId=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtEditSupplierId.Text = dr.GetInt32(0).ToString();
                    txtEditSupplierName.Text = dr.GetString(1);
                    txtEditSupplierAddress.Text = dr.GetString(2);
                    txtEditSupplierPhone.Text = dr.GetString(3);
                    txtEditSupplierRemarks.Text = dr.GetString(4);
                }
                con.Close();
            }
        }

        //----------------------------------------------------------------------- UPDATE SUPPLIER -->>>
        private void supplierUpdateReset()
        {
            txtEditSupplierId.Text = "";
            txtEditSupplierName.Text = "";
            txtEditSupplierAddress.Text = "";
            txtEditSupplierPhone.Text = "";
            txtEditSupplierRemarks.Text = "";
        }
        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE tblSupplier SET supplierName=@n,supplierAddress=@a,supplierPhone=@p,supplierRemarks=@r WHERE supplierId=@i", con);
                    cmd.Parameters.AddWithValue("@i", txtEditSupplierId.Text);
                    cmd.Parameters.AddWithValue("@n", txtEditSupplierName.Text);
                    cmd.Parameters.AddWithValue("@a", txtEditSupplierAddress.Text);
                    cmd.Parameters.AddWithValue("@p", txtEditSupplierPhone.Text);
                    cmd.Parameters.AddWithValue("@r", txtEditSupplierRemarks.Text);
                    cmd.ExecuteNonQuery();

                    UpdateMessage m = new UpdateMessage();
                    m.Show();

                    //MessageBox.Show("Supplier Updated successfully!!!");
                    con.Close();
                    supplierUpdateReset();
                    loadSupplierGrid();
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        // -------------------------------------------------------------- SUPPLIER DELETE ----------->>>
        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (txtEditSupplierId.Text !="")
            {
                try
                {
                    if (MessageBox.Show("Delete this Record??", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM tblSupplier WHERE supplierId=@i", con);
                        cmd.Parameters.AddWithValue("@i", txtEditSupplierId.Text);

                        cmd.ExecuteNonQuery();

                        DeleteMessage d = new DeleteMessage();
                        d.Show();

                        //MessageBox.Show("Supplier DELETED Successfully!!!");
                        con.Close();
                        supplierUpdateReset();
                        loadSupplierGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Supplier Id");
            }
        }

        //----------------------------------------------------- DATAGRIDVIEW EDIT AND DELETE
        private void SupplierDataGridViewCellContentEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
               txtEditSupplierId.Text = SupplierDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
               txtEditSupplierName.Text = SupplierDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
               txtEditSupplierAddress.Text = SupplierDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
               txtEditSupplierPhone.Text = SupplierDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
               txtEditSupplierRemarks.Text = SupplierDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }

            else if (e.ColumnIndex == 6 && e.RowIndex > -1)
            {
                string supplierID = SupplierDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                if(MessageBox.Show("Delete this Record??","Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes){

                    con.Open();
                    string query = "DELETE FROM tblSupplier WHERE supplierId =" + supplierID;
                    SqlCommand cmd = new SqlCommand(query, con);                  
                    cmd.ExecuteNonQuery();

                    DeleteMessage d = new DeleteMessage();
                    d.Show();

                    con.Close();
                    supplierUpdateReset();
                    loadSupplierGrid();
                }
            }
        }

        // -------------------------------------------------------
        // --------SUPPLIER SEARCH --------->>>
        //
        private void txtSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string search = txtSupplierSearch.Text;

            string query = "SELECT * FROM tblSupplier";

            if (cmbSupplierSearch.SelectedIndex==0)
            {
                query += " WHERE supplierName LIKE '%" + search + "%' OR supplierAddress LIKE '%" + search + "%' OR supplierRemarks LIKE '%" + search + "%' OR supplierPhone LIKE '%" + search + "%'";

                if (int.TryParse(search, out _))
                {
                    query += " OR supplierId =" + search;
                }
            }

            else if (cmbSupplierSearch.SelectedIndex==1)
            {
                if (int.TryParse(search, out _))
                {
                    query += " WHERE supplierId =" + search;
                }         
            }

            else if (cmbSupplierSearch.SelectedIndex==2)
            {
                query += " WHERE supplierName LIKE '%" + search + "%'";
            }

            else if (cmbSupplierSearch.SelectedIndex == 3)
            {
                query += " WHERE supplierAddress LIKE '%" + search + "%'";
            }

            else if (cmbSupplierSearch.SelectedIndex == 4)
            {
                query += " WHERE supplierPhone LIKE '%" + search + "%'";
            }

            else if (cmbSupplierSearch.SelectedIndex == 5)
            {
                query += " WHERE supplierRemarks LIKE '%" + search + "%'";
            }

            SqlCommand cmd = new SqlCommand(query, con);

            var reader = cmd.ExecuteReader();

            SupplierDataGridView.Rows.Clear();
            while (reader.Read())
            {
                SupplierDataGridView.Rows.Add(reader["supplierId"], reader["supplierName"], reader["supplierAddress"], reader["supplierPhone"], reader["supplierRemarks"], "EDIT", "DELETE");
            }
            con.Close();
        }


        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        //------------------------------- ADMIN START ----------------------------------->>>>

        // --------------------------------------------------
        // -- ADMIN MENU 
        //

        private void AdminDownPictureBox_Click(object sender, EventArgs e)
        {            
            btnAdminPanel.Height = 115;
            AdminDownPictureBox.Hide();
            AdminUpPictureBox.Show();           
        }

        private void AdminUpPictureBox_Click(object sender, EventArgs e)
        {
            btnAdminPanel.Height = 38;
            AdminUpPictureBox.Hide();
            AdminDownPictureBox.Show();
        }

        // -------------------------------------------------- 
        // ---- ADMIN PLACEHOLDERS -->>
        //

        private void txtAdminNameEnterEvent(object sender, EventArgs e)
        {
            if (txtAdminName.Text == "Admin Name")
            {
                txtAdminName.Text = "";
                txtAdminName.BackColor = Color.White;
                txtAdminName.ForeColor = Color.DarkBlue;
            }
        }

        private void txtAdminNameLeaveEvent(object sender, EventArgs e)
        {
            if (txtAdminName.Text == "")
            {
                txtAdminName.Text = "Admin Name";
                txtAdminName.BackColor = Color.Red;
                txtAdminName.ForeColor = Color.White;
            }
        }

        private void txtAdminUserNameEnterEvent(object sender, EventArgs e)
        {
            if (txtAdminUserName.Text == "Admin User Name")
            {
                txtAdminUserName.Text = "";
                txtAdminUserName.BackColor = Color.White;
                txtAdminUserName.ForeColor = Color.DarkBlue;
            }
        }

        private void txtAdminUserNameLeaveEvent(object sender, EventArgs e)
        {
            if (txtAdminUserName.Text == "")
            {
                txtAdminUserName.Text = "Admin User Name";
                txtAdminUserName.BackColor = Color.Red;
                txtAdminUserName.ForeColor = Color.White;
            }
        }

        private void txtAdminPasswordEnterEvent(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text == "Password")
            {
                txtAdminPassword.Text = "";
                txtAdminPassword.BackColor = Color.White;
                txtAdminPassword.ForeColor = Color.DarkBlue;
            }
        }

        private void txtAdminPasswordLeaveEvent(object sender, LayoutEventArgs e)
        {
            if (txtAdminPassword.Text == "")
            {
                txtAdminPassword.Text = "Password";
                txtAdminPassword.BackColor = Color.Red;
                txtAdminPassword.ForeColor = Color.White;
            }
        }


        // -------------------------------------------------
        // ------- ADMIN NEW PANEL FOR --->> DATA INSERT

        private void btnNewAdmin_Click(object sender, EventArgs e)
        {
            EmployeesViewPanel.Hide();
            AdminNewPanel.Show();
            AdminNewPanel.Dock = DockStyle.Fill;
            BrandPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Hide();
            AdminViewPanel.Hide();
            AddEmployeePanel.Hide();
            ViewEmployeePanel.Hide();
            HomePanel.Hide();
            ProductsPanel.Hide();
            TransactionPanel.Hide();
        }

        // ------------------------------------------------------------ Admin Insert -->>>
        // -- ADMIN RESET TEXTBOX
        //

        private void AdminReset()
        {
            txtAdminName.Text = "Admin Name";
            txtAdminName.ForeColor = Color.SkyBlue;
            txtAdminUserName.Text = "Admin User Name";
            txtAdminUserName.ForeColor = Color.SkyBlue;
            txtAdminPassword.Text = "Password";
            txtAdminPassword.ForeColor = Color.SkyBlue;
        }

        // -------------------------------------------------------
        // ADMIN DATA INSERT
        //

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (txtAdminName.Text == "Admin Name" || txtAdminUserName.Text == "Admin User Name" || txtAdminPassword.Text == "Password")
            {
                if (txtAdminName.Text == "Admin Name")
                {
                    MessageBox.Show("Missing Admin Name");
                    txtAdminName.Focus();
                    txtAdminName.Text = "";
                }
                else if (txtAdminUserName.Text == "Admin User Name")
                {
                    MessageBox.Show("Admin User Name");
                    txtAdminUserName.Focus();
                    txtAdminUserName.Text = "";
                }
                else if (txtAdminPassword.Text == "Password")
                {
                    MessageBox.Show("Missing Password");
                    txtAdminPassword.Focus();
                    txtAdminPassword.Text = "";
                }
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblAdmin(adminName,adminUserName,adminPassword) VALUES(@aN,@aUN,@aP)", con);
                    cmd.Parameters.AddWithValue("@aN", txtAdminName.Text);
                    cmd.Parameters.AddWithValue("@aUN", txtAdminUserName.Text);
                    cmd.Parameters.AddWithValue("@aP", txtAdminPassword.Text);

                    cmd.ExecuteNonQuery();

                    InsertMessage m = new InsertMessage();
                    m.Show();

                    //MessageBox.Show("Supplier Added Successfully");
                    con.Close();

                    AdminReset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // --------------------------------------------------
        // ---- LOADADMIN DATA GRID VIEW
        //
        private void loadAdminGrid()
        {
            con.Open();
            string Query = "SELECT * FROM tblAdmin";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            AdminDataGridView.Rows.Clear();
            while (reader.Read())
            {
                AdminDataGridView.Rows.Add(reader["adminId"], reader["adminName"], reader["adminUserName"], reader["adminPassword"], "EDIT", "DELETE");
            }

            AdminDataGridView.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            AdminDataGridView.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            AdminDataGridView.Columns[2].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            AdminDataGridView.Columns[3].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            AdminDataGridView.Columns[4].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            AdminDataGridView.Columns[5].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            AdminDataGridView.Columns[4].HeaderCell.Style.BackColor = Color.DarkGreen;
            AdminDataGridView.Columns[5].HeaderCell.Style.BackColor = Color.Red;

            AdminDataGridView.Columns[0].Width = 30;
            AdminDataGridView.Columns[4].Width = 50;
            AdminDataGridView.Columns[5].Width = 70;
          
            con.Close();
        }

        // ----------------------------------------
        // --- VIEW ADMIN PANEL
        //

        private void btnViewAdmin_Click(object sender, EventArgs e)
        {
            loadAdminGrid();

            EmployeesViewPanel.Hide();
            AdminViewPanel.Show();
            AdminViewPanel.Dock = DockStyle.Fill;
            BrandPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Hide();
            AdminNewPanel.Hide();
            AddEmployeePanel.Hide();
            ViewEmployeePanel.Hide();
            HomePanel.Hide();
            ProductsPanel.Hide();
            TransactionPanel.Hide();
        }


        //---------------------DATAGRIDVIEW CELL CONTENT CLICK EVENT -->>>
        // --------------------------------------------------------------
        // -------------------- ADMIN TABLE CELL CONTENT CLICK
        int key = 0;
        private void AdminDataGridViewCellContentEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                txtAdminEditId.Text = AdminDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAdminEditName.Text = AdminDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAdminEditUserName.Text = AdminDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAdminEditPassword.Text = AdminDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (txtAdminEditName.Text == "")
                {
                    key = Convert.ToInt32(AdminDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }

            else if (e.ColumnIndex == 4 && e.RowIndex > -1)
            {
                txtAdminEditId.Text = AdminDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAdminEditName.Text = AdminDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAdminEditUserName.Text = AdminDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAdminEditPassword.Text = AdminDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            }           
        }

        // ------------------------------------------------------
        // -- AdminDataGridViewCellMouseClick 
        // -- FOR EDIT AND DELETE
        //
        private void AdminDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.ColumnIndex == 5 && e.RowIndex > -1)
            {
                string adminId = AdminDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (MessageBox.Show("Delete this Record??", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    string query = "DELETE FROM tblAdmin WHERE adminId =" + adminId;
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    DeleteMessage d = new DeleteMessage();
                    d.Show();

                    con.Close();
                    adminUpdateReset();
                    loadAdminGrid();
                }
            }

            else
            {
                txtAdminEditId.Text = AdminDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtAdminEditName.Text = AdminDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAdminEditUserName.Text = AdminDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtAdminEditPassword.Text = AdminDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (txtAdminEditName.Text == "")
                {
                    key = Convert.ToInt32(AdminDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        // --------------------------------------------------------------
        // -------------------- ADMIN TABLE RESET TEXT BOXES 
        //
        private void adminUpdateReset()
        {
            txtAdminEditId.Text = "";
            txtAdminEditName.Text = "";
            txtAdminEditUserName.Text = "";
            txtAdminEditPassword.Text = "";
        }

        // --------------------------------------------------------------
        // -------------------- ADMIN TABLE DATA EDIT 
        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE tblAdmin SET adminName=@aN,adminUserName=@aUN,adminPassword=@aP WHERE adminId=@aId", con);
                    cmd.Parameters.AddWithValue("@aId", txtAdminEditId.Text);
                    cmd.Parameters.AddWithValue("@aN", txtAdminEditName.Text);
                    cmd.Parameters.AddWithValue("@aUN", txtAdminEditUserName.Text);
                    cmd.Parameters.AddWithValue("@aP", txtAdminEditPassword.Text);
                    cmd.ExecuteNonQuery();

                    UpdateMessage m = new UpdateMessage();
                    m.Show();

                    con.Close();
                    adminUpdateReset();
                    loadAdminGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // --------------------------------------------------------------
        // -------------------- ADMIN TABLE DATA DELETE 
        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (txtAdminEditId.Text != "")
            {
                try
                {
                    if (MessageBox.Show("ARE YOU SURE??\nWant to Delete this Record??", "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM tblAdmin WHERE adminId=@i", con);
                        cmd.Parameters.AddWithValue("@i", txtAdminEditId.Text);

                        cmd.ExecuteNonQuery();

                        DeleteMessage d = new DeleteMessage();
                        d.Show();

                        con.Close();
                        adminUpdateReset();
                        loadAdminGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Admin Id");
            }
        }

        // --------------------------------------------------------------
        // -------------------- ADMIN TABLE SEARCH 
        private void txtAdminSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string search = txtAdminSearch.Text;

            string query = "SELECT * FROM tblAdmin";

            if (cmbAdminSearch.SelectedIndex == 0)
            {
                query += " WHERE adminName LIKE '%" + search + "%' OR adminUserName LIKE '%" + search + "%' OR adminPassword LIKE '%" + search + "%'";

                if (int.TryParse(search, out _))
                {
                    query += " OR adminId =" + search;
                }
            }

            else if (cmbAdminSearch.SelectedIndex == 1)
            {
                if (int.TryParse(search, out _))
                {
                    query += " WHERE adminId =" + search;
                }
            }

            else if (cmbAdminSearch.SelectedIndex == 2)
            {
                query += " WHERE adminName LIKE '%" + search + "%'";
            }

            else if (cmbAdminSearch.SelectedIndex == 3)
            {
                query += " WHERE adminUserName LIKE '%" + search + "%'";
            }

            else if (cmbAdminSearch.SelectedIndex == 4)
            {
                query += " WHERE adminPassword LIKE '%" + search + "%'";
            }

            SqlCommand cmd = new SqlCommand(query, con);

            var reader = cmd.ExecuteReader();

            AdminDataGridView.Rows.Clear();
            while (reader.Read())
            {
                AdminDataGridView.Rows.Add(reader["adminId"], reader["adminName"], reader["adminUserName"], reader["adminPassword"], "EDIT", "DELETE");
            }

            con.Close();
        }



        // ------------------------------------------------------------
        // ------------------------ HOME PANEL 
        //
        private void HomePictureBoxClickEvent(object sender, EventArgs e)
        {
            HomePanel.Show();
            HomePanel.Dock = DockStyle.Fill;
            BrandPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Hide();
            AdminNewPanel.Hide();
            AdminViewPanel.Hide();
            AddEmployeePanel.Hide();
            ViewEmployeePanel.Hide();
            ProductsPanel.Hide();
            TransactionPanel.Hide();
            EmployeesViewPanel.Hide();
        }


        // ------------------------------------------------------------
        // ------------------------ HOME PANEL ------------------------
        // -- ADMIN REPORT PANEL MOUSE HOVER EFECT 



        //-----------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------
        //------------------------------- EMPLOYEE START ----------------------------------->>>>

        private void LoadAdminDataForEmployeeComboBox()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT adminId, adminUserName FROM tblAdmin", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbAdminDataForEmployee.DataSource = dt;
            cmbAdminDataForEmployee.DisplayMember = "adminUserName";
            cmbAdminDataForEmployee.ValueMember = "adminId";
            con.Close();
        }

        // -------------------------------------
        // FOR EDIT
        //

        private void LoadEditAdminDataForEmployeeComboBox()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT adminId, adminUserName FROM tblAdmin", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbEditEmployeeCreatedByAdmin.DataSource = dt;
            cmbEditEmployeeCreatedByAdmin.DisplayMember = "adminUserName";
            cmbEditEmployeeCreatedByAdmin.ValueMember = "adminId";
            con.Close();
        }

        private void btnAddEmplyee_Click(object sender, EventArgs e)
        {          
            BrandPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Hide();
            AdminNewPanel.Hide();
            AdminViewPanel.Hide();
            AddEmployeePanel.Show();
            AddEmployeePanel.Dock = DockStyle.Fill;
            ViewEmployeePanel.Hide();
            HomePanel.Hide();
            ProductsPanel.Hide();
            TransactionPanel.Hide();
            EmployeesViewPanel.Hide();


            LoadAdminDataForEmployeeComboBox();
        }


        // --------------------------------------------------------
        // --- RESET EMPLOYEE
        //
        private void employeeReset()
        {
            txtEmplyeeName.Text = "";
            txtEmployeeUserName.Text = "";
            txtEmployeePassword.Text = "";
            EmployeeDateTimePicker.Value = DateTime.Today;
            EmploeeRadioButtonUnMarried.Checked = true;
            txtEmployeeBasicSalary.Text = "";
            EmployeePictureBox.Image = null;
        }

        // --------------------------------------------------------
        // --- INSERT EMPLOYEE
        //
        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tblEmployee(employeeName,employeeUserName,employeePassword,employeJoinDate,employeeMaterialStatus,employeeBasicSalary,employeeCreatedBy,employeePhoto) VALUES(@eN,@eUN,@eP,@eJD,@eMS,@eBS,@eCB,@ePhoto)", con);

            cmd.Parameters.AddWithValue("@eN", txtEmplyeeName.Text);
            cmd.Parameters.AddWithValue("@eUN", txtEmployeeUserName.Text);
            cmd.Parameters.AddWithValue("@eP", txtEmployeePassword.Text);
            cmd.Parameters.AddWithValue("@eJD", EmployeeDateTimePicker.Value.Date);
            if (EmployeeRadioButtonMarried.Checked == true)
            {
                cmd.Parameters.AddWithValue("@eMS", "Married");
            }
            else
            {
                cmd.Parameters.AddWithValue("@eMS", "Unmarried");
            }
            cmd.Parameters.AddWithValue("@eBS", txtEmployeeBasicSalary.Text);
            cmd.Parameters.AddWithValue("@eCB", cmbAdminDataForEmployee.SelectedValue);

            MemoryStream ms = new MemoryStream();
            EmployeePictureBox.Image.Save(ms, EmployeePictureBox.Image.RawFormat);
            cmd.Parameters.AddWithValue("@ePhoto", ms.ToArray());
            cmd.ExecuteNonQuery();

            InsertMessage m = new InsertMessage();
            m.Show();

            con.Close();
            employeeReset();
        }


        // ----------------------------------------------------------
        // -------- OPEN FILE DIALOG
        //
        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            if (EmployeeOpenFileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(EmployeeOpenFileDialogPicture.FileName);
                this.EmployeePictureBox.Image = img;
            }
        }

        // -------------------------------------------------------------
        // 
        //
        private void loadEmployeeDataGridView()
        {
            con.Open();
            string Query = "SELECT e.employeeId, e.employeeName, e.employeeUserName, e.employeePassword, a.adminUserName, e.employeePhoto FROM tblEmployee e INNER JOIN tblAdmin a ON e.employeeCreatedBy = a.adminId";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            EmployeeViewDataGridView.Rows.Clear();
            while (reader.Read())
            {
                EmployeeViewDataGridView.Rows.Add(reader["employeeId"], reader["employeeName"], reader["employeeUserName"], reader["employeePassword"], reader["adminUserName"], reader["employeePhoto"], "Edit", "View");
            }
            con.Close();

            EmployeeViewDataGridView.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            EmployeeViewDataGridView.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            EmployeeViewDataGridView.Columns[2].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            EmployeeViewDataGridView.Columns[3].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            EmployeeViewDataGridView.Columns[4].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            EmployeeViewDataGridView.Columns[5].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            EmployeeViewDataGridView.Columns[6].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            EmployeeViewDataGridView.Columns[6].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            EmployeeViewDataGridView.Columns[6].HeaderCell.Style.BackColor = Color.DarkGreen;
            EmployeeViewDataGridView.Columns[6].HeaderCell.Style.ForeColor = Color.White;

            EmployeeViewDataGridView.Columns[7].HeaderCell.Style.ForeColor = Color.White;
            EmployeeViewDataGridView.Columns[7].HeaderCell.Style.BackColor = Color.Green;

            EmployeeViewDataGridView.Columns[0].Width = 50;
            EmployeeViewDataGridView.Columns[6].Width = 60;
            EmployeeViewDataGridView.Columns[7].Width = 60;
        }

        private void btnViewEmplyee_Click(object sender, EventArgs e)
        {
            ViewEmployeePanel.Show();
            ViewEmployeePanel.Dock = DockStyle.Fill;

            EmployeesViewPanel.Hide();
            BrandPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Hide();
            AdminNewPanel.Hide();
            AdminViewPanel.Hide();
            AddEmployeePanel.Hide();
            HomePanel.Hide();
            ProductsPanel.Hide();
            TransactionPanel.Hide();
            EmployeesViewPanel.Hide();

            loadEmployeeDataGridView();
            LoadEditAdminDataForEmployeeComboBox();
        }

        private void EmployeeViewDataGridViewSelectionChangedEvent(object sender, EventArgs e)
        {
            
            if (this.EmployeeViewDataGridView.SelectedRows.Count > 0)
            {
                int idNo = (int)this.EmployeeViewDataGridView.SelectedRows[0].Cells[0].Value;

                SqlCommand cmd = new SqlCommand("SELECT * FROM tblEmployee where employeeId=@id", con);
                cmd.Parameters.AddWithValue("@id", idNo);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtEditEmployeeId.Text = dr.GetInt32(0).ToString();
                    txtEditEmployeeName.Text = dr.GetString(1);
                    txtEditEmployeeUserName.Text = dr.GetString(2);
                    txtEditEmployeePassword.Text = dr.GetString(3);
                    EmployeeEditDateTimePIcker.Value = dr.GetDateTime(4).Date;
                    if (dr.GetString(5) == "Married")
                    {
                        EmployeeEditRadioButtonMarried.Checked = true;
                    }
                    else
                    {
                        EmployeeEditRadioButtonUnmarried.Checked = true;
                    }

                    txtEditEmployeeBasicSalary.Text = dr.GetDecimal(6).ToString("0.00"); ;
                  
                    cmbEditEmployeeCreatedByAdmin.Text = dr.GetInt32(7).ToString();
                  
                    MemoryStream ms = new MemoryStream((byte[])dr[8]);
                    Image img = Image.FromStream(ms);
                    EmployeeEditPictureBox.Image = img;
                }
                con.Close();
                LoadEditAdminDataForEmployeeComboBox();
            }
        }


        // ---------------------------------------------------------
        // ---------------- EDIT DIALOG BOX
        //
        private void btnEditEmployeeImage_Click(object sender, EventArgs e)
        {
            if (EmployeeOpenFileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(EmployeeOpenFileDialogPicture.FileName);
                this.EmployeeEditPictureBox.Image = img;
            }
        }


        // ----------------------------------------------------------
        // ---------EMPLOYE EDIT RESET
        //
        private void employeEditReset()
        {
            txtEditEmployeeId.Text = "";
            txtEditEmployeeName.Text = "";
            txtEditEmployeeUserName.Text = "";
            txtEditEmployeePassword.Text = "";
            EmployeeEditDateTimePIcker.Value = DateTime.Today;
            EmployeeEditRadioButtonMarried.Checked = true;
            txtEditEmployeeBasicSalary.Text = "";
            EmployeeEditPictureBox.Image = null;
        }


        // -------------------------------------------------------
        // ------ UPDATE
        //
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE tblEmployee SET employeeName=@eN,employeeUserName=@eUN,employeePassword=@eP,employeJoinDate=@eJD,employeeMaterialStatus=@eMS,employeeBasicSalary=@eBS,employeeCreatedBy=@eCB,employeePhoto=@ePhoto WHERE employeeId=@eId", con);

            cmd.Parameters.AddWithValue("@eId", txtEditEmployeeId.Text);
            cmd.Parameters.AddWithValue("@eN", txtEditEmployeeName.Text);
            cmd.Parameters.AddWithValue("@eUN", txtEditEmployeeUserName.Text);
            cmd.Parameters.AddWithValue("@eP", txtEditEmployeePassword.Text);
            cmd.Parameters.AddWithValue("@eJD", EmployeeEditDateTimePIcker.Value.Date);
            if (EmployeeEditRadioButtonMarried.Checked == true)
            {
                cmd.Parameters.AddWithValue("@eMS", "Married");
            }
            else
            {
                cmd.Parameters.AddWithValue("@eMS", "Unmarried");
            }
            cmd.Parameters.AddWithValue("@eBS", txtEditEmployeeBasicSalary.Text);
            cmd.Parameters.AddWithValue("@eCB", cmbEditEmployeeCreatedByAdmin.SelectedValue);

            MemoryStream ms = new MemoryStream();
            EmployeeEditPictureBox.Image.Save(ms, EmployeeEditPictureBox.Image.RawFormat);
            cmd.Parameters.AddWithValue("@ePhoto", ms.ToArray());
            cmd.ExecuteNonQuery();

            InsertMessage m = new InsertMessage();
            m.Show();

            con.Close();
            employeEditReset();
            loadEmployeeDataGridView();
        }


        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (txtEditEmployeeId.Text != "")
            {
                try
                {
                    if (MessageBox.Show("Delete this Record??", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM tblEmployee WHERE employeeId=@i", con);
                        cmd.Parameters.AddWithValue("@i", txtEditEmployeeId.Text);

                        cmd.ExecuteNonQuery();

                        DeleteMessage d = new DeleteMessage();
                        d.Show();


                        con.Close();
                        employeEditReset();
                        loadEmployeeDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Employee Id");
            }
        }




        // ----------------------------------------------------------
        // --- BRAND
        //

        // ----------------------------------------------------------
        // --------- BRAND RESET
        //
        private void brandReset()
        {
            txtBrandName.Text = "";
        }

        // -----------------------------------------------------------
        // ------- BRAND INSERT 
        //
        private void btnAddBrand_Click_1(object sender, EventArgs e)
        {
            if (txtBrandName.Text == "")
            {
                MessageBox.Show("Please Insert A Brand Name");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblBrand VALUES(@bN)", con);
                    cmd.Parameters.AddWithValue("@bN", txtBrandName.Text);


                    cmd.ExecuteNonQuery();

                    InsertMessage m = new InsertMessage();
                    m.Show();

                    con.Close();

                    brandReset();
                    loadBrandDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // -------------------------------------------------------------
        // LOAD BRAND GRID
        //
        private void loadBrandDataGrid()
        {
            con.Open();
            string Query = "SELECT * FROM tblBrand";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            BrandDataGridView.Rows.Clear();
            while (reader.Read())
            {
                BrandDataGridView.Rows.Add(reader["brandId"], reader["brandName"]);
            }

            BrandDataGridView.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            BrandDataGridView.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            con.Close();
        }




        // ------------------------------------------------
        // --------- CATEGORY START
        //

        private void categoryReset()
        {
            txtCategoryName.Text = "";
        }


        private void LoadCategoryDataGridView()
        {
            con.Open();
            string Query = "SELECT * FROM tblCategory";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            DataGridViewCategory.Rows.Clear();
            while (reader.Read())
            {
                DataGridViewCategory.Rows.Add(reader["categoryId"], reader["categoryName"]);
            }

            DataGridViewCategory.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            DataGridViewCategory.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            con.Close();
        }

        // ------------------------------------------------
        // ---------- INSERT
        //
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Please Insert A Category Name");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblCategory VALUES(@cN)", con);
                    cmd.Parameters.AddWithValue("@cN", txtCategoryName.Text);


                    cmd.ExecuteNonQuery();

                    InsertMessage m = new InsertMessage();
                    m.Show();

                    con.Close();

                    categoryReset();
                    LoadCategoryDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        // ----------------------------------------------------------------------------------------------
        // -------------------- PRODUCT START
        //
        // -------------------------------------- COMBO BOX
        //
        private void LoadAdminDataForProduct()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT adminId, adminUserName FROM tblAdmin", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbCreatedByAdmin.DataSource = dt;
            cmbCreatedByAdmin.DisplayMember = "adminUserName";
            cmbCreatedByAdmin.ValueMember = "adminId";
            con.Close();
        }

        private void LoadSupplierDataForProduct()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT supplierId, supplierName FROM tblSupplier", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbProductSupplier.DataSource = dt;
            cmbProductSupplier.DisplayMember = "supplierName";
            cmbProductSupplier.ValueMember = "supplierId";
            con.Close();
        }

        private void LoadBrandDataForProduct()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT brandId, brandName FROM tblBrand", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbProductBrand.DataSource = dt;
            cmbProductBrand.DisplayMember = "brandName";
            cmbProductBrand.ValueMember = "brandId";
            con.Close();
        }

        private void LoadCategoryDataForProduct()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT categoryId, categoryName FROM tblCategory", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbProductCategory.DataSource = dt;
            cmbProductCategory.DisplayMember = "categoryName";
            cmbProductCategory.ValueMember = "categoryId";
            con.Close();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsPanel.Show();
            ProductsPanel.Dock = DockStyle.Fill;
            BrandPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Hide();
            AdminNewPanel.Hide();
            AdminViewPanel.Hide();
            AddEmployeePanel.Hide();
            ViewEmployeePanel.Hide();
            HomePanel.Hide();
            TransactionPanel.Hide();
            EmployeesViewPanel.Hide();


            LoadAdminDataForProduct();
            LoadSupplierDataForProduct();
            LoadBrandDataForProduct();
            LoadCategoryDataForProduct();
        }

        // -------------------------------------------------------------------
        // ----------- PRODUCT RESET
        //
        private void productReset()
        {
            txtProductName.Text = "";
            txtProductDescription.Text = "";
            txtProductQuantity.Text = "";
        }


        // -- ---------------------------------------------------------------
        // --- PRODUCT INSERT
        //
        private void btnNewProducts_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO tblProducts(productName,productDescription,productQuantity,productCreatedByAdmin,productSupplier,productBrand,productCategory) VALUES(@pN,@pD,@pQ,@pA,@pS,@pB,@pC)", con);

            cmd.Parameters.AddWithValue("@pN", txtProductName.Text);
            cmd.Parameters.AddWithValue("@pD", txtProductDescription.Text);
            cmd.Parameters.AddWithValue("@pQ", txtProductQuantity.Text);
            cmd.Parameters.AddWithValue("@pA", cmbCreatedByAdmin.SelectedValue);
            cmd.Parameters.AddWithValue("@pS", cmbProductSupplier.SelectedValue);
            cmd.Parameters.AddWithValue("@pB", cmbProductBrand.SelectedValue);
            cmd.Parameters.AddWithValue("@pC", cmbProductCategory.SelectedValue);

            cmd.ExecuteNonQuery();

            InsertMessage m = new InsertMessage();
            m.Show();

            con.Close();
            productReset();
        }


        
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductPanel.Show();
            ViewProductPanel.Hide();

            btnAddProduct.BackColor = Color.LightSeaGreen;
            btnAddProduct.ForeColor = Color.White;
            btnViewProduct.BackColor = Color.Black;
            btnViewProduct.ForeColor = Color.White;
        }


        // ------------------------ PRODUCT EDIT
        //
        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            AddProductPanel.Hide();
            ViewProductPanel.Show();

            loadProductDataGridView();

            btnViewProduct.BackColor = Color.LightSeaGreen;
            btnViewProduct.ForeColor = Color.White;
            btnAddProduct.BackColor = Color.Black;
            btnAddProduct.ForeColor = Color.White;

            LoadEditAdminDataForProduct();
            LoadEditSupplierDataForProduct();
            LoadEditBrandDataForProduct();
            LoadEditCategoryDataForProduct();
        }

        /// <----------------------------------------------------------------->
        /// ----------- PRODUCT DATA GRID VIEW
        /// <>
        private void loadProductDataGridView()
        {
            con.Open();
            string Query = "SELECT p.productId,p.productName,p.productDescription,p.productQuantity,a.adminUserName,s.supplierName,b.brandName,c.categoryName FROM tblProducts p INNER JOIN tblAdmin a ON p.productCreatedByAdmin=a.adminId INNER JOIN tblSupplier s ON p.productSupplier=s.supplierId INNER JOIN tblBrand b ON p.productBrand=b.brandId INNER JOIN tblCategory c ON p.productCategory=c.categoryId";
            SqlCommand cmd = new SqlCommand(Query, con);

            var reader = cmd.ExecuteReader();

            ProductDataGridView.Rows.Clear();
            while (reader.Read())
            {
                ProductDataGridView.Rows.Add(reader["productId"], reader["productName"], reader["productDescription"], reader["productQuantity"],reader["adminUserName"], reader["supplierName"], reader["brandName"], reader["categoryName"]);
            }

            ProductDataGridView.Columns[0].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            ProductDataGridView.Columns[1].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            ProductDataGridView.Columns[2].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            ProductDataGridView.Columns[3].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            ProductDataGridView.Columns[4].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            ProductDataGridView.Columns[5].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            ProductDataGridView.Columns[6].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            ProductDataGridView.Columns[7].HeaderCell.Style.Font = new Font("Century Gothic", 14, FontStyle.Bold);

            //AdminDataGridView.Columns[4].HeaderCell.Style.BackColor = Color.DarkGreen;
            //AdminDataGridView.Columns[5].HeaderCell.Style.BackColor = Color.Red;

            ProductDataGridView.Columns[0].Width = 30;
            ProductDataGridView.Columns[2].Width = 200;

            //AdminDataGridView.Columns[4].Width = 50;
            //AdminDataGridView.Columns[5].Width = 70;

            con.Close();
        }


        /// <FOR RETERIEVE DATA>
        /// 
        int k = 0;
        private void ProductDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtEditProductId.Text = ProductDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEditProductName.Text = ProductDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEditProductDescription.Text = ProductDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEditProductQuantity.Text = ProductDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbEditProductCreatedBy.Text = ProductDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbEditProductSupplier.Text = ProductDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbEditProductBrand.Text = ProductDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbEditProductCategory.Text = ProductDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();


            if (txtEditProductId.Text == "")
            {
                k = Convert.ToInt32(AdminDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }


        // ------------------------------ EDIT PRODUCT COMBO ------
        private void LoadEditAdminDataForProduct()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT adminId, adminUserName FROM tblAdmin", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbEditProductCreatedBy.DataSource = dt;
            cmbEditProductCreatedBy.DisplayMember = "adminUserName";
            cmbEditProductCreatedBy.ValueMember = "adminId";
            con.Close();
        }

        private void LoadEditSupplierDataForProduct()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT supplierId, supplierName FROM tblSupplier", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbEditProductSupplier.DataSource = dt;
            cmbEditProductSupplier.DisplayMember = "supplierName";
            cmbEditProductSupplier.ValueMember = "supplierId";
            con.Close();
        }

        private void LoadEditBrandDataForProduct()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT brandId, brandName FROM tblBrand", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbEditProductBrand.DataSource = dt;
            cmbEditProductBrand.DisplayMember = "brandName";
            cmbEditProductBrand.ValueMember = "brandId";
            con.Close();
        }

        private void LoadEditCategoryDataForProduct()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT categoryId, categoryName FROM tblCategory", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbEditProductCategory.DataSource = dt;
            cmbEditProductCategory.DisplayMember = "categoryName";
            cmbEditProductCategory.ValueMember = "categoryId";
            con.Close();
        }


        // ------------------------------------------------------ 
        // RESET EDIT PRODUCT
        //
        private void ProductEditReset()
        {
            txtEditProductId.Text = "";
            txtEditProductName.Text = "";
            txtEditProductDescription.Text = "";
            txtEditProductQuantity.Text = "";
        }

        // --------------------- UPDATE -->>>
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"UPDATE tblProducts SET productName=@pN,productDescription=@pD,productQuantity=@pQ,productCreatedByAdmin=@pA,productSupplier=@pS,productBrand=@pB,productCategory=@pC WHERE productId=@pI", con);

                    cmd.Parameters.AddWithValue("pI", txtEditProductId.Text);
                    cmd.Parameters.AddWithValue("@pN", txtEditProductName.Text);
                    cmd.Parameters.AddWithValue("@pD", txtEditProductDescription.Text);
                    cmd.Parameters.AddWithValue("@pQ", txtEditProductQuantity.Text);
                    cmd.Parameters.AddWithValue("@pA", cmbEditProductCreatedBy.SelectedValue);
                    cmd.Parameters.AddWithValue("@pS", cmbEditProductSupplier.SelectedValue);
                    cmd.Parameters.AddWithValue("@pB", cmbEditProductBrand.SelectedValue);
                    cmd.Parameters.AddWithValue("@pC", cmbEditProductCategory.SelectedValue);
                    cmd.ExecuteNonQuery();

                    UpdateMessage m = new UpdateMessage();
                    m.Show();

                    con.Close();
                    ProductEditReset();
                    loadProductDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (txtEditProductId.Text != "")
            {
                try
                {
                    if (MessageBox.Show("Delete this Record??", "Are You Sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand(@"DELETE FROM tblProducts WHERE productId=@i", con);
                        cmd.Parameters.AddWithValue("@i", txtEditProductId.Text);

                        cmd.ExecuteNonQuery();

                        DeleteMessage d = new DeleteMessage();
                        d.Show();

                        con.Close();
                        ProductEditReset();
                        loadProductDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Product Id");
            }
        }


        // --------------------------------------------------------------------------
        // ------------------------------ TRANSACTION
        //

        private void LoadEditProductDataGridView()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT productId, productName FROM tblProducts", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            product.DataSource = dt;
            product.DisplayMember = "productName";
            product.ValueMember = "productId";
            con.Close();
        }



        // --------------------------------------- TRANSACTION BILL 
        //
        private void btnProductTransaction_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlTransaction ts = con.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Transaction = ts;

                cmd.CommandText = "INSERT INTO tblcustomer VALUES(@name,@add) SELECT @@IDENTITY";

                cmd.Parameters.AddWithValue("@name", txtTSCustomerName.Text);
                cmd.Parameters.AddWithValue("@add", txtTSCustomerAddress.Text);

                int id = Convert.ToInt32(cmd.ExecuteScalar());
                for (int i = 0; i < TransactionDataGridView.Rows.Count; i++)
                {
                    if (TransactionDataGridView.Rows[i].Cells["product"].Value != null && TransactionDataGridView.Rows[i].Cells["total"].Value != null)
                    {
                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;
                        cmd2.Transaction = ts;
                        cmd2.CommandText = "INSERT INTO tblBill(customerId,productId,totalTaka) VALUES(@customerId,@productId,@totalTaka)";
                        cmd2.Parameters.AddWithValue("@customerId", id);
                        cmd2.Parameters.AddWithValue("@productId", TransactionDataGridView.Rows[i].Cells["product"].Value);
                        cmd2.Parameters.AddWithValue("@totalTaka", TransactionDataGridView.Rows[i].Cells["total"].Value);
                        cmd2.ExecuteNonQuery();
                    }
                }
                ts.Commit();
                MessageBox.Show("Data saved successfully!!!!");
            }
            catch (Exception ex)
            {
                ts.Rollback();
                MessageBox.Show(ex.Message + "\nData not saved!!!!");
            }
            con.Close();
        }


        private void btnEmployeeReport_Click(object sender, EventArgs e)
        {
            reportEmployee r = new reportEmployee();
            r.Show();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            TransactionPanel.Show();
            TransactionPanel.Dock = DockStyle.Fill;
            ProductsPanel.Hide();
            BrandPanel.Hide();
            CategoryPanel.Hide();
            SupplierPanel.Hide();
            AdminNewPanel.Hide();
            AdminViewPanel.Hide();
            AddEmployeePanel.Hide();
            ViewEmployeePanel.Hide();
            HomePanel.Hide();
            EmployeesViewPanel.Hide();
        }

        private void btnProductReport_Click(object sender, EventArgs e)
        {
            pReport p = new pReport();
            p.Show();
        }

      


        // -----------------------------------------------------------------------
        // ----------------------------- EMPLOYEE CELL MOUSE CLICK
        // ----------- FOR VIEW

        private void EmployeeViewDataGridViewCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.ColumnIndex == 7 && e.RowIndex > -1)
            {
                TransactionPanel.Hide();
                ProductsPanel.Hide();
                BrandPanel.Hide();
                CategoryPanel.Hide();
                SupplierPanel.Hide();
                AdminNewPanel.Hide();
                AdminViewPanel.Hide();
                AddEmployeePanel.Hide();
                ViewEmployeePanel.Hide();
                HomePanel.Hide();
                EmployeesViewPanel.Show();
                EmployeesViewPanel.Dock = DockStyle.Fill;

                string adminId = EmployeeViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                SqlCommand cmd = new SqlCommand("SELECT * FROM tblEmployee where employeeId=@id", con);
                cmd.Parameters.AddWithValue("@id", adminId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    //txtEditEmployeeId.Text = dr.GetInt32(0).ToString();
                    lblViewEmployeeName.Text = dr.GetString(1);
                    lblViewEmployeeUserName.Text = dr.GetString(2);
                    lblViewEmployeePassword.Text = dr.GetString(3);
                    lblViewEmployeeDateOfBirth.Text = dr.GetDateTime(4).Date.ToString("D");

                    if (dr.GetString(5) == "Married")
                    {
                        lblViewEmpoyeeMateial.Text = "Married";
                    }
                    else
                    {
                        lblViewEmpoyeeMateial.Text = "Unmarried";
                    }

                    lblViewEmployeeSalary.Text = dr.GetDecimal(6).ToString("0.00")+" Taka"; 

                    //cmbEditEmployeeCreatedByAdmin.Text = EmployeeViewDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    MemoryStream ms = new MemoryStream((byte[])dr[8]);
                    Image img = Image.FromStream(ms);
                    EmployeeViewPictureBox.Image = img;

                    //txtEditEmployeeId.Text = dr.GetInt32(0).ToString();
                    //txtEditEmployeeName.Text = dr.GetString(1);
                    //txtEditEmployeeUserName.Text = dr.GetString(2);
                    //txtEditEmployeePassword.Text = dr.GetString(3);
                    //EmployeeEditDateTimePIcker.Value = dr.GetDateTime(4).Date;
                    //if (dr.GetString(5) == "Married")
                    //{
                    //    EmployeeEditRadioButtonMarried.Checked = true;
                    //}
                    //else
                    //{
                    //    EmployeeEditRadioButtonUnmarried.Checked = true;
                    //}

                    //txtEditEmployeeBasicSalary.Text = dr.GetDecimal(6).ToString("0.00"); ;

                    //cmbEditEmployeeCreatedByAdmin.Text = EmployeeViewDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    //MemoryStream ms = new MemoryStream((byte[])dr[8]);
                    //Image img = Image.FromStream(ms);
                    //EmployeeEditPictureBox.Image = img;
                }
                con.Close();
            }

            else if (e.ColumnIndex == 6 && e.RowIndex > -1)
            {
                string adminId = EmployeeViewDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                SqlCommand cmd = new SqlCommand("SELECT * FROM tblEmployee where employeeId=@id", con);
                cmd.Parameters.AddWithValue("@id", adminId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtEditEmployeeId.Text = dr.GetInt32(0).ToString();
                    txtEditEmployeeName.Text = dr.GetString(1);
                    txtEditEmployeeUserName.Text = dr.GetString(2);
                    txtEditEmployeePassword.Text = dr.GetString(3);
                    EmployeeEditDateTimePIcker.Value = dr.GetDateTime(4).Date;
                    if (dr.GetString(5) == "Married")
                    {
                        EmployeeEditRadioButtonMarried.Checked = true;
                    }
                    else
                    {
                        EmployeeEditRadioButtonUnmarried.Checked = true;
                    }

                    txtEditEmployeeBasicSalary.Text = dr.GetDecimal(6).ToString("0.00"); ;

                    cmbEditEmployeeCreatedByAdmin.Text = EmployeeViewDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

                    MemoryStream ms = new MemoryStream((byte[])dr[8]);
                    Image img = Image.FromStream(ms);
                    EmployeeEditPictureBox.Image = img;
                }
                con.Close();
            }

        }

        private void EmployeeViewPictureBoxClose_Click(object sender, EventArgs e)
        {
            EmployeesViewPanel.Hide();
            ViewEmployeePanel.Show();
        }


        // ----------------------------------------------------------------------------
        // ---------------------------- EMPLOYEE CLOSE
    }

}

