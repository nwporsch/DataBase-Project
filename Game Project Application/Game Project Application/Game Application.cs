using System;
using System.Collections;
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
    public partial class GameApplication : Form
    {
        private StoreView storeView;
        private SearchResults searchWindow;
        private EmployeeView receiptLookup;
        private CustomerInput customerWindow;
        private Customer customer;
        private List<string[]> reservedItems;
        private ArrayList orderList;

        public GameApplication()
        {
            InitializeComponent();
            reservedItems = new List<string[]>();
        }
        /// <summary>
        /// Adds a list of given items to the Receipt text box
        /// </summary>
        /// <param name="s"></param>
        public void AddItemToReceipt(string[] s)
        {
            uxReceipt.Rows.Add(s);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool AddReserve(string[] s)
        {
            bool removeFromGameList = false;
            bool inList = false;

            foreach (string[] item in reservedItems)
            {
                if (item[5].Equals(s[5]) && item[4].Equals(s[4]) && item[3].Equals(s[3]) && item[7].Equals(s[7]))
                {
                    inList = true;
                    int temp = Convert.ToInt32(item[6]);
                    temp++;
                    item[6] = temp.ToString();
                    int remaining = Convert.ToInt32(s[6]) - temp;
                    if (remaining == 0)
                    {
                        removeFromGameList = true;
                    }
                }
            }

            if (!inList)
            {
                if (s[6].Equals("1"))
                {
                    removeFromGameList = true;
                }
                string[] temp = s;
                temp[6] = "1";
                reservedItems.Add(temp);
            }

            return removeFromGameList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool RemoveFromSearch(string[] s)
        {
            bool removeFromGameList = false;

            foreach (string[] item in reservedItems)
            {
                if (item[5].Equals(s[5]) && s[4].Equals(s[4]) && s[3].Equals(s[3]))
                {

                    if (item[6].Equals(s[6]))
                    {
                        removeFromGameList = true;
                    }
                }
            }

            return removeFromGameList;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        public void RemoveReserve(string[] s)
        {
            bool isAdded = false;
            int index = 0;
            foreach (string[] item in reservedItems)
            {
                if (item[5].Equals(s[5]) && item[4].Equals(s[4]) && item[3].Equals(s[3]) && !isAdded)
                {
                    int temp = Convert.ToInt32(item[6]);
                    temp--;
                    item[6] = temp.ToString();
                    isAdded = true;
                    index = reservedItems.IndexOf(item);
                    if (temp <= 0)
                    {
                        reservedItems.RemoveAt(index);
                        break;
                    }


                }
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        /// <summary>
        /// Connects to the database and querys using the given input paramaters then opens a window to display the query results
        /// </summary>
        private void btnFind_Click(object sender, EventArgs e)
        {
            string title;
            string genre;
            string platform;
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

                if (uxPlatform.Text == "")
                {
                    platform = "*";
                }
                else
                {
                    platform = uxPlatform.Text;
                }

                if (uxPriceRange.SelectedIndex == 0)
                {
                    minPrice = -1;
                    maxPrice = -1;
                }
                else if (uxPriceRange.SelectedIndex == 1)
                {
                    minPrice = 0;
                    maxPrice = 9.99;
                }
                else if (uxPriceRange.SelectedIndex == 2)
                {
                    minPrice = 10;
                    maxPrice = 19.99;
                }
                else if (uxPriceRange.SelectedIndex == 3)
                {
                    minPrice = 20;
                    maxPrice = 29.99;
                }
                else if (uxPriceRange.SelectedIndex == 4)
                {
                    minPrice = 30;
                    maxPrice = 39.99;
                }
                else if (uxPriceRange.SelectedIndex == 5)
                {
                    minPrice = 40;
                    maxPrice = 49.99;
                }
                else if (uxPriceRange.SelectedIndex == 6)
                {
                    minPrice = 50;
                    maxPrice = 59.99;
                }
                else if (uxPriceRange.SelectedIndex == 7)
                {
                    minPrice = 60;
                    maxPrice = 69.99;
                }
                else if (uxPriceRange.SelectedIndex == 8)
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

                btnFind.Enabled = false;
                sc = new SearchConditions(title, genre, platform, minPrice, maxPrice, isUsed, storeId);
                searchWindow = new SearchResults(this, sc);
                searchWindow.ShowDialog();
                btnFind.Enabled = true;
            }
        }

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

        /// <summary>
        /// Makes sure the first indexes of the priceRange and the condition are in the default condition.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStoreApplication_Load(object sender, EventArgs e)
        {
            uxPriceRange.SelectedIndex = 0;
            uxCondition.SelectedIndex = 0;
        }

        /// <summary>
        /// Handles a click event on the Remove Button, Removes a selected game from the receipt
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (uxReceipt.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in uxReceipt.SelectedRows)
                {
                    int selected = uxReceipt.CurrentCell.RowIndex;
                    string[] item = new string[r.Cells.Count];
                    for (int i = 0; i < r.Cells.Count; i++)
                    {
                        item[i] = r.Cells[i].Value.ToString();
                    }

                    RemoveReserve(item);
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
            if (uxReceipt.RowCount == 0)
            {
                MessageBox.Show("Please add items to receipt before ending transaction.");
            }
            else
            {
                orderList = new ArrayList();
                foreach (DataGridViewRow r in uxReceipt.Rows)
                {

                    string[] game = new string[r.Cells.Count];

                    for (int i = 0; i < r.Cells.Count; i++)
                    {
                        game[i] = r.Cells[i].Value.ToString();
                    }

                    string title = game[0];
                    int gameId = Convert.ToInt32(game[5]);
                    int storeId = Convert.ToInt32(game[4]);
                    double price = Convert.ToDouble(game[2]);
                    OrderLine orderLine = new OrderLine(title, 1, price, gameId, storeId);
                    orderList.Add(orderLine);
                }

                btnFinishTransaction.Enabled = false;
                customerWindow = new CustomerInput(this);
                customerWindow.Show();
            }
        }
        /// <summary>
        /// Creates an Order
        /// </summary>
        public void CreateOrder()
        {
            Order order = new Order(customer, orderList);

            uxReceipt.Rows.Clear();

        }
        /// <summary>
        /// Opens the EmployeeView Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxEmployeeView_Click(object sender, EventArgs e)
        {
            uxEmployeeView.Enabled = false;
            receiptLookup = new EmployeeView();
            receiptLookup.ShowDialog();
            uxEmployeeView.Enabled = true;
        }
        /// <summary>
        /// Opens the StoreView Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void storeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storeViewToolStripMenuItem.Enabled = false;
            storeView = new StoreView();
            storeView.ShowDialog();
            storeViewToolStripMenuItem.Enabled = true;
        }

        public void EnableTransactionButton()
        {
            btnFinishTransaction.Enabled = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStoreId_TextChanged(object sender, EventArgs e)
        {
            int index = uxStoreId.SelectionStart;
            string text = uxStoreId.Text;
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i]< '0' || text[i] > '9')
                {
                    if(i == 0)
                    {
                        text = text.Substring(1, text.Length - 1);
                    }
                    else if( i == text.Length - 1)
                    {
                        text = text.Substring(0, text.Length - 1);
                    }
                    else
                    {
                        text = text.Substring(0, i) + text.Substring(i + 1, text.Length - i - 1);
                    }
                    uxStoreId.Text = text;
                    if (index > 0)
                    {
                        uxStoreId.SelectionStart = index - 1;
                    }
                    else
                    {
                        uxStoreId.SelectionStart = index;
                    }
                }
            }
            
        }
    }

}