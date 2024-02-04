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
    public partial class CommitCheckoutForms : Form
    {
        public CommitCheckoutForms()
        {
            InitializeComponent();
        }

        private void buttonYouTube_Click(object sender, EventArgs e)
        {
            YouTubeLinkForm youTubeLinkForm = new YouTubeLinkForm();
            youTubeLinkForm.ShowDialog();
        }

        private void buttonSite_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://git-scm.com/docs/git-checkout");
        }
    }
}
