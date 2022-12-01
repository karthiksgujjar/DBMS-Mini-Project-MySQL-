using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Library_Surfer
{
    public partial class GetDBDetails : Form
    {
        public GetDBDetails()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ServerNameTB.Text == "" || UserNameTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Please Enter All Fileds", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Properties.Settings.Default.constring =
               "SERVER=" + ServerNameTB.Text + ";USERID=" + UserNameTB.Text + ";PASSWORD=" + PasswordTB.Text + ";";

                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                string CreateDB_UseDB_CreateTable_Query = "CREATE DATABASE SLS_DB;" +
                                                          "USE SLS_DB;" +
                                        "CREATE TABLE Library(name varchar(255) not null, author varchar(255) not null,         id int not null, primary key(id));";
                MySqlCommand cmd = new MySqlCommand(CreateDB_UseDB_CreateTable_Query, con);

                //string constring = "SERVER=localhost;DATABASE=DBMS_Mini_Project;USERID=SLS;PASSWORD=sls@123;"
                try
                {
                    con.Open();
                    int res = cmd.ExecuteNonQuery();

                    if (res == 1)
                    {
                        MessageBox.Show("Successfully Connected to the Server!!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Properties.Settings.Default.constring = "SERVER=" + ServerNameTB.Text + ";DATABASE=SLS_DB" + ";USERID=" + UserNameTB.Text + ";PASSWORD=" + PasswordTB.Text + ";";
                        Properties.Settings.Default.Save();
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    if(Err.Message.Contains("exists"))
                    {
                        Properties.Settings.Default.constring = "SERVER=" + ServerNameTB.Text + ";DATABASE=SLS_DB" + ";USERID=" + UserNameTB.Text + ";PASSWORD=" + PasswordTB.Text + ";";
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        MessageBox.Show("Unable to Connect to the Server\n" + Err.Message, "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                this.Close();
            }
        }

        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
