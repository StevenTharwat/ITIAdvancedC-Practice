namespace D7
{
    public partial class NotePadDialog : Form
    {
        public string Str = "";
        public NotePadDialog()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Str = textBox1.Text;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
