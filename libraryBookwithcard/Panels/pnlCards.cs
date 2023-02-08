using libraryBookwithcard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryBookwithcard.Panels
{
    internal class pnlCards:Panel
    {
       

        List<Book> books = new List<Book>();

        Label lblInfo;

        Form1 form;

        ControllerBooks controllerBooks;

        public pnlCards(List<Book> books1, Form1 form1)
        {

            controllerBooks = new ControllerBooks();

            this.Name = "pnlCards";
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Size = new System.Drawing.Size(765, 412);
            this.Location = new System.Drawing.Point(5, 82);
            this.BackColor = System.Drawing.Color.LightGray;

            books = books1;

            createCard(3);


            //Info
            this.lblInfo = new Label();
            this.Controls.Add(this.lblInfo);

            this.lblInfo.Text = "To change the data and delete a book, click on book title";
            this.lblInfo.BackColor = System.Drawing.Color.Yellow;
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft YaHei UI",10);

            this.form = form1;
        }
        public void createCard(int nrCollums)
        {

            this.Controls.Clear();

            int x = 53, y = 43, ct = 0;

            foreach(Book book in books)
            {
                ct++;
                pnlCard pnlcard = new pnlCard(book,form);
                pnlcard.Location = new System.Drawing.Point(x,y);
                this.Controls.Add(pnlcard);
                pnlcard.Click += new EventHandler(pnlcard_Click);
                void pnlcard_Click(object sender, EventArgs e)
                {
                    string title = pnlcard.lblTitle1.Text;
                    int id = controllerBooks.idByTitle(title);
                    this.form.removePnl("pnlCards");
                    this.form.Controls.Add(new pnlUpdate(id,form));
                }
                x += 200;

                if (ct % nrCollums == 0)
                {
                    x = 55;
                    y += 210;
                }
                if(y>this.Height)
                {
                    this.AutoScroll= true;
                }
            }


        }

       

    }
}
