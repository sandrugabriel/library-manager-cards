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

        public string textAllBooks(string text) {

            string t = "";

            for(int i = 0; i < books.Count; i++)
            {

                t += books[i].textBook();

            }

            return t + text;

        
        }

        public void addBookFisier(string text)
        {
            string t = textAllBooks(text);
            string patch = Application.StartupPath + @"/data/books.txt";
            File.WriteAllText(patch, t);
            load();
        }
    
        public Book getIdBooks(int id)
        {

            for(int i=0;i<books.Count;i++) {
                if (id == books[i].getId())
                {
                    return books[i];
                }
            }

            return null;

        }

        public int generareId()
        {

            Random random = new Random();

            int id = random.Next();
            while (this.getIdBooks(id) != null)
            {
                id = random.Next();
            }


            return id;
        }

        public string titleById(int id)
        {

            for(int i=0;i<books.Count;i++)
            {
                if (books[i].getId() == id)
                {
                    return books[i].getTitle();
                }
            }

            return null;
        }

        public string authorById(int id)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    return books[i].getAuthor();
                }
            }

            return null;
        }

        public string genreById(int id)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    return books[i].getGenre();
                }
            }

            return null;
        }

        public int yearById(int id)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    return books[i].getYear();
                }
            }

            return -1;
        }

        public int idByTitle(string title)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getTitle().Equals(title))
                {
                    return books[i].getId();
                }
            }

            return -1;
        }


        public void setNume(int id, string nume)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    books[i].setTitle(nume);
                }
            }


        }

        public void setAutor(int id, string autor)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    books[i].setAuthor(autor);
                }
            }


        }

        public void setGenre(int id, string genre)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    books[i].setGenre(genre);
                }
            }


        }

        public void setAn(int id, int an)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].getId() == id)
                {
                    books[i].setYear(an);
                }
            }


        }


        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < books.Count; i++)
            {
                t += books[i].toSave() + "\n";
            }

            return t;
        }

        public void save()
        {
            String path = Application.StartupPath + @"/data/books.txt";
            StreamWriter streamWriter = new StreamWriter(path);

            streamWriter.Write(this.toSaveFisier());

            streamWriter.Close();
        }



    }
}
