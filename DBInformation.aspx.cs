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
    public partial class DBInformation : System.Web.UI.Page
    {
        SqlConnection cn = null;
        SqlCommand cmd = null;
        SqlDataReader dr = null;
        DataSet ds = null;
        SqlDataAdapter da=null;

        string StrCommand = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {

       // lblstatus.Text = Session["UserName"].ToString();

                    if(!Page.IsPostBack)
                    {
                        BindDBInformation();
                    }
                }
                void BindDBInformation()
                {
                    SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString);

                    cmd=new SqlCommand("Select * from RegistrationForm",cn);
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "RegistrationForm");
                    Repeater1.DataSource = ds.Tables["RegistrationForm"]; 
                    Repeater1.DataBind();
                }

                protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
                {
                    var UserName = Convert.ToString(e.CommandArgument.ToString());
                    if (e.CommandName == "Edit") 
                   { 
                    Response.Redirect("UpdateDBI.aspx?UserName="+UserName);
                    } 
                    else if (e.CommandName == "Delete") 
                    {

                        SqlConnection connectionstring = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString);
                        
                        connectionstring.Open();

                        cmd =new SqlCommand("Delete from RegistrationForm Where UserName='"+UserName+"'");
                        cmd.Connection = connectionstring;
                   //cmd = new SqlCommand("Select * from RegistrationForm",cn); 
                   //cmd.Parameters.AddWithValue("UserName",UserName);
                        if (cmd.ExecuteNonQuery() > 0) 
                        { 
                            Response.Write("Record Deleted Successfully!!!");
                           BindDBInformation();
                        } 
                        else 
                        { 
                            Response.Write("Record Deletion Failed!!!"); 
                        } 
                        connectionstring.Close();
                }
                }

       
        }
    }