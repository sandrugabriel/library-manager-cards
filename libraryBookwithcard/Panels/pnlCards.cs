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

        public pnlCards(List<Book> books1)
        {
            this.Name = "pnlCards";
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Size = new System.Drawing.Size(765, 412);
            this.Location = new System.Drawing.Point(5, 82);
            this.BackColor = System.Drawing.Color.LightGray;

            books = books1;

            createCard(3);





        }

        public void createCard(int nrCollums)
        {

            this.Controls.Clear();

            int x = 53, y = 43, ct = 0;

            foreach(Book book in books)
            {
                ct++;
                pnlCard pnlcard = new pnlCard(book);
                pnlcard.Location = new System.Drawing.Point(x,y);
                this.Controls.Add(pnlcard);
                

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
