namespace CertificateProMis
{
    partial class FmLesson
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLesson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbQuaName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TbQuaName = new System.Windows.Forms.TextBox();
            this.CbAllType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LbQuaAttention = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LbQuaCourse = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.LbQuaRequirement = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LbQuaCandidate = new System.Windows.Forms.Label();
            this.LbQuaCost = new System.Windows.Forms.Label();
            this.LbQuaTime = new System.Windows.Forms.Label();
            this.LbQuaType = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.LaLessonName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbQuaName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TbQuaName);
            this.panel1.Controls.Add(this.CbAllType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 436);
            this.panel1.TabIndex = 19;
            // 
            // CbQuaName
            // 
            this.CbQuaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbQuaName.FormattingEnabled = true;
            this.CbQuaName.Location = new System.Drawing.Point(47, 175);
            this.CbQuaName.Name = "CbQuaName";
            this.CbQuaName.Size = new System.Drawing.Size(159, 23);
            this.CbQuaName.TabIndex = 27;
            this.CbQuaName.SelectedIndexChanged += new System.EventHandler(this.CbQuaName_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(47, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 34);
            this.button1.TabIndex = 26;
            this.button1.Text = "搜    索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbQuaName
            // 
            this.TbQuaName.Location = new System.Drawing.Point(47, 257);
            this.TbQuaName.Name = "TbQuaName";
            this.TbQuaName.Size = new System.Drawing.Size(159, 25);
            this.TbQuaName.TabIndex = 25;
            this.TbQuaName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CbAllType
            // 
            this.CbAllType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAllType.FormattingEnabled = true;
            this.CbAllType.Items.AddRange(new object[] {
            "土木培训",
            "建筑培训",
            "资格认证",
            "职业培训",
            "IT培训",
            "机械培训",
            "语言培训",
            "电气培训",
            "化学培训",
            "医药培训",
            "财经培训",
            "学历培训"});
            this.CbAllType.Location = new System.Drawing.Point(47, 94);
            this.CbAllType.Name = "CbAllType";
            this.CbAllType.Size = new System.Drawing.Size(159, 23);
            this.CbAllType.TabIndex = 23;
            this.CbAllType.SelectedIndexChanged += new System.EventHandler(this.CbAllType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(46, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "按课程类别搜索";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.label64);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.LaLessonName);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(246, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 674);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程详细信息";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.LbQuaAttention);
            this.panel4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel4.Location = new System.Drawing.Point(40, 510);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(773, 146);
            this.panel4.TabIndex = 18;
            // 
            // LbQuaAttention
            // 
            this.LbQuaAttention.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.LbQuaAttention.Location = new System.Drawing.Point(14, 16);
            this.LbQuaAttention.Name = "LbQuaAttention";
            this.LbQuaAttention.Size = new System.Drawing.Size(735, 114);
            this.LbQuaAttention.TabIndex = 0;
            this.LbQuaAttention.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(36, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "注意事项:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.LbQuaCourse);
            this.panel3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3.Location = new System.Drawing.Point(40, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 121);
            this.panel3.TabIndex = 19;
            // 
            // LbQuaCourse
            // 
            this.LbQuaCourse.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.LbQuaCourse.Location = new System.Drawing.Point(14, 16);
            this.LbQuaCourse.Name = "LbQuaCourse";
            this.LbQuaCourse.Size = new System.Drawing.Size(735, 84);
            this.LbQuaCourse.TabIndex = 0;
            this.LbQuaCourse.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(36, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "考试科目:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel10.Controls.Add(this.LbQuaRequirement);
            this.panel10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel10.Location = new System.Drawing.Point(40, 191);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(773, 118);
            this.panel10.TabIndex = 15;
            // 
            // LbQuaRequirement
            // 
            this.LbQuaRequirement.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.LbQuaRequirement.Location = new System.Drawing.Point(14, 13);
            this.LbQuaRequirement.Name = "LbQuaRequirement";
            this.LbQuaRequirement.Size = new System.Drawing.Size(734, 96);
            this.LbQuaRequirement.TabIndex = 0;
            this.LbQuaRequirement.Text = "label66";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label64.Location = new System.Drawing.Point(36, 161);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(93, 25);
            this.label64.TabIndex = 14;
            this.label64.Text = "报考条件:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel9.Controls.Add(this.LbQuaCandidate);
            this.panel9.Controls.Add(this.LbQuaCost);
            this.panel9.Controls.Add(this.LbQuaTime);
            this.panel9.Controls.Add(this.LbQuaType);
            this.panel9.Controls.Add(this.label63);
            this.panel9.Controls.Add(this.label62);
            this.panel9.Controls.Add(this.label61);
            this.panel9.Controls.Add(this.label60);
            this.panel9.Location = new System.Drawing.Point(40, 51);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(772, 97);
            this.panel9.TabIndex = 13;
            // 
            // LbQuaCandidate
            // 
            this.LbQuaCandidate.AutoSize = true;
            this.LbQuaCandidate.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.LbQuaCandidate.Location = new System.Drawing.Point(134, 57);
            this.LbQuaCandidate.Name = "LbQuaCandidate";
            this.LbQuaCandidate.Size = new System.Drawing.Size(78, 25);
            this.LbQuaCandidate.TabIndex = 7;
            this.LbQuaCandidate.Text = "label18";
            // 
            // LbQuaCost
            // 
            this.LbQuaCost.AutoSize = true;
            this.LbQuaCost.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.LbQuaCost.Location = new System.Drawing.Point(469, 13);
            this.LbQuaCost.Name = "LbQuaCost";
            this.LbQuaCost.Size = new System.Drawing.Size(78, 25);
            this.LbQuaCost.TabIndex = 6;
            this.LbQuaCost.Text = "label17";
            // 
            // LbQuaTime
            // 
            this.LbQuaTime.AutoSize = true;
            this.LbQuaTime.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.LbQuaTime.Location = new System.Drawing.Point(474, 57);
            this.LbQuaTime.Name = "LbQuaTime";
            this.LbQuaTime.Size = new System.Drawing.Size(78, 25);
            this.LbQuaTime.TabIndex = 5;
            this.LbQuaTime.Text = "label16";
            // 
            // LbQuaType
            // 
            this.LbQuaType.AutoSize = true;
            this.LbQuaType.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.LbQuaType.Location = new System.Drawing.Point(134, 13);
            this.LbQuaType.Name = "LbQuaType";
            this.LbQuaType.Size = new System.Drawing.Size(78, 25);
            this.LbQuaType.TabIndex = 4;
            this.LbQuaType.Text = "label15";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label63.Location = new System.Drawing.Point(361, 57);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(107, 25);
            this.label63.TabIndex = 3;
            this.label63.Text = "考试时间：";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label62.Location = new System.Drawing.Point(21, 57);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(107, 25);
            this.label62.TabIndex = 2;
            this.label62.Text = "报考时间：";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label61.Location = new System.Drawing.Point(361, 13);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(107, 25);
            this.label61.TabIndex = 1;
            this.label61.Text = "报考费用：";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label60.Location = new System.Drawing.Point(21, 13);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(107, 25);
            this.label60.TabIndex = 0;
            this.label60.Text = "所属类别：";
            // 
            // LaLessonName
            // 
            this.LaLessonName.AutoSize = true;
            this.LaLessonName.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LaLessonName.Location = new System.Drawing.Point(321, 19);
            this.LaLessonName.Name = "LaLessonName";
            this.LaLessonName.Size = new System.Drawing.Size(160, 24);
            this.LaLessonName.TabIndex = 12;
            this.LaLessonName.Text = "培训课程名称";
            // 
            // FmLesson
            // 
            this.ClientSize = new System.Drawing.Size(1107, 696);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmLesson";
            this.Load += new System.EventHandler(this.FmLesson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TbQuaName;
        private System.Windows.Forms.ComboBox CbAllType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbQuaName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LbQuaAttention;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbQuaCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label LbQuaRequirement;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label LbQuaCandidate;
        private System.Windows.Forms.Label LbQuaCost;
        private System.Windows.Forms.Label LbQuaTime;
        private System.Windows.Forms.Label LbQuaType;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label LaLessonName;
    }
}
