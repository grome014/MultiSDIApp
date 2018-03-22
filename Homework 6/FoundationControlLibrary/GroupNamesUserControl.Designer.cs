namespace FoundationControlLibrary
{
    partial class GroupNamesUserControl
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
            this.namesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namesLabel
            // 
            this.namesLabel.BackColor = System.Drawing.Color.LightGreen;
            this.namesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namesLabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesLabel.ForeColor = System.Drawing.Color.Snow;
            this.namesLabel.Location = new System.Drawing.Point(0, 0);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(388, 227);
            this.namesLabel.TabIndex = 0;
            this.namesLabel.Text = "Group 8:\r\nShafeeque Khan\r\nJahkell Lazarre\r\nBernardo Pla\r\nGalo Romero";
            this.namesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.namesLabel.Click += new System.EventHandler(this.namesLabel_Click);
            // 
            // GroupNamesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.Controls.Add(this.namesLabel);
            this.Name = "GroupNamesUserControl";
            this.Size = new System.Drawing.Size(388, 227);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label namesLabel;
    }
}
