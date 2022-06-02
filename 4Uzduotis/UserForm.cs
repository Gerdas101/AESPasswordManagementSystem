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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AESFileEncryptor.Cipher();
            this.Close();
        }
        private void btnGeneratePass_Click(object sender, EventArgs e)
        {
            int length = 9;
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            this.txtPassword1.Text = res.ToString();
        }
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            string passwordEcrypted = AESTextEncryptor.EncryptString(key, txtPassword1.Text);
            using (var writer = File.AppendText(FileInfo.fileName))
            {
                string line = txtUsername1.Text + " " + passwordEcrypted + " " + txtUrl1.Text + " " + txtComment1.Text;
                writer.WriteLine(line);
                MessageBox.Show("Account added!");
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // If line does not contain specified data, it moves it into temp.txt.
            // After loop, data from temp.txt copied into original file.
            // File temp.txt is cleard
            foreach (string line in File.ReadAllLines(FileInfo.filePath + FileInfo.fileName))
            {
                if (line.Contains(txtUsername2.Text) && line.Contains(txtUrl2.Text))
                {

                }
                else
                {
                    using (var writer = File.AppendText(FileInfo.filePath + "temp.txt"))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            File.Copy(FileInfo.filePath + "temp.txt", FileInfo.filePath + FileInfo.fileName, true);
            File.WriteAllText(FileInfo.filePath + "temp.txt", String.Empty);
            MessageBox.Show("Account deleted");
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            string newEncryptedPassword = AESTextEncryptor.EncryptString(key, txtNewPassword.Text);
            foreach (string line in File.ReadAllLines(FileInfo.filePath + FileInfo.fileName))
            {
                if (line.Contains(txtUsername3.Text) && line.Contains(txtUrl3.Text))
                {
                    string[] words = line.Split(' ');

                    String strFile = File.ReadAllText(FileInfo.filePath + FileInfo.fileName);
                    strFile = strFile.Replace(words[1], newEncryptedPassword);
                    File.WriteAllText(FileInfo.filePath + FileInfo.fileName, strFile);
                    MessageBox.Show("Password changed!");
                }
            }
        }
        private void btnSearchPass_Click(object sender, EventArgs e)
        {
            PasswordForm passwordForm = new PasswordForm();
            if(txtUsername4.Text == "" && txtUrl4.Text == "")
            {
                string line1 = File.ReadLines(FileInfo.filePath + FileInfo.fileName).First();
                passwordForm.password = line1;
                passwordForm.Show();
            }
            else
            {
                foreach (string line in File.ReadAllLines(FileInfo.filePath + FileInfo.fileName))
                {
                    if (line.Contains(txtUsername4.Text) && line.Contains(txtUrl4.Text))
                    {
                        string[] words = line.Split(' ');
                        passwordForm.password = words[1];
                        passwordForm.Show();
                    }
                }
            }
        }
    }
}
