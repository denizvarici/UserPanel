namespace Panel.UI
{
    partial class MailVerificationForm
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
            this.gbxMailVerification = new System.Windows.Forms.GroupBox();
            this.mskTbxMailVerification = new System.Windows.Forms.MaskedTextBox();
            this.lblVerifCode = new System.Windows.Forms.Label();
            this.lblVerifInfo = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnSendMeVerificationMail = new System.Windows.Forms.Button();
            this.gbxMailVerification.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMailVerification
            // 
            this.gbxMailVerification.Controls.Add(this.btnSendMeVerificationMail);
            this.gbxMailVerification.Controls.Add(this.btnConfirm);
            this.gbxMailVerification.Controls.Add(this.lblVerifInfo);
            this.gbxMailVerification.Controls.Add(this.lblVerifCode);
            this.gbxMailVerification.Controls.Add(this.mskTbxMailVerification);
            this.gbxMailVerification.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxMailVerification.Location = new System.Drawing.Point(12, 12);
            this.gbxMailVerification.Name = "gbxMailVerification";
            this.gbxMailVerification.Size = new System.Drawing.Size(691, 217);
            this.gbxMailVerification.TabIndex = 0;
            this.gbxMailVerification.TabStop = false;
            // 
            // mskTbxMailVerification
            // 
            this.mskTbxMailVerification.Font = new System.Drawing.Font("Lucida Console", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTbxMailVerification.Location = new System.Drawing.Point(223, 64);
            this.mskTbxMailVerification.Mask = "000-000";
            this.mskTbxMailVerification.Name = "mskTbxMailVerification";
            this.mskTbxMailVerification.PromptChar = '-';
            this.mskTbxMailVerification.Size = new System.Drawing.Size(206, 54);
            this.mskTbxMailVerification.TabIndex = 0;
            // 
            // lblVerifCode
            // 
            this.lblVerifCode.AutoSize = true;
            this.lblVerifCode.Location = new System.Drawing.Point(219, 32);
            this.lblVerifCode.Name = "lblVerifCode";
            this.lblVerifCode.Size = new System.Drawing.Size(207, 19);
            this.lblVerifCode.TabIndex = 1;
            this.lblVerifCode.Text = " Verification Code";
            // 
            // lblVerifInfo
            // 
            this.lblVerifInfo.AutoSize = true;
            this.lblVerifInfo.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVerifInfo.Location = new System.Drawing.Point(6, 188);
            this.lblVerifInfo.Name = "lblVerifInfo";
            this.lblVerifInfo.Size = new System.Drawing.Size(487, 14);
            this.lblVerifInfo.TabIndex = 2;
            this.lblVerifInfo.Text = "*Mail adresinize gönderilen doğrulama kodunu buraya giriniz.";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(264, 124);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(119, 42);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Onayla";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnSendMeVerificationMail
            // 
            this.btnSendMeVerificationMail.Location = new System.Drawing.Point(223, 24);
            this.btnSendMeVerificationMail.Name = "btnSendMeVerificationMail";
            this.btnSendMeVerificationMail.Size = new System.Drawing.Size(228, 138);
            this.btnSendMeVerificationMail.TabIndex = 4;
            this.btnSendMeVerificationMail.Text = "Onay Maili Gönder";
            this.btnSendMeVerificationMail.UseVisualStyleBackColor = true;
            this.btnSendMeVerificationMail.Click += new System.EventHandler(this.btnSendMeVerificationMail_Click);
            // 
            // MailVerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 252);
            this.Controls.Add(this.gbxMailVerification);
            this.Name = "MailVerificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DV/Mail Doğrulama";
            this.Load += new System.EventHandler(this.MailVerificationForm_Load);
            this.gbxMailVerification.ResumeLayout(false);
            this.gbxMailVerification.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMailVerification;
        private System.Windows.Forms.MaskedTextBox mskTbxMailVerification;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblVerifInfo;
        private System.Windows.Forms.Label lblVerifCode;
        private System.Windows.Forms.Button btnSendMeVerificationMail;
    }
}