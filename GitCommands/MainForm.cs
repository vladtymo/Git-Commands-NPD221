namespace GitCommands
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommitForm commitForm = new CommitForm();
            commitForm.Show();
            //commitForm.ShowDialog();
        }

        private void button_Click_Branch(object sender, EventArgs e)
        {
            BranchForm branchForm = new BranchForm();
            branchForm.Show();
        }
    }
}
