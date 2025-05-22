namespace D7
{
    partial class NotePadDialog
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
            BtnCancel = new Button();
            BtnSave = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(178, 132);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(117, 36);
            BtnCancel.TabIndex = 0;
            BtnCancel.Text = "cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click +=  BtnCancel_Click ;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(55, 132);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(117, 36);
            BtnSave.TabIndex = 1;
            BtnSave.Text = "save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click +=  BtnSave_Click ;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 78);
            textBox1.TabIndex = 2;
            // 
            // NotePadDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 212);
            Controls.Add(textBox1);
            Controls.Add(BtnSave);
            Controls.Add(BtnCancel);
            Name = "NotePadDialog";
            Text = "NotePadDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Button BtnSave;
        private TextBox textBox1;
    }
}