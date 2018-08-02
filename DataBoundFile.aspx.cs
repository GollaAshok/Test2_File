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
using com.limoliner.Service;
using com.limoliner.Service.Impl;
using com.limoliner.model;
using com.limoliner.dto;


namespace WebProject
{
    public partial class DataBoundFile : System.Web.UI.Page
    {
        UserDto userUpdate = new UserDto();
        UserService service = new UserServiceImpl();
        //string lbltatus;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Session["UserName"] != null)
                {
                    this.lblStatus.Text = string.Format(Session["UserName"].ToString());
                    BindDBdata(); 
                }
            }
        }
        void BindDBdata() 
        {
            //userUpdate.UserName = Request.Form["lblStatus"];
            GridView1.DataSource = service.GetAllUsers();
            GridView1.DataBind();
          }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindDBdata();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindDBdata();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
            string UserName = e.Keys["UserName"].ToString();
            string Password = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtpsw")).Text.Trim();
            string Name = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtname")).Text.Trim();
            string MobileNo = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtmobile")).Text.Trim();
            string EmaiId = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txtemail")).Text.Trim();

            userUpdate.UserName = UserName;
            userUpdate.Password = Password;
            userUpdate.Name = Name;
            userUpdate.MobileNo = MobileNo;
            userUpdate.EmailId = EmaiId;


            
            bool update = service.updateUser(userUpdate);
            if (update)
            {
                Response.Write("Record Updated Successfully!!!");
                GridView1.EditIndex = -1;
                BindDBdata();
            }
            else
            {
                Response.Write("Record Updation Failed!!!");
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            var UserName = e.Keys["UserName"].ToString();
            userUpdate.UserName = UserName;
            bool delete = service.DeleteUser(userUpdate);

            if(delete)
            {
                Response.Write("<b style='color:green'>Record Deleted Successfully!!!</b>");
                BindDBdata();
            }
            else
            {
                Response.Write("<b style='color:red'>Record Deletion Failed!!!</b>");
            }
            
        }

        protected void lnkbtnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }
      }
    }
 