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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            
            string constring = File.ReadAllText("DBConnect.dat");
            MySqlConnection con = new MySqlConnection(constring);
            string query = "INSERT INTO Library values(@NameOfBook,@AuthorOfBook,@IdOfBook)";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                if (NameTB.Text == "" || AuthorTB.Text == "" || IdTB.Text == "")
                {
                    MessageBox.Show("Please Enter All Fields", "EMPTY FIELDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(IdTB.Text);
                        cmd.Parameters.AddWithValue("@NameOfBook", NameTB.Text);
                        cmd.Parameters.AddWithValue("@AuthorOfBook", AuthorTB.Text);
                        cmd.Parameters.AddWithValue("@IdOfBook", IdTB.Text);

                        con.Open();
                        int res = cmd.ExecuteNonQuery();
                        
                        if (res > 0)
                        {
                            MessageBox.Show("Inserted Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Insertion Failed!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        con.Close();
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("Enter only Numbers in ID Field\n", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception Err)
            {
                if (Err.Message.Contains("PRIMARY"))
                {
                    MessageBox.Show("Enter Unique ID.\nID  " + IdTB.Text + "  ALREADY EXISTS!!", "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            NameTB.Text = null;
            AuthorTB.Text=null;
            IdTB.Text=null;
        }
    }
}
