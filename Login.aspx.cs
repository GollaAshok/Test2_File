using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using com.limoliner.Service;
using com.limoliner.Service.Impl;
using com.limoliner.dto;

namespace WebProject
{
    public partial class Login : System.Web.UI.Page
    {
        private object txtuname;
        private object txtpsw;
        private object lblStatus;
        private object txtname;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lnbnewuserregi_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registration.aspx");
        }
        protected void btnlogin_Click(object sender, EventArgs e)
        {

            UserDto dto = new UserDto();
            dto.UserName = Request.Form["txtuname"];
            dto.Password = Request.Form["txtpsw"];
            dto.Name=Request.Form["txtname"];

            UserService service = new UserServiceImpl();
            bool validUser = service.ValidatUser(dto);
            if (validUser)
            {
                Session["UserName"]=dto.UserName;
                Session["Password"] = dto.Password;
                Session["Name"]=dto.Name;
                Response.Redirect("DataBoundFile.aspx");
            }
            else
            {
                //lblstatus = "<b style='color:red'>Please check your UserName and Password!!!</b>";
                //Response.Output.Write(lblstatus);
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");
                txtuname = "";
                txtpsw = "";
            }          
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtuname = "";
            txtpsw = "";
        }
    }
}