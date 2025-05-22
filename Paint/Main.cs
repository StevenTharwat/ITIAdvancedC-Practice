namespace Paint
{
    public partial class FmMain : Form
    {
        int FontSize = 10;
        Color color = Color.Black;
        Graphics graphics;
        public FmMain()
        {
            InitializeComponent();
            nudFontSize.Value = FontSize;
        }

        private void FmMain_MouseMove(object sender, MouseEventArgs e)
        {
            graphics = CreateGraphics();

            if (e.Button == MouseButtons.Left) graphics.FillEllipse(new SolidBrush(color), e.X - ( FontSize / 2 ), e.Y - ( FontSize / 2 ), FontSize, FontSize);
            else if (e.Button == MouseButtons.Right) graphics.FillEllipse(new SolidBrush(BackColor), e.X - ( FontSize / 2 ), e.Y - ( FontSize / 2 ), FontSize, FontSize);
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            if (sender == null) return;
            NumericUpDown numericUpDown = (NumericUpDown) sender;
            FontSize = (int) numericUpDown.Value;
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                color = colorDialog.Color;
        }

        private void FmMain_KeyUp(object sender, KeyEventArgs e)
        {
            MessageBox.Show("up");
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            graphics?.Clear(BackColor);
        }
    }
}

