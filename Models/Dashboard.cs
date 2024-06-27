using interdisciplinar2.CustomMessageBoxes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace interdisciplinar2.Models
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal totalAmount { get; set; }
    }

    public class Dashboard : DbConnection
    {
        private DateTime startDate;
        private DateTime endDate;
        private int numberOfDays;

        public List<RevenueByDate> RevenueByDateList { get; private set; }
        public int numberOfSchedules { get; private set; }
        public string ClientWithMostSchedules { get; set; }
        public decimal totalRevenue { get; set; }

        public Dashboard()
        {
        }

        private void GetNumberOfSchedules()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.Connection = connection;


                        command.CommandText = @"SELECT COUNT(schedules.id) 
                                       FROM schedules 
                                       WHERE horary BETWEEN @fromDate AND @toDate AND schedules.updated_at <> schedules.created_at;";
                        command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                        command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;
                        numberOfSchedules = Convert.ToInt32(command.ExecuteScalar());


                        command.CommandText = @"SELECT customers.full_name 
                                       FROM customers 
                                       INNER JOIN schedules ON customers.id = schedules.customer_id 
                                       WHERE schedules.horary BETWEEN @fromDate AND @toDate 
                                       AND schedules.updated_at <> schedules.created_at
                                       GROUP BY customers.full_name 
                                       ORDER BY COUNT(schedules.id) DESC 
                                       LIMIT 1;";

                        command.Parameters.Clear();
                        command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                        command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;
                        ClientWithMostSchedules = command.ExecuteScalar() as string;
                    }
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Algo deu errado, tente novamente");
                Console.WriteLine(erro.Message);
            }
        }


        private void GetResultGraphic()
        {
            RevenueByDateList = new List<RevenueByDate>();
            totalRevenue = 0;

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();

                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;

                        command.CommandText = @"SELECT schedules.horary, COUNT(schedules.id), services.price_id 
                                        FROM schedules 
                                        INNER JOIN services ON schedules.service_id = services.id 
                                        INNER JOIN service_prices ON services.price_id = service_prices.id
                                        WHERE schedules.horary BETWEEN @fromDate AND @toDate 
                                        AND schedules.updated_at <> schedules.created_at
                                        GROUP BY schedules.horary, services.price_id;";

                        command.Parameters.Add("@fromDate", MySqlDbType.DateTime).Value = startDate;
                        command.Parameters.Add("@toDate", MySqlDbType.DateTime).Value = endDate;

                        MySqlDataReader reader = command.ExecuteReader();

                        var resultTable = new List<KeyValuePair<DateTime, decimal>>();

                        while (reader.Read())
                        {
                            var horary = reader.GetDateTime(0);
                            var count = reader.GetDecimal(1);
                            var priceId = reader.GetInt32(2);

                            decimal price = GetServicePrice(priceId);

                            resultTable.Add(new KeyValuePair<DateTime, decimal>(horary, count * price));
                            totalRevenue += count * price;
                        }
                        reader.Close();

                        if (numberOfDays < 1)
                        {
                            RevenueByDateList = (from pair in resultTable
                                                 group pair by pair.Key.ToString("yyyy-MM-dd HH:00") into grouped
                                                 select new RevenueByDate()
                                                 {
                                                     Date = grouped.Key.Substring(11, 5), // Apenas a hora e minutos
                                                     totalAmount = grouped.Sum(pair => pair.Value)
                                                 }).ToList();
                        }
                        else if (numberOfDays < 30)
                        {

                            RevenueByDateList = (from list in resultTable
                                                 group list by list.Key.ToString("dd MMM") into grouped
                                                 select new RevenueByDate()
                                                 {
                                                     Date = grouped.Key,
                                                     totalAmount = grouped.Sum(amount => amount.Value)
                                                 }).ToList();
                        }
                        else if (numberOfDays < 92)
                        {
                            RevenueByDateList = (from list in resultTable
                                                 group list by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(list.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday) into grouped
                                                 select new RevenueByDate()
                                                 {
                                                     Date = "Semana " + grouped.Key.ToString(),
                                                     totalAmount = grouped.Sum(amount => amount.Value)
                                                 }).ToList();
                        }
                        else if (numberOfDays < (365 * 2))
                        {
                            bool isYear = numberOfDays > 365 ? true : false;

                            RevenueByDateList = (from list in resultTable
                                                 group list by list.Key.ToString("MMM yyyy") into grouped
                                                 select new RevenueByDate()
                                                 {
                                                     Date = isYear ? grouped.Key.Substring(0, grouped.Key.IndexOf(" ")) : grouped.Key,
                                                     totalAmount = grouped.Sum(amount => amount.Value)
                                                 }).ToList();
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                eMessageBox.ShowDialog();
            }
        }


        private decimal GetServicePrice(int priceId)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT price FROM service_prices WHERE id = @priceId", connection))
                {
                    command.Parameters.Add("@priceId", MySqlDbType.Int32).Value = priceId;
                    return Convert.ToDecimal(command.ExecuteScalar());
                }
                connection.Close();
            }
        }

        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, endDate.Hour, endDate.Minute, 59);


            this.startDate = startDate;
            this.endDate = endDate;
            this.numberOfDays = (endDate - startDate).Days;

            GetNumberOfSchedules();
            GetResultGraphic();

            return true;

            
        }
    }

}