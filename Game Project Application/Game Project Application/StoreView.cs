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
    public partial class StoreView : Form
    {
        public StoreView()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStoreInfo_Click(object sender, EventArgs e)
        {
            if(uxStoreId.Text != "")
            {
                int storeId = Convert.ToInt32(uxStoreId.Text);
                string location;
                string hours;
                string numOfGames;
                string totalSales;

                string[] output = getStoreInfo(storeId);

                string s = "Location: " +  output[0] + "\n" +
                           "Weekday Hours: " + output[1] + "\n" +
                           "Saturday Hours: " + output[2] + "\n" +
                           "Sunday Hours: " + output[3] + "\n" +
                           "Number of Games in Store: " + output[4] + "\n" +
                           "Total Sales: " + output[5] + "\n";
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show("Please Insert a Store Id.");
            }

        }

        private string[] getStoreInfo(int id)
        {
            string connectionString = "Server=mssql.cs.ksu.edu;Database=cis560_team21; Integrated Security=true";
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand("GameStore.GetStoreInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("StoreId", id);
                    connection.Open();

                    var k = command.ExecuteReader();


                    string address ="";
                    string city ="";
                    string state ="";
                    string weekdayHours = "";
                    string saturdayHours = "";
                    string sundayHours = "";
                    string numOfGames = "";
                    string totalSales = "";
                    int hours;
                    int minute;
                    string m;

                    while (k.Read())
                    {
             
                        address = k.GetString(k.GetOrdinal("Address"));
                        city = k.GetString(k.GetOrdinal("City"));
                        state = k.GetString(k.GetOrdinal("State"));

                        if(k.GetString(k.GetOrdinal("Description")).Equals("Monday to Friday Hours"))
                        {

                            hours = k.GetInt32(k.GetOrdinal("StartHour"));
                            minute = k.GetInt32(k.GetOrdinal("StartMinute"));
                            
                            if(minute < 10)
                            {
                                m = "0" + minute.ToString();
                            }
                            else
                            {
                                m = minute.ToString();
                            }

                            if(hours < 12)
                            {
                                
                                weekdayHours = hours.ToString() + ":" + m + " AM";
                            }
                            else
                            {
                                
                                weekdayHours = (hours % 12).ToString() + ":" + m + " PM";
                            }

                        }
                        else if(k.GetString(k.GetOrdinal("Description")).Equals("Saturday Hours"))
                        {
                            hours = k.GetInt32(k.GetOrdinal("StartHour"));
                            minute = k.GetInt32(k.GetOrdinal("StartMinute"));

                            if (minute < 10)
                            {
                                m = "0" + minute.ToString();
                            }
                            else
                            {
                                m = minute.ToString();
                            }

                            if (hours < 12)
                            {

                                saturdayHours = hours.ToString() + ":" + m + " AM";
                            }
                            else
                            {

                                saturdayHours = (hours % 12).ToString() + ":" + m + " PM";
                            }
                        }
                        else if(k.GetString(k.GetOrdinal("Description")).Equals("Sunday Hours"))
                        {
                            hours = k.GetInt32(k.GetOrdinal("StartHour"));
                            minute = k.GetInt32(k.GetOrdinal("StartMinute"));

                            if (minute < 10)
                            {
                                m = "0" + minute.ToString();
                            }
                            else
                            {
                                m = minute.ToString();
                            }

                            if (hours < 12)
                            {

                                sundayHours = hours.ToString() + ":" + m + " AM";
                            }
                            else
                            {

                                sundayHours = (hours % 12).ToString() + ":" + m + " PM";
                            }
                        }


                        numOfGames = k.GetInt32(k.GetOrdinal("NumGames")).ToString();
                        totalSales = k.GetDecimal(k.GetOrdinal("TotalSales")).ToString();

                    }

                    string location = address + ", " + city + ", " + state;

                    
                    k.Close();

                    string[] output = { location, weekdayHours, saturdayHours, sundayHours, numOfGames, totalSales };
                    return output;
                }
            }
        }


        private void btnSales_Click(object sender, EventArgs e)
        {
            if (uxStoreId.Text != "")
            {
                int storeId = Convert.ToInt32(uxStoreId.Text);
            }
            else
            {
                MessageBox.Show("Please Insert a Store Id.");
            }
        }
    }
}
