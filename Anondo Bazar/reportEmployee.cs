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
    public partial class reportEmployee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=AnondoBazar;Trusted_connection=True");
        public reportEmployee()
        {
            InitializeComponent();
        }

        private void btnLoadEmployeeReport_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblEmployee WHERE employeeId='"+txtSearchEmployeeReport.Text+ "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataSet s = new DataSet();
            sd.Fill(s);

            EmployeeReport er = new EmployeeReport();
            er.SetDataSource(s.Tables["table"]);
            crystalReportViewer1.ReportSource = er;
        }

        private void reportEmployee_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
        }
    }
}
