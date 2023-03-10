using libraryBookwithcard.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryBookwithcard.Panels
{
    internal class pnlUpdate:Panel
    {

        Label lblTitle;
        TextBox txtTitle;

        Label lblAuthor;
        TextBox txtAuthor;

        Label lblGenre;
        TextBox txtGenre;

        Label lblYear;
        NumericUpDown numericYear;

        Button btnUpdate;
        Button btnDelete;

        ControllerBooks controllerBooks;

        Form1 form;

        private int id;

        List<Book> books = new List<Book>();

        public pnlUpdate(int id1, Form1 form1)
        {
            id = id1;
            this.form = form1;
            this.controllerBooks = new ControllerBooks();

            this.Name = "pnlUpdate";
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
            this.lblTitle.AutoSize = true;
            this.txtTitle.Location = new System.Drawing.Point(184, 26);
            this.txtTitle.Size = new System.Drawing.Size(172, 43);
            this.txtTitle.Font = font1;
            this.txtTitle.Text = controllerBooks.titleById(id);

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
            this.txtAuthor.Font = font1;
            this.txtAuthor.Text = controllerBooks.authorById(id);

            //Genre
            lblGenre = new Label();
            txtGenre = new TextBox();
            this.Controls.Add(lblGenre);
            this.Controls.Add(txtGenre);

            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(59, 181);
            this.lblGenre.Font = font;
            this.lblGenre.Text = "Genre";
            this.txtGenre.Location = new System.Drawing.Point(184, 177);
            this.txtGenre.Size = new System.Drawing.Size(172, 43);
            this.txtGenre.Font = font1;
            this.txtGenre.Text = controllerBooks.genreById(id);

            //Year
            lblYear = new Label();
            numericYear = new NumericUpDown();
            this.Controls.Add(lblYear);
            this.Controls.Add(numericYear);

            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(62, 256);
            this.lblYear.Font = font;
            this.lblYear.Text = "Year";
            this.numericYear.Location = new System.Drawing.Point(207, 252);
            this.numericYear.Maximum = 2028;
            this.numericYear.Font = font1;
            this.numericYear.Value = controllerBooks.yearById(id);

            //BtnUpdate

            btnUpdate = new Button();
            this.Controls.Add(btnUpdate);

            this.btnUpdate.Location = new System.Drawing.Point(399, 75);
            this.btnUpdate.Size = new System.Drawing.Size(151, 66);
            this.btnUpdate.BackColor = System.Drawing.Color.GreenYellow;
            this.btnUpdate.Font = font;
            this.btnUpdate.Click += new EventHandler(btnUpdate_Click);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Text = "Update";

            //BtnDelete

            btnDelete = new Button();
            this.Controls.Add(btnDelete);

            this.btnDelete.Location = new System.Drawing.Point(399, 200);
            this.btnDelete.Size = new System.Drawing.Size(151, 66);
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = font;
            this.btnDelete.Click += new EventHandler(btnDelete_Click);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Text = "Delete";

            books = new List<Book>();
            controllerBooks.getBooks(books);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            controllerBooks.setNume(id, txtTitle.Text);
            controllerBooks.setAutor(id, txtAuthor.Text);
            controllerBooks.setGenre(id, txtGenre.Text);
            controllerBooks.setAn(id, ((int)numericYear.Value));
            controllerBooks.save();

            this.form.removePnl("pnlUpdate");
            this.form.Controls.Add(new pnlCards(books,form));

        }

        public void btnDelete_Click(object sender, EventArgs e)
        {

            controllerBooks.deleteCarte(id);
            this.form.removePnl("pnlUpdate");
            controllerBooks.getBooks(books);
            this.form.Controls.Add(new pnlCards(books,form));

        }


    }
}
