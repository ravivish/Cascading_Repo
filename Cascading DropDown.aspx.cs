using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Test16_1_19
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                show();
                bindcountry();
                binddepartment();
            }

        }
        private void show()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_reg_join", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            grd.DataSource = ds;
            grd.DataBind();
        }
        private void bindcountry()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_country_select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            ddlcountry.DataValueField = "id";
            ddlcountry.DataTextField = "cname";
            ddlcountry.DataSource = ds;
            ddlcountry.DataBind();
            ddlcountry.Items.Insert(0, new ListItem("--Select--", "0"));
        }
        private void binddepartment()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_depart_select", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();
            ddldepart.DataValueField = "id";
            ddldepart.DataTextField = "dname";
            ddldepart.DataSource = ds;
            ddldepart.DataBind();
            ddldepart.Items.Insert(0, new ListItem("--Select--", "0"));
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_reg_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fname", txtfname.Text);
            cmd.Parameters.AddWithValue("@lname", txtlname.Text);
            cmd.Parameters.AddWithValue("@country", ddlcountry.SelectedValue);
            cmd.Parameters.AddWithValue("@depart", ddldepart.SelectedValue);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }
    }
}