using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEPHI_Library
{
    public class BookRepository
    {
        private List<Book> _books = new List<Book>();

        public void Init()
        {
            _books = new List<Book>()
            {
                new Book {ID = 1, Author = "А автор", Name = "П книга", Publisher = "Ф издатель", Section = "А раздел", IsAvailable = true, Rating = "Хорошо" },
                new Book {ID = 2, Author = "В автор", Name = "Л книга", Publisher = "П издательство", Section = "Л раздел", IsAvailable = true, Rating = "Хорошо" },
                new Book {ID = 3, Author = "М автор", Name = "Р книга", Publisher = "Ю издательство", Section = "Д раздел", IsAvailable = true, Rating = "Плохо" },
                new Book {ID = 4, Author = "Б автор", Name = "А книга", Publisher = "Д издатель", Section = "Л раздел", IsAvailable = false, Rating = "Отлично" },
                new Book {ID = 5, Author = "В автор", Name = "Т книга", Publisher = "Ф издатель", Section = "Л раздел", IsAvailable = false, Rating = "Хорошо" }
            };
        }

        public List<Book> GetBooks(string sort = "none")
        {
            List<Book> result;
            switch (sort)
            {
                case "author":
                    result = _books.OrderBy(b => b.Author).ToList();
                    break;
                case "name":
                    result = _books.OrderBy(b => b.Name).ToList();
                    break;
                case "publisher":
                    result = _books.OrderBy(b => b.Publisher).ToList();
                    break;
                case "section":
                    result = _books.OrderBy(b => b.Section).ToList();
                    break;
                case "availability":
                    result = _books.OrderBy(b => b.IsAvailable).ToList();
                    break;
                case "rating":
                    result = _books.OrderBy(b => b.IsAvailable).ToList();
                    break;
                default:
                    result = _books;
                    break;
            }            
            return result;
        }

        public string ShowBooks()
        {
            string result = string.Format("{0,-10} | {1,12} | {2,23} | {3,18} | {4,18} | {5,7}", "КОД", "АВТОР", "НАЗВАНИЕ", "ИЗДАТЕЛЬСТВО", "РАЗДЕЛ", "НАЛИЧИЕ");
            result += "\n________________________________________________________________________________________";
            foreach (var item in _books)
            {
                result += "\n" + item.ToString();
            }
            return result;
        }

        private int MaxID()
        {
            if (_books.Count == 0)
            {
                return 0;
            }
            return _books.Max(b => b.ID);
        }

        public void AddBook(Book book)
        {
            var bookToAdd = book;
            bookToAdd.ID = MaxID() + 1;
            _books.Add(bookToAdd);
        }

        public Book GetBook(int id)
        {
            var book = _books.Find(b => b.ID == id);
            return book;
        }

        public void DeleteBook(int id)
        {
            var book = GetBook(id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }

        public void EditBook(Book book)
        {
            var bookToEdit = GetBook(book.ID);
            if (bookToEdit != null)
            {
                bookToEdit.Author = book.Author != null ? book.Author : bookToEdit.Author;
                bookToEdit.Name = book.Name != null ? book.Name : bookToEdit.Name;
                bookToEdit.Publisher = book.Publisher != null ? book.Publisher : bookToEdit.Publisher;
                bookToEdit.Section = book.Section != null ? book.Section : bookToEdit.Section;
                bookToEdit.IsAvailable = book.IsAvailable;
            }
        }

        public string Save()
        {
            var booksJson = JsonConvert.SerializeObject(_books);
            var fileName = "books_" + DateTime.Now.ToString("dd.MM.yyyy_hh-mm-ss") + ".json";
            File.WriteAllText(fileName, booksJson);
            return fileName;
        }

        public void Load(string fileName)
        {
            if (File.Exists(fileName))
            {
                var booksJson = File.ReadAllText(fileName);
                _books = JsonConvert.DeserializeObject<List<Book>>(booksJson);
            }
        }
    }
}
