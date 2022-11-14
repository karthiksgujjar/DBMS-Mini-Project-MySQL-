namespace Simple_Library_Surfer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
            this.TotalTextLabel = new System.Windows.Forms.Label();
            this.TotalBooksCountLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.MainFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ProjectTitleLabel
            // 
            this.ProjectTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProjectTitleLabel.Font = new System.Drawing.Font("AR DARLING", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ProjectTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.ProjectTitleLabel.Name = "ProjectTitleLabel";
            this.ProjectTitleLabel.Size = new System.Drawing.Size(800, 59);
            this.ProjectTitleLabel.TabIndex = 0;
            this.ProjectTitleLabel.Text = "SIMPLE LIBRARY SURFER";
            this.ProjectTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalTextLabel
            // 
            this.TotalTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalTextLabel.AutoSize = true;
            this.TotalTextLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextLabel.Location = new System.Drawing.Point(169, 118);
            this.TotalTextLabel.Name = "TotalTextLabel";
            this.TotalTextLabel.Size = new System.Drawing.Size(436, 40);
            this.TotalTextLabel.TabIndex = 1;
            this.TotalTextLabel.Text = "- Total Books in the Library -";
            // 
            // TotalBooksCountLabel
            // 
            this.TotalBooksCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalBooksCountLabel.AutoSize = true;
            this.TotalBooksCountLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBooksCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalBooksCountLabel.Location = new System.Drawing.Point(365, 167);
            this.TotalBooksCountLabel.Name = "TotalBooksCountLabel";
            this.TotalBooksCountLabel.Size = new System.Drawing.Size(68, 40);
            this.TotalBooksCountLabel.TabIndex = 1;
            this.TotalBooksCountLabel.Text = "000";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = global::Simple_Library_Surfer.Properties.Resources.Delete;
            this.DeleteButton.Location = new System.Drawing.Point(72, 322);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(51, 47);
            this.DeleteButton.TabIndex = 1;
            this.MainFormToolTip.SetToolTip(this.DeleteButton, "DELETE");
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewButton.FlatAppearance.BorderSize = 0;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Image = global::Simple_Library_Surfer.Properties.Resources.View;
            this.ViewButton.Location = new System.Drawing.Point(680, 322);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(51, 47);
            this.ViewButton.TabIndex = 3;
            this.MainFormToolTip.SetToolTip(this.ViewButton, "VIEW");
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Image = global::Simple_Library_Surfer.Properties.Resources.Update;
            this.UpdateButton.Location = new System.Drawing.Point(680, 207);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(51, 47);
            this.UpdateButton.TabIndex = 2;
            this.MainFormToolTip.SetToolTip(this.UpdateButton, "UPDATE");
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertButton.FlatAppearance.BorderSize = 0;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Image = global::Simple_Library_Surfer.Properties.Resources.Insert;
            this.InsertButton.Location = new System.Drawing.Point(72, 207);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(51, 47);
            this.InsertButton.TabIndex = 0;
            this.MainFormToolTip.SetToolTip(this.InsertButton, "INSERT");
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.TotalBooksCountLabel);
            this.Controls.Add(this.TotalTextLabel);
            this.Controls.Add(this.ProjectTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S L S ";
            this.Activated += new System.EventHandler(this.BooksCountUpdate_OnFormActivation);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectTitleLabel;
        private System.Windows.Forms.Label TotalTextLabel;
        private System.Windows.Forms.Label TotalBooksCountLabel;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.ToolTip MainFormToolTip;
    }
}

