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
            this.ProjectTitleLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.ClearFormButton = new System.Windows.Forms.Button();
            this.DeleteFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MasterDeleteButton = new System.Windows.Forms.Button();
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
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.DeleteButton.FlatAppearance.BorderSize = 0;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(259, 160);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(87, 30);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IdTB
            // 
            this.IdTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IdTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdTB.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTB.Location = new System.Drawing.Point(203, 97);
            this.IdTB.MaxLength = 5;
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(198, 24);
            this.IdTB.TabIndex = 0;
            // 
            // isbnLabel
            // 
            this.isbnLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.Location = new System.Drawing.Point(139, 91);
            this.isbnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(62, 32);
            this.isbnLabel.TabIndex = 6;
            this.isbnLabel.Text = "ID :";
            // 
            // ClearFormButton
            // 
            this.ClearFormButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearFormButton.FlatAppearance.BorderSize = 0;
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
            this.MasterDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MasterDeleteButton.FlatAppearance.BorderSize = 0;
            this.MasterDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MasterDeleteButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterDeleteButton.Location = new System.Drawing.Point(203, 223);
            this.MasterDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.MasterDeleteButton.Name = "MasterDeleteButton";
            this.MasterDeleteButton.Size = new System.Drawing.Size(198, 30);
            this.MasterDeleteButton.TabIndex = 2;
            this.MasterDeleteButton.Text = "DELETE EVERYTHING";
            this.MasterDeleteButton.UseVisualStyleBackColor = false;
            this.MasterDeleteButton.Click += new System.EventHandler(this.MasterDeleteButton_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.MasterDeleteButton);
            this.Controls.Add(this.ClearFormButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.ProjectTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "S L S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProjectTitleLabel;
        private System.Windows.Forms.Button ClearFormButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.ToolTip DeleteFormToolTip;
        private System.Windows.Forms.Button MasterDeleteButton;
    }
}