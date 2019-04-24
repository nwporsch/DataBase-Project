using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Game_Project_Application
{
    public partial class SalesInformation : Form
    {
        private int storeId;

        public SalesInformation(int storeId)
        {
            this.storeId = storeId;
            InitializeComponent();
            GetSales();
        }

        /// <summary>
        /// Returns the total number of orders made and total sales of each month and each year
        /// </summary>
        /// <param name="storeId"></param>
        /// <returns></returns>
        private string[] getSalesInfo(int storeId, int i)
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
                        if (k.GetInt32(k.GetOrdinal("OrderMonth")).Equals(i))
                        {
                            orders = k.GetInt32(k.GetOrdinal("OrderCount")).ToString();
                            totalSales = k.GetDecimal(k.GetOrdinal("Sales")).ToString();
                        }
                        else if (i == 0 && k.GetInt32(k.GetOrdinal("OrderMonth")).Equals(12))
                        {
                            orders = k.GetInt32(k.GetOrdinal("YearlyOrders")).ToString();
                            totalSales = k.GetDecimal(k.GetOrdinal("YearlySales")).ToString();
                        }
                    }

                    k.Close();

                    string[] output = { orders, totalSales };
                    return output;
                }
            }
        }


        private void GetSales()
        {
            StringBuilder s = new StringBuilder();

            string[] output;

            for (int i = 1; i <= 12; i++)
            {
                output = getSalesInfo(storeId, i);
                switch (i)
                {
                    case 1:
                        s.Append("Month: January\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 2:
                        s.Append("Month: February\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 3:
                        s.Append("Month: March\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 4:
                        s.Append("Month: April\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 5:
                        s.Append("Month: May\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 6:
                        s.Append("Month: June\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 7:
                        s.Append("Month: July\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 8:
                        s.Append("Month: August\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 9:
                        s.Append("Month: September\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 10:
                        s.Append("Month: October\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 11:
                        s.Append("Month: November\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n");
                        break;
                    case 12:
                        s.Append("Month: December\r\n" +
                                 "Monthly Orders: " + output[0] + "\r\n" +
                                 "Monthly Sales:  " + output[1] + "\r\n\r\n");
                        break;
                }

            }

            output = getSalesInfo(storeId, 0);
            s.Append("Yearly Orders: " + output[0] + "\r\n" +
                     "Yearly Sales:  " + output[1]);

            this.uxSalesText.Text = s.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
