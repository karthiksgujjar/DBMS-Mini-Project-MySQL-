namespace Simple_Library_Surfer
{
    partial class InsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertForm));
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AuthorTB = new System.Windows.Forms.TextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.InsertFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ProjectTitleLabel
            // 
            this.ProjectTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProjectTitleLabel.Font = new System.Drawing.Font("AR DARLING", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ProjectTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.ProjectTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProjectTitleLabel.Name = "ProjectTitleLabel";
            this.ProjectTitleLabel.Size = new System.Drawing.Size(600, 48);
            this.ProjectTitleLabel.TabIndex = 1;
            this.ProjectTitleLabel.Text = "SIMPLE LIBRARY SURFER";
            this.ProjectTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(109, 83);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(93, 32);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name :";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(95, 147);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(107, 32);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author :";
            // 
            // IdLabel
            // 
            this.IdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(138, 211);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(62, 32);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "ID :";
            // 
            // NameTB
            // 
            this.NameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(218, 83);
            this.NameTB.Multiline = true;
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(198, 32);
            this.NameTB.TabIndex = 0;
            // 
            // AuthorTB
            // 
            this.AuthorTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorTB.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTB.Location = new System.Drawing.Point(218, 147);
            this.AuthorTB.Multiline = true;
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(198, 32);
            this.AuthorTB.TabIndex = 1;
            // 
            // IdTB
            // 
            this.IdTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdTB.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(218, 219);
            this.IdTB.MaxLength = 5;
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(198, 24);
            this.IdTB.TabIndex = 2;
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.InsertButton.FlatAppearance.BorderSize = 0;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.Location = new System.Drawing.Point(101, 281);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(87, 30);
            this.InsertButton.TabIndex = 3;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearFormButton.FlatAppearance.BorderSize = 0;
            this.ClearFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFormButton.Image = global::Simple_Library_Surfer.Properties.Resources.Clear_Form;
            this.ClearFormButton.Location = new System.Drawing.Point(378, 281);
            this.ClearFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(38, 30);
            this.ClearFormButton.TabIndex = 4;
            this.InsertFormToolTip.SetToolTip(this.ClearFormButton, "Clear Form");
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.AuthorTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ProjectTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "S L S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectTitleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox AuthorTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button ClearFormButton;
        private System.Windows.Forms.ToolTip InsertFormToolTip;
    }
}