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
    public partial class MainForm : Form
    {
        private User _User { get; }
        private StorageContext _context { get; set; }
        public MainForm(User user, StorageContext context)
        {
            InitializeComponent();
            _User = user;
            _context = context;
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            if(_User.Role == "Admin")
            {
                Hide();
                var window = new AdminForm(_context);
                window.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка! У вас не достаточно прав чтоб войти как администратор");
            }
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            if(_User.Role == "User")
            {
                Hide();
                var window = new AdminForm(_context);
                window.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Ошибка! У вас не достаточно прав чтоб войти как пользователь");
            }
        }
    }
}
