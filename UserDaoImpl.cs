using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using com.limoliner.model;

namespace com.limoliner.Dao.Impl
{
    public partial class UserDaoImpl : UserDao
    {
        SqlConnection sqlConnection;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;
        public SqlConnection getDBConnection()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["ConnectionString3"].ConnectionString;
            sqlConnection = new SqlConnection(connectionstring);

            return sqlConnection;
        }
        public bool AddUser(UserModel um)
        {    
            int rowAffected;
            SqlConnection cn = getDBConnection();
            bool insert = false;
            if (cn != null)
            {
            cn.Open();

            cmd = new SqlCommand("insert into RegistrationForm values('" + um.UserName + "','" + um.Password + "','" + um.Name + "','" + um.MobilNo + "','" + um.EmailId + "')", cn);
            rowAffected = cmd.ExecuteNonQuery();
            cn.Close();
                if(rowAffected == 1)
                {
                    insert = true;
                }
            }
            return insert;
        }
        public bool UpdateUser(UserModel um)
        {
            int rowAffected;
            SqlConnection cn = getDBConnection();
            bool update = false;
            if (cn != null)
            {
                cn.Open();
                cmd = new SqlCommand( "Update RegistrationForm Set Password=@Password, Name=@Name, MobileNo=@MobileNo, EmailId=@EmailId Where UserName=@UserName",cn);

                cmd.Parameters.AddWithValue("UserName", um.UserName);
                cmd.Parameters.AddWithValue("Password",um.Password);
                cmd.Parameters.AddWithValue("Name", um.Name);
                cmd.Parameters.AddWithValue("MobileNo",um.MobilNo);
                cmd.Parameters.AddWithValue("EmailId",um.EmailId);
               
                rowAffected = cmd.ExecuteNonQuery();
                cn.Close();
                if (rowAffected == 1)
                {
                    update = true;
                }
            }
            return update;           
        }
        public bool DeleteUser(UserModel um)
        {
            int rowAffected;
            SqlConnection cn = getDBConnection();
            bool delete = false;
            if (cn != null)
                {
                    cn.Open();
                    cmd = new SqlCommand("Delete from RegistrationForm Where UserName='" +um.UserName+ "'",cn);

                    cmd.Parameters.AddWithValue("UserName",um.UserName);
                    rowAffected = cmd.ExecuteNonQuery();
                    cn.Close();
                    if (rowAffected == 1)
                    {
                        delete = true;
                    }
                }
                return delete;
        }
        public bool ValidatUser(UserModel um)
        {
            SqlConnection cn = getDBConnection();
            bool isValidate = false;
            if (cn != null)
            {
                cn.Open();
                cmd = new SqlCommand("select COUNT(*) from RegistrationForm where UserName='" + um.UserName + "'and Password='" + um.Password + "'", cn);
                //SqlCommand cmd = new SqlCommand("Select * from RegistrationForm",cn);
                dr = cmd.ExecuteReader();
                String columnIndex = null;
                while (dr.Read())
                {
                    columnIndex = String.Format("{0}", dr[0]);
                }

                if (columnIndex.Equals("1"))
                {
                    isValidate = true;
                }
                dr.Close();
                cn.Close();
            }
            return isValidate;
        }
        public UserModel GetUser(UserModel um)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> uml = new List<UserModel>();
            DataTable dt = new DataTable();
            SqlConnection con = getDBConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from RegistrationForm", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    UserModel userinfo = new UserModel();
                    userinfo.UserName = dt.Rows[i]["UserName"].ToString();
                    userinfo.Password = dt.Rows[i]["Password"].ToString();
                    userinfo.Name = dt.Rows[i]["Name"].ToString();
                    userinfo.MobilNo = dt.Rows[i]["MobileNo"].ToString();
                    userinfo.EmailId = dt.Rows[i]["EmailId"].ToString();
                    uml.Add(userinfo);
                }
            }
            return uml;
            }
    }
}