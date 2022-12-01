using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Simple_Library_Surfer
{
    public partial class MainForm : Form
    {
        public MainForm()
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
        
        private void BooksCountUpdate_OnFormActivation(object sender, EventArgs e)
        {
            //string constring = File.ReadAllText("DBConnect.dat");
            
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT count(*) FROM Library";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                /*  MySqlDataReader DataCount = cmd.ExecuteReader();

                    int Count = 0;
                    while (DataCount.Read())
                        Count++;
    */
                int Count = Convert.ToInt32(cmd.ExecuteScalar());
                TotalBooksCountLabel.Text = Count.ToString();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Invalid Database Connection Details.\nPlease Re-Enter Database Connection details for the Application to Run.\n\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                GetDBDetails dBDetails = new GetDBDetails();
                dBDetails.ShowDialog();
            }
            
            
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.ShowDialog();
        }
    }
}
