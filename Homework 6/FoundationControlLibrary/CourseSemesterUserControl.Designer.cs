namespace FoundationControlLibrary
{
    partial class CourseSemesterUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.courseLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // courseLabel
            // 
            this.courseLabel.BackColor = System.Drawing.Color.Transparent;
            this.courseLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseLabel.ForeColor = System.Drawing.Color.Snow;
            this.courseLabel.Location = new System.Drawing.Point(0, 0);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(269, 127);
            this.courseLabel.TabIndex = 0;
            this.courseLabel.Text = "COP4226";
            this.courseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.courseLabel.Click += new System.EventHandler(this.courseLabel_Click);
            // 
            // semesterLabel
            // 
            this.semesterLabel.BackColor = System.Drawing.Color.Transparent;
            this.semesterLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.semesterLabel.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semesterLabel.ForeColor = System.Drawing.Color.Snow;
            this.semesterLabel.Location = new System.Drawing.Point(0, 99);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(269, 28);
            this.semesterLabel.TabIndex = 1;
            this.semesterLabel.Text = "Fall 2016";
            this.semesterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseSemesterUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.courseLabel);
            this.Name = "CourseSemesterUserControl";
            this.Size = new System.Drawing.Size(269, 127);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.Label semesterLabel;
    }
}
