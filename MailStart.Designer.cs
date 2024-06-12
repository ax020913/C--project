namespace MailForm
{
    partial class MailStart
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.t_stmp = new System.Windows.Forms.TextBox();
            this.t_from = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_pwd = new System.Windows.Forms.TextBox();
            this.t_to = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpb = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.t_files = new System.Windows.Forms.TextBox();
            this.t_body = new System.Windows.Forms.TextBox();
            this.t_subject = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lab_hzcs = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_hz = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.t_number = new System.Windows.Forms.TextBox();
            this.c_start = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gpb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 554);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_stmp
            // 
            this.t_stmp.Location = new System.Drawing.Point(117, 31);
            this.t_stmp.Margin = new System.Windows.Forms.Padding(4);
            this.t_stmp.Name = "t_stmp";
            this.t_stmp.Size = new System.Drawing.Size(192, 25);
            this.t_stmp.TabIndex = 1;
            this.t_stmp.Text = "smtp.163.com";
            // 
            // t_from
            // 
            this.t_from.Location = new System.Drawing.Point(117, 78);
            this.t_from.Margin = new System.Windows.Forms.Padding(4);
            this.t_from.Name = "t_from";
            this.t_from.Size = new System.Drawing.Size(192, 25);
            this.t_from.TabIndex = 2;
            this.t_from.Text = "Shovyaccount@163.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Smtp服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "发件人：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "密码：";
            // 
            // t_pwd
            // 
            this.t_pwd.Location = new System.Drawing.Point(117, 129);
            this.t_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.t_pwd.Name = "t_pwd";
            this.t_pwd.PasswordChar = '#';
            this.t_pwd.Size = new System.Drawing.Size(192, 25);
            this.t_pwd.TabIndex = 10;
            // 
            // t_to
            // 
            this.t_to.Location = new System.Drawing.Point(117, 174);
            this.t_to.Margin = new System.Windows.Forms.Padding(4);
            this.t_to.Name = "t_to";
            this.t_to.Size = new System.Drawing.Size(192, 25);
            this.t_to.TabIndex = 11;
            this.t_to.Text = "289413934@qq.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "收件人：";
            // 
            // gpb
            // 
            this.gpb.Controls.Add(this.label9);
            this.gpb.Controls.Add(this.linkLabel2);
            this.gpb.Controls.Add(this.linkLabel1);
            this.gpb.Controls.Add(this.t_files);
            this.gpb.Controls.Add(this.t_body);
            this.gpb.Controls.Add(this.t_subject);
            this.gpb.Controls.Add(this.label8);
            this.gpb.Controls.Add(this.label7);
            this.gpb.Controls.Add(this.label6);
            this.gpb.Location = new System.Drawing.Point(348, 15);
            this.gpb.Margin = new System.Windows.Forms.Padding(4);
            this.gpb.Name = "gpb";
            this.gpb.Padding = new System.Windows.Forms.Padding(4);
            this.gpb.Size = new System.Drawing.Size(548, 491);
            this.gpb.TabIndex = 13;
            this.gpb.TabStop = false;
            this.gpb.Text = "邮件内容";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 432);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "（可添加多个附件）";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(201, 432);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(37, 15);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "清空";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(145, 432);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(37, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "添加";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // t_files
            // 
            this.t_files.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.t_files.Location = new System.Drawing.Point(145, 398);
            this.t_files.Margin = new System.Windows.Forms.Padding(4);
            this.t_files.Name = "t_files";
            this.t_files.ReadOnly = true;
            this.t_files.Size = new System.Drawing.Size(357, 25);
            this.t_files.TabIndex = 2;
            // 
            // t_body
            // 
            this.t_body.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.t_body.Location = new System.Drawing.Point(99, 89);
            this.t_body.Margin = new System.Windows.Forms.Padding(4);
            this.t_body.Multiline = true;
            this.t_body.Name = "t_body";
            this.t_body.Size = new System.Drawing.Size(404, 286);
            this.t_body.TabIndex = 2;
            // 
            // t_subject
            // 
            this.t_subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.t_subject.Location = new System.Drawing.Point(99, 35);
            this.t_subject.Margin = new System.Windows.Forms.Padding(4);
            this.t_subject.Name = "t_subject";
            this.t_subject.Size = new System.Drawing.Size(404, 25);
            this.t_subject.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 404);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "附件：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "正文：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "标题：";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.t_stmp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.t_from);
            this.groupBox1.Controls.Add(this.t_to);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.t_pwd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(324, 248);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邮件配置";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lab_hzcs);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btn_hz);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.t_number);
            this.groupBox2.Controls.Add(this.c_start);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(324, 236);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "有偿服务";
            // 
            // lab_hzcs
            // 
            this.lab_hzcs.AutoSize = true;
            this.lab_hzcs.Location = new System.Drawing.Point(132, 141);
            this.lab_hzcs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_hzcs.Name = "lab_hzcs";
            this.lab_hzcs.Size = new System.Drawing.Size(15, 15);
            this.lab_hzcs.TabIndex = 15;
            this.lab_hzcs.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "当前已轰炸：";
            // 
            // btn_hz
            // 
            this.btn_hz.Enabled = false;
            this.btn_hz.Location = new System.Drawing.Point(204, 193);
            this.btn_hz.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hz.Name = "btn_hz";
            this.btn_hz.Size = new System.Drawing.Size(105, 35);
            this.btn_hz.TabIndex = 13;
            this.btn_hz.Text = "轰炸";
            this.btn_hz.UseVisualStyleBackColor = true;
            this.btn_hz.Click += new System.EventHandler(this.btn_hz_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "轰炸次数：";
            // 
            // t_number
            // 
            this.t_number.Enabled = false;
            this.t_number.Location = new System.Drawing.Point(131, 82);
            this.t_number.Margin = new System.Windows.Forms.Padding(4);
            this.t_number.MaxLength = 3;
            this.t_number.Name = "t_number";
            this.t_number.Size = new System.Drawing.Size(103, 25);
            this.t_number.TabIndex = 11;
            this.t_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_number_KeyPress);
            // 
            // c_start
            // 
            this.c_start.AutoSize = true;
            this.c_start.Location = new System.Drawing.Point(239, 25);
            this.c_start.Margin = new System.Windows.Forms.Padding(4);
            this.c_start.Name = "c_start";
            this.c_start.Size = new System.Drawing.Size(59, 19);
            this.c_start.TabIndex = 0;
            this.c_start.Text = "启动";
            this.c_start.UseVisualStyleBackColor = true;
            this.c_start.CheckedChanged += new System.EventHandler(this.c_start_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MailStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpb);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MailStart";
            this.Text = "邮箱发送器";
            this.gpb.ResumeLayout(false);
            this.gpb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_stmp;
        private System.Windows.Forms.TextBox t_from;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_pwd;
        private System.Windows.Forms.TextBox t_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox t_files;
        private System.Windows.Forms.TextBox t_body;
        private System.Windows.Forms.TextBox t_subject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox c_start;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox t_number;
        private System.Windows.Forms.Button btn_hz;
        private System.Windows.Forms.Label lab_hzcs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
    }
}

