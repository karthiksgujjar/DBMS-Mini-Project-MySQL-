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
            this.MainFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.FormMinimizeButton = new System.Windows.Forms.Button();
            this.SLSHeaderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProjectTitleLabel
            // 
            this.ProjectTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProjectTitleLabel.Font = new System.Drawing.Font("AR DARLING", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ProjectTitleLabel.Location = new System.Drawing.Point(0, 27);
            this.ProjectTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProjectTitleLabel.Name = "ProjectTitleLabel";
            this.ProjectTitleLabel.Size = new System.Drawing.Size(600, 48);
            this.ProjectTitleLabel.TabIndex = 0;
            this.ProjectTitleLabel.Text = "SIMPLE LIBRARY SURFER";
            this.ProjectTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotalTextLabel
            // 
            this.TotalTextLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalTextLabel.AutoSize = true;
            this.TotalTextLabel.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextLabel.Location = new System.Drawing.Point(162, 96);
            this.TotalTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalTextLabel.Name = "TotalTextLabel";
            this.TotalTextLabel.Size = new System.Drawing.Size(276, 28);
            this.TotalTextLabel.TabIndex = 1;
            this.TotalTextLabel.Text = "- Total Books in the Library -";
            // 
            // TotalBooksCountLabel
            // 
            this.TotalBooksCountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalBooksCountLabel.AutoSize = true;
            this.TotalBooksCountLabel.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBooksCountLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TotalBooksCountLabel.Location = new System.Drawing.Point(288, 136);
            this.TotalBooksCountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalBooksCountLabel.Name = "TotalBooksCountLabel";
            this.TotalBooksCountLabel.Size = new System.Drawing.Size(24, 28);
            this.TotalBooksCountLabel.TabIndex = 1;
            this.TotalBooksCountLabel.Text = "0";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Image = global::Simple_Library_Surfer.Properties.Resources.Delete;
            this.DeleteButton.Location = new System.Drawing.Point(54, 262);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(38, 38);
            this.DeleteButton.TabIndex = 1;
            this.MainFormToolTip.SetToolTip(this.DeleteButton, "DELETE");
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewButton.FlatAppearance.BorderSize = 0;
            this.ViewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Image = global::Simple_Library_Surfer.Properties.Resources.View;
            this.ViewButton.Location = new System.Drawing.Point(510, 262);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(2);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(38, 38);
            this.ViewButton.TabIndex = 3;
            this.MainFormToolTip.SetToolTip(this.ViewButton, "VIEW");
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Image = global::Simple_Library_Surfer.Properties.Resources.Update;
            this.UpdateButton.Location = new System.Drawing.Point(510, 168);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(38, 38);
            this.UpdateButton.TabIndex = 2;
            this.MainFormToolTip.SetToolTip(this.UpdateButton, "UPDATE");
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertButton.FlatAppearance.BorderSize = 0;
            this.InsertButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Image = global::Simple_Library_Surfer.Properties.Resources.Insert;
            this.InsertButton.Location = new System.Drawing.Point(54, 168);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(2);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(38, 38);
            this.InsertButton.TabIndex = 0;
            this.MainFormToolTip.SetToolTip(this.InsertButton, "INSERT");
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // FormCloseButton
            // 
            this.FormCloseButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormCloseButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FormCloseButton.FlatAppearance.BorderSize = 0;
            this.FormCloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.FormCloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.FormCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCloseButton.Location = new System.Drawing.Point(575, 0);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(25, 25);
            this.FormCloseButton.TabIndex = 5;
            this.FormCloseButton.Text = "X";
            this.FormCloseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.FormCloseButton.UseVisualStyleBackColor = false;
            this.FormCloseButton.Click += new System.EventHandler(this.FormCloseButton_Click);
            // 
            // FormMinimizeButton
            // 
            this.FormMinimizeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormMinimizeButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.FormMinimizeButton.FlatAppearance.BorderSize = 0;
            this.FormMinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.FormMinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.FormMinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FormMinimizeButton.Font = new System.Drawing.Font("Wide Latin", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormMinimizeButton.Location = new System.Drawing.Point(546, 0);
            this.FormMinimizeButton.Name = "FormMinimizeButton";
            this.FormMinimizeButton.Size = new System.Drawing.Size(25, 25);
            this.FormMinimizeButton.TabIndex = 6;
            this.FormMinimizeButton.Text = "-";
            this.FormMinimizeButton.UseVisualStyleBackColor = false;
            this.FormMinimizeButton.Click += new System.EventHandler(this.FormMinimizeButton_Click);
            // 
            // SLSHeaderLabel
            // 
            this.SLSHeaderLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.SLSHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SLSHeaderLabel.Image = global::Simple_Library_Surfer.Properties.Resources.SLS_Image_Icon;
            this.SLSHeaderLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SLSHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.SLSHeaderLabel.Name = "SLSHeaderLabel";
            this.SLSHeaderLabel.Size = new System.Drawing.Size(600, 25);
            this.SLSHeaderLabel.TabIndex = 4;
            this.SLSHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.FormMinimizeButton);
            this.Controls.Add(this.FormCloseButton);
            this.Controls.Add(this.SLSHeaderLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.TotalBooksCountLabel);
            this.Controls.Add(this.TotalTextLabel);
            this.Controls.Add(this.ProjectTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S L S ";
            this.Activated += new System.EventHandler(this.BooksCountUpdate_OnFormActivation);
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
        private System.Windows.Forms.Label SLSHeaderLabel;
        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.Button FormMinimizeButton;
    }
}

