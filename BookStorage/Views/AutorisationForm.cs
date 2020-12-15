using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStorage.Services;
using BookStorage.Models;
namespace BookStorage.Views
{
    public partial class AutorisationForm : Form
    {
        private StorageContext _context;
        public AutorisationForm(StorageContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            var login = loginBox.Text;
            var password = passwordBox.Text;
            var result = _context.AutorisationProvider.SignIn(login, password);

            if(result == null)
            {
                MessageBox.Show("Ошибка! Введите логин и пароль для входа");
            }
            else
            {
                Hide();
                var window = new MainForm(result, _context);
                window.ShowDialog();
                Close();
            }
        }
    }
}
