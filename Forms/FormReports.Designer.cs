namespace HRMVP.Forms
{
    partial class FormReports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSalary = new System.Windows.Forms.Button();
            this.buttonReportSalaryYear = new System.Windows.Forms.Button();
            this.buttonReportBoss = new System.Windows.Forms.Button();
            this.buttonReportGroups = new System.Windows.Forms.Button();
            this.buttonManager = new System.Windows.Forms.Button();
            this.buttonSalaryBoss = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 566);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSalary
            // 
            this.buttonSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalary.Location = new System.Drawing.Point(898, 13);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(157, 44);
            this.buttonSalary.TabIndex = 1;
            this.buttonSalary.Text = "Зарплаты";
            this.buttonSalary.UseVisualStyleBackColor = true;
            this.buttonSalary.Click += new System.EventHandler(this.buttonSalary_Click);
            // 
            // buttonReportSalaryYear
            // 
            this.buttonReportSalaryYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportSalaryYear.Location = new System.Drawing.Point(898, 239);
            this.buttonReportSalaryYear.Name = "buttonReportSalaryYear";
            this.buttonReportSalaryYear.Size = new System.Drawing.Size(157, 44);
            this.buttonReportSalaryYear.TabIndex = 2;
            this.buttonReportSalaryYear.Text = "Зарплаты за год";
            this.buttonReportSalaryYear.UseVisualStyleBackColor = true;
            this.buttonReportSalaryYear.Click += new System.EventHandler(this.buttonReportSalaryYear_Click);
            // 
            // buttonReportBoss
            // 
            this.buttonReportBoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportBoss.Location = new System.Drawing.Point(898, 289);
            this.buttonReportBoss.Name = "buttonReportBoss";
            this.buttonReportBoss.Size = new System.Drawing.Size(157, 44);
            this.buttonReportBoss.TabIndex = 3;
            this.buttonReportBoss.Text = "Зарплаты руководителей";
            this.buttonReportBoss.UseVisualStyleBackColor = true;
            this.buttonReportBoss.Click += new System.EventHandler(this.buttonReportBoss_Click);
            // 
            // buttonReportGroups
            // 
            this.buttonReportGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReportGroups.Location = new System.Drawing.Point(898, 339);
            this.buttonReportGroups.Name = "buttonReportGroups";
            this.buttonReportGroups.Size = new System.Drawing.Size(157, 44);
            this.buttonReportGroups.TabIndex = 4;
            this.buttonReportGroups.Text = "Средние зарплаты в группе";
            this.buttonReportGroups.UseVisualStyleBackColor = true;
            this.buttonReportGroups.Click += new System.EventHandler(this.buttonReportGroups_Click);
            // 
            // buttonManager
            // 
            this.buttonManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonManager.Location = new System.Drawing.Point(898, 63);
            this.buttonManager.Name = "buttonManager";
            this.buttonManager.Size = new System.Drawing.Size(157, 44);
            this.buttonManager.TabIndex = 5;
            this.buttonManager.Text = "Зарплаты менеджеров";
            this.buttonManager.UseVisualStyleBackColor = true;
            this.buttonManager.Click += new System.EventHandler(this.buttonManager_Click);
            // 
            // buttonSalaryBoss
            // 
            this.buttonSalaryBoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalaryBoss.Location = new System.Drawing.Point(898, 113);
            this.buttonSalaryBoss.Name = "buttonSalaryBoss";
            this.buttonSalaryBoss.Size = new System.Drawing.Size(157, 44);
            this.buttonSalaryBoss.TabIndex = 6;
            this.buttonSalaryBoss.Text = "Зарплаты босов";
            this.buttonSalaryBoss.UseVisualStyleBackColor = true;
            this.buttonSalaryBoss.Click += new System.EventHandler(this.buttonSalaryBoss_Click);
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 591);
            this.Controls.Add(this.buttonSalaryBoss);
            this.Controls.Add(this.buttonManager);
            this.Controls.Add(this.buttonReportGroups);
            this.Controls.Add(this.buttonReportBoss);
            this.Controls.Add(this.buttonReportSalaryYear);
            this.Controls.Add(this.buttonSalary);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReports";
            this.Text = "FormReports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSalary;
        private System.Windows.Forms.Button buttonReportSalaryYear;
        private System.Windows.Forms.Button buttonReportBoss;
        private System.Windows.Forms.Button buttonReportGroups;
        private System.Windows.Forms.Button buttonManager;
        private System.Windows.Forms.Button buttonSalaryBoss;
    }
}