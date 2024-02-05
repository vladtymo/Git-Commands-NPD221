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

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            CommitCheckoutForms commitCheckoutForms = new CommitCheckoutForms();
            commitCheckoutForms.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PushForm pushForm = new PushForm();     
            pushForm.Show();  //fdgfd
        }
    }
}
