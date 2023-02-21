using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SuSoftProject.AppPages
{
    public partial class AddEmp_WebPage : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //string conn = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FKEAHBN; Initial Catalog=SuSoft_DB;Trusted_Connection=true");
            //con.ConnectionString = "Data Source=DESKTOP-FKEAHBN; Initial Catalog=SuSoft_DB;Trusted_Connection=true";
            con.Open();
            SqlCommand cmd = new SqlCommand("SP_Insert_Into_EmployeeTable", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Emp_ID", txtEmpID.Text);
            cmd.Parameters.AddWithValue("@Emp_Name", txtEmpName.Text);

            DateTime dobDate = Convert.ToDateTime(txtEmpDob.Text.ToString());
            cmd.Parameters.AddWithValue("@Emp_DoB", dobDate.Date);

            string empDesg = ddlEmpDesg.SelectedItem.Text; 
            cmd.Parameters.AddWithValue("@Emp_Desg", empDesg);

            cmd.Parameters.AddWithValue("@Emp_Mobile", txtEmpMobile.Text);
            cmd.Parameters.AddWithValue("@Email_ID", txtEmailID.Text); 
            cmd.ExecuteNonQuery();
            con.Close();

            ScriptManager.RegisterStartupScript(this, this.GetType(),"script","alert('Data Inserted Successfully')", true);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmp_WebPage.aspx");
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpDetailsPage.aspx");
        }
    }
}