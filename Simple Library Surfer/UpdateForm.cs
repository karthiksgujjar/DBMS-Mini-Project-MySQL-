using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Library_Surfer
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        private void FormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FormMinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "UPDATE Library SET name=@NameOfBook,author=@AuthorOfBook,id=@NewIdOfBook WHERE id=@CurrentIdOfBook";
            MySqlCommand cmd = new MySqlCommand(query, con);
            try
            {
                if (NameTB.Text == "" || AuthorTB.Text == "" || CurrentIdTB.Text == "" || NewIdTB.Text == "")
                {
                    MessageBox.Show("Please Enter All Fields", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        if (!(Convert.ToInt32(NewIdTB.Text) > 0) || !(Convert.ToInt32(CurrentIdTB.Text) > 0))
                        {
                            throw new FormatException();
                        }
                        cmd.Parameters.AddWithValue("@NameOfBook", NameTB.Text);
                        cmd.Parameters.AddWithValue("@AuthorOfBook", AuthorTB.Text);
                        cmd.Parameters.AddWithValue("@NewIdOfBook", NewIdTB.Text);
                        cmd.Parameters.AddWithValue("@CurrentIdOfBook", CurrentIdTB.Text);
                        con.Open();
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0)
                        {
                            MessageBox.Show("Updated Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormButton_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Updation Failed!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Enter only Positive Numbers in ID Field\n", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception Err)
            {
                if (Err.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Enter Unique ID in \"New ID\" Field.\nID  " + NewIdTB.Text + "  ALREADY EXISTS!!", "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            NameTB.Clear();
            AuthorTB.Clear();
            CurrentIdTB.Clear();
            NewIdTB.Clear();
            NameTB.Focus();
        }
    }
}
