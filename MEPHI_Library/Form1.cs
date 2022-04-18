using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEPHI_Library
{
    public partial class Form1 : Form
    {
        BookRepository bookRep = new BookRepository();

        private void BindSort()
        {
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            comboSource.Add("По умолчанию", "none");
            comboSource.Add("По автору", "author");
            comboSource.Add("По названию", "name");
            comboSource.Add("По издательству", "publisher");
            comboSource.Add("По разделу", "section");
            comboSource.Add("По наличию", "availability");
            comboSource.Add("По оценке", "rating");
            sort_comboBox.DataSource = new BindingSource(comboSource, null);
            sort_comboBox.DisplayMember = "Key";
            sort_comboBox.ValueMember = "Value";
        }

        public Form1()
        {
            InitializeComponent();
            BindSort();
            bookRep.Init();
            UpdateGridView();
        }

        public void UpdateGridView()
        {
            string sort = "none";
            if (sort_comboBox.SelectedItem != null)
            {
                sort = ((KeyValuePair<string, string>)sort_comboBox.SelectedItem).Value;
            }
            books_GridView.DataSource = null;
            books_GridView.DataSource = bookRep.GetBooks(sort);
            books_GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void sort_comboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void saveBooks_btn_Click(object sender, EventArgs e)
        {
            saveLoadState.Text = "Сохранено в файле:\n" + bookRep.Save();
        }

        private void loadBooks_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "JSON Files|*.json";
            fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = fileDialog.FileName;
                bookRep.Load(fileName);
            }
            UpdateGridView();
        }

        private void addBook_btn_Click(object sender, EventArgs e)
        {
            var addForm = new AddEditForm(bookRep);
            var result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateGridView();
            }
            addForm.Dispose();
            
        }

        private void editBook_btn_Click(object sender, EventArgs e)
        {
            int selectedBook = (int)books_GridView.Rows[books_GridView.SelectedCells[0].RowIndex].Cells[0].Value;
            var editForm = new AddEditForm(bookRep, selectedBook);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                UpdateGridView();
            }
            editForm.Dispose();
        }

        private void deleteBook_btn_Click(object sender, EventArgs e)
        {
            int selectedBook = (int)books_GridView.Rows[books_GridView.SelectedCells[0].RowIndex].Cells[0].Value;
            bookRep.DeleteBook(selectedBook);
            UpdateGridView();
        }
    }
}
