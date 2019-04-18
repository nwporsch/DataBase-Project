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
    public partial class SearchResults : Form
    {
        private StoreApplication sa;
        private Connection c;

        public SearchResults(StoreApplication sa, Game g)
        {
            this.sa = sa;
            c = new Connection();

         

            GameRepository gr = new GameRepository();
            List<Game> l = gr.RetrieveGames(g);
            
            foreach(Game ga in l)
            {
                string s = ga.Title.ToString();
            }
            InitializeComponent();
        }

        public void hideButton()
        {
            btnAddToReceipt.Hide();
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
