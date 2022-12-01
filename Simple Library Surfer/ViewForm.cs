using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.Runtime.InteropServices;
using iText.Layout.Borders;
using iText.Kernel.Geom;
using System.Collections;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics;

namespace Simple_Library_Surfer
{
    public partial class ViewForm : Form
    {
        public ViewForm()
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
        
        private void ViewForm_Load(object sender, EventArgs e)
        {
            //string constring = Properties.Settings.Default.constring;
            MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
            string query = "SELECT * FROM Library";
            MySqlCommand cmd = new MySqlCommand(query, con);

            try
            {
                con.Open();
                MySqlDataReader LibraryData = cmd.ExecuteReader();

                int Count = 0;

                while (LibraryData.Read())
                {
                    Count++;

                    LibraryDataTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    LibraryDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
                    LibraryDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
                    LibraryDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
                    LibraryDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));

                    Label slno = new Label();
                    slno.Text = Count.ToString();
                    LabelPropertiesSet(slno);
                    LibraryDataTable.Controls.Add(slno, 0, Count);

                    Label name = new Label();
                    name.Text = LibraryData["name"].ToString();
                    LabelPropertiesSet(name);
                    LibraryDataTable.Controls.Add(name, 1, Count);

                    Label author = new Label();
                    author.Text = LibraryData["author"].ToString();
                    LabelPropertiesSet(author);
                    LibraryDataTable.Controls.Add(author, 2, Count);

                    Label id = new Label();
                    id.Text = LibraryData["id"].ToString();
                    LabelPropertiesSet(id);
                    LibraryDataTable.Controls.Add(id, 3, Count);
                }
                con.Close();
            }
            catch (Exception Err)
            {
                MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LabelPropertiesSet(Label x)
        {
            x.AutoSize = true;
            x.Font = new Font("Comic Sans MS", 12, FontStyle.Italic);
            x.Anchor = AnchorStyles.None;
            x.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Report";
            sfd.DefaultExt = ".pdf";
            sfd.Filter = "(*.pdf)|*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PdfWriter writer = new PdfWriter(sfd.FileName);
                PdfDocument pdf = new PdfDocument(writer);
                Document doc = new Document(pdf, PageSize.A4);
                PdfFont BoldItalic = PdfFontFactory.CreateFont(StandardFonts.COURIER_BOLDOBLIQUE);
                PdfFont Italic = PdfFontFactory.CreateFont(StandardFonts.COURIER_OBLIQUE);


                Paragraph Title = new Paragraph("SIMPLE LIBRARY SURFER").SetFont(BoldItalic).SetTextAlignment(TextAlignment.CENTER).SetFontSize(30).SetFontColor(ColorConstants.ORANGE);
                doc.Add(Title);

                Paragraph SubTitle = new Paragraph("-- ALL BOOKS IN THE LIBRARY --").SetFont(BoldItalic).SetTextAlignment(TextAlignment.CENTER).SetFontSize(15).SetBold();
                doc.Add(SubTitle);

                LineSeparator ls = new LineSeparator(new SolidLine());
                doc.Add(ls);

                Paragraph NewLine = new Paragraph("\n");
                doc.Add(NewLine);

                Table PdfTable = new Table(4, true);

                Cell RTSlNo = new Cell(1,1).SetFont(BoldItalic).SetBackgroundColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Sl. No."));

                Cell RTName = new Cell(1, 1).SetFont(BoldItalic).SetBackgroundColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Name of Book"));

                Cell RTAuthor = new Cell(1, 1).SetFont(BoldItalic).SetBackgroundColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("Author of Book"));

                Cell RTID = new Cell(1, 1).SetFont(BoldItalic).SetBackgroundColor(ColorConstants.DARK_GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph("ID"));

                PdfTable.AddCell(RTSlNo);
                PdfTable.AddCell(RTName);
                PdfTable.AddCell(RTAuthor);
                PdfTable.AddCell(RTID);

                try
                {
                    //string constring = File.ReadAllText("DBConnect.dat");
                    MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                    string query = "SELECT * FROM Library";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();
                    MySqlDataReader LibraryData = cmd.ExecuteReader();

                    int Count = 0;

                    while (LibraryData.Read())
                    {
                        Count++;

                        Cell RDSlNo = new Cell(1, 1).SetFont(Italic).SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(Count.ToString()));
                        Cell RDName = new Cell(1, 1).SetFont(Italic).SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(LibraryData["name"].ToString()));
                        Cell RDAuthor = new Cell(1, 1).SetFont(Italic).SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(LibraryData["author"].ToString()));
                        Cell RDID = new Cell(1, 1).SetFont(Italic).SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetTextAlignment(TextAlignment.CENTER).Add(new Paragraph(LibraryData["id"].ToString()));

