namespace D7
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }

        }

        private void BtnOpen_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void BtnChangeForm_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void BtnOpenDialog_Click(object sender, EventArgs e)
        {
            NotePadDialog notePadDialog = new NotePadDialog();
            if (notePadDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = notePadDialog.Str;
            }
        }
    }
}
