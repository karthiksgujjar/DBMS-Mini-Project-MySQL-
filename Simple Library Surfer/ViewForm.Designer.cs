namespace Simple_Library_Surfer
{
    partial class ViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.TotalTextLabel = new System.Windows.Forms.Label();
            this.SlNoTitleLabel = new System.Windows.Forms.Label();
            this.NameOfBookTitleLabel = new System.Windows.Forms.Label();
            this.AuthorOfBookTitleLabel = new System.Windows.Forms.Label();
            this.IdOfBookTitleLabel = new System.Windows.Forms.Label();
            this.LibraryDataTable = new System.Windows.Forms.TableLayoutPanel();
            this.ViewFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.GenerateReportButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchedDataTable = new System.Windows.Forms.TableLayoutPanel();
            this.FormMinimizeButton = new System.Windows.Forms.Button();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.SLSHeaderLabel = new System.Windows.Forms.Label();
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
            this.UnderbarLabel1 = new System.Windows.Forms.Label();
            this.LibraryDataTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalTextLabel
            // 
            this.TotalTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalTextLabel.AutoSize = true;
            this.TotalTextLabel.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextLabel.Location = new System.Drawing.Point(291, 128);
            this.TotalTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalTextLabel.Name = "TotalTextLabel";
            this.TotalTextLabel.Size = new System.Drawing.Size(281, 32);
            this.TotalTextLabel.TabIndex = 3;
            this.TotalTextLabel.Text = "All Books in the Library";
            // 
            // SlNoTitleLabel
            // 
            this.SlNoTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SlNoTitleLabel.AutoSize = true;
            this.SlNoTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.SlNoTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlNoTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlNoTitleLabel.Location = new System.Drawing.Point(10, 8);
            this.SlNoTitleLabel.Name = "SlNoTitleLabel";
            this.SlNoTitleLabel.Size = new System.Drawing.Size(65, 22);
            this.SlNoTitleLabel.TabIndex = 0;
            this.SlNoTitleLabel.Text = "Sl. No.";
            this.SlNoTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameOfBookTitleLabel
            // 
            this.NameOfBookTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameOfBookTitleLabel.AutoSize = true;
            this.NameOfBookTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameOfBookTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameOfBookTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfBookTitleLabel.Location = new System.Drawing.Point(181, 8);
            this.NameOfBookTitleLabel.Name = "NameOfBookTitleLabel";
            this.NameOfBookTitleLabel.Size = new System.Drawing.Size(110, 23);
            this.NameOfBookTitleLabel.TabIndex = 0;
            this.NameOfBookTitleLabel.Text = "Book\'s Name";
            this.NameOfBookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorOfBookTitleLabel
            // 
            this.AuthorOfBookTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorOfBookTitleLabel.AutoSize = true;
            this.AuthorOfBookTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorOfBookTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorOfBookTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorOfBookTitleLabel.Location = new System.Drawing.Point(475, 8);
            this.AuthorOfBookTitleLabel.Name = "AuthorOfBookTitleLabel";
            this.AuthorOfBookTitleLabel.Size = new System.Drawing.Size(128, 23);
            this.AuthorOfBookTitleLabel.TabIndex = 0;
            this.AuthorOfBookTitleLabel.Text = "Author\'s Name";
            this.AuthorOfBookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdOfBookTitleLabel
            // 
            this.IdOfBookTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdOfBookTitleLabel.AutoSize = true;
            this.IdOfBookTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.IdOfBookTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdOfBookTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdOfBookTitleLabel.Location = new System.Drawing.Point(735, 8);
            this.IdOfBookTitleLabel.Name = "IdOfBookTitleLabel";
            this.IdOfBookTitleLabel.Size = new System.Drawing.Size(31, 23);
            this.IdOfBookTitleLabel.TabIndex = 0;
            this.IdOfBookTitleLabel.Text = "ID";
            this.IdOfBookTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LibraryDataTable
            // 
            this.LibraryDataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LibraryDataTable.AutoScroll = true;
            this.LibraryDataTable.AutoSize = true;
            this.LibraryDataTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LibraryDataTable.BackColor = System.Drawing.Color.Transparent;
            this.LibraryDataTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.LibraryDataTable.ColumnCount = 4;
            this.LibraryDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.LibraryDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.LibraryDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.LibraryDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.LibraryDataTable.Controls.Add(this.SlNoTitleLabel, 0, 0);
            this.LibraryDataTable.Controls.Add(this.IdOfBookTitleLabel, 3, 0);
            this.LibraryDataTable.Controls.Add(this.NameOfBookTitleLabel, 1, 0);
            this.LibraryDataTable.Controls.Add(this.AuthorOfBookTitleLabel, 2, 0);
            this.LibraryDataTable.Location = new System.Drawing.Point(26, 177);
            this.LibraryDataTable.MaximumSize = new System.Drawing.Size(810, 262);
            this.LibraryDataTable.MinimumSize = new System.Drawing.Size(810, 36);
            this.LibraryDataTable.Name = "LibraryDataTable";
            this.LibraryDataTable.RowCount = 1;
            this.LibraryDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.LibraryDataTable.Size = new System.Drawing.Size(810, 39);
            this.LibraryDataTable.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = global::Simple_Library_Surfer.Properties.Resources.Search;
            this.SearchButton.Location = new System.Drawing.Point(26, 129);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(38, 38);
            this.SearchButton.TabIndex = 6;
            this.ViewFormToolTip.SetToolTip(this.SearchButton, "Search");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateReportButton.FlatAppearance.BorderSize = 0;
            this.GenerateReportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.GenerateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateReportButton.Image = global::Simple_Library_Surfer.Properties.Resources.Report;
            this.GenerateReportButton.Location = new System.Drawing.Point(798, 129);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(38, 38);
            this.GenerateReportButton.TabIndex = 5;
            this.ViewFormToolTip.SetToolTip(this.GenerateReportButton, "Generate Report");
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(78, 143);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(139, 19);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Visible = false;
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // SearchedDataTable
            // 
            this.SearchedDataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchedDataTable.AutoScroll = true;
            this.SearchedDataTable.AutoSize = true;
            this.SearchedDataTable.BackColor = System.Drawing.Color.Transparent;
            this.SearchedDataTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.SearchedDataTable.ColumnCount = 4;
            this.SearchedDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.SearchedDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.SearchedDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.SearchedDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.SearchedDataTable.Location = new System.Drawing.Point(26, 177);
            this.SearchedDataTable.MaximumSize = new System.Drawing.Size(810, 262);
            this.SearchedDataTable.MinimumSize = new System.Drawing.Size(810, 36);
            this.SearchedDataTable.Name = "SearchedDataTable";
            this.SearchedDataTable.RowCount = 1;
            this.SearchedDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.SearchedDataTable.Size = new System.Drawing.Size(810, 42);
            this.SearchedDataTable.TabIndex = 5;
            this.SearchedDataTable.Visible = false;
            // 
            // FormMinimizeButton
            // 
            this.FormMinimizeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormMinimizeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FormMinimizeButton.FlatAppearance.BorderSize = 0;
            this.FormMinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.FormMinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.FormMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormMinimizeButton.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormMinimizeButton.Location = new System.Drawing.Point(809, 0);
            this.FormMinimizeButton.Name = "FormMinimizeButton";
            this.FormMinimizeButton.Size = new System.Drawing.Size(25, 25);
            this.FormMinimizeButton.TabIndex = 14;
            this.FormMinimizeButton.Text = "-";
            this.FormMinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.FormMinimizeButton.UseVisualStyleBackColor = false;
            this.FormMinimizeButton.Click += new System.EventHandler(this.FormMinimizeButton_Click);
            // 
            // FormCloseButton
            // 
            this.FormCloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormCloseButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FormCloseButton.FlatAppearance.BorderSize = 0;
            this.FormCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.FormCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCloseButton.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCloseButton.Location = new System.Drawing.Point(838, 0);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(25, 25);
            this.FormCloseButton.TabIndex = 13;
            this.FormCloseButton.Text = "X";
            this.FormCloseButton.UseVisualStyleBackColor = false;
            this.FormCloseButton.Click += new System.EventHandler(this.FormCloseButton_Click);
            // 
            // SLSHeaderLabel
            // 
            this.SLSHeaderLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SLSHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SLSHeaderLabel.Image = global::Simple_Library_Surfer.Properties.Resources.SLS_Image_Icon;
            this.SLSHeaderLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SLSHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.SLSHeaderLabel.Name = "SLSHeaderLabel";
            this.SLSHeaderLabel.Size = new System.Drawing.Size(863, 25);
            this.SLSHeaderLabel.TabIndex = 12;
            this.SLSHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ProjectTitleLabel
            // 
            this.ProjectTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProjectTitleLabel.Font = new System.Drawing.Font("AR DARLING", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ProjectTitleLabel.Location = new System.Drawing.Point(131, 27);
            this.ProjectTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProjectTitleLabel.Name = "ProjectTitleLabel";
            this.ProjectTitleLabel.Size = new System.Drawing.Size(600, 48);
            this.ProjectTitleLabel.TabIndex = 11;
            this.ProjectTitleLabel.Text = "SIMPLE LIBRARY SURFER";
            this.ProjectTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UnderbarLabel1
            // 
            this.UnderbarLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.UnderbarLabel1.Location = new System.Drawing.Point(78, 165);
            this.UnderbarLabel1.Name = "UnderbarLabel1";
            this.UnderbarLabel1.Size = new System.Drawing.Size(139, 1);
            this.UnderbarLabel1.TabIndex = 15;
            this.UnderbarLabel1.Visible = false;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 444);
            this.ControlBox = false;
            this.Controls.Add(this.UnderbarLabel1);
            this.Controls.Add(this.FormMinimizeButton);
            this.Controls.Add(this.FormCloseButton);
            this.Controls.Add(this.SLSHeaderLabel);
            this.Controls.Add(this.ProjectTitleLabel);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.TotalTextLabel);
            this.Controls.Add(this.SearchedDataTable);
            this.Controls.Add(this.LibraryDataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "S L S";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            this.LibraryDataTable.ResumeLayout(false);
            this.LibraryDataTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TotalTextLabel;
        private System.Windows.Forms.Label SlNoTitleLabel;
        private System.Windows.Forms.Label NameOfBookTitleLabel;
        private System.Windows.Forms.Label AuthorOfBookTitleLabel;
        private System.Windows.Forms.Label IdOfBookTitleLabel;
        private System.Windows.Forms.TableLayoutPanel LibraryDataTable;
        private System.Windows.Forms.Button GenerateReportButton;
        private System.Windows.Forms.ToolTip ViewFormToolTip;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.TableLayoutPanel SearchedDataTable;
        private System.Windows.Forms.Button FormMinimizeButton;
        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.Label SLSHeaderLabel;
        private System.Windows.Forms.Label ProjectTitleLabel;
        private System.Windows.Forms.Label UnderbarLabel1;
    }
}