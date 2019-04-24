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
    /// <summary>
    /// The SearchResults accesses the database and returns all the games based off the given criteria from the SearchCondtions variable in the constructor.
    /// </summary>
    public partial class SearchResults : Form
    {
        /// <summary>
        /// A StoreApplication object which is the creator of this form.  This is needed to be able to send information back and forth
        /// between forms.
        /// </summary>
        private GameApplication sa;

        /// <summary>
        /// Constructor for SearchResults and retireves all the games related to the search parameters in g
        /// </summary>
        /// <param name="sa">The Store application that created this form.</param>
        /// <param name="g">A game object with all the parameters given to find games</param>
        public SearchResults(GameApplication sa, SearchConditions g)
        {
            this.sa = sa;
         

            GameRepository gr = new GameRepository();
            List<Game> lg = gr.RetrieveGames(g);

            InitializeComponent();
            foreach (Game ga in lg)
            {
                string[] s = { ga.Title, ga.Genre, ga.Price.ToString(), ga.IsUsed, ga.StoreId.ToString(), ga.GameId.ToString(), ga.Quantity.ToString(), ga.Platform.ToString() };
                bool allAreInReceipt = sa.RemoveFromSearch(s);

                if (!allAreInReceipt)
                {
                    this.uxResults.Rows.Add(s);
                }
                
            }
        }
        /// <summary>
        /// Handles a click event on the Add To Receipt button, Adds a selected game from the list to the receipt in the GameApplication window and removes the selected game from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToReceipt_Click(object sender, EventArgs e)
        {
            //Finds all the rows seleccted by the user.
            if (uxResults.SelectedRows.Count > 0)
            {
                List<int> rowsToRemove = new List<int>();

                foreach (DataGridViewRow r in uxResults.SelectedRows)
                {
                    string[] item = new string[r.Cells.Count];
                    for(int i = 0; i < r.Cells.Count; i++)
                    {
                        item[i] = r.Cells[i].Value.ToString();
                    }

                    //The selected row's values are sent to a reservedList in the Game Application. Where if the number of quantity in the reserved list for the given item
                    //are greater than or equal to the quantity of the item in the search results the item is removed from the search results.
                    bool toRemoveRow = sa.AddReserve(item);

                    if(toRemoveRow == true)
                    {
                        rowsToRemove.Add(r.Index);
                    }
                    
                    sa.AddItemToReceipt(item);
                }
                
                foreach(int index in rowsToRemove)
                {
                    uxResults.Rows.RemoveAt(index);
                }
                    
            }
            else
            {
                MessageBox.Show("Please select an item.");
            }
            
        }
    }
}
