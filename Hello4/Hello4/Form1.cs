using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello4
{
    public partial class Form1 : Form
    {
        private String[] args;
        public Form1()
        {
            InitializeComponent();
            args = Environment.GetCommandLineArgs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String msg = "Hello World!\n";
            if (args.Length == 0)
            {
                msg += "There is no argument.\n";
            }
            else
            {
                msg += $"There are {args.Length} argument(s).\nThey are:\n";
                for (int i = 0; i < args.Length; ++i)
                {
                    msg += args[i] + "\n";
                }
            }
            this.label1.Text = msg;
        }
    }
}
