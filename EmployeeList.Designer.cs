namespace PixisAirDatabaseTest2
{
    partial class EmployeeList
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
            this.EmployeeDataGrid = new System.Windows.Forms.DataGridView();
            this.AddEmpBtn = new System.Windows.Forms.Button();
            this.UpdateEmpBtn = new System.Windows.Forms.Button();
            this.ExtBtn = new System.Windows.Forms.Button();
            this.ReloadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataGrid
            // 
            this.EmployeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGrid.Location = new System.Drawing.Point(87, 12);
            this.EmployeeDataGrid.Name = "EmployeeDataGrid";
            this.EmployeeDataGrid.Size = new System.Drawing.Size(1164, 618);
            this.EmployeeDataGrid.TabIndex = 0;
            // 
            // AddEmpBtn
            // 
            this.AddEmpBtn.Location = new System.Drawing.Point(6, 41);
            this.AddEmpBtn.Name = "AddEmpBtn";
            this.AddEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.AddEmpBtn.TabIndex = 1;
            this.AddEmpBtn.Text = "Add Employee";
            this.AddEmpBtn.UseVisualStyleBackColor = true;
            this.AddEmpBtn.Click += new System.EventHandler(this.AddEmpBtn_Click);
            // 
            // UpdateEmpBtn
            // 
            this.UpdateEmpBtn.Location = new System.Drawing.Point(6, 83);
            this.UpdateEmpBtn.Name = "UpdateEmpBtn";
            this.UpdateEmpBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateEmpBtn.TabIndex = 2;
            this.UpdateEmpBtn.Text = "Update Employee";
            this.UpdateEmpBtn.UseVisualStyleBackColor = true;
            this.UpdateEmpBtn.Click += new System.EventHandler(this.UpdateEmpBtn_Click);
            // 
            // ExtBtn
            // 
            this.ExtBtn.Location = new System.Drawing.Point(6, 167);
            this.ExtBtn.Name = "ExtBtn";
            this.ExtBtn.Size = new System.Drawing.Size(75, 23);
            this.ExtBtn.TabIndex = 3;
            this.ExtBtn.Text = "Close";
            this.ExtBtn.UseVisualStyleBackColor = true;
            this.ExtBtn.Click += new System.EventHandler(this.ExtBtn_Click);
            // 
            // ReloadBtn
            // 
            this.ReloadBtn.Location = new System.Drawing.Point(6, 125);
            this.ReloadBtn.Name = "ReloadBtn";
            this.ReloadBtn.Size = new System.Drawing.Size(75, 23);
            this.ReloadBtn.TabIndex = 4;
            this.ReloadBtn.Text = "Refresh";
            this.ReloadBtn.UseVisualStyleBackColor = true;
            this.ReloadBtn.Click += new System.EventHandler(this.ReloadBtn_Click);
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 642);
            this.Controls.Add(this.ReloadBtn);
            this.Controls.Add(this.ExtBtn);
            this.Controls.Add(this.UpdateEmpBtn);
            this.Controls.Add(this.AddEmpBtn);
            this.Controls.Add(this.EmployeeDataGrid);
            this.Name = "EmployeeList";
            this.Text = "EmployeeList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeeList_FormClosed);
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGrid;
        private System.Windows.Forms.Button AddEmpBtn;
        private System.Windows.Forms.Button UpdateEmpBtn;
        private System.Windows.Forms.Button ExtBtn;
        private System.Windows.Forms.Button ReloadBtn;
    }
}