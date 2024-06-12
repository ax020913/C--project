using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;

namespace MailForm
{
    public partial class MailStart : Form
    {
        public static string Numbers = "0";
        public ArrayList paths = new ArrayList();//保存附件地址

        public MailStart()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e){
            if (check()){
                mailunit mu = new mailunit(t_stmp.Text, t_from.Text, t_pwd.Text, t_to.Text, t_subject.Text, t_body.Text, paths);
                mu.SendMail();
            }
        }

        private void NewMethod(){
            for (int i = 0; i < Convert.ToInt32(t_number.Text); i++){
                Numbers = (Convert.ToInt32(Numbers) + 1).ToString();
                mailunit mu = new mailunit(t_stmp.Text, t_from.Text, t_pwd.Text, t_to.Text, t_subject.Text, t_body.Text, paths);
                mu.SendMail_1();
            }
            MessageBox.Show("发送完毕！");
            Thread.CurrentThread.Abort();
        }

        /// <summary>
        /// 添加附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            openFileDialog1.Filter = "所有文件(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                string[] files = openFileDialog1.FileNames;
                foreach (string file in files){
                    paths.Add(file);
                    t_files.Text += Path.GetFileName(file) + "  ";
                }
            }
        }
        /// <summary>
        /// 点击清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            t_files.Text = string.Empty;
            paths.Clear();
        }


        /*检查输入参数*/
        public bool check(){
            string err = "注意：\n\n";
            int errCount = 0;
            if (t_stmp.Text.Trim().Length == 0){
                err += "Smtp服务器地址不能为空！\r\n";
                errCount++;
            }
            if (t_from.Text.Trim().Length == 0){
                err += "用户名不能为空！\r\n";
                errCount++;
            }
            if (t_pwd.Text.Trim().Length == 0){
                err += "密码不能为空！\r\n";
                errCount++;
            }
            if (t_subject.Text.Trim().Length == 0){
                err += "标题不能为空！\r\n";
                errCount++;
            }
            if (t_to.Text.Trim().Length == 0){
                err += "收件人不能为空！\r\n";
                errCount++;
            }
            if (t_body.Text.Trim().Length == 0){
                err += "正文不能为空！\r\n";
                errCount++;
            }
            Regex myreg = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"); //email验证
            //if (!myreg.IsMatch(t_from.Text))
            //{
            //    err += "用户名格式不正确！\r\n";
            //    errCount++;
            //}
            //看还有没有其他需要验证的
            if (errCount == 0)
                return true;
            else{
                MessageBox.Show(err, "提示");
                return false;
            }
        }

        /// <summary>
        /// 点击启动特殊服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c_start_CheckedChanged(object sender, EventArgs e){
            t_number.Enabled = false;
            btn_hz.Enabled = false;
            if (c_start.Checked){
                t_number.Enabled = true;
                btn_hz.Enabled = true;
            }
        }

        /// <summary>
        /// 点击轰炸
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_hz_Click(object sender, EventArgs e){
            if (check()){
                Thread mythread = new Thread(new ThreadStart(NewMethod));
                mythread.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e){
            lab_hzcs.Text = Numbers + " 次";
        }
        /// <summary>
        /// 键盘绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_number_KeyPress(object sender, KeyPressEventArgs e){
            int key = Convert.ToInt32(e.KeyChar);
            if ((key >= 48 && key <= 57))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
