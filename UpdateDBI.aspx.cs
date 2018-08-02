using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace WebProject
{
    public partial class UpdateDBI : System.Web.UI.Page
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataSet ds = null;
        SqlDataAdapter da = null;

        string StrCommand = string.Empty;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["UserName"] == null) 
                Response.Redirect("DBInformation.aspx");

            cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString);

            if (!Page.IsPostBack) 
            { 
                
             } 
        }
        void BindDBIdetailes() 
        { 
            var UserName = Convert.ToString(Request.QueryString["UserName"]);

            StrCommand = "Select * from RegistrationForm where UserName="+UserName; 

            if (cn.State != ConnectionState.Open) 
                cn.Open();
            cmd = new SqlCommand(StrCommand, cn); 
            cmd.Parameters.AddWithValue("UserName",UserName);
 
            SqlDataReader dr = cmd.ExecuteReader(); 

            if (dr.Read()) 
            { 
                txtPsw.Text=dr["Password"].ToString();
                txtName.Text=dr["Name"].ToString();
                txtMobile.Text=dr["MobileNo"].ToString();
                txtEmail.Text=dr["EmailId"].ToString();
            } 
            else 
            { 
                lblStatus.Text = "<b>No Employee Details Found!!!</b>";
            } 
            dr.Close(); 
            cn.Close();
        }
    }
}