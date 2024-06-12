using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MailForm
{
    static class Program
    {
        public static int success = 0;//发送成功的个数
        public static int fail = 0;//发送失败的个数
        public static int runing = 0;//运行的线程数

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MailStart());
        }
    }
}
