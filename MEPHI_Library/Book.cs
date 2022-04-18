using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEPHI_Library
{
    public class Book
    {
        [DisplayName("КОД")]
        public int ID { get; set; }
        [DisplayName("АВТОР")]
        public string Author { get; set; }
        [DisplayName("НАЗВАНИЕ")]
        public string Name { get; set; }
        [DisplayName("ИЗДАТЕЛЬСТВО")]
        public string Publisher { get; set; }
        [DisplayName("РАЗДЕЛ")]
        public string Section { get; set; }
        [DisplayName("НАЛИЧИЕ")]
        public bool IsAvailable { get; set; } = true;
        [DisplayName("ОЦЕНКА")]
        public string Rating { get; set; }

        public override string ToString()
        {            
            return string.Format("{0,-10} | {1,12} | {2,23} | {3,18} | {4,18} | {5,7}", ID, Author, Name, Publisher, Section, IsAvailable ? "Да" : "Нет");
        }
    }
}
