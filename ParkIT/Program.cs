using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkIT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static Label lblTitle = null;
        
        public static string strConn = "Data Source=sharathkumar;Initial Catalog=db_internproject;Integrated Security=True;";
        public static string currentUserName = "";
        public static string currentPassword = "";
        public static bool isLoggedIn = false;

        public static int currentUserID { get;  set; }
        public static int currentPreUserID { get; set; }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        public static Regex EmailOnly()
        {
            string Email_Pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
    + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
    + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(Email_Pattern, RegexOptions.IgnoreCase);
        }

        public static Regex PasswordOnly()
        {
            string Password_Pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(Password_Pattern, RegexOptions.IgnoreCase);

        }

        public static Regex NumberOnly()
        {
            string Number_Pattern = "^[0-9]*$";

            return new Regex(Number_Pattern, RegexOptions.IgnoreCase);

        }

        public static Regex StringOnly()
        {
            string String_Pattern = "^[a-zA-Z]";

            return new Regex(String_Pattern, RegexOptions.IgnoreCase);

        }


      


    }
}
