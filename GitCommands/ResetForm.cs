using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitCommands
{
    public partial class ResetForm : Form
    {
        public ResetForm()
        {
            InitializeComponent();
        }

        private void button_learnmore_Click(object sender, EventArgs e)
        {
            Process.Start("msedge.exe", "https://git-scm.com/docs/git-reset");
        }
    }
}
