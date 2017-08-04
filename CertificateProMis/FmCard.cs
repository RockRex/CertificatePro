using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DBCL;
using System.Data.SqlClient;
namespace CertificateProMis
{
    public partial class FmCard : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        
        public FmCard()
        {
            InitializeComponent();
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FmCard_Load(object sender, EventArgs e)
        {

            try
            {
                CbAllType.Items.Clear();
                string sql1 = "";
                sql1 = "select distinct QuaType from Qualifications";
                SqlDataReader dr = db.DB_Red(sql1);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CbAllType.Items.Add(dr["QuaType"].ToString());
                    }
                    dr.Close();
                    db.connClose();
                }
            }
            catch
            {
                MessageBox.Show("窗口加载失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string QuaType = "";
                string QuaName = "";
                string QuaCandidate = "";
                string QuaRequirement = "";
                string QuaCost = "";
                string QuaTime = "";
                string QuaCourse = "";
                string QuaAttention = "";
                QuaType = CbAllType.Text;
                QuaName = textBox7.Text.Trim();
                QuaCandidate = textBox2.Text.Trim();
                QuaRequirement = textBox4.Text.Trim();
                QuaCost = textBox1.Text.Trim();
                QuaTime = textBox3.Text.Trim();
                QuaCourse = textBox5.Text.Trim();
                QuaAttention = textBox6.Text.Trim();


                if (QuaType == "" || QuaName == "" || QuaCandidate == "" || QuaRequirement == "" || QuaCost == "" || QuaTime == "" || QuaCourse == "" || QuaAttention == "" )
                {
                    MessageBox.Show("提交内容不能为空");
                    return;
                }

                string sql1 = "";
                //sql1 = "insert into Users values('5')";
                sql1 = "insert into Qualifications values('" + QuaType + "','" + QuaName + "','" + QuaCandidate + "','" + QuaRequirement + "','" + QuaCost + "','" + QuaTime + "','" + QuaCourse + "','" + QuaAttention + "')";
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
