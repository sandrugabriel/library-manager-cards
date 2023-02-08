using libraryBookwithcard.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryBookwithcard.Panels
{
    internal class pnlCard: Panel
    {

        Label lblTitle;
        public Label lblTitle1;

        Label lblAuthor;
        Label lblAuthor1;

        Label lblInfo;

        Book book;
        Form1 form;

        private int id;

        public pnlCard(Book book1,Form1 form1) {
            this.form = form1;
            this.Name = "pnlCard";
            this.Size = new System.Drawing.Size(191, 175);
            this.Location = new System.Drawing.Point(53, 43);
            this.BackColor = System.Drawing.Color.White;

            book= book1;

            Font font = new Font("Cambria", 13);
            Font font1 = new Font("Cambria", 12);

            //Title
            lblTitle = new Label();
            lblTitle1 = new Label();
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTitle1);
            this.lblTitle.Name = "lbltitle";
            this.lblTitle1.Name = "lblTitle1";

            this.lblTitle.Location = new System.Drawing.Point(21, 13);
            this.lblTitle1.Location = new System.Drawing.Point(42, 42);
            this.lblTitle.AutoSize = true;
            this.lblTitle1.AutoSize = true;
            this.lblTitle.Font = font;
            this.lblTitle1.Font = font1;
            this.lblTitle.Text = "Title";
            this.lblTitle1.Text = book.getTitle();

            //Author
            this.lblAuthor= new Label();
            this.lblAuthor1 = new Label();
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblAuthor1);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor1.Name = "lblAuthor1";

            this.lblAuthor.Location = new System.Drawing.Point(21, 80);
            this.lblAuthor1.Location = new System.Drawing.Point(42, 109);
            this.lblAuthor.AutoSize= true;
            this.lblAuthor1.AutoSize = true;
            this.lblAuthor.Text = "Author";
            this.lblAuthor.Font= font;
            this.lblAuthor1.Font = font1;
            this.lblAuthor1.Text = book.getAuthor();

            id=book1.getId();
          
        }

        public int getid()
        {

            return id;

        }

    }
}
