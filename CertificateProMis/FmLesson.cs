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
    public partial class FmLesson : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        string type = "";
        public FmLesson()
        {
            InitializeComponent();
            LbQuaAttention.Text = "";
            LbQuaCandidate.Text = "";
            LbQuaCost.Text = "";
            LbQuaCourse.Text = "";
            LbQuaRequirement.Text = "";
            LbQuaTime.Text = "";
            LbQuaType.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FmLesson_Load(object sender, EventArgs e)
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

        private void CbAllType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                type = CbAllType.Text.Trim();
                CbQuaName.Items.Clear();
                string sql1 = "";
                sql1 = "select QuaName from Qualifications where QuaType = '" + type + "'";
                SqlDataReader dr = db.DB_Red(sql1);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CbQuaName.Items.Add(dr["QuaName"].ToString());
                    }
                    dr.Close();
                    db.connClose();
                }
            }
            catch
            {
                MessageBox.Show("查询失败");
            }
            
        }

        private void CbQuaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "";
            sql1 = "select * from Qualifications where QuaName = '" + CbQuaName.Text + "'";
            try
            {
                SqlDataReader dr = db.DB_Red(sql1);
                dr.Read();
                LbQuaType.Text = dr.GetString(0);
                LaLessonName.Text = dr.GetString(1);
                LbQuaCost.Text = dr.GetString(4);
                LbQuaCandidate.Text = dr.GetString(2);
                LbQuaTime.Text = dr.GetString(5);
                LbQuaRequirement.Text = dr.GetString(3);
                LbQuaCourse.Text = dr.GetString(6);
                LbQuaAttention.Text = dr.GetString(7);
                dr.Close();
            }
            catch
            {
                MessageBox.Show("查询失败!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = "";
            name = TbQuaName.Text.Trim();
            string sql1 = "";
            sql1 = "select * from Qualifications where QuaName = '" + name + "'";


            try
            {
                SqlDataReader dr = db.DB_Red(sql1);
                dr.Read();
                LbQuaType.Text = dr.GetString(0);
                LaLessonName.Text = dr.GetString(1);
                LbQuaCost.Text = dr.GetString(4);
                LbQuaCandidate.Text = dr.GetString(2);
                LbQuaTime.Text = dr.GetString(5);
                LbQuaRequirement.Text = dr.GetString(3);
                LbQuaCourse.Text = dr.GetString(6);
                LbQuaAttention.Text = dr.GetString(7);
                dr.Close();
            }
            catch
            {
                MessageBox.Show("无此数据!");
            }
        }
    }
}
