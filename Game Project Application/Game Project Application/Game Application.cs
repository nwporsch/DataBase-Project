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

                searchWindow = new SearchResults(this, g);
                searchWindow.ShowDialog();
            }

            //C.CloseConnection();
        }

        /// <summary>
        /// Prevents the user from adding in superfluous input
        /// </summary>
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
