using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertificateProMis
{
    
    static class Program
    {
       
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmMainMis());
        }
        
    }
    static class Gloable
    {
        public static string username = "您好，请先登录！";
        public static string type = "建工进阶";
        public static string LessonName = "教师资格证";
    }  
}
