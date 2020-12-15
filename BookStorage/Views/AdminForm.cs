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
    public partial class AdminForm : Form
    {
        StorageContext _context { get; set; }
        public AdminForm(StorageContext context)
        {
            InitializeComponent();
            _context = context;

            if(_context.AutorisationProvider.Me.Role == "User")
            {
                editButton.Visible = false;
                createButton.Visible = false;
                deleteButton.Visible = false;
            }
            
        }

        public void RefreshData()
        {
            List<Book> books = _context.booksProvider.GetAll();
            bookGridView.DataSource = books;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            RefreshData();  
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (bookGridView.SelectedRows == null)
                return;
            var selectedBook = bookGridView.SelectedRows[0].DataBoundItem as Book;
            var books = _context.booksProvider.GetAll();
            var editor = new BookFormEditor(books);
            var res = editor.ShowDialog(selectedBook);

            if (res != DialogResult.OK)
                return;

            _context.booksProvider.Update(editor.Book);
            RefreshData();
                
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (bookGridView.SelectedRows.Count == 0)
                return;

            var selectedBook = bookGridView.SelectedRows[0].DataBoundItem as Book;
            _context.booksProvider.Delete(selectedBook.Id);
            RefreshData();
        }   

        private void createButton_Click(object sender, EventArgs e)
        {
            var books = _context.booksProvider.GetAll();
            var editor = new BookFormEditor(books);
            var res = editor.ShowDialog();
            if (res != DialogResult.OK)
                return;

            _context.booksProvider.Insert(editor.Book);

            RefreshData();

        }
    }
}
