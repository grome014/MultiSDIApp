using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Group8_Homework6
{
    class MultiSDIApplication: WindowsFormsApplicationBase
    {
        private static MultiSDIApplication application;
        internal static MultiSDIApplication Application
        {
            get
            {
                if (application == null)
                {
                    application = new MultiSDIApplication();
                }
                return application;
            }
        }
        public MultiSDIApplication()
        {
            this.IsSingleInstance = true;
            this.ShutdownStyle = ShutdownMode.AfterAllFormsClose;
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = this.CreateTopLevelWindow(this.CommandLineArgs);
        }

        private System.Windows.Forms.Form CreateTopLevelWindow(
            ReadOnlyCollection<string> args)
        {
            String fileName = null;
            if (args.Count > 0) fileName = args[0];
            return MultiSDIForm.CreateTopLevelWindow(fileName);
        }

        protected override void OnStartupNextInstance(
            StartupNextInstanceEventArgs eventArgs)
        {
            this.CreateTopLevelWindow(eventArgs.CommandLine);
        }

        public void AddTopLevelForm(Form form)
        {
            form.FormClosed += form_FormClosed;
        }

        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form = sender as Form;
            if (form == this.MainForm &&
                this.OpenForms.Count > 0)
            {
                this.MainForm = (Form)this.OpenForms[0];
            }
            form.FormClosed -= form_FormClosed;
        }

        public void AddWindowMenu(ToolStripMenuItem windowMenu)
        {
            windowMenu.DropDownOpening += windowMenu_DropDownOpening;
        }

        void windowMenu_DropDownOpening(object sender, EventArgs e)
        {
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            menu.DropDownItems.Clear();
            foreach (Form form in this.OpenForms)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(form.Text);
                item.Tag = form;
                item.Click += item_Click;
                item.Checked = form == Form.ActiveForm;
                menu.DropDownItems.Add(item);
            }
        }

        void item_Click(object sender, EventArgs e)
        {
            ((Form)((ToolStripMenuItem)sender).Tag).Activate();
        }
    }
}

