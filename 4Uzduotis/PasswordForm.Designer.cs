
namespace _4Uzduotis
{
    partial class PasswordForm
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDecryptedPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowPass = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddToClipboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(96, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(256, 22);
            this.txtPassword.TabIndex = 0;
            // 
            // txtDecryptedPass
            // 
            this.txtDecryptedPass.Location = new System.Drawing.Point(96, 192);
            this.txtDecryptedPass.Name = "txtDecryptedPass";
            this.txtDecryptedPass.Size = new System.Drawing.Size(256, 22);
            this.txtDecryptedPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decrypted password:";
            // 
            // btnShowPass
            // 
            this.btnShowPass.Location = new System.Drawing.Point(232, 224);
            this.btnShowPass.Name = "btnShowPass";
            this.btnShowPass.Size = new System.Drawing.Size(120, 32);
            this.btnShowPass.TabIndex = 4;
            this.btnShowPass.Text = "Show password";
            this.btnShowPass.UseVisualStyleBackColor = true;
            this.btnShowPass.Click += new System.EventHandler(this.btnShowPass_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(8, 336);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 55);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddToClipboard
            // 
            this.btnAddToClipboard.Location = new System.Drawing.Point(96, 224);
            this.btnAddToClipboard.Name = "btnAddToClipboard";
            this.btnAddToClipboard.Size = new System.Drawing.Size(120, 32);
            this.btnAddToClipboard.TabIndex = 6;
            this.btnAddToClipboard.Text = "Add to clipboard";
            this.btnAddToClipboard.UseVisualStyleBackColor = true;
            this.btnAddToClipboard.Click += new System.EventHandler(this.btnAddToClipboard_Click);
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 399);
            this.ControlBox = false;
            this.Controls.Add(this.btnAddToClipboard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecryptedPass);
            this.Controls.Add(this.txtPassword);
            this.Name = "PasswordForm";
            this.Text = "PasswordForm";
            this.Load += new System.EventHandler(this.PasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDecryptedPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddToClipboard;
    }
}