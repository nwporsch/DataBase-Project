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
        private Game g;



        public SearchResults(StoreApplication sa, Game g)
        {
            this.sa = sa;
            this.g = g;


            InitializeComponent();
        }

        private void btnAddToReceipt_Click(object sender, EventArgs e)
        {
            if (uxSearchResults.SelectedIndex >= 0)
            {
                string item = uxSearchResults.GetItemText(uxSearchResults.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
            
        }
    }
}
