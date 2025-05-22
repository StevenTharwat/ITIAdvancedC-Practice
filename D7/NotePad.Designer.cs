namespace D7
{
    partial class NotePad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            BtnOpenDialog = new Button();
            BtnOpen = new Button();
            BtnSave = new Button();
            BtnChangeForm = new Button();
            BtnChangeColor = new Button();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor =     AnchorStyles.Top  |  AnchorStyles.Bottom   |  AnchorStyles.Left   |  AnchorStyles.Right ;
            richTextBox1.Location = new Point(12, 112);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 326);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnOpenDialog
            // 
            BtnOpenDialog.Location = new Point(202, 83);
            BtnOpenDialog.Name = "BtnOpenDialog";
            BtnOpenDialog.Size = new Size(87, 23);
            BtnOpenDialog.TabIndex = 1;
            BtnOpenDialog.Text = "Open Dialog";
            BtnOpenDialog.UseVisualStyleBackColor = true;
            BtnOpenDialog.Click +=  BtnOpenDialog_Click ;
            // 
            // BtnOpen
            // 
            BtnOpen.Location = new Point(106, 83);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(75, 23);
            BtnOpen.TabIndex = 2;
            BtnOpen.Text = "open";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click +=  BtnOpen_Click_1 ;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(12, 83);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 23);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click +=  BtnSave_Click ;
            // 
            // BtnChangeForm
            // 
            BtnChangeForm.Location = new Point(309, 83);
            BtnChangeForm.Name = "BtnChangeForm";
            BtnChangeForm.Size = new Size(75, 23);
            BtnChangeForm.TabIndex = 4;
            BtnChangeForm.Text = "Font";
            BtnChangeForm.UseVisualStyleBackColor = true;
            BtnChangeForm.Click +=  BtnChangeForm_Click ;
            // 
            // BtnChangeColor
            // 
            BtnChangeColor.Location = new Point(416, 83);
            BtnChangeColor.Name = "BtnChangeColor";
            BtnChangeColor.Size = new Size(75, 23);
            BtnChangeColor.TabIndex = 5;
            BtnChangeColor.Text = "Color";
            BtnChangeColor.UseVisualStyleBackColor = true;
            BtnChangeColor.Click +=  BtnChangeColor_Click ;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // NotePad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnChangeColor);
            Controls.Add(BtnChangeForm);
            Controls.Add(BtnSave);
            Controls.Add(BtnOpen);
            Controls.Add(BtnOpenDialog);
            Controls.Add(richTextBox1);
            Name = "NotePad";
            Text = "NotePad";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button BtnOpenDialog;
        private Button BtnOpen;
        private Button BtnSave;
        private Button BtnChangeForm;
        private Button BtnChangeColor;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}