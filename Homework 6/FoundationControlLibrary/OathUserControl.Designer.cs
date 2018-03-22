namespace FoundationControlLibrary
{
    partial class OathUserControl
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
            this.oathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oathLabel
            // 
            this.oathLabel.BackColor = System.Drawing.Color.Transparent;
            this.oathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathLabel.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oathLabel.ForeColor = System.Drawing.Color.Snow;
            this.oathLabel.Location = new System.Drawing.Point(0, 0);
            this.oathLabel.Name = "oathLabel";
            this.oathLabel.Size = new System.Drawing.Size(431, 184);
            this.oathLabel.TabIndex = 0;
            this.oathLabel.Text = "I understand that this is a group project.\r\nIt is in my best interest to particip" +
    "ate in writing the homework and study all the code from the homework.";
            // 
            // OathUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.oathLabel);
            this.Name = "OathUserControl";
            this.Size = new System.Drawing.Size(431, 184);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label oathLabel;
    }
}
