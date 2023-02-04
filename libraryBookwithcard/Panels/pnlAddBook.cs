using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryBookwithcard.Panels
{
    internal class pnlAddBook:Panel
    {

        Label lblTitle;
        TextBox txtTitle;

        Label lblAuthor;
        TextBox txtAuthor;

        Label lblGenre;
        TextBox txtGenre;

        Label lblYear;
        NumericUpDown numericYear;

        Button btnAddBook;

        

        public pnlAddBook()
        {
            this.Name = "pnlAddBook";
            this.Size = new System.Drawing.Size(600, 321);
            this.Location = new System.Drawing.Point(85, 100);
            this.BackColor = System.Drawing.Color.Goldenrod;

            Font font = new Font("Microsoft YaHei UI", 18);
            Font font1 = new Font("Microsoft YaHei UI", 16);

            //Title
            lblTitle = new Label();
            txtTitle = new TextBox();
            this.Controls.Add(lblTitle);
            this.Controls.Add(txtTitle);

            this.lblTitle.Location = new System.Drawing.Point(62, 30);
            this.lblTitle.Text = "Title";
            this.lblTitle.Font = font;
            this.AutoSize = true;
            this.txtTitle.Location = new System.Drawing.Point(184, 26);
            this.txtTitle.Size = new System.Drawing.Size(172, 43);
            this.txtTitle.Font= font1;
            
            //Author
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            this.Controls.Add(lblAuthor);
            this.Controls.Add(txtAuthor);

            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(59, 103);
            this.lblAuthor.Font = font;
            this.lblAuthor.Text = "Author";
            this.txtAuthor.Location = new System.Drawing.Point(184, 99);
            this.txtAuthor.Size = new System.Drawing.Size(172, 43);
            this.txtAuthor.Font= font1;

            //Genre
            lblGenre= new Label();
            txtGenre= new TextBox();
            this.Controls.Add(lblGenre);
            this.Controls.Add(txtGenre);

            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(59, 181); 
            this.lblGenre.Font = font;
            this.lblGenre.Text = "Genre";
            this.txtGenre.Location = new System.Drawing.Point(184, 177);
            this.txtGenre.Size = new System.Drawing.Size(172, 43);
            this.txtGenre.Font= font1;

            //Year
            lblYear= new Label();
            numericYear= new NumericUpDown();
            this.Controls.Add(lblYear);
            this.Controls.Add(numericYear);

            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(62, 256);
            this.lblYear.Font = font;
            this.lblYear.Text = "Year";
            this.numericYear.Location = new System.Drawing.Point(207, 252);
            this.numericYear.Maximum = 2028;
            this.numericYear.Font = font1;


            //BtnAddBook

            btnAddBook = new Button();
            this.Controls.Add(btnAddBook);

            this.btnAddBook.Location = new System.Drawing.Point(399, 111);
            this.btnAddBook.Size = new System.Drawing.Size(151, 66);
            this.btnAddBook.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddBook.Font = font;
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.Click += new EventHandler(btnAddBook_Click);



        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

           



        }





    }
}
