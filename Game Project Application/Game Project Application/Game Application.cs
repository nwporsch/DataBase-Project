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

        private SearchResults searchWindow;

        public StoreApplication()
        {
            InitializeComponent();
        }

        public void AddItemToReceipt(string[] s)
        {
            uxReceipt.Rows.Add(s);
        }

        /// <summary>
        /// Connects to the database and querys using the given input paramaters then opens a window to display the query results
        /// </summary>
        private void btnFind_Click(object sender, EventArgs e)
        {
            //Connection C = new Connection();
            //C.OpenConnection();
            string title;
            string genre;
            double minPrice;
            double maxPrice;
            int isUsed;
            int storeId;
            SearchConditions sc;

            if (uxStoreId.Text == "")
            {
                MessageBox.Show("Please enter a Store Id.");
            }
            else
            {
                storeId = Convert.ToInt32(uxStoreId.Text);

                if (uxTitle.Text != "")
                {
                    title = uxTitle.Text;
                }
                else
                {
                    title = "*";
                }


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
                    minPrice = -1;
                    maxPrice = -1;
                }
                else if (uxPriceRange.SelectedIndex == 2)
                {
                    minPrice = 0;
                    maxPrice = 9.99;
                }
                else if (uxPriceRange.SelectedIndex == 3)
                {
                    minPrice = 10;
                    maxPrice = 19.99;
                }
                else if (uxPriceRange.SelectedIndex == 4)
                {
                    minPrice = 20;
                    maxPrice = 29.99;
                }
                else if (uxPriceRange.SelectedIndex == 5)
                {
                    minPrice = 30;
                    maxPrice = 39.99;
                }
                else if (uxPriceRange.SelectedIndex == 6)
                {
                    minPrice = 40;
                    maxPrice = 49.99;
                }
                else if (uxPriceRange.SelectedIndex == 7)
                {
                    minPrice = 50;
                    maxPrice = 59.99;
                }
                else if (uxPriceRange.SelectedIndex == 8)
                {
                    minPrice = 60;
                    maxPrice = 69.99;
                }
                else if (uxPriceRange.SelectedIndex == 9)
                {
                    minPrice = 70;
                    maxPrice = 79.99;
                }
                else
                {
                    minPrice = 80;
                    maxPrice = -1;
                }

                if (uxCondition.SelectedIndex == 0)
                {
                    isUsed = -1;
                }
                else if (uxCondition.SelectedIndex == 1)
                {
                    isUsed = 0;
                }
                else
                {
                    isUsed = 1;
                }

                sc = new SearchConditions(title, genre, minPrice, maxPrice, isUsed, storeId);
                searchWindow = new SearchResults(this, sc);
                searchWindow.ShowDialog();
            }
        }

        //C.CloseConnection();


        /// <summary>
        /// Prevents the user from adding in superfluous input
        /// </summary>
        private void uxTitle_TextChanged(object sender, EventArgs e)
        {
            if (uxTitle.Text == "")
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

        /// <summary>
        /// Removes a selected game from the receipt
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (uxReceipt.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in uxReceipt.SelectedRows)
                {
                    int selected = uxReceipt.CurrentCell.RowIndex;
                    uxReceipt.Rows.RemoveAt(selected);

                }

            }
            else
            {
                MessageBox.Show("Please select a game to remove from the receipt");
            }
        }

        /// <summary>
        /// Finalizes receipt then sends it to the database to be stored and closes the search window
        /// </summary>
        private void btnFinishTransaction_Click(object sender, EventArgs e)
        {
            //Connection C = new Connection();
            OrderLine[] orderList = new OrderLine[uxReceipt.Rows.Count];

            foreach (string[] game in uxReceipt.Rows)
            {
                string title = game[0];
                int gameId = Convert.ToInt32(game[4]);
                int storeId = Convert.ToInt32(game[5]);
                double price = Convert.ToDouble(game[2]);
                OrderLine orderLine = new OrderLine(title, 1, price, gameId, storeId);
                //orderList[] = orderLine;
            }
            Order order = new Order();

            searchWindow.Close();
            //C.CloseConnection();

            MessageBox.Show("Thank you for you patronage, please come again.");
        }
    }

}