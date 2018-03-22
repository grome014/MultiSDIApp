using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group8_Homework6
{
    class PreferencesDialog : Form, IPreferencesDialog
    {
        private GroupBox colorGroupBox;
        private Panel colorPreviewPanel;
        private Label redColorComponentLabel;
        private Label greenColorComponentLabel;
        private Label blueColorComponentLabel;
        private GroupBox fontGroupBox;
        private Button pickColorButton;
        private Button okButton;
        private Button applyButton;
        private Button cancelButton;
        private TextBox fontNameTextBox;
        private NumericUpDown redColorComponentUpDown;
        private NumericUpDown fontSizeUpDown;
        private NumericUpDown blueColorComponentUpDown;
        private NumericUpDown greenColorComponentUpDown;
        private Label fontSizeLabel;
        private GroupBox fontStylesGroupBox;
        private CheckBox boldCheckBox;
        private CheckBox underlineCheckBox;
        private CheckBox italicCheckBox;
        private GroupBox rgbGroupBox;
        private Button pickFontButton;
        private Label colorPreviewLabel;
        private Label fontNameLabel;

        public Color color { get; set; }
        public Font font { get; set; }
        public event EventHandler OK;
        public event EventHandler Apply;
        public event EventHandler Cancel;

        private void InitializeComponent()
        {
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.colorPreviewLabel = new System.Windows.Forms.Label();
            this.rgbGroupBox = new System.Windows.Forms.GroupBox();
            this.redColorComponentUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueColorComponentUpDown = new System.Windows.Forms.NumericUpDown();
            this.redColorComponentLabel = new System.Windows.Forms.Label();
            this.greenColorComponentUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenColorComponentLabel = new System.Windows.Forms.Label();
            this.blueColorComponentLabel = new System.Windows.Forms.Label();
            this.pickColorButton = new System.Windows.Forms.Button();
            this.colorPreviewPanel = new System.Windows.Forms.Panel();
            this.fontGroupBox = new System.Windows.Forms.GroupBox();
            this.pickFontButton = new System.Windows.Forms.Button();
            this.fontStylesGroupBox = new System.Windows.Forms.GroupBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.fontSizeLabel = new System.Windows.Forms.Label();
            this.fontSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.fontNameLabel = new System.Windows.Forms.Label();
            this.fontNameTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.colorGroupBox.SuspendLayout();
            this.rgbGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redColorComponentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorComponentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorComponentUpDown)).BeginInit();
            this.fontGroupBox.SuspendLayout();
            this.fontStylesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorPreviewLabel);
            this.colorGroupBox.Controls.Add(this.rgbGroupBox);
            this.colorGroupBox.Controls.Add(this.pickColorButton);
            this.colorGroupBox.Controls.Add(this.colorPreviewPanel);
            this.colorGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorGroupBox.Location = new System.Drawing.Point(0, 213);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(334, 190);
            this.colorGroupBox.TabIndex = 3;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // colorPreviewLabel
            // 
            this.colorPreviewLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.colorPreviewLabel.AutoSize = true;
            this.colorPreviewLabel.Location = new System.Drawing.Point(216, 15);
            this.colorPreviewLabel.Name = "colorPreviewLabel";
            this.colorPreviewLabel.Size = new System.Drawing.Size(72, 13);
            this.colorPreviewLabel.TabIndex = 14;
            this.colorPreviewLabel.Text = "Color Preview";
            // 
            // rgbGroupBox
            // 
            this.rgbGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rgbGroupBox.Controls.Add(this.redColorComponentUpDown);
            this.rgbGroupBox.Controls.Add(this.blueColorComponentUpDown);
            this.rgbGroupBox.Controls.Add(this.redColorComponentLabel);
            this.rgbGroupBox.Controls.Add(this.greenColorComponentUpDown);
            this.rgbGroupBox.Controls.Add(this.greenColorComponentLabel);
            this.rgbGroupBox.Controls.Add(this.blueColorComponentLabel);
            this.rgbGroupBox.Location = new System.Drawing.Point(53, 61);
            this.rgbGroupBox.Name = "rgbGroupBox";
            this.rgbGroupBox.Size = new System.Drawing.Size(233, 77);
            this.rgbGroupBox.TabIndex = 13;
            this.rgbGroupBox.TabStop = false;
            this.rgbGroupBox.Text = "RGB";
            // 
            // redColorComponentUpDown
            // 
            this.redColorComponentUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redColorComponentUpDown.Location = new System.Drawing.Point(16, 25);
            this.redColorComponentUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redColorComponentUpDown.Name = "redColorComponentUpDown";
            this.redColorComponentUpDown.Size = new System.Drawing.Size(40, 20);
            this.redColorComponentUpDown.TabIndex = 10;
            // 
            // blueColorComponentUpDown
            // 
            this.blueColorComponentUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blueColorComponentUpDown.Location = new System.Drawing.Point(171, 25);
            this.blueColorComponentUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueColorComponentUpDown.Name = "blueColorComponentUpDown";
            this.blueColorComponentUpDown.Size = new System.Drawing.Size(40, 20);
            this.blueColorComponentUpDown.TabIndex = 12;
            // 
            // redColorComponentLabel
            // 
            this.redColorComponentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redColorComponentLabel.AutoSize = true;
            this.redColorComponentLabel.Location = new System.Drawing.Point(21, 52);
            this.redColorComponentLabel.Name = "redColorComponentLabel";
            this.redColorComponentLabel.Size = new System.Drawing.Size(27, 13);
            this.redColorComponentLabel.TabIndex = 4;
            this.redColorComponentLabel.Text = "Red";
            // 
            // greenColorComponentUpDown
            // 
            this.greenColorComponentUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greenColorComponentUpDown.Location = new System.Drawing.Point(94, 25);
            this.greenColorComponentUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenColorComponentUpDown.Name = "greenColorComponentUpDown";
            this.greenColorComponentUpDown.Size = new System.Drawing.Size(40, 20);
            this.greenColorComponentUpDown.TabIndex = 11;
            // 
            // greenColorComponentLabel
            // 
            this.greenColorComponentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greenColorComponentLabel.AutoSize = true;
            this.greenColorComponentLabel.Location = new System.Drawing.Point(96, 52);
            this.greenColorComponentLabel.Name = "greenColorComponentLabel";
            this.greenColorComponentLabel.Size = new System.Drawing.Size(36, 13);
            this.greenColorComponentLabel.TabIndex = 5;
            this.greenColorComponentLabel.Text = "Green";
            // 
            // blueColorComponentLabel
            // 
            this.blueColorComponentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blueColorComponentLabel.AutoSize = true;
            this.blueColorComponentLabel.Location = new System.Drawing.Point(178, 52);
            this.blueColorComponentLabel.Name = "blueColorComponentLabel";
            this.blueColorComponentLabel.Size = new System.Drawing.Size(28, 13);
            this.blueColorComponentLabel.TabIndex = 6;
            this.blueColorComponentLabel.Text = "Blue";
            // 
            // pickColorButton
            // 
            this.pickColorButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pickColorButton.Location = new System.Drawing.Point(128, 151);
            this.pickColorButton.Name = "pickColorButton";
            this.pickColorButton.Size = new System.Drawing.Size(75, 23);
            this.pickColorButton.TabIndex = 7;
            this.pickColorButton.Text = "Pick Color...";
            this.pickColorButton.UseVisualStyleBackColor = true;
            this.pickColorButton.Click += new System.EventHandler(this.pickColorButton_Click);
            // 
            // colorPreviewPanel
            // 
            this.colorPreviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPreviewPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorPreviewPanel.Location = new System.Drawing.Point(291, 15);
            this.colorPreviewPanel.Name = "colorPreviewPanel";
            this.colorPreviewPanel.Size = new System.Drawing.Size(37, 33);
            this.colorPreviewPanel.TabIndex = 3;
            // 
            // fontGroupBox
            // 
            this.fontGroupBox.Controls.Add(this.pickFontButton);
            this.fontGroupBox.Controls.Add(this.fontStylesGroupBox);
            this.fontGroupBox.Controls.Add(this.fontSizeLabel);
            this.fontGroupBox.Controls.Add(this.fontSizeUpDown);
            this.fontGroupBox.Controls.Add(this.fontNameLabel);
            this.fontGroupBox.Controls.Add(this.fontNameTextBox);
            this.fontGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.fontGroupBox.Location = new System.Drawing.Point(0, 0);
            this.fontGroupBox.Name = "fontGroupBox";
            this.fontGroupBox.Size = new System.Drawing.Size(334, 213);
            this.fontGroupBox.TabIndex = 7;
            this.fontGroupBox.TabStop = false;
            this.fontGroupBox.Text = "Font";
            // 
            // pickFontButton
            // 
            this.pickFontButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pickFontButton.Location = new System.Drawing.Point(127, 174);
            this.pickFontButton.Name = "pickFontButton";
            this.pickFontButton.Size = new System.Drawing.Size(75, 23);
            this.pickFontButton.TabIndex = 14;
            this.pickFontButton.Text = "Pick Font...";
            this.pickFontButton.UseVisualStyleBackColor = true;
            this.pickFontButton.Click += new System.EventHandler(this.pickFontButton_Click);
            // 
            // fontStylesGroupBox
            // 
            this.fontStylesGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fontStylesGroupBox.Controls.Add(this.underlineCheckBox);
            this.fontStylesGroupBox.Controls.Add(this.italicCheckBox);
            this.fontStylesGroupBox.Controls.Add(this.boldCheckBox);
            this.fontStylesGroupBox.Location = new System.Drawing.Point(53, 94);
            this.fontStylesGroupBox.Name = "fontStylesGroupBox";
            this.fontStylesGroupBox.Size = new System.Drawing.Size(218, 65);
            this.fontStylesGroupBox.TabIndex = 11;
            this.fontStylesGroupBox.TabStop = false;
            this.fontStylesGroupBox.Text = "Font Styles";
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Location = new System.Drawing.Point(141, 35);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(71, 17);
            this.underlineCheckBox.TabIndex = 2;
            this.underlineCheckBox.Text = "Underline";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Location = new System.Drawing.Point(78, 35);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(48, 17);
            this.italicCheckBox.TabIndex = 1;
            this.italicCheckBox.Text = "Italic";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Location = new System.Drawing.Point(14, 34);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(47, 17);
            this.boldCheckBox.TabIndex = 0;
            this.boldCheckBox.Text = "Bold";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            // 
            // fontSizeLabel
            // 
            this.fontSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fontSizeLabel.AutoSize = true;
            this.fontSizeLabel.Location = new System.Drawing.Point(113, 72);
            this.fontSizeLabel.Name = "fontSizeLabel";
            this.fontSizeLabel.Size = new System.Drawing.Size(51, 13);
            this.fontSizeLabel.TabIndex = 10;
            this.fontSizeLabel.Text = "Font Size";
            // 
            // fontSizeUpDown
            // 
            this.fontSizeUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fontSizeUpDown.Location = new System.Drawing.Point(169, 70);
            this.fontSizeUpDown.Name = "fontSizeUpDown";
            this.fontSizeUpDown.Size = new System.Drawing.Size(40, 20);
            this.fontSizeUpDown.TabIndex = 9;
            // 
            // fontNameLabel
            // 
            this.fontNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fontNameLabel.AutoSize = true;
            this.fontNameLabel.Location = new System.Drawing.Point(34, 24);
            this.fontNameLabel.Name = "fontNameLabel";
            this.fontNameLabel.Size = new System.Drawing.Size(59, 13);
            this.fontNameLabel.TabIndex = 8;
            this.fontNameLabel.Text = "Font Name";
            // 
            // fontNameTextBox
            // 
            this.fontNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fontNameTextBox.Location = new System.Drawing.Point(37, 40);
            this.fontNameTextBox.Name = "fontNameTextBox";
            this.fontNameTextBox.ReadOnly = true;
            this.fontNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.fontNameTextBox.TabIndex = 8;
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okButton.Location = new System.Drawing.Point(43, 418);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 8;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.applyButton.Location = new System.Drawing.Point(127, 418);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(213, 418);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // PreferencesDialog
            // 
            this.AcceptButton = this.okButton;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(334, 453);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.colorGroupBox);
            this.Controls.Add(this.fontGroupBox);
            this.MinimumSize = new System.Drawing.Size(300, 492);
            this.Name = "PreferencesDialog";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.PreferencesDialog_Load);
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.rgbGroupBox.ResumeLayout(false);
            this.rgbGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redColorComponentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColorComponentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColorComponentUpDown)).EndInit();
            this.fontGroupBox.ResumeLayout(false);
            this.fontGroupBox.PerformLayout();
            this.fontStylesGroupBox.ResumeLayout(false);
            this.fontStylesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        public PreferencesDialog()
        {

            InitializeComponent();
            color = Color.CornflowerBlue;
            font = new Font("Arial", 12, FontStyle.Bold);

            fontSizeUpDown.ValueChanged += new EventHandler(updateFontGroupBox);
            boldCheckBox.CheckStateChanged += new EventHandler(updateFontGroupBox);
            italicCheckBox.CheckStateChanged += new EventHandler(updateFontGroupBox);
            underlineCheckBox.CheckStateChanged += new EventHandler(updateFontGroupBox);

            redColorComponentUpDown.ValueChanged += new EventHandler(updateColorGroupBox);
            greenColorComponentUpDown.ValueChanged += new EventHandler(updateColorGroupBox);
            blueColorComponentUpDown.ValueChanged += new EventHandler(updateColorGroupBox);

        }

        private void PreferencesDialog_Load(object sender, EventArgs e)
        {

            updateFontGroupBox(font);
            updateColorGroupBox(color); 

        }

        private bool hasFontStyle(FontStyle thisStyle, FontStyle thatStyle)
        {

            if ((thisStyle & thatStyle) == thatStyle)
                return true;
            else
                return false;

        }

        private void updateFontStyleCheckBox(Font font, FontStyle style, CheckBox checkBox)
        {

            if (font.FontFamily.IsStyleAvailable(style))
            {

                checkBox.Enabled = true;

                if (hasFontStyle(font.Style, style))
                    checkBox.CheckState = CheckState.Checked;
                else
                    checkBox.CheckState = CheckState.Unchecked;

            }
            else
            {

                checkBox.CheckState = CheckState.Unchecked;
                checkBox.Enabled = false;

            }


        }

        private void updateFontGroupBox(Font font)
        {

            fontNameTextBox.Text = font.Name;
            fontSizeUpDown.Value = (int)font.SizeInPoints;

            updateFontStyleCheckBox(font, FontStyle.Bold, boldCheckBox);
            updateFontStyleCheckBox(font, FontStyle.Italic, italicCheckBox);
            updateFontStyleCheckBox(font, FontStyle.Underline, underlineCheckBox);

        }

        private void updateFontGroupBox(Object sender, EventArgs e)
        {
            FontStyle style = FontStyle.Regular;

            /* Get style of font. */

            if (boldCheckBox.CheckState == CheckState.Checked)
                style |= FontStyle.Bold;

            if (italicCheckBox.CheckState == CheckState.Checked)
                style |= FontStyle.Italic;

            if (underlineCheckBox.CheckState == CheckState.Checked)
                style |= FontStyle.Underline;

            font = new Font(fontNameTextBox.Text, (int)fontSizeUpDown.Value, style);
            updateFontGroupBox(font);

        }

        private void updateColorGroupBox(Color color) {

            colorPreviewPanel.BackColor = color;
            redColorComponentUpDown.Value = color.R;
            greenColorComponentUpDown.Value = color.G;
            blueColorComponentUpDown.Value = color.B;

        }

        private void updateColorGroupBox(Object sender, EventArgs e)
        {

            color = Color.FromArgb((int)redColorComponentUpDown.Value, (int)greenColorComponentUpDown.Value, (int)blueColorComponentUpDown.Value);
            updateColorGroupBox(color);

        }
        
        private void pickColorButton_Click(object sender, EventArgs e)
        {

            using (ColorDialog colorDialog = new ColorDialog())
            {

                colorDialog.Color = color;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {

                    color = colorDialog.Color;
                    updateColorGroupBox(color);

                }

            }
        }

        private void pickFontButton_Click(object sender, EventArgs e)
        {

            using (FontDialog fontDialog = new FontDialog())
            {

                fontDialog.Font = font;

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {

                    font = fontDialog.Font;
                    updateFontGroupBox(font);

                }

            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {

            if (OK != null)
                OK(this, e);

            this.Close();

        }

        private void applyButton_Click(object sender, EventArgs e)
        {

            if (Apply != null)
                Apply(this, e);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
        
            if (Cancel != null)
                Cancel(this, e);

            this.Close();

        }

    }
}
