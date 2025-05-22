namespace D7
{
    partial class Login
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
            txtPass = new TextBox();
            txtUserName = new TextBox();
            BtnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPass
            // 
            txtPass.Location = new Point(87, 98);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(182, 23);
            txtPass.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(87, 55);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(182, 23);
            txtUserName.TabIndex = 0;
            // 
            // BtnLogin
            // 
            BtnLogin.Location = new Point(64, 159);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(205, 23);
            BtnLogin.TabIndex = 2;
            BtnLogin.Text = "login";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click +=  BtnLogin_Click ;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 101);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 58);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "userName";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 217);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnLogin);
            Controls.Add(txtUserName);
            Controls.Add(txtPass);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPass;
        private TextBox txtUserName;
        private Button BtnLogin;
        private Label label1;
        private Label label2;
    }
}