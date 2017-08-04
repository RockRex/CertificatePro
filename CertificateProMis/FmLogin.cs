using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using DBCL;

namespace CertificateProMis
{
    
    public partial class FmLogin : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();

        string strID = "";
        string strPsd = "";
        


        public FmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            strID = tbID.Text.Trim();
            strPsd = tbPsd.Text.Trim();

            string strSql = "";

            strSql = "select * from userTable where userID = '" + strID + "'";

            SqlDataReader dr = db.DB_Red(strSql);
            if (dr.Read())
            {
                string psd = db.DB_C(strSql, 1);
                if (strPsd.Equals(psd))
                {
                    string name = dr.GetString(2);
                    string strSql2 = "delete from Users";
                    db.DB_ZSG(strSql2);
                    string strSql1 = "insert into Users values('" + strID + "')";
                    db.DB_ZSG(strSql1);
                    MessageBox.Show("登录成功");
                    Gloable.username = "您好" + name;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("用户名或者密码错误");
                tbID.Text = "";
                tbPsd.Text = "";
                tbID.Focus();
            }
        }

        private void bt_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbPsd.Text = "";
        }
    }
}
