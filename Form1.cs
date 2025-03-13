using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Генерация пароля и вывод в TextBox
            txtPassword.Text = GeneratePassword(12); // Устанавливаем длину пароля, например 12 символов
        }

        private string GeneratePassword(int length)
        {
            const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numbers = "0123456789";
            const string symbols = "!@#$%^&*()_-+=<>?/";

            string charSet = letters + numbers + symbols;

            Random rnd = new Random();
            return new string(Enumerable.Repeat(charSet, length)
                .Select(s => s[rnd.Next(s.Length)]).ToArray());
        }
    }
}
