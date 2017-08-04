using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBCL;

namespace CertificateProMis
{
    public partial class FmRegistered : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();

        string strID = "";
        string strPsd = "";
        string strPsd1 = "";
        string strUserName = "";
        string strSex = "";
        string strShenFen = "";
        string strXueLi = "";
        string strPhone = "";
        string strArea1 = "";
        string strArea2 = "";
        string strArea3 = "";
        public FmRegistered()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FmRegistered_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            strID = tbID.Text.Trim();
            strPsd = tbPsd.Text.Trim();
            strPsd1 = tbPsd1.Text.Trim();
            strUserName = tbUserName.Text.Trim();
            if (radioButton1.Checked == true)
            {
                strSex = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                strSex = radioButton2.Text;
            }
            strShenFen = comboBox1.Text;
            strXueLi = comboBox2.Text;
            strPhone = tbPhone.Text.Trim();
            strArea1 = comboBox3.Text;
            strArea2 = comboBox4.Text;
            strArea3 = comboBox5.Text;

            if (strID == "" || strPsd == "" || strPsd1 == "" || strUserName == "" || strSex == "" || strShenFen == "" || strXueLi == "" || strPhone == "" || strArea1 == "" || strArea2 == "" || strArea3 == "")
            {
                MessageBox.Show("注册内容不能为空");
                return;
            }

            if (strPsd != strPsd1)
            {
                MessageBox.Show("两次输入的密码不一样");
                return;
            }

            string strSql = "";

            strSql = "insert into userTable values('" + strID + "','" + strPsd + "','" + strUserName + "','" + strSex + "','" + strShenFen + "','" + strXueLi + "','" + strPhone + "','" + strArea1 + "','" + strArea2 + "','" + strArea3 + "')";
            try
            {

                db.DB_ZSG(strSql);
                db.connClose();
                MessageBox.Show("注册成功");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbPsd.Text = "";
            tbPsd1.Text = "";
            tbUserName.Text = "";
            tbPhone.Text = "";
        }
    }
}
