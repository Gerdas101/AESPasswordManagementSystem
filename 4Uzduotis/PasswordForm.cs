using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4Uzduotis
{
    
    public partial class PasswordForm : Form
    {
        public string password { get; set; }
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            string decryptedPassword = AESTextEncryptor.DecryptString(key, password);
            txtDecryptedPass.Text = decryptedPassword;
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            this.txtPassword.Text = this.password;
        }

        private void btnAddToClipboard_Click(object sender, EventArgs e)
        {
            if(txtDecryptedPass.Text != "")
            {
                System.Windows.Forms.Clipboard.SetText(txtDecryptedPass.Text);

            }
        }
    }
}
