namespace Simple_Library_Surfer
{
    partial class DeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.DeleteFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MasterDeleteButton = new System.Windows.Forms.Button();
            this.FormMinimizeButton = new System.Windows.Forms.Button();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.SLSHeaderLabel = new System.Windows.Forms.Label();
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
            this.UnderbarLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(261, 160);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 35);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IdTB
            // 
            this.IdTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdTB.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(203, 99);
            this.IdTB.MaxLength = 5;
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(198, 21);
            this.IdTB.TabIndex = 0;
            // 
            // isbnLabel
            // 
            this.isbnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.Location = new System.Drawing.Point(154, 95);
            this.isbnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(44, 28);
            this.isbnLabel.TabIndex = 6;
            this.isbnLabel.Text = "ID :";
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearFormButton.FlatAppearance.BorderSize = 0;
            this.ClearFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.ClearFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFormButton.Image = global::Simple_Library_Surfer.Properties.Resources.Clear_Form;
            this.ClearFormButton.Location = new System.Drawing.Point(403, 93);
            this.ClearFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(38, 32);
            this.ClearFormButton.TabIndex = 3;
            this.DeleteFormToolTip.SetToolTip(this.ClearFormButton, "Clear Form");
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // MasterDeleteButton
            // 
            this.MasterDeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MasterDeleteButton.AutoSize = true;
            this.MasterDeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.MasterDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.MasterDeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MasterDeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.MasterDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MasterDeleteButton.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterDeleteButton.Location = new System.Drawing.Point(209, 223);
            this.MasterDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.MasterDeleteButton.Name = "MasterDeleteButton";
            this.MasterDeleteButton.Size = new System.Drawing.Size(182, 35);
            this.MasterDeleteButton.TabIndex = 2;
            this.MasterDeleteButton.Text = "DELETE EVERYTHING";
            this.MasterDeleteButton.UseVisualStyleBackColor = false;
            this.MasterDeleteButton.Click += new System.EventHandler(this.MasterDeleteButton_Click);
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
            this.FormMinimizeButton.TabIndex = 14;
            this.FormMinimizeButton.Text = "-";
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
            this.FormCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCloseButton.Location = new System.Drawing.Point(575, 0);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(25, 25);
            this.FormCloseButton.TabIndex = 13;
            this.FormCloseButton.Text = "X";
            this.FormCloseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.SLSHeaderLabel.Size = new System.Drawing.Size(600, 25);
            this.SLSHeaderLabel.TabIndex = 12;
            this.SLSHeaderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.ProjectTitleLabel.TabIndex = 11;
            this.ProjectTitleLabel.Text = "SIMPLE LIBRARY SURFER";
            this.ProjectTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UnderbarLabel1
            // 
            this.UnderbarLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.UnderbarLabel1.Location = new System.Drawing.Point(203, 123);
            this.UnderbarLabel1.Name = "UnderbarLabel1";
            this.UnderbarLabel1.Size = new System.Drawing.Size(198, 1);
            this.UnderbarLabel1.TabIndex = 15;
            this.UnderbarLabel1.Text = "label1";
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.UnderbarLabel1);
            this.Controls.Add(this.FormMinimizeButton);
            this.Controls.Add(this.FormCloseButton);
            this.Controls.Add(this.SLSHeaderLabel);
            this.Controls.Add(this.ProjectTitleLabel);
            this.Controls.Add(this.MasterDeleteButton);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.isbnLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "S L S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ClearFormButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.ToolTip DeleteFormToolTip;
        private System.Windows.Forms.Button MasterDeleteButton;
        private System.Windows.Forms.Button FormMinimizeButton;
        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.Label SLSHeaderLabel;
        private System.Windows.Forms.Label ProjectTitleLabel;
        private System.Windows.Forms.Label UnderbarLabel1;
    }
}