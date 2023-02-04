using libraryBookwithcard.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryBookwithcard
{
    internal class ControllerBooks
    {
        private List<Book> books;

        public ControllerBooks() { 
        
        books= new List<Book>();
            load();
        
        }

        public void load()
        {
            string path = Application.StartupPath + @"/data/books.txt";

            StreamReader streamReader = new StreamReader(path);

            string t;

            while ((t = streamReader.ReadLine()) != null)
            {

                Book a = new Book(t);

                books.Add(a);
            }

            streamReader.Close();
        }

        public void afisare()
        {

            for(int i=0;i<books.Count;i++)
            {
                MessageBox.Show(books[i].descriere());
            }

        }

        public void getBooks(List<Book> books1) {
            
            for(int i = 0; i < books.Count; i++)
            {

                Book a = books[i];
                books1.Add(a);
            }


        }

       


    }
}
