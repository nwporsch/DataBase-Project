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
            string priceRange;
            string condition;

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

            if (uxPriceRange.Text == "")
            {
                priceRange = "*";
            }
            else
            {
                priceRange = uxPriceRange.Text;
            }

            if(uxCondition.Text == " ")
            {
                condition = "*";
            }
            else
            {
                condition = uxCondition.Text;
            }

            Game g = new Game(title, genre, priceRange, condition);
        }
    }
}
