﻿namespace PixisAirDatabaseTest2
{
    partial class ListJobs
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
            this.DataGridViewJobs = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewJobs
            // 
            this.DataGridViewJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewJobs.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewJobs.Name = "DataGridViewJobs";
            this.DataGridViewJobs.Size = new System.Drawing.Size(598, 286);
            this.DataGridViewJobs.TabIndex = 0;
            // 
            // ListJobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 286);
            this.Controls.Add(this.DataGridViewJobs);
            this.Name = "ListJobs";
            this.Text = "ListJobs";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewJobs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewJobs;
    }
}