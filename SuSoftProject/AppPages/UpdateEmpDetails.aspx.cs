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
    public partial class UpdateEmpDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int empID = Convert.ToInt32(Request.QueryString["Emp_ID"]);
                //int empID = Convert.ToInt32(Session["Emp_ID"]);

                getEmployeeDetails(empID);
            }
        }

        private void getEmployeeDetails(int empID)
        {
            string ConnectionString = "Data Source=DESKTOP-FKEAHBN; Initial Catalog=SuSoft_DB;Trusted_Connection=true";
            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SelectEmployeeDetailsByEmpID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Emp_ID", empID);
            IDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtEmpID.Text = dr["Emp_ID"].ToString();
                txtEmpName.Text = dr["Emp_Name"].ToString();

                DateTime empDob = Convert.ToDateTime(dr["Emp_DoB"]).Date;
                string strDate = empDob.ToString("dd/MM/yyyy");
                //txtEmpDob.Text = empDob.ToString();
                string[] newDate = strDate.Split('-');
                txtEmpDob.Text = newDate[0].ToString() + "/" + newDate[1].ToString() + "/" + newDate[2].ToString();

                ddlEmpDesg.SelectedItem.Text = dr["Emp_Desg"].ToString();
                txtEmpMobile.Text = dr["Emp_Mobile"].ToString();
                txtEmailID.Text = dr["Email_ID"].ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FKEAHBN; Initial Catalog=SuSoft_DB;Trusted_Connection=true");

            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_Update_Employee_Details", con);
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

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Data Updated Successfully')", true);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateEmpDetails.aspx");
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpDetailsPage.aspx");
        }
    }
}