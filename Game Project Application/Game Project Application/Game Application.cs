using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Project_Application
{
    public partial class StoreApplication : Form
    {

        private SearchResults searchWindow = new SearchResults();

        public StoreApplication()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string genre;
            string priceRange;
            string condition;
            int storeId;
            Game g;

            if(uxStoreId.Text == "")
            {
                MessageBox.Show("Please enter a Store Id.");
            }
            else
            {
                storeId = Convert.ToInt32(uxStoreId.Text);

                if (uxTitle.Text != "")
                {
                    g = new Game(uxTitle.Text.ToLower(), uxCondition.Text, storeId);
                }
                else
                {

                    if (uxGenre.Text == "")
                    {
                        genre = "*";
                    }
                    else
                    {
                        genre = uxGenre.Text;
                    }

                    if (uxPriceRange.SelectedIndex == 0)
                    {
                        priceRange = "*";
                    }
                    else
                    {
                        priceRange = uxPriceRange.Text;
                    }

                    if (uxCondition.SelectedIndex == 0)
                    {
                        condition = "*";
                    }
                    else
                    {
                        condition = uxCondition.Text;
                    }

                    g = new Game(genre, priceRange, condition, storeId);
                }



                searchWindow.ShowDialog();
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

        private void uxStoreApplication_Load(object sender, EventArgs e)
        {
            uxPriceRange.SelectedIndex = 0;
            uxCondition.SelectedIndex = 0;
        }
    }
}
