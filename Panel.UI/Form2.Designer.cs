namespace Panel.UI
{
    partial class SignUpForm
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
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.tbxMailAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeePswd2 = new System.Windows.Forms.Button();
            this.btnSeePswd1 = new System.Windows.Forms.Button();
            this.lblPasswordVerification = new System.Windows.Forms.Label();
            this.tbxPasswordVerification = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.tbxMailAddress);
            this.gbxLogin.Controls.Add(this.label1);
            this.gbxLogin.Controls.Add(this.btnSeePswd2);
            this.gbxLogin.Controls.Add(this.btnSeePswd1);
            this.gbxLogin.Controls.Add(this.lblPasswordVerification);
            this.gbxLogin.Controls.Add(this.tbxPasswordVerification);
            this.gbxLogin.Controls.Add(this.lblUsername);
            this.gbxLogin.Controls.Add(this.btnSignUp);
            this.gbxLogin.Controls.Add(this.lblPassword);
            this.gbxLogin.Controls.Add(this.tbxPassword);
            this.gbxLogin.Controls.Add(this.tbxUsername);
            this.gbxLogin.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(774, 494);
            this.gbxLogin.TabIndex = 7;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Kayıt Ekranı";
            this.gbxLogin.Enter += new System.EventHandler(this.gbxLogin_Enter);
            // 
            // tbxMailAddress
            // 
            this.tbxMailAddress.Location = new System.Drawing.Point(281, 169);
            this.tbxMailAddress.Name = "tbxMailAddress";
            this.tbxMailAddress.Size = new System.Drawing.Size(349, 25);
            this.tbxMailAddress.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mail:";
            // 
            // btnSeePswd2
            // 
            this.btnSeePswd2.Location = new System.Drawing.Point(636, 289);
            this.btnSeePswd2.Name = "btnSeePswd2";
            this.btnSeePswd2.Size = new System.Drawing.Size(33, 23);
            this.btnSeePswd2.TabIndex = 8;
            this.btnSeePswd2.Text = "*";
            this.btnSeePswd2.UseVisualStyleBackColor = true;
            this.btnSeePswd2.Click += new System.EventHandler(this.btnSeePswd2_Click);
            // 
            // btnSeePswd1
            // 
            this.btnSeePswd1.Location = new System.Drawing.Point(636, 229);
            this.btnSeePswd1.Name = "btnSeePswd1";
            this.btnSeePswd1.Size = new System.Drawing.Size(33, 23);
            this.btnSeePswd1.TabIndex = 7;
            this.btnSeePswd1.Text = "*";
            this.btnSeePswd1.UseVisualStyleBackColor = true;
            this.btnSeePswd1.Click += new System.EventHandler(this.btnSeePswd1_Click);
            // 
            // lblPasswordVerification
            // 
            this.lblPasswordVerification.AutoSize = true;
            this.lblPasswordVerification.Location = new System.Drawing.Point(90, 289);
            this.lblPasswordVerification.Name = "lblPasswordVerification";
            this.lblPasswordVerification.Size = new System.Drawing.Size(185, 19);
            this.lblPasswordVerification.TabIndex = 6;
            this.lblPasswordVerification.Text = "Şifreyi doğrula:";
            // 
            // tbxPasswordVerification
            // 
            this.tbxPasswordVerification.Location = new System.Drawing.Point(281, 286);
            this.tbxPasswordVerification.Name = "tbxPasswordVerification";
            this.tbxPasswordVerification.PasswordChar = '*';
            this.tbxPasswordVerification.Size = new System.Drawing.Size(349, 25);
            this.tbxPasswordVerification.TabIndex = 5;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(112, 110);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(163, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Kullanıcı Adı:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(493, 358);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(137, 47);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Kayıt ol";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(200, 229);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(281, 226);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(349, 25);
            this.tbxPassword.TabIndex = 4;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(281, 107);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(349, 25);
            this.tbxUsername.TabIndex = 3;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 518);
            this.Controls.Add(this.gbxLogin);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DV/Kayıt ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Label lblPasswordVerification;
        private System.Windows.Forms.TextBox tbxPasswordVerification;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Button btnSeePswd2;
        private System.Windows.Forms.Button btnSeePswd1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMailAddress;
    }
}