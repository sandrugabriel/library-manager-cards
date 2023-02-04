using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace libraryBookwithcard.Models
{
    internal class Book
    {
        private int id;
        private string title;
        private string author;
        private string genre;
        private int year;

        public Book(int id, string title, string author, string genre, int year ) {
        
            this.id = id;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.year = year;

        }

        public Book(string text)
        {

            string[] prop = text.Split(',');

            this.id = int.Parse(prop[0]);
            this.title = prop[1];
            this.author = prop[2];
            this.genre = prop[3];
            this.year= int.Parse(prop[4]);

        }

        public string getTitle()
        {
            return title;
        }

        public void setTitle( string title )
        {
            this.title = title;
        }

        public string getAuthor()
        {
            return author;
        }

        public void setAuthor( string author )
        {
            this.author = author;
        }

        public string getGenre()
        {
            return genre;
        }

        public void setGenre(string genre)
        {
            this.genre = genre;
        }

        public int getYear()
        {
            return year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public string descriere()
        {

            string t = "";

            t += "Title: " + getTitle() + "\n";
            t += "Author: " + getAuthor() + "\n";
            t += "Genre: " + getGenre() + "\n";
            t += "Year: " + getYear() + "\n";

            return t;
        }


    }
}
