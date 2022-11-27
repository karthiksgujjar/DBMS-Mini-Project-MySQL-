﻿namespace Simple_Library_Surfer
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
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
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
            this.LibraryDataTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProjectTitleLabel
            // 
            this.ProjectTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectTitleLabel.AutoSize = true;
            this.ProjectTitleLabel.Font = new System.Drawing.Font("AR DARLING", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ProjectTitleLabel.Location = new System.Drawing.Point(173, 0);
            this.ProjectTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProjectTitleLabel.Name = "ProjectTitleLabel";
            this.ProjectTitleLabel.Size = new System.Drawing.Size(516, 47);
            this.ProjectTitleLabel.TabIndex = 2;
            this.ProjectTitleLabel.Text = "SIMPLE LIBRARY SURFER";
            this.ProjectTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalTextLabel
            // 
            this.TotalTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalTextLabel.AutoSize = true;
            this.TotalTextLabel.Font = new System.Drawing.Font("Comic Sans MS", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextLabel.Location = new System.Drawing.Point(286, 74);
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
            this.SlNoTitleLabel.BackColor = System.Drawing.Color.DarkGray;
            this.SlNoTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlNoTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlNoTitleLabel.Location = new System.Drawing.Point(10, 7);
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
            this.NameOfBookTitleLabel.BackColor = System.Drawing.Color.DarkGray;
            this.NameOfBookTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NameOfBookTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameOfBookTitleLabel.Location = new System.Drawing.Point(181, 6);
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
            this.AuthorOfBookTitleLabel.BackColor = System.Drawing.Color.DarkGray;
            this.AuthorOfBookTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorOfBookTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorOfBookTitleLabel.Location = new System.Drawing.Point(475, 6);
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
            this.IdOfBookTitleLabel.BackColor = System.Drawing.Color.DarkGray;
            this.IdOfBookTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdOfBookTitleLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdOfBookTitleLabel.Location = new System.Drawing.Point(734, 6);
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
            this.LibraryDataTable.BackColor = System.Drawing.Color.DarkGray;
            this.LibraryDataTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.LibraryDataTable.ColumnCount = 4;
            this.LibraryDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.LibraryDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.LibraryDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.LibraryDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.LibraryDataTable.Controls.Add(this.SlNoTitleLabel, 0, 0);
            this.LibraryDataTable.Controls.Add(this.IdOfBookTitleLabel, 3, 0);
            this.LibraryDataTable.Controls.Add(this.NameOfBookTitleLabel, 1, 0);
            this.LibraryDataTable.Controls.Add(this.AuthorOfBookTitleLabel, 2, 0);
            this.LibraryDataTable.Location = new System.Drawing.Point(21, 123);
            this.LibraryDataTable.MaximumSize = new System.Drawing.Size(810, 262);
            this.LibraryDataTable.MinimumSize = new System.Drawing.Size(810, 36);
            this.LibraryDataTable.Name = "LibraryDataTable";
            this.LibraryDataTable.RowCount = 1;
            this.LibraryDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LibraryDataTable.Size = new System.Drawing.Size(810, 36);
            this.LibraryDataTable.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = global::Simple_Library_Surfer.Properties.Resources.Search;
            this.SearchButton.Location = new System.Drawing.Point(21, 75);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(38, 38);
            this.SearchButton.TabIndex = 6;
            this.ViewFormToolTip.SetToolTip(this.SearchButton, "Generate Report");
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // GenerateReportButton
            // 
            this.GenerateReportButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateReportButton.FlatAppearance.BorderSize = 0;
            this.GenerateReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateReportButton.Image = global::Simple_Library_Surfer.Properties.Resources.Report;
            this.GenerateReportButton.Location = new System.Drawing.Point(793, 75);
            this.GenerateReportButton.Name = "GenerateReportButton";
            this.GenerateReportButton.Size = new System.Drawing.Size(38, 38);
            this.GenerateReportButton.TabIndex = 5;
            this.ViewFormToolTip.SetToolTip(this.GenerateReportButton, "Generate Report");
            this.GenerateReportButton.UseVisualStyleBackColor = true;
            this.GenerateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.Location = new System.Drawing.Point(73, 84);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(139, 26);
            this.SearchTextBox.TabIndex = 7;
            this.SearchTextBox.Visible = false;
            this.SearchTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchTextBox_KeyPress);
            // 
            // SearchedDataTable
            // 
            this.SearchedDataTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchedDataTable.AutoScroll = true;
            this.SearchedDataTable.AutoSize = true;
            this.SearchedDataTable.BackColor = System.Drawing.Color.DarkGray;
            this.SearchedDataTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.SearchedDataTable.ColumnCount = 4;
            this.SearchedDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.SearchedDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.SearchedDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.SearchedDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.SearchedDataTable.Location = new System.Drawing.Point(21, 123);
            this.SearchedDataTable.MaximumSize = new System.Drawing.Size(810, 262);
            this.SearchedDataTable.MinimumSize = new System.Drawing.Size(810, 36);
            this.SearchedDataTable.Name = "SearchedDataTable";
            this.SearchedDataTable.RowCount = 1;
            this.SearchedDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.SearchedDataTable.Size = new System.Drawing.Size(810, 36);
            this.SearchedDataTable.TabIndex = 5;
            this.SearchedDataTable.Visible = false;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(863, 413);
            this.Controls.Add(this.SearchedDataTable);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.GenerateReportButton);
            this.Controls.Add(this.LibraryDataTable);
            this.Controls.Add(this.TotalTextLabel);
            this.Controls.Add(this.ProjectTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

        private System.Windows.Forms.Label ProjectTitleLabel;
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
    }
}