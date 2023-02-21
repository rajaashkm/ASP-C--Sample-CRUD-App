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
    public partial class EmpDetailsPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_GridData();
            }
        }

        private void load_GridData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FKEAHBN; Initial Catalog=SuSoft_DB;Trusted_Connection=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("Sp_SelectEmployeeDetails",con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EmpGridData.DataSource = dt;
            EmpGridData.DataBind();
        }

        protected void EmpGridData_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            { 
                e.Row.Attributes["onClick"] = Page.ClientScript.GetPostBackClientHyperlink(EmpGridData, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }

        protected void EmpGridData_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (GridViewRow row in EmpGridData.Rows)
            {
                if (row.RowIndex == EmpGridData.SelectedIndex)
                {
                    //Response.Redirect("UpdateEmpDetails.aspx?Emp_ID=" + row.Cells[0].Text.Trim());
                    //int empID = Convert.ToInt32(EmpGridData.SelectedRow.Cells[1].Text);
                    //Session["EmpID"] = EmpGridData.SelectedRow.Cells[1].Text;
                    Response.Redirect("UpdateEmpDetails.aspx?Emp_ID=" + row.Cells[1].Text.Trim());
                }
            }
        }
    }
}