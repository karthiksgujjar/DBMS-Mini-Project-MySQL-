namespace Simple_Library_Surfer
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CurrentIdTB = new System.Windows.Forms.TextBox();
            this.AuthorTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CurrentIdLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.NewIdLabel = new System.Windows.Forms.Label();
            this.NewIdTB = new System.Windows.Forms.TextBox();
            this.UpdateFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FormMinimizeButton = new System.Windows.Forms.Button();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.SLSHeaderLabel = new System.Windows.Forms.Label();
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
            this.UnderbarLabel3 = new System.Windows.Forms.Label();
            this.UnderbarLabel2 = new System.Windows.Forms.Label();
            this.UnderbarLabel1 = new System.Windows.Forms.Label();
            this.UnderbarLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.BackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.UpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.UpdateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(163, 314);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(84, 35);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CurrentIdTB
            // 
            this.CurrentIdTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentIdTB.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIdTB.Location = new System.Drawing.Point(264, 207);
            this.CurrentIdTB.MaxLength = 5;
            this.CurrentIdTB.Name = "CurrentIdTB";
            this.CurrentIdTB.Size = new System.Drawing.Size(198, 21);
            this.CurrentIdTB.TabIndex = 2;
            // 
            // AuthorTB
            // 
            this.AuthorTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorTB.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTB.Location = new System.Drawing.Point(264, 150);
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(198, 21);
            this.AuthorTB.TabIndex = 1;
            // 
            // NameTB
            // 
            this.NameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(264, 95);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(198, 21);
            this.NameTB.TabIndex = 0;
            // 
            // CurrentIdLabel
            // 
            this.CurrentIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentIdLabel.AutoSize = true;
            this.CurrentIdLabel.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIdLabel.Location = new System.Drawing.Point(139, 200);
            this.CurrentIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentIdLabel.Name = "CurrentIdLabel";
            this.CurrentIdLabel.Size = new System.Drawing.Size(120, 28);
            this.CurrentIdLabel.TabIndex = 9;
            this.CurrentIdLabel.Text = "Current ID :";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(170, 144);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(89, 28);
            this.AuthorLabel.TabIndex = 10;
            this.AuthorLabel.Text = "Author :";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(180, 88);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(79, 28);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name :";
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearFormButton.FlatAppearance.BorderSize = 0;
            this.ClearFormButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.ClearFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFormButton.Image = global::Simple_Library_Surfer.Properties.Resources.Clear_Form;
            this.ClearFormButton.Location = new System.Drawing.Point(424, 314);
            this.ClearFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(38, 30);
            this.ClearFormButton.TabIndex = 5;
            this.UpdateFormToolTip.SetToolTip(this.ClearFormButton, "Clear Form");
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // NewIdLabel
            // 
            this.NewIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewIdLabel.AutoSize = true;
            this.NewIdLabel.Font = new System.Drawing.Font("Calibri", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewIdLabel.Location = new System.Drawing.Point(167, 256);
            this.NewIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewIdLabel.Name = "NewIdLabel";
            this.NewIdLabel.Size = new System.Drawing.Size(92, 28);
            this.NewIdLabel.TabIndex = 9;
            this.NewIdLabel.Text = "New ID :";
            // 
            // NewIdTB
            // 
            this.NewIdTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewIdTB.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewIdTB.Location = new System.Drawing.Point(264, 263);
            this.NewIdTB.MaxLength = 5;
            this.NewIdTB.Name = "NewIdTB";
            this.NewIdTB.Size = new System.Drawing.Size(198, 21);
            this.NewIdTB.TabIndex = 3;
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
            this.FormMinimizeButton.TabIndex = 15;
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
            this.FormCloseButton.TabIndex = 14;
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
            this.SLSHeaderLabel.TabIndex = 13;
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
            this.ProjectTitleLabel.TabIndex = 12;
            this.ProjectTitleLabel.Text = "SIMPLE LIBRARY SURFER";
            this.ProjectTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UnderbarLabel3
            // 
            this.UnderbarLabel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.UnderbarLabel3.Location = new System.Drawing.Point(264, 231);
            this.UnderbarLabel3.Name = "UnderbarLabel3";
            this.UnderbarLabel3.Size = new System.Drawing.Size(198, 1);
            this.UnderbarLabel3.TabIndex = 18;
            this.UnderbarLabel3.Text = "label1";
            // 
            // UnderbarLabel2
            // 
            this.UnderbarLabel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.UnderbarLabel2.Location = new System.Drawing.Point(264, 174);
            this.UnderbarLabel2.Name = "UnderbarLabel2";
            this.UnderbarLabel2.Size = new System.Drawing.Size(198, 1);
            this.UnderbarLabel2.TabIndex = 17;
            this.UnderbarLabel2.Text = "label1";
            // 
            // UnderbarLabel1
            // 
            this.UnderbarLabel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.UnderbarLabel1.Location = new System.Drawing.Point(264, 119);
            this.UnderbarLabel1.Name = "UnderbarLabel1";
            this.UnderbarLabel1.Size = new System.Drawing.Size(198, 1);
            this.UnderbarLabel1.TabIndex = 16;
            this.UnderbarLabel1.Text = "label1";
            // 
            // UnderbarLabel4
            // 
            this.UnderbarLabel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.UnderbarLabel4.Location = new System.Drawing.Point(264, 287);
            this.UnderbarLabel4.Name = "UnderbarLabel4";
            this.UnderbarLabel4.Size = new System.Drawing.Size(198, 1);
            this.UnderbarLabel4.TabIndex = 19;
            this.UnderbarLabel4.Text = "label1";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.UnderbarLabel4);
            this.Controls.Add(this.UnderbarLabel3);
            this.Controls.Add(this.UnderbarLabel2);
            this.Controls.Add(this.UnderbarLabel1);
            this.Controls.Add(this.FormMinimizeButton);
            this.Controls.Add(this.FormCloseButton);
            this.Controls.Add(this.SLSHeaderLabel);
            this.Controls.Add(this.ProjectTitleLabel);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.NewIdTB);
            this.Controls.Add(this.CurrentIdTB);
            this.Controls.Add(this.AuthorTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.NewIdLabel);
            this.Controls.Add(this.CurrentIdLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "S L S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearFormButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox CurrentIdTB;
        private System.Windows.Forms.TextBox AuthorTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label CurrentIdLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label NewIdLabel;
        private System.Windows.Forms.TextBox NewIdTB;
        private System.Windows.Forms.ToolTip UpdateFormToolTip;
        private System.Windows.Forms.Button FormMinimizeButton;
        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.Label SLSHeaderLabel;
        private System.Windows.Forms.Label ProjectTitleLabel;
        private System.Windows.Forms.Label UnderbarLabel3;
        private System.Windows.Forms.Label UnderbarLabel2;
        private System.Windows.Forms.Label UnderbarLabel1;
        private System.Windows.Forms.Label UnderbarLabel4;
    }
}