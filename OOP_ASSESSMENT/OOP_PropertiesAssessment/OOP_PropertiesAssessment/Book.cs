using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PropertiesAssessment
{
    internal class Book
    {
        private string _title;
        private int _Pages;

        public string Title { 
            get { return _title; }

            set { 
                
                if(value == "")
                {
                    _title = "Unknown";
                }
                else
                {
                    _title = value;
                }
            } 
        }
        public int Pages
        {
            get { return _Pages; }

            set { 
                if(value < 1)
                {
                    _Pages = 1;
                }
                else
                {
                    _Pages = value;
                }
            }
        }

        public Book()
        {
            _title = "Money Heist";
            _Pages = 218;
        }

        public Book(string bookTitle, int bookPages)
        {
            _title = bookTitle;
            _Pages = bookPages;
        }

        public void BookDetails()
        {
            Console.WriteLine("{0} is a book with {1} pages", _title, Pages);
        }
    }
}
