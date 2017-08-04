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
    public partial class FmSchool : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        public FmSchool()
        {
            InitializeComponent();
            LbSchoolName.Text = "";
            LbSchoolType.Text = "";
            LbSchoolPassNum.Text = "";
            LbSchoolProvince.Text = "";
            LbSchoolCity.Text = "";
            LbSchoolNote.Text = "";
            LbSchoolPerson.Text = "";
            LbSchoolPhone.Text = "";
            LbSchoolEmail.Text = "";
        }

        private void LbQuaCandidate_Click(object sender, EventArgs e)
        {

        }

        private void FmSchool_Load(object sender, EventArgs e)
        {
            try
            {
                CbSchoolProvince.Items.Clear();
                string sql1 = "";
                sql1 = "select distinct schoolProvince from cardSchool";
                SqlDataReader dr = db.DB_Red(sql1);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CbSchoolProvince.Items.Add(dr["schoolProvince"].ToString());
                    }
                    dr.Close();
                    db.connClose();
                }
            }
            catch
            {
                MessageBox.Show("窗口加载失败!");
            }
            
        }

        private void CbSchoolProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CbSchoolCity.Items.Clear();
                string sql1 = "";
                sql1 = "select schoolCity from cardSchool where schoolProvince = '" + CbSchoolProvince.Text + "'";
                SqlDataReader dr = db.DB_Red(sql1);
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        CbSchoolCity.Items.Add(dr["schoolCity"].ToString());
                    }
                    dr.Close();
                    db.connClose();
                }
            }
            catch
            {
                MessageBox.Show("省区查询失败!");
            }
            
        }

        private void CbSchoolCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "";
            sql1 = "select * from cardSchool where schoolCity = '" + CbSchoolCity.Text + "'";
            try
            {
                SqlDataReader dr = db.DB_Red(sql1);
                dr.Read();
                LbSchoolName.Text = dr.GetString(0);
                LbSchoolPassNum.Text = dr.GetString(1);
                LbSchoolType.Text = dr.GetString(2);
                LbSchoolNote.Text = dr.GetString(3);
                LbSchoolPerson.Text = dr.GetString(4);
                LbSchoolPhone.Text = dr.GetString(5);
                LbSchoolEmail.Text = dr.GetString(6);
                LbSchoolProvince.Text = dr.GetString(7);
                LbSchoolCity.Text = dr.GetString(8);
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
            name = TbSchoolName.Text.Trim();
            string sql1 = "";
            sql1 = "select * from cardSchool where schoolName = '" + name + "'";


            try
            {
                SqlDataReader dr = db.DB_Red(sql1);
                dr.Read();
                LbSchoolName.Text = dr.GetString(0);
                LbSchoolPassNum.Text = dr.GetString(1);
                LbSchoolType.Text = dr.GetString(2);
                LbSchoolNote.Text = dr.GetString(3);
                LbSchoolPerson.Text = dr.GetString(4);
                LbSchoolPhone.Text = dr.GetString(5);
                LbSchoolEmail.Text = dr.GetString(6);
                LbSchoolProvince.Text = dr.GetString(7);
                LbSchoolCity.Text = dr.GetString(8);
                dr.Close();
            }
            catch
            {
                MessageBox.Show("无此数据!");
            }
        }
    }
}
