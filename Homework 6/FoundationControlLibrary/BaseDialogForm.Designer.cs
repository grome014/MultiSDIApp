namespace FoundationControlLibrary
{
    partial class BaseDialogForm
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
            this.dialogPanel = new System.Windows.Forms.Panel();
            this.courseSemesterUserControl1 = new FoundationControlLibrary.CourseSemesterUserControl();
            this.groupNamesUserControl1 = new FoundationControlLibrary.GroupNamesUserControl();
            this.SuspendLayout();
            // 
            // dialogPanel
            // 
            this.dialogPanel.BackColor = System.Drawing.Color.Transparent;
            this.dialogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogPanel.Location = new System.Drawing.Point(0, 89);
            this.dialogPanel.Name = "dialogPanel";
            this.dialogPanel.Size = new System.Drawing.Size(468, 150);
            this.dialogPanel.TabIndex = 2;
            // 
            // courseSemesterUserControl1
            // 
            this.courseSemesterUserControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.courseSemesterUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.courseSemesterUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseSemesterUserControl1.Location = new System.Drawing.Point(0, 0);
            this.courseSemesterUserControl1.Name = "courseSemesterUserControl1";
            this.courseSemesterUserControl1.Size = new System.Drawing.Size(468, 89);
            this.courseSemesterUserControl1.TabIndex = 4;
            // 
            // groupNamesUserControl1
            // 
            this.groupNamesUserControl1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.groupNamesUserControl1.BackColor = System.Drawing.Color.White;
            this.groupNamesUserControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupNamesUserControl1.Location = new System.Drawing.Point(0, 239);
            this.groupNamesUserControl1.Name = "groupNamesUserControl1";
            this.groupNamesUserControl1.Size = new System.Drawing.Size(468, 190);
            this.groupNamesUserControl1.TabIndex = 3;
            // 
            // BaseDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 429);
            this.Controls.Add(this.dialogPanel);
            this.Controls.Add(this.courseSemesterUserControl1);
            this.Controls.Add(this.groupNamesUserControl1);
            this.Name = "BaseDialogForm";
            this.Text = "BaseDialogForm";
            this.ResumeLayout(false);

        }

        #endregion
        private GroupNamesUserControl groupNamesUserControl1;
        private CourseSemesterUserControl courseSemesterUserControl1;
        protected System.Windows.Forms.Panel dialogPanel;
    }
}