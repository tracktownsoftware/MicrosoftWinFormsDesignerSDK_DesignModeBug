using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyButtonLibrary2
{
    public partial class MyButtonDialog : Form
    {
        public MyButtonDialog()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;
            this.Load += MyButtonDialog_Load;
        }

        private void MyButtonDialog_Load(object? sender, EventArgs e)
        {
            this.textBox1.Text = "DesignMode:" + DesignMode + Environment.NewLine 
                + "Process:" + System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
