namespace PixisAirDatabaseTest2
{
    partial class CrewDisplay
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
            this.CrewdataGridView = new System.Windows.Forms.DataGridView();
            this.Exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CrewdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CrewdataGridView
            // 
            this.CrewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CrewdataGridView.Location = new System.Drawing.Point(74, 50);
            this.CrewdataGridView.Name = "CrewdataGridView";
            this.CrewdataGridView.Size = new System.Drawing.Size(489, 238);
            this.CrewdataGridView.TabIndex = 0;
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(660, 68);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(75, 23);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // CrewDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.CrewdataGridView);
            this.Name = "CrewDisplay";
            this.Text = "CrewDisplay";
            ((System.ComponentModel.ISupportInitialize)(this.CrewdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CrewdataGridView;
        private System.Windows.Forms.Button Exit_Button;
    }
}