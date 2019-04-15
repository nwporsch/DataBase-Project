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

            Game g;


            if (uxTitle.Text != "")
            {
                g = new Game(uxTitle.Text, uxCondition.Text);
            }
            else
            {
                title = "*";

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

                if (uxCondition.Text == " ")
                {
                    condition = "*";
                }
                else
                {
                    condition = uxCondition.Text;
                }

                g = new Game(title, genre, priceRange, condition);
            }
            
        }

        private void uxTitle_TextChanged(object sender, EventArgs e)
        {
            if(uxTitle.Text == "")
            {
                uxGenre.Enabled = true;
                uxPlatform.Enabled = true;
                uxPriceRange.Enabled = true;

            }
            else
            {
                uxGenre.Enabled = false;
                uxGenre.Text = "";
                uxPlatform.Enabled = false;
                uxPlatform.Text = "";
                uxPriceRange.Enabled = false;
                uxPriceRange.SelectedIndex = 0;
            }
        }
    }
}
