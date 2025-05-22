namespace Paint
{
    partial class FmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbControls = new GroupBox();
            nudFontSize = new NumericUpDown();
            label2 = new Label();
            btnChangeColor = new Button();
            colorDialog = new ColorDialog();
            btnDeleteAll = new Button();
            gbControls.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) nudFontSize ).BeginInit();
            SuspendLayout();
            // 
            // gbControls
            // 
            gbControls.Controls.Add(btnDeleteAll);
            gbControls.Controls.Add(nudFontSize);
            gbControls.Controls.Add(label2);
            gbControls.Controls.Add(btnChangeColor);
            gbControls.Dock = DockStyle.Left;
            gbControls.Location = new Point(0, 0);
            gbControls.Name = "gbControls";
            gbControls.Size = new Size(156, 450);
            gbControls.TabIndex = 0;
            gbControls.TabStop = false;
            gbControls.Text = "Controls";
            // 
            // nudFontSize
            // 
            nudFontSize.Location = new Point(6, 96);
            nudFontSize.Name = "nudFontSize";
            nudFontSize.Size = new Size(120, 23);
            nudFontSize.TabIndex = 4;
            nudFontSize.ValueChanged +=  nudFontSize_ValueChanged ;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 3;
            label2.Text = "Size";
            // 
            // btnChangeColor
            // 
            btnChangeColor.Location = new Point(6, 36);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(121, 23);
            btnChangeColor.TabIndex = 1;
            btnChangeColor.Text = "ChangeColor";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click +=  btnChangeColor_Click ;
            // 
            // colorDialog
            // 
            colorDialog.AnyColor = true;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(6, 141);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(120, 23);
            btnDeleteAll.TabIndex = 5;
            btnDeleteAll.Text = "Delete All";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click +=  btnDeleteAll_Click ;
            // 
            // FmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 450);
            Controls.Add(gbControls);
            Name = "FmMain";
            ShowIcon = false;
            Text = "Main";
            KeyUp +=  FmMain_KeyUp ;
            MouseMove +=  FmMain_MouseMove ;
            gbControls.ResumeLayout(false);
            gbControls.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) nudFontSize ).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbControls;
        private NumericUpDown nudFontSize;
        private Label label2;
        private Button btnChangeColor;
        private ColorDialog colorDialog;
        private Button btnDeleteAll;
    }
}
