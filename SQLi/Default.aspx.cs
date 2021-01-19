using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SQLi
{
    
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dset = new DataSet();
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString());
                using (conn)
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("SELECT userID, name, email FROM user_info", conn);
                    cmd.CommandType = CommandType.Text;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dset);
                    gvUserInfo.DataSource = dset;
                    gvUserInfo.DataBind();


                }
            }
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            DataSet dset = new DataSet();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString());
            using (conn)
            {
                if (txtUserID.Text != string.Empty)
                {
                    //try
                    //{

                    //bad code (able to do SQLi)
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string sqlQuery = string.Format("SELECT userID,name, email FROM user_info WHERE userID ={0}", txtUserID.Text);
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.CommandType = CommandType.Text;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dset);
                    gvUserInfo.DataSource = dset;
                    gvUserInfo.DataBind();

                    //Good code (
                    //conn.Open();
                    //SqlDataAdapter adapter = new SqlDataAdapter();
                    //string sqlQuery = string.Format("SELECT userID,name, email FROM User_Info WHERE userID =@UID");
                    //SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    //cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@UID", txtUserID.Text);
                    //adapter.SelectCommand = cmd;
                    //adapter.Fill(dset);
                    //gvUserInfo.DataSource = dset;
                    //gvUserInfo.DataBind();
                    //}
                    //catch (Exception ex)
                    //{
                    //    throw new Exception (ex.ToString());

                    //}


                }
            }

        }
    }
}