namespace Panel.UI
{
    partial class LogInForm
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
            this.dgwUser = new System.Windows.Forms.DataGridView();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gbxLogin = new System.Windows.Forms.GroupBox();
            this.lblArentyououruser = new System.Windows.Forms.Label();
            this.btnSignUpForm = new System.Windows.Forms.Button();
            this.btnRefreshDb = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPswdSee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).BeginInit();
            this.gbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUser
            // 
            this.dgwUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUser.Location = new System.Drawing.Point(58, 399);
            this.dgwUser.Name = "dgwUser";
            this.dgwUser.RowTemplate.Height = 24;
            this.dgwUser.Size = new System.Drawing.Size(488, 201);
            this.dgwUser.TabIndex = 0;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(28, 61);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(163, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Kullanıcı Adı:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(116, 133);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre:";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(197, 58);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(349, 25);
            this.tbxUsername.TabIndex = 3;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(197, 130);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(349, 25);
            this.tbxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(409, 176);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 47);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Giriş yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gbxLogin
            // 
            this.gbxLogin.Controls.Add(this.btnPswdSee);
            this.gbxLogin.Controls.Add(this.lblArentyououruser);
            this.gbxLogin.Controls.Add(this.btnSignUpForm);
            this.gbxLogin.Controls.Add(this.lblUsername);
            this.gbxLogin.Controls.Add(this.btnLogin);
            this.gbxLogin.Controls.Add(this.lblPassword);
            this.gbxLogin.Controls.Add(this.tbxPassword);
            this.gbxLogin.Controls.Add(this.tbxUsername);
            this.gbxLogin.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxLogin.Location = new System.Drawing.Point(12, 12);
            this.gbxLogin.Name = "gbxLogin";
            this.gbxLogin.Size = new System.Drawing.Size(589, 307);
            this.gbxLogin.TabIndex = 6;
            this.gbxLogin.TabStop = false;
            this.gbxLogin.Text = "Kullanıcı Girişi";
            // 
            // lblArentyououruser
            // 
            this.lblArentyououruser.AutoSize = true;
            this.lblArentyououruser.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArentyououruser.Location = new System.Drawing.Point(77, 271);
            this.lblArentyououruser.Name = "lblArentyououruser";
            this.lblArentyououruser.Size = new System.Drawing.Size(343, 14);
            this.lblArentyououruser.TabIndex = 8;
            this.lblArentyououruser.Text = "Hala üye değil misiniz? Hemen kayıt olun !";
            // 
            // btnSignUpForm
            // 
            this.btnSignUpForm.Location = new System.Drawing.Point(426, 259);
            this.btnSignUpForm.Name = "btnSignUpForm";
            this.btnSignUpForm.Size = new System.Drawing.Size(120, 34);
            this.btnSignUpForm.TabIndex = 7;
            this.btnSignUpForm.Text = "Kayıt ol";
            this.btnSignUpForm.UseVisualStyleBackColor = true;
            this.btnSignUpForm.Click += new System.EventHandler(this.btnSignUpForm_Click);
            // 
            // btnRefreshDb
            // 
            this.btnRefreshDb.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefreshDb.Location = new System.Drawing.Point(409, 346);
            this.btnRefreshDb.Name = "btnRefreshDb";
            this.btnRefreshDb.Size = new System.Drawing.Size(137, 47);
            this.btnRefreshDb.TabIndex = 9;
            this.btnRefreshDb.Text = "Yenile";
            this.btnRefreshDb.UseVisualStyleBackColor = true;
            this.btnRefreshDb.Click += new System.EventHandler(this.btnRefreshDb_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Lucida Console", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(266, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 47);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPswdSee
            // 
            this.btnPswdSee.Location = new System.Drawing.Point(552, 133);
            this.btnPswdSee.Name = "btnPswdSee";
            this.btnPswdSee.Size = new System.Drawing.Size(29, 22);
            this.btnPswdSee.TabIndex = 9;
            this.btnPswdSee.Text = "*";
            this.btnPswdSee.UseVisualStyleBackColor = true;
            this.btnPswdSee.Click += new System.EventHandler(this.btnPswdSee_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 666);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefreshDb);
            this.Controls.Add(this.gbxLogin);
            this.Controls.Add(this.dgwUser);
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DV/Giriş Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUser)).EndInit();
            this.gbxLogin.ResumeLayout(false);
            this.gbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox gbxLogin;
        private System.Windows.Forms.Label lblArentyououruser;
        private System.Windows.Forms.Button btnSignUpForm;
        private System.Windows.Forms.Button btnRefreshDb;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPswdSee;
    }
}

