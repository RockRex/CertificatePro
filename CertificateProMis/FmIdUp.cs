using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DBCL;

namespace CertificateProMis
{
    public partial class FmIdUp : Form
    {
        
        string username = "";
        public FmIdUp()
        {
            try
            {
                DBCL.DataBase db = new DBCL.DataBase();
                string strSql = "";
                strSql = "select * from Users";
                username = db.DB_C(strSql, 0);
                db.odrClose();
                db.connClose();
            
            }
            catch
            {
                MessageBox.Show("窗口初始化失败");
            }
            
            InitializeComponent();
        }

        private void FmIdUp_Load(object sender, EventArgs e)
        {
            try
            {
                DBCL.DataBase db = new DBCL.DataBase();
                string sql = "select * from userTable where userID = '" + username + "'";
                textBox1.Text = db.DB_C(sql, 2);
                comboBox2.Text = db.DB_C(sql, 5);
                db.odrClose();
                db.connClose();
            }
            catch
            {
                MessageBox.Show("窗口加载失败");
            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DBCL.DataBase db = new DBCL.DataBase();

                string name = "";
                string sex = "";
                string diploma = "";
                string cardclass = "";
                string card = "";
                string school = "";
                string idnum = "";
                string tel = "";
                string tel1 = "";
                string tel2 = "";
                string phone = "";
                string province = "";
                string city = "";
                string area = "";
                string note = "";

                name = textBox1.Text;
                if (radioButton1.Checked == true)
                {
                    sex = radioButton1.Text;
                }
                else if (radioButton2.Checked == false)
                {
                    sex = radioButton2.Text;
                }
                diploma = comboBox2.Text;
                cardclass = comboBox8.Text;
                card = comboBox7.Text;
                school = comboBox1.Text;
                idnum = textBox7.Text.Trim();
                tel1 = textBox6.Text.Trim();
                tel2 = textBox3.Text.Trim();
                tel = tel1 + tel2;
                phone = textBox4.Text.Trim();
                province = comboBox3.Text;
                city = comboBox4.Text;
                area = comboBox5.Text;
                note = textBox2.Text.Trim();

                if (sex == "" || cardclass == "" || card == "" || idnum == "" || phone == "" || province == "" || city == "" || area == "" || note == "")
                {
                    MessageBox.Show("提交内容不能为空");
                    return;
                }

                string sql1 = "";
                //sql1 = "insert into Users values('5')";
                sql1 = "insert into signUp values('" + username + "','" + name + "','" + sex + "','" + diploma + "','" + cardclass + "','" + card + "','" + school + "','" + idnum + "','" + tel + "','" + phone + "','" + province + "','" + city + "','" + area + "','" + note + "')";
                db.DB_ZSG(sql1);
                db.connClose();
                MessageBox.Show("提交成功");
            }
            catch
            {
                MessageBox.Show("信息提交异常");
            }
            
        }
    }
}
