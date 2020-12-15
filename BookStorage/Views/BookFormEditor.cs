using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStorage.Models;
namespace BookStorage.Views
{
    public partial class BookFormEditor : Form
    {
        private int _bookId = 0;
        
        public Book Book
        {
            get
            {

                return new Book
                {
                    Id = _bookId,
                    Name = nameBox.Text,
                    FullNameAutor = autorBox.Text,
                    Pages = (int)pagesBox.Value,
                    DateOfRelese = dateOfRelesePicker.Value,
                    Genre = genreBox.Text

                };
            }
        }
        public BookFormEditor(List<Book> books)
        {
            InitializeComponent();
            //_books = books;
            //autorBox.DataSource = _books;
        }
        public DialogResult ShowDialog(Book book)
        {
            if (book == null)
                return DialogResult.None;

            _bookId = book.Id;
            nameBox.Text = book.Name;
            pagesBox.Value = book.Pages;
            dateOfRelesePicker.Value = book.DateOfRelese;

            return ShowDialog();
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(nameBox.Text))
            {
                MessageBox.Show("Заполните поле {Название книги} ");
                return;
            }
            if(string.IsNullOrEmpty(autorBox.Text))
            {
                MessageBox.Show("Укажите автора книги ");
                return;
            }

            DialogResult = DialogResult.OK;
        }

    }
}
