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

        public SearchResults(StoreApplication sa, Game g)
        {
            this.sa = sa;
         

            GameRepository gr = new GameRepository();
            List<Game> l = gr.RetrieveGames(g);
           
            InitializeComponent();
            foreach (Game ga in l)
            {
                string[] s = { ga.Title, ga.Genre, ga.Price.ToString(), ga.IsUsed, ga.StoreId.ToString() };
                this.uxResults.Rows.Add(s);
            }
        }

        public void hideButton()
        {
            btnAddToReceipt.Hide();
        }

        private void btnAddToReceipt_Click(object sender, EventArgs e)
        {
            if (uxResults.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in uxResults.SelectedRows)
                {
                    string[] item = new string[r.Cells.Count];
                    sa.AddItemToReceipt(item);
                }    
                    
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
            
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {

        }
    }
}
