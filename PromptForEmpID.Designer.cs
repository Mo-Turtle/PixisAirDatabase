namespace PixisAirDatabaseTest2
{
    partial class PromptForEmpID
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
            this.OkayBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.textBoxEmpIDPrompt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OkayBtn
            // 
            this.OkayBtn.Location = new System.Drawing.Point(12, 51);
            this.OkayBtn.Name = "OkayBtn";
            this.OkayBtn.Size = new System.Drawing.Size(75, 23);
            this.OkayBtn.TabIndex = 0;
            this.OkayBtn.Text = "Okay";
            this.OkayBtn.UseVisualStyleBackColor = true;
            this.OkayBtn.Click += new System.EventHandler(this.OkayBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(93, 51);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // textBoxEmpIDPrompt
            // 
            this.textBoxEmpIDPrompt.Location = new System.Drawing.Point(12, 25);
            this.textBoxEmpIDPrompt.Name = "textBoxEmpIDPrompt";
            this.textBoxEmpIDPrompt.Size = new System.Drawing.Size(104, 20);
            this.textBoxEmpIDPrompt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "To update an Employee entry, please enter the EMPNO";
            // 
            // PromptForEmpID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 90);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEmpIDPrompt);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkayBtn);
            this.Name = "PromptForEmpID";
            this.Text = "PromptForEmpID";
            this.Load += new System.EventHandler(this.PromptForEmpID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkayBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox textBoxEmpIDPrompt;
        private System.Windows.Forms.Label label1;
    }
}