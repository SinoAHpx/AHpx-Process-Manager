using ProcessMGR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Core.KillProcess("javaw");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Core.SuspendProcess("javaw");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Core.ResumeProcess("javaw");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Core.StartProcess(@"C:\Users\AHpx\Desktop\VisualStudio Projects\AHpxToolsBox\AHpxToolsBox\bin\Debug\AHpxToolsBox.exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Core.ChangeWindowTitle("This is a test", "javaw");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Core.IsProcessExist("javaw"))
            {
                MessageBox.Show("Exist!!");
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Core.IsWindowExist("This is a test"))
            {
                MessageBox.Show("Exist!!");
            }
        }
    }
}
