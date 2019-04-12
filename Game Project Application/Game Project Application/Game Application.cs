using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project_Application
{
    public partial class uxStoreApplication : Form
    {
        public uxStoreApplication()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string title;
            string genre;
            double price;
            bool isUsed;

            if(uxTitle.Text == "")
            {
                title = "*";
            }
            else
            {
                title = uxTitle.Text;
            }

            if (uxGenre.Text == "")
            {
                genre = "*";
            }
            else
            {
                genre = uxGenre.Text;
            }

            if (uxPrice.Text == "")
            {
                title = "*";
            }
            else
            {
                title = uxTitle.Text;
            }

            if(uxUsed.Checked == false  && uxNew.Checked == false)
            {

            }
            else if()
            {
                
            }
            else
            {

            }

            Game g = new Game(title, genre, price, isUsed);
        }
    }
}
