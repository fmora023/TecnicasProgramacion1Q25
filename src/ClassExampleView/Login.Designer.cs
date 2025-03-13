namespace ClassExample
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            label2 = new Label();
            txt_User = new TextBox();
            txt_Password = new TextBox();
            btn_Login = new Button();
            logo = new PictureBox();
            btn_ResetPassword = new Button();
            webLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webLogo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(581, 113);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "User:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(581, 158);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txt_User
            // 
            txt_User.Location = new Point(777, 113);
            txt_User.Name = "txt_User";
            txt_User.Size = new Size(227, 27);
            txt_User.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(777, 157);
            txt_Password.Name = "txt_Password";
            txt_Password.PasswordChar = '*';
            txt_Password.Size = new Size(227, 27);
            txt_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(777, 223);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(227, 29);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 93);
            logo.Name = "logo";
            logo.Size = new Size(528, 268);
            logo.TabIndex = 5;
            logo.TabStop = false;
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // btn_ResetPassword
            // 
            btn_ResetPassword.Location = new Point(777, 280);
            btn_ResetPassword.Name = "btn_ResetPassword";
            btn_ResetPassword.Size = new Size(227, 29);
            btn_ResetPassword.TabIndex = 6;
            btn_ResetPassword.Text = "Reset Password";
            btn_ResetPassword.UseVisualStyleBackColor = true;
            // 
            // webLogo
            // 
            webLogo.Location = new Point(12, 381);
            webLogo.Name = "webLogo";
            webLogo.Size = new Size(528, 217);
            webLogo.TabIndex = 7;
            webLogo.TabStop = false;
            webLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 610);
            Controls.Add(webLogo);
            Controls.Add(btn_ResetPassword);
            Controls.Add(logo);
            Controls.Add(btn_Login);
            Controls.Add(txt_Password);
            Controls.Add(txt_User);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)webLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_User;
        private TextBox txt_Password;
        private Button btn_Login;
        private PictureBox logo;
        private Button btn_ResetPassword;
        private PictureBox webLogo;
    }
}