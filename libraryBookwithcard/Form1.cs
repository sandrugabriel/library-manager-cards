using libraryBookwithcard.Models;
using libraryBookwithcard.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryBookwithcard
{
    public partial class Form1 : Form
    {
        ControllerBooks controllerBooks;
        List<Book> books;
        public Form1()
        {
            InitializeComponent();
            controllerBooks= new ControllerBooks();
            books= new List<Book>();
            controllerBooks.getBooks(books);

            this.Controls.Add(new pnlCards(books));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            removePnl("pnlCards");
            this.Controls.Add(new pnlAddBook(this));
            this.button1.Visible = false;  
        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach(Control ctrl in this.Controls)
            {
                if (ctrl.Name.Equals(pnl))
                {
                    control = ctrl;
                }
            }

            this.Controls.Remove(control);
        }

        private void pnlBtn_Paint(object sender, PaintEventArgs e)
        {

        }

        public bool pnlActiv(string pnl)
        {
            Control control = null;

            foreach (Control control1 in this.Controls)
            {
                if (control1.Name.Equals(pnl))
                {
                    return true;
                }
            }


            return false;
        }

        public void label1_Click(object sender, EventArgs e)
        {

            if (pnlActiv("pnlAddBook"))
            {
                removePnl("pnlAddBook");
                this.Controls.Add(new pnlCards(books));
                this.button1.Visible = true;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
