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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string constring = File.ReadAllText("DBConnect.dat");
            MySqlConnection con = new MySqlConnection(constring);
            string query = "DELETE FROM Library WHERE id = @IdOfBook";
            MySqlCommand cmd = new MySqlCommand(query, con);
            
            try
            {
                if (IdTB.Text == "")
                {
                    MessageBox.Show("Please Enter ID Field", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        Convert.ToInt32(IdTB.Text);
                        cmd.Parameters.AddWithValue("@IdOfBook", IdTB.Text);
                        
                        con.Open();
                        int res = cmd.ExecuteNonQuery();
                        
                        if (res > 0)
                        {
                            MessageBox.Show("Deleted Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFormButton_Click(sender, e);
                            IdTB.Focus();
                        }
                        else
                        {
                            MessageBox.Show("Deletion Failed!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        con.Close();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Enter only Numbers in ID Field\n", "INPUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFormButton_Click(object sender, EventArgs e)
        {
            IdTB.Clear();
            IdTB.Focus();
        }
        private void MasterDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This Action cannot be reversed\nDo you really want to DELETE EVERYTHING?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                string constring = File.ReadAllText("DBConnect.dat");
                MySqlConnection con = new MySqlConnection(constring);
                string query = "DELETE FROM Library";
                MySqlCommand cmd = new MySqlCommand(query, con);

                
                try
                {
                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    
                    if (res > 0)
                    {
                        MessageBox.Show("Deleted Successfully!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFormButton_Click(sender, e);
                        IdTB.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed!", "FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception Err)
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
