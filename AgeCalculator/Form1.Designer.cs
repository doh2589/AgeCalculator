
namespace AgeCalculator
{
    partial class Form1
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
            this.dateOfBirthPicker = new System.Windows.Forms.DateTimePicker();
            this.txtAgeYears = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtAgeMonths = new System.Windows.Forms.TextBox();
            this.txtAgeDays = new System.Windows.Forms.TextBox();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.txtCurrentDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Location = new System.Drawing.Point(48, 57);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(200, 20);
            this.dateOfBirthPicker.TabIndex = 0;
            // 
            // txtAgeYears
            // 
            this.txtAgeYears.Location = new System.Drawing.Point(105, 117);
            this.txtAgeYears.Name = "txtAgeYears";
            this.txtAgeYears.Size = new System.Drawing.Size(100, 20);
            this.txtAgeYears.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Age is:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(173, 83);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtAgeMonths
            // 
            this.txtAgeMonths.Location = new System.Drawing.Point(105, 143);
            this.txtAgeMonths.Name = "txtAgeMonths";
            this.txtAgeMonths.Size = new System.Drawing.Size(100, 20);
            this.txtAgeMonths.TabIndex = 5;
            // 
            // txtAgeDays
            // 
            this.txtAgeDays.Location = new System.Drawing.Point(105, 169);
            this.txtAgeDays.Name = "txtAgeDays";
            this.txtAgeDays.Size = new System.Drawing.Size(100, 20);
            this.txtAgeDays.TabIndex = 6;
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Location = new System.Drawing.Point(13, 18);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(33, 13);
            this.lblCurrentDate.TabIndex = 7;
            this.lblCurrentDate.Text = "Date:";
            this.lblCurrentDate.Click += new System.EventHandler(this.lblCurrentDate_Click);
            // 
            // txtCurrentDate
            // 
            this.txtCurrentDate.Location = new System.Drawing.Point(48, 15);
            this.txtCurrentDate.Name = "txtCurrentDate";
            this.txtCurrentDate.ReadOnly = true;
            this.txtCurrentDate.Size = new System.Drawing.Size(128, 20);
            this.txtCurrentDate.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 234);
            this.Controls.Add(this.txtCurrentDate);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.txtAgeDays);
            this.Controls.Add(this.txtAgeMonths);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAgeYears);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Name = "Form1";
            this.Text = "Age Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateOfBirthPicker;
        private System.Windows.Forms.TextBox txtAgeYears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtAgeMonths;
        private System.Windows.Forms.TextBox txtAgeDays;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.TextBox txtCurrentDate;
    }
}

