using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Import namespaces
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using com.limoliner.dto;
using com.limoliner.Service;
using com.limoliner.Service.Impl;
using com.limoliner.model;

namespace WebProject
{
    public partial class Registration : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            txtuname.Focus();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            UserDto userRegister = new UserDto();
            userRegister.UserName = txtuname.Text;
            userRegister.Password = txtpsw.Text;
            userRegister.Name = txtname.Text;
            userRegister.MobileNo = txtmobile.Text;
            userRegister.EmailId = txtemail.Text;


            UserService Service = new UserServiceImpl();
            bool insert = Service.AddUser(userRegister);
            if (insert)
            {
                //lblstatus.Text = "<b style='color:red'>User detailes  has been inserted successfully!!!</b>";
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('User detailes  has been instantiate successfully.')</script>");
                txtuname.Text = string.Empty;
                txtpsw.Text = string.Empty;
                txtname.Text = string.Empty;
                txtmobile.Text = string.Empty;
                txtemail.Text = string.Empty;

            }
            else
            {
                //lblstatus.Text = "<b style='color:red'>User detailes insertion failed!!!</b>";
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('User detailes insertion failed.')</script>");
            }
            //Response.Redirect("~/Login.aspx");
        }

        protected void btnreset_Click1(object sender, EventArgs e)
        {
            txtuname.Text = string.Empty;
            txtpsw.Text = string.Empty;
            txtname.Text = string.Empty;
            txtmobile.Text = string.Empty;
            txtemail.Text = string.Empty;
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }
        protected void lbnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Home.aspx");
        }

        protected void lbnlogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}