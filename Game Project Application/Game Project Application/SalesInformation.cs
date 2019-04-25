using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Game_Project_Application
{
    /// <summary>
    /// This form is used to find total sales of each month and each year for a given store.
    /// </summary>
    public partial class SalesInformation : Form
    {
        /// <summary>
        /// The Store Identifier
        /// </summary>
        private int storeId;

        /// <summary>
        /// Constructor of the SalesInformation form.
        /// </summary>
        /// <param name="storeId"></param>
        public SalesInformation(int storeId)
        {
            this.storeId = storeId;
            InitializeComponent();
        }

        /// <summary>
        /// Returns the total number of orders made and total sales of each month and each year
        /// </summary>
        /// <param name="storeId">The identifier of the Store Id</param>
        /// /// <param name="i">The month to be searched for.  i is from 1-12 which corresponds to the month of the year.</param>
        /// <param name="year">The year to be searched for.</param>
        /// <returns>A string array that holds all the orders made and total sales based off the parameters given.</returns>
        private string[] getSalesInfo(int storeId, int i, int year)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("GameStore.GetSalesInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("StoreId", storeId);
                    connection.Open();

                    var k = command.ExecuteReader();

                    string orders = "";
                    string totalSales = "";

                    while (k.Read())
                    {
                        if (k.GetInt32(k.GetOrdinal("OrderMonth")).Equals(i) && k.GetInt32(k.GetOrdinal("OrderYear")).Equals(year))
                        {
                            orders = k.GetInt32(k.GetOrdinal("OrderCount")).ToString();
                            totalSales = k.GetDecimal(k.GetOrdinal("Sales")).ToString();
                            break;
                        }
                        else if (i == 0 && k.GetInt32(k.GetOrdinal("OrderYear")).Equals(year))
                        {
                            orders = k.GetInt32(k.GetOrdinal("YearlyOrders")).ToString();
                            totalSales = k.GetDecimal(k.GetOrdinal("YearlySales")).ToString();
                        }                                                                                 
                    }
                    if(orders.Equals("") && totalSales.Equals(""))
                    {
                        orders = "0";
                        totalSales = "0";
                    }
              
                    k.Close();

                    string[] output = { orders, totalSales };
                    return output;
                }
            }
        }

        /// <summary>
        /// Calls getSalesInfo(int storeId, int month, int year) and takes the string array returned and formats it for the user.
        /// </summary>
        private void GetSales()
        {
            StringBuilder s = new StringBuilder();
            
            string[] output;
            int year = Convert.ToInt32(uxYearText.Text);
            bool hasResults = true;

            for (int i = 1; i <= 12; i++)
            {
                output = getSalesInfo(storeId, i, year);
                if (output[0] != "")
                {

                    switch (i)
                    {
                        case 1:
                            s.Append("Year: " + year + "\r\n\r\n");

                            s.Append("Month: January\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 2:
                            s.Append("Month: February\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 3:
                            s.Append("Month: March\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 4:
                            s.Append("Month: April\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 5:
                            s.Append("Month: May\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 6:
                            s.Append("Month: June\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 7:
                            s.Append("Month: July\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 8:
                            s.Append("Month: August\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 9:
                            s.Append("Month: September\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 10:
                            s.Append("Month: October\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 11:
                            s.Append("Month: November\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                        case 12:
                            s.Append("Month: December\r\n" +
                                     "Monthly Orders: " + output[0] + "\r\n" +
                                     "Monthly Sales:  $" + output[1] + "\r\n\r\n");
                            break;
                    }

                }
                else
                {
                    s.Append("No Results.");
                    hasResults = false;
                    break;
                }

            }

            if (hasResults == true)
            {

                output = getSalesInfo(storeId, 0, year);
                s.Append(year + " Yearly Orders: " + output[0] + "\r\n" +
                         year + " Yearly Sales:  $" + output[1]);
            }

            this.uxSalesText.Text = s.ToString();
        }

        /// <summary>
        /// Closes the SalesInformation form.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// If the user clicks the search button the sales for the given you is searched for.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxbtnSearch_Click(object sender, EventArgs e)
        {
            GetSales();
        }
    }


}
