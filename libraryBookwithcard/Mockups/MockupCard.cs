using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryBookwithcard.Mockups
{
    public partial class MockupCard : Form
    {
        private string title;
        private string author;

        public MockupCard(string title1, string author1)
        {
            InitializeComponent();

            this.title = title1;
            this.author = author1;


            this.label3.Text = title;
            this.label4.Text = author;


        }

        private void MockupCard_Load(object sender, EventArgs e)
        {

        }
    }
}
