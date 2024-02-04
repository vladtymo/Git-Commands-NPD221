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
    public partial class YouTubeLinkForm : Form
    {
        public YouTubeLinkForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.youtube.com/watch?v=KxKjBneF_NI");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.youtube.com/watch?v=jXKdGIV7O3w");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.youtube.com/watch?v=VJm_AjiTEEc&t=307s");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://www.youtube.com/watch?v=EeARyFrZsnU");
        }

        
    }
}
