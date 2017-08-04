using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CertificateProMis
{
    public partial class FmDepartment : Form
    {
        public FmDepartment()
        {
            InitializeComponent();
            label6.Text = "";
            label15.Text = "";
            label7.Text = "";
            label18.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "住房和城乡建设部";
            label15.Text = "国家部级部门";
            label7.Text = "中华人民共和国住房和城乡建设部，\n" +
                "是2008年中央“大部制”改革背景下，新成立的中央部委。是中华人民共和国负责建设行政管理的国务院组成部门。";
            label18.Text = "一级建造师（建筑工程）考试难度 ★★★☆☆☆\n" +
                "一级建造师（公路工程）  考试难度 ★★★☆☆☆\n "+
                "一级建造师（市政公用工程） 考试难度★★★★☆\n "+
                "一级建造师（机电工程）  考试难度 ★★★☆☆☆\n" +
                "一级建造师（矿业工程）  考试难度 ★★★☆☆☆\n" +
                "一级建造师（铁路工程）  考试难度 ★★★☆☆☆\n" +
                "一级建造师（水利水电工程）  考试难度 ★★★☆☆☆ \n" +
                "一级建造师（港口航道工程）  考试难度 ★★★☆☆☆\n";

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "国家发展和改革委员会";
            label15.Text = "国家部级部门";
            label7.Text = "中华人民共和国国家发展和改革委员会，\n" +
                "是综合研究拟订经济和社会发展政策，进行总量平衡，指导总体经济体制改革的宏观调控部门。 "+
                "国家发改委的前身是国家计划委员会，成立于1952年。原国家计划委员会于1998年更名为国家发展计划委员会，"+
                "又于2003年将原国务院体改办和国家经贸委部分职能并入，改组为国家发展和改革委员会，简称国家发改委。";
            label18.Text = "注册咨询工程师\n" +
                "\n " +
                "\n " +
                "\n" +
                "\n" +
                "\n" +
                " \n" +
                "\n";
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "全国外贸职业培训认证办公室";
            label15.Text = "政府行政部门";
            label7.Text = "全国外贸职业培训认证办公室，\n" +
                "（简称‘外贸认证办公室’）是开展外经贸职业人员资格认证的专门执行管理机构，具体承担全国外贸职业人员资格评价及培训认证的组织、实施等各项日常工作。";
            label18.Text = "全国外贸职业人员资格证书\n";
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "中华人民共和国交通运输部";
            label15.Text = "国家部级部门";
            label7.Text = "中华人民共和国交通运输部，\n" +
                "简称交通运输部或交通部，是中华人民共和国国务院组成部门中重要的部委机关。负责优化交通运输布局，发挥整体优势和组合效率，加快形成便捷、通畅、高效、安全的综合运输体系，组建交通运输部。将交通部、中国民用航空总局的职责，建设部的指导城市客运的职责，整合划入该部。交通运输部的主要职责是，拟订并组织实施公路、水陆、民航行业规划、政策和标准，承担涉及综合运输体系的规划协调工作，促进各种运输方式相互衔接等。";
            label18.Text = "注册公路造价工程师（甲级）  考试难度 ★★★☆☆☆";
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "中华人民共和国财政部";
            label15.Text = "国家部级部门";
            label7.Text = "中华人民共和国财政部，\n" +
                "是中华人民共和国负责财务的国务院组成部门。其前身为1949年10月1日成立的中央人民政府财政部。";
            label18.Text = "会计从业资格证书 考试难度 ★☆☆☆☆\n" +
                "注册会计师证书  考试难度 ★★★☆☆☆\n ";
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "中华人民共和国教育部";
            label15.Text = "国家部级部门";
            label7.Text = "中华人民共和国教育部，\n" +
                "是中华人民共和国国务院主管教育事业和语言文字工作的国务院组成部门。教育部现有19个内设司、局，“中国联合国教科文组织全国委员会秘书处”也设在其中。另外，教育部还直接管理15个教育类社会团体和组织。";
            label18.Text = "教师从业资格证 考试难度 ★★★☆☆☆\n";
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "国家环境保护局";
            label15.Text = "国家部级部门";
            label7.Text = "国家环境保护局，\n" +
                "负责拟定国家环境保护的方针、政策和法规，制定行政规章；受国务院委托对重大经济和技术政策、发展规划以及重大经济开发计划进行环境影响评价；拟定国家环境保护规划；组织拟定和监督实施国家确定的重点区域、重点流域污染防治规划和生态保护规划；组织编制环境功能区划。";
            label18.Text = "注册环境影响评价工程师  考试难度 ★★★★☆☆\n";
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "中华人民共和国国家国有资产管理局";
            label15.Text = "国家部级部门";
            label7.Text = "中华人民共和国国家国有资产管理局，\n" +
                " 国家国有资产管理局作为执行国有资产者职能的代表，行使国家赋予的国有资产所有权、监督管理权、国家投资和收益权、资产处置权等职能。";
            label18.Text = "注册资产评估师 考试难度 ★★☆☆☆☆\n";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "国家安全生产监督管理总局";
            label15.Text = "国家部级部门";
            label7.Text = "国家安全生产监督管理总局，\n" +
                "是中华人民共和国国务院直属的正部级行政机构，主要负责安全生产、煤炭矿业安全工作的监察等工作。";
            label18.Text = "注册安全工程师 考试难度 ★★★☆☆☆\n";
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "国际信息化认证协会";
            label15.Text = "非政府机构";
            label7.Text = "国际信息化认证协会，\n" +
                "是由中国政府支持的从事人才培训认证交流活动的非政府机构。国际注册登记号：35244350-001-01-05-4，协会的宗旨是通过国际间人才交流活动，促进中国IT信息化行业与世界各国的交流与合作，推动中国的社会主义经济建设和社会发展以及国际间友好往来。";
            label18.Text = "国际信息化人才资格认证证书\n" ;
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "中华人民共和国劳动和社会保障部";
            label15.Text = "国家部级部门";
            label7.Text = "中华人民共和国劳动和社会保障部，\n" +
                "中华人民共和国劳动和社会保障部于1998年3月在原中华人民共和国劳动部基础上组建。是参与制定中国医改方案的主要机构之一。根据2008年3月全国人民代表大会通过的国务院机构改革方案，劳动保障部与人事部合并为人力资源和社会保障部。";
            label18.Text = "各种行业资格证书\n";
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label6.Text = "国际互联网证书机构CTW";
            label15.Text = "非政府机构";
            label7.Text = "国际互联网证书机构，\n" +
                "CTW证书由以下三个国际性的互联网专家协会认可并签署：国际Webmaster协会(IWA)，互联网专家协会（AIP）及位于欧洲的国际互联网证书机构（ICII）。在国际IT业内，CIW培训倍受推崇,与Intel,HP,IBM有密切的合作关系。";
            label18.Text = "CTW认证证书\n" ;
        }
    }
}
