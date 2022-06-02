using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _4Uzduotis
{
    public partial class LoginRegisterForm : Form
    {
        public LoginRegisterForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            FileInfo.fileName = this.txtUsername.Text + ".txt";

            if (File.Exists(FileInfo.filePath + FileInfo.fileName))
            {
                AESFileEncryptor.Decipher();
                string[] lines = File.ReadAllLines(FileInfo.filePath + FileInfo.fileName);
                string decryptedPassword = AESTextEncryptor.DecryptString(key, lines[0]);
                if (decryptedPassword == txtPassword.Text)
                {
                    UserForm userForm = new UserForm();
                    userForm.Show();
                }
                else
                {
                    MessageBox.Show("Neteisingas slaptazodis");
                    AESFileEncryptor.Cipher();
                }
            }
            else
            {
                MessageBox.Show("Username does not exists!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            FileInfo.fileName = this.txtUsername.Text + ".txt";

            if(File.Exists(FileInfo.filePath + FileInfo.fileName))
            {
                MessageBox.Show("Username already exists!");
            }
            else
            {
                File.Create(FileInfo.filePath + FileInfo.fileName).Close();
                string encryptedPassword = AESTextEncryptor.EncryptString(key, this.txtPassword.Text);

                using (var writer = File.AppendText(FileInfo.fileName))
                {
                    writer.WriteLine(encryptedPassword);
                }

                UserForm userForm = new UserForm();
                userForm.Show();
            }
        }
    }
}
