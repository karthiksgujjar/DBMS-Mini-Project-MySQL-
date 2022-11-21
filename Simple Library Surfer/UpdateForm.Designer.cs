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
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.NewIdLabel = new System.Windows.Forms.Label();
            this.NewIdTB = new System.Windows.Forms.TextBox();
            this.UpdateFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(180, 386);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(116, 37);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "UPDATE";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CurrentIdTB
            // 
            this.CurrentIdTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrentIdTB.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIdTB.Location = new System.Drawing.Point(336, 238);
            this.CurrentIdTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CurrentIdTB.MaxLength = 5;
            this.CurrentIdTB.Name = "CurrentIdTB";
            this.CurrentIdTB.Size = new System.Drawing.Size(264, 30);
            this.CurrentIdTB.TabIndex = 2;
            // 
            // AuthorTB
            // 
            this.AuthorTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorTB.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTB.Location = new System.Drawing.Point(336, 159);
            this.AuthorTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuthorTB.Multiline = true;
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(264, 39);
            this.AuthorTB.TabIndex = 1;
            // 
            // NameTB
            // 
            this.NameTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTB.Location = new System.Drawing.Point(336, 90);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTB.Multiline = true;
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(264, 39);
            this.NameTB.TabIndex = 0;
            // 
            // CurrentIdLabel
            // 
            this.CurrentIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrentIdLabel.AutoSize = true;
            this.CurrentIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentIdLabel.Location = new System.Drawing.Point(115, 228);
            this.CurrentIdLabel.Name = "CurrentIdLabel";
            this.CurrentIdLabel.Size = new System.Drawing.Size(190, 40);
            this.CurrentIdLabel.TabIndex = 9;
            this.CurrentIdLabel.Text = "Current ID :";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLabel.Location = new System.Drawing.Point(172, 159);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(133, 40);
            this.AuthorLabel.TabIndex = 10;
            this.AuthorLabel.Text = "Author :";
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(191, 90);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(118, 40);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Name :";
            // 
            // ProjectTitleLabel
            // 
            this.ProjectTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProjectTitleLabel.Font = new System.Drawing.Font("AR DARLING", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ProjectTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.ProjectTitleLabel.Name = "ProjectTitleLabel";
            this.ProjectTitleLabel.Size = new System.Drawing.Size(800, 59);
            this.ProjectTitleLabel.TabIndex = 7;
            this.ProjectTitleLabel.Text = "SIMPLE LIBRARY SURFER";
            this.ProjectTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearFormButton.FlatAppearance.BorderSize = 0;
            this.ClearFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFormButton.Image = global::Simple_Library_Surfer.Properties.Resources.Clear_Form;
            this.ClearFormButton.Location = new System.Drawing.Point(549, 386);
            this.ClearFormButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearFormButton.Name = "ClearFormButton";
            this.ClearFormButton.Size = new System.Drawing.Size(51, 37);
            this.ClearFormButton.TabIndex = 5;
            this.UpdateFormToolTip.SetToolTip(this.ClearFormButton, "Clear Form");
            this.ClearFormButton.UseVisualStyleBackColor = true;
            this.ClearFormButton.Click += new System.EventHandler(this.ClearFormButton_Click);
            // 
            // NewIdLabel
            // 
            this.NewIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewIdLabel.AutoSize = true;
            this.NewIdLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewIdLabel.Location = new System.Drawing.Point(160, 297);
            this.NewIdLabel.Name = "NewIdLabel";
            this.NewIdLabel.Size = new System.Drawing.Size(146, 40);
            this.NewIdLabel.TabIndex = 9;
            this.NewIdLabel.Text = "New ID :";
            // 
            // NewIdTB
            // 
            this.NewIdTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewIdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewIdTB.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewIdTB.Location = new System.Drawing.Point(336, 306);
            this.NewIdTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewIdTB.MaxLength = 5;
            this.NewIdTB.Name = "NewIdTB";
            this.NewIdTB.Size = new System.Drawing.Size(264, 30);
            this.NewIdTB.TabIndex = 3;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.ProjectTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label ProjectTitleLabel;
        private System.Windows.Forms.Label NewIdLabel;
        private System.Windows.Forms.TextBox NewIdTB;
        private System.Windows.Forms.ToolTip UpdateFormToolTip;
    }
}