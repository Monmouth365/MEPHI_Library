using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEPHI_Library
{
    public partial class AddEditForm : Form
    {
        private int _id = 0;
        private BookRepository _bookRepository;

        public AddEditForm(BookRepository bookRepository)
        {
            InitializeComponent();
            Text = "Окно добавления";
            _bookRepository = bookRepository;
        }

        public AddEditForm(BookRepository bookRepository, int id):this(bookRepository:bookRepository)
        {
            Text = "Окно изменения";
            _id = id;
            Book book = bookRepository.GetBook(id);
            author_textBox.Text = book.Author;
            name_textBox.Text = book.Name;
            publisher_textBox.Text = book.Publisher;
            section_textBox.Text = book.Section;
            isAvailable_checkBox.Checked = book.IsAvailable;
            rating_textBox.Text = book.Rating;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                var book = new Book
                {
                    Author = author_textBox.Text,
                    Name = name_textBox.Text,
                    Publisher = publisher_textBox.Text,
                    Section = section_textBox.Text,
                    IsAvailable = isAvailable_checkBox.Checked,
                    Rating = rating_textBox.Text
                };
                _bookRepository.AddBook(book);
            }
            else
            {
                Book book = new Book
                {
                    ID = _id,
                    Author = author_textBox.Text,
                    Name = name_textBox.Text,
                    Publisher = publisher_textBox.Text,
                    Section = section_textBox.Text,
                    IsAvailable = isAvailable_checkBox.Checked,
                    Rating = rating_textBox.Text
                };
                _bookRepository.EditBook(book);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
