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
    public partial class SearchResults : Form
    {
        private StoreApplication sa;

        public SearchResults(StoreApplication sa)
        {
            this.sa = sa;
            InitializeComponent();
        }

        private void btnAddToReceipt_Click(object sender, EventArgs e)
        {
            if (uxSearchResults.SelectedIndex >= 0)
            {
                string item = uxSearchResults.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
            
        }
    }
}
