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
    public partial class FmMainMis : Form
    {
        DBCL.DataBase db = new DBCL.DataBase();
        
        public FmMainMis()
        {
            InitializeComponent();
            aboutMe.Hide();
            
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainMis_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BnRegistered_Click(object sender, EventArgs e)
        {
            FmRegistered fmRegistered = new FmRegistered();
           
            fmRegistered.Show();
        }

        private void BnLogin_Click(object sender, EventArgs e)
        {
            FmLogin fmLogin = new FmLogin();
            
            fmLogin.Show();
          
            //this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void FmMainMis_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            aboutMe.Hide();
        }

        private void 关于我AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void 考证书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FmIdUp fmIdUp = new FmIdUp();
            fmIdUp.MdiParent = this;
            panel1.Controls.Add(fmIdUp);
            fmIdUp.Show();

        }
        private void 培训机构ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FmSchool fm = new FmSchool();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 证书荟萃ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FmLesson fm = new FmLesson();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 专家名师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FmTeacher fm = new FmTeacher();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 颁证部门ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            panel1.Controls.Clear();
            FmDepartment fm = new FmDepartment();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "资格认证";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 语言培训ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "语言培训";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 电脑培训ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "IT培训";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 学历招生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "学历进阶";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 管理培训ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "医药进修";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 出国留学ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "化工进修";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void iT认证ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "电气培训";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 职业培训ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "职业培训";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 财经培训ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "财经培训";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void BNofficer_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "公考求职";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 艺术健身ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "建工进阶";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 基础教育ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "土木工程";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 少儿培训ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Gloable.type = "机械工程";
            FmLessonShow fm = new FmLessonShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void FmMainMis_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutMe.Show();
        }

        private void 个人中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FmPerson fm = new FmPerson();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void 新添课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FmCard fm = new FmCard();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gloable.LessonName = textBox1.Text.Trim();
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "公务员考试";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "二级建造师";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Gloable.LessonName = "教师资格证";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "教师资格证";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "公共营养师";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "注册会计师";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "注册会计师";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "心理咨询师";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "人力资源管理师";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "证券从业资格证";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "注册会计师";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "法律职业资格证（司法考试）";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "事业单位招聘考试";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "考研";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gloable.LessonName = "考研";
            panelIndex.Hide();
            FmCardShow fm = new FmCardShow();
            fm.MdiParent = this;
            panel1.Controls.Add(fm);
            fm.Show();
        }

        private void FmMainMis_Paint(object sender, PaintEventArgs e)
        {
           
        }
   
    }
}
