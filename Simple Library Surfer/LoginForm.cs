using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Simple_Library_Surfer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(UserNameTB.Text))
            {
                MessageBox.Show("Please enter Username!","INPUT ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                UserNameTB.Focus();
            }
            else if (string.IsNullOrEmpty(PasswordTB.Text))
            {
                MessageBox.Show("Please enter Password!", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTB.Focus();
            }
            else
            {
                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                string query = "SELECT * FROM login WHERE username=@UserName and password=@Password";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserName", UserNameTB.Text);
                cmd.Parameters.AddWithValue("@Password", PasswordTB.Text);
                try
                {
                    con.Open();
                    MySqlDataReader userDetails = cmd.ExecuteReader();
                    if (userDetails.HasRows)
                    {
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        mainForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Enter Correct User Credentials","INVALID USER CREDENTIALS",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        UserNameTB.Text = string.Empty;
                        PasswordTB.Text = string.Empty;
                        UserNameTB.Focus();
                    }
                    con.Close();
                }
                catch(Exception Err)
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
