using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Group8_Homework6
{
    public enum ProcessKeysEnum { None, ProcessCmdKey, IsInputKey, ProcessCmdKeyTrue, OnPreviewKeyDown, OnPreviewKeyDownTrue }
    public partial class MultiSDIForm : Form
    {
        private DocumentFont document;
        private DocumentFont savedDocument;     // Saved document settings to revert
                                                // to original when user clicks 
                                                // cancel in Preferences Dialog.

        private PreferencesDialog preferencesDialog;
        private bool needSaving = false;       

        private string FileName {get; set;}
        public static ProcessKeysEnum ProcessKeys
        {
            get; set;
        }
        public IEnumerable<Form> OpenForms { get; private set; }

        static int formCount = 0;
        private string appName;

        public MultiSDIForm()
        {
            InitializeComponent();
            document = new DocumentFont();
            updateTextBox();
            updateStatusLabel();
            formCount++;
            appName = "MultiSDIApp: " + formCount.ToString();
            this.Text = appName;
            MultiSDIApplication.Application.AddTopLevelForm(this);
            MultiSDIApplication.Application.AddWindowMenu(windowToolStripMenuItem);
            
            
            ProcessKeys = ProcessKeysEnum.ProcessCmdKey;
        }


        private void notifyIconMenuStrip(object sender, EventArgs e)
        {
            
            notifyIcon.ContextMenuStrip.Items.Add(windowToolStripMenuItem);
            notifyIcon.ContextMenuStrip.Show();
        }

        

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OathDialog oath = new OathDialog())
            {
                oath.ShowDialog(this);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutDialog about = new AboutDialog();
            about.Show();
        }

        private void updateTextBox()
        {
            this.textBox.Font = document.Font;
            this.textBox.ForeColor = document.Color;
            this.textBox.Text = document.Text;
        }

        private void saveDocument()
        {
            document.Font = this.textBox.Font;
            document.Color = this.textBox.ForeColor;
            document.Text = this.textBox.Text;
        }

        public void Serialize(string fileName)
        {
            using (Stream stream =
                new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, document);
            }
        }

        public void Deserialize(string fileName)
        {
            using (Stream stream =
                new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                IFormatter formatter = new BinaryFormatter();
                document = (DocumentFont)formatter.Deserialize(stream);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; 
                if ( dlg.ShowDialog() == DialogResult.OK)
                {
                    MultiSDIForm.CreateTopLevelWindow(dlg.FileName);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Changed this if statement. Would not save because document has default name thus making file name != null. If statement now checks for null as well as default file name */
            if (FileName == null || FileName.Contains("Untitled")) 
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }

            else
            {
                saveDocument();
                Serialize(FileName);
            }
        }


        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDocument();
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = "txt";
                dlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Serialize(FileName = dlg.FileName);
                    this.FileName = dlg.FileName;
                    this.Text = appName + " (" + this.FileName + ") ";
                    needSaving = false;
                }
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToClipboard(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, textBox.SelectedText);
        }

        private void cutFromClipboard(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, textBox.SelectedText);
            textBox.SelectedText = "";
        }

        private void pasteFromClipboard(object sender, EventArgs e)
        {
            textBox.Paste((String)Clipboard.GetData(DataFormats.Text)); 
        }

        private void updateStatusLabel()
        {
            
            if(Control.IsKeyLocked(Keys.CapsLock))
            {
                this.toolStripStatusLabel.Text = "Current Font: " + textBox.Font.Size + " "
                + textBox.Font.Name + " " + textBox.ForeColor.Name + " CapsLock On";
            }
            else
            {
                this.toolStripStatusLabel.Text = "Current Font: " + textBox.Font.Size + " "
                + textBox.Font.Name + " " + textBox.ForeColor.Name + " CapsLock Off";
            }

        }

        private void updateCapsLock(object sender, KeyEventArgs e)
        {
            updateStatusLabel();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needSaving)
            {
                DialogResult confirmExit = MessageBox.Show("You have unsaved changes. Do you want to save them before quitting?", "Exit Application?", MessageBoxButtons.YesNoCancel);

               //e.Cancel = (confirmExit == DialogResult.Cancel);

                if(confirmExit == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }

                else if (confirmExit == DialogResult.No)
                {
                    //skip 
                }

                else
                {
                    //User made mistake and wants to cancel
                    e.Cancel = true;
                }
            }               
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            needSaving = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiSDIForm.CreateTopLevelWindow(null);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            MultiSDIForm.CreateTopLevelWindow(null);
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // MainForm
        //    // 
        //    this.ClientSize = new System.Drawing.Size(360, 280);
        //    this.Name = "MainForm";
        //    this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
        //    this.ResumeLayout(false);

        //}

        public static MultiSDIForm CreateTopLevelWindow(String fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                foreach (MultiSDIForm form in Application.OpenForms)
                {
                    if (String.Compare(form.FileName, fileName, true) == 0)
                    {
                        form.Activate();
                        return form;
                    }
                }
            }

            MultiSDIForm newForm = new MultiSDIForm();
            newForm.OpenFile(fileName);
            newForm.Show();
            newForm.Activate();
            return newForm;
        }


        private void OpenFile(String fileName)
        {
            this.FileName = fileName;
            if (!string.IsNullOrEmpty(FileName))
            {
                Deserialize(FileName);
                updateTextBox();
                updateStatusLabel();
                needSaving = false;
            }
            else
            {
                this.FileName = "Untitled " + formCount.ToString();
            }
            this.Text = this.Text + " (" + this.FileName + ") ";
        }

        private void Form_DoDragDrop(object sender, MouseEventArgs e)
        {
            DoDragDrop(this.Text, DragDropEffects.Copy);
        }

        private void Form_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(string)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form_DragDrop(object sender, DragEventArgs e)
        {
            textBox.Text = (String)e.Data.GetData(typeof(String));
        }

        /* 'Apply' */
        private void applyUserPreferences(object sender, EventArgs e)
        {

            document.Font = preferencesDialog.font;
            document.Color = preferencesDialog.color;
            document.Text = textBox.Text;
            updateTextBox();
            updateStatusLabel();
        }

        /* 'Cancel' */
        private void cancelUserPreferences(object sender, EventArgs e)
        {

            document = savedDocument;

        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            preferencesDialog = new PreferencesDialog();
            preferencesDialog.color = document.Color;
            preferencesDialog.font = document.Font;

            preferencesDialog.Apply += new EventHandler(applyUserPreferences);
            preferencesDialog.Cancel += new EventHandler(cancelUserPreferences);

            savedDocument = document;
            preferencesDialog.Show();

        }



        private void statusStrip_KeyUp(object sender, KeyEventArgs e)
        {

            updateStatusLabel();
        }

        private void statusStrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(IsKeyLocked(Keys.CapsLock))
            {
                updateStatusLabel();
            }
            
        }

        private void statusStrip_Click(object sender, EventArgs e)
        {
            updateStatusLabel();
        }

        /*
        private void textBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            moveMe(e.KeyCode);
        }
        */
        private void moveMe(Keys key)
        {
            Point location = this.Location;
            /*
            if(ModifierKeys != Keys.Control)
            {
                return;
            }
            */
            switch(key)
            {
                case Keys.Up | Keys.Control:
                    --location.Y;
                    break;

                case Keys.Down | Keys.Control:
                    ++location.Y;
                    break;

                case Keys.Left | Keys.Control:
                    --location.X;
                    break;

                case Keys.Right | Keys.Control:
                    ++location.X;
                    break;
            }
            this.Location = location;
        }
        /*
        private void MultiSDIForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Up && e.Control)
            {
                this.Top += 1;
            }

            if(e.KeyCode == Keys.Down && e.Control)
            {
                this.Top -= 1;
            }

            if (e.KeyCode == Keys.Left && e.Control)
            {
                this.Left += 1;
            }

            if (e.KeyCode == Keys.Right && e.Control)
            {
                this.Left -= 1;
            }
        }
        */
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (ProcessKeys == ProcessKeysEnum.ProcessCmdKey)
            {
                moveMe(keyData);
                if (ProcessKeys == ProcessKeysEnum.ProcessCmdKeyTrue)
                {
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
