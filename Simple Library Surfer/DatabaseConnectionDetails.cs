using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Simple_Library_Surfer
{
    public partial class DatabaseConnectionDetails : Form
    {
        public DatabaseConnectionDetails()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText("DBConnect.dat", "SERVER=" + ServerNameTB.Text + ";DATABASE=" + DatabaseNameTB.Text + ";UID=" + UserNameTB.Text + ";PASSWORD=" + PasswordTB.Text + ";");

            MessageBox.Show("Details Saved Successfully","Database Connection Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            /*string server = "localhost";
            string database = "mysql_test";
            string username = "root";
            string password = "123456";
            string constring = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + username + ";" + "PASSWORD=" + password + ";";*/
        }
    }
}