                        PdfTable.AddCell(RDSlNo);
                        PdfTable.AddCell(RDName);
                        PdfTable.AddCell(RDAuthor);
                        PdfTable.AddCell(RDID);
                    }
                    con.Close();
                    doc.Add(PdfTable);
                    doc.Close();
                    MessageBox.Show("Report Successfully Generated!!","SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Process.Start(sfd.FileName);
                }
                catch (Exception Err)
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Visible = true;
            UnderbarLabel1.Visible = true;
            SearchTextBox.Focus();
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13 && !string.IsNullOrEmpty(SearchTextBox.Text))
            {
                e.Handled = true;
                MySqlConnection con = new MySqlConnection(Properties.Settings.Default.constring);
                string query = "SELECT * FROM Library";
                MySqlCommand cmd = new MySqlCommand(query, con);

                SearchedDataTable.Controls.Clear();

                try
                {
                    con.Open();
                    MySqlDataReader SeacrhedLibraryData = cmd.ExecuteReader();

                    int Count = 0;

                    Label SlNoTitleLabel = new Label();
                    SlNoTitleLabel.Text = "Sl. No.";
                    LabelPropertiesSet(SlNoTitleLabel);
                    SlNoTitleLabel.Font = new Font("Comic Sans MS", 12, FontStyle.Bold | FontStyle.Italic);
                    SearchedDataTable.Controls.Add(SlNoTitleLabel, 0, Count);

                    Label NameTitleLabel = new Label();
                    NameTitleLabel.Text = "Book's Name";
                    LabelPropertiesSet(NameTitleLabel);
                    NameTitleLabel.Font = new Font("Comic Sans MS", 12, FontStyle.Bold | FontStyle.Italic);
                    SearchedDataTable.Controls.Add(NameTitleLabel, 1, Count);

                    Label AuthorTitleLabel = new Label();
                    AuthorTitleLabel.Text = "Author's Name";
                    LabelPropertiesSet(AuthorTitleLabel);
                    AuthorTitleLabel.Font = new Font("Comic Sans MS", 12, FontStyle.Bold | FontStyle.Italic);
                    SearchedDataTable.Controls.Add(AuthorTitleLabel, 2, Count);

                    Label IdTitleLabel = new Label();
                    IdTitleLabel.Text = "ID";
                    LabelPropertiesSet(IdTitleLabel);
                    IdTitleLabel.Font = new Font("Comic Sans MS", 12, FontStyle.Bold | FontStyle.Italic);
                    SearchedDataTable.Controls.Add(IdTitleLabel, 3, Count);

                    while (SeacrhedLibraryData.Read())
                    {
                        if (SeacrhedLibraryData["name"].ToString().Contains(SearchTextBox.Text) || SeacrhedLibraryData["author"].ToString().Contains(SearchTextBox.Text) || SeacrhedLibraryData["id"].ToString().Contains(SearchTextBox.Text))
                        {
                            Count++;

                            SearchedDataTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                            SearchedDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
                            SearchedDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
                            SearchedDataTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));

                            Label slno = new Label();
                            slno.Text = Count.ToString();
                            LabelPropertiesSet(slno);
                            SearchedDataTable.Controls.Add(slno, 0, Count);

                            Label name = new Label();
                            name.Text = SeacrhedLibraryData["name"].ToString();
                            LabelPropertiesSet(name);
                            SearchedDataTable.Controls.Add(name, 1, Count);

                            Label author = new Label();
                            author.Text = SeacrhedLibraryData["author"].ToString();
                            LabelPropertiesSet(author);
                            SearchedDataTable.Controls.Add(author, 2, Count);

                            Label id = new Label();
                            id.Text = SeacrhedLibraryData["id"].ToString();
                            LabelPropertiesSet(id);
                            SearchedDataTable.Controls.Add(id, 3, Count);
                        }
                    }
                    con.Close();
                    LibraryDataTable.Hide();
                    SearchedDataTable.Visible = true;
                }
                catch (Exception Err)
                {
                    MessageBox.Show("- Error -\n" + Err.Message, "DATABASE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if(e.KeyChar == 13 && string.IsNullOrEmpty(SearchTextBox.Text))
            {
                e.Handled = true;
                LibraryDataTable.Show();
                SearchedDataTable.Visible = false;
                UnderbarLabel1.Visible = false;
                SearchTextBox.Visible = false;
            }
            
        }

    }
}
