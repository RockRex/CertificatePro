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
using System.Data.SqlClient;

namespace CertificateProMis
{
    public partial class FmPerson : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        string username = "";
        
        public FmPerson()
        {
            try
            {
                string strSql = "";
                strSql = "select * from Users";
                username = db.DB_C(strSql, 0);
            }
            catch
            {
                MessageBox.Show("获取用户名失败！");
            }
            
            InitializeComponent();
            LbMess.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 2;
        }

        private void BackShowUser()
        {
            string strSql1 = "select * from userTable where userID = '" + username + "'";
            SqlDataReader dr1;
            dr1 = db.DB_Red(strSql1);
            dr1.Read();
            tbUserName.Text = dr1.GetString(2);
            comboBox1.Text = dr1.GetString(4);
            comboBox2.Text = dr1.GetString(5);
            tbPhone.Text = dr1.GetString(6);
            comboBox3.Text = dr1.GetString(7);
            comboBox4.Text = dr1.GetString(8);
            comboBox5.Text = dr1.GetString(9);
            dr1.Close();
        }
        private void BackShowUp1()
        {
            string sql = "select * from signUp where upID='" + username + "'";
            SqlDataReader dr;
            dr = db.DB_Red(sql);
            dr.Read();
            comboBox8.Text = dr.GetString(4);
            comboBox7.Text = dr.GetString(5);
            comboBox12.Text = dr.GetString(6);
            textBox5.Text = dr.GetString(7);
            textBox3.Text = dr.GetString(8);
            textBox9.Text = dr.GetString(9);
            comboBox10.Text = dr.GetString(10);
            comboBox9.Text = dr.GetString(11);
            comboBox6.Text = dr.GetString(12);
            textBox10.Text = dr.GetString(13);
        }
        private void BackShowUp2()
        {
            //MessageBox.Show("获取用户名失败！");
            LbMess.Text = "用户尚未提交过报考表单！";
            comboBox8.Text = "";
            comboBox7.Text = "";
            comboBox12.Text = "";
            textBox5.Text = "";
            textBox3.Text = "";
            textBox9.Text = "";
            comboBox10.Text = "";
            comboBox9.Text = "";
            comboBox6.Text = "";
            textBox10.Text = "";
        }
        private void panelPerson_Paint(object sender, PaintEventArgs e)
        {
            textBox6.PasswordChar = '*';
            textBox7.PasswordChar = '*';
            try
            {
                BackShowUser();
            }
            catch
            {
                DialogResult dir;
                dir = MessageBox.Show("会员信息获取失败，是否继续？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dir == DialogResult.OK)
                {
                    tbUserName.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    tbPhone.Text = "";
                    comboBox3.Text = "";
                    comboBox4.Text = "";
                    comboBox5.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
            try
            {
                BackShowUp1();
            }
            catch
            {
                BackShowUp2();
               
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("性别不能为空");
                return;
            }
            string strSql = "";
            if (radioButton1.Checked == true)
            {
                strSql = "update userTable set userName = '" + tbUserName.Text.Trim() + "',userSex='" + radioButton1.Text + "',userIdent='" + comboBox1.Text + "',userDiploma='" + comboBox2.Text + "',userPhone='" + tbPhone.Text.Trim() + "',userAddProvince='" + comboBox3.Text + "',userAddCity='" + comboBox4.Text + "',userAddArea='" + comboBox5.Text + "' where userID = '" + username + "'";
            }
            else if (radioButton2.Checked == true)
            {
                strSql = "update userTable set userName = '" + tbUserName.Text.Trim() + "',userSex='" + radioButton2.Text + "',userIdent='" + comboBox1.Text + "',userDiploma='" + comboBox2.Text + "',userPhone='" + tbPhone.Text.Trim() + "',userAddProvince='" + comboBox3.Text + "',userAddCity='" + comboBox4.Text + "',userAddArea='" + comboBox5.Text + "' where userID = '" + username + "'";
            }
            try
            {
                db.DB_ZSG(strSql);
                MessageBox.Show("修改成功");
            }
            catch
            {
                MessageBox.Show("修改失败!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!textBox6.Text.Trim().Equals(textBox7.Text.Trim()))
            {
                MessageBox.Show("两次输入的密码不一致");
                textBox6.Text = "";
                textBox7.Text = "";
                textBox7.Focus();
                return;
            }
            string sql1 = "";
            sql1 = "update userTable set userPwd = '" + textBox6.Text.Trim() + "'";
            try
            {
                db.DB_ZSG(sql1);
                textBox6.Text = "";
                textBox7.Text = "";
                MessageBox.Show("修改成功");
            }
            catch
            {
                MessageBox.Show("修改失败");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql1 = "";
            sql1 = "update signUp set upCardClass='" + comboBox8.Text + "',upCard='" + comboBox7.Text + "',upSchool='" + comboBox12.Text + "',upIdNum='" + textBox5.Text.Trim() + "',upTel='" + textBox3.Text.Trim() + "',upPhone='" + textBox9.Text.Trim() + "',upAddProvince='" + comboBox10.Text + "',upAddCity='" + comboBox9.Text + "',upAddArea='" + comboBox6.Text + "',upNote='" + textBox10.Text.Trim() + "' where upID='" + username + "'";
            db.DB_ZSG(sql1);
            MessageBox.Show("修改成功");
        }
    }
}
