using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace interdisciplinar2
{
    public partial class HistoricScreen : Form
    {
        private ProgramTheme programTheme;
        private Schedule schedule;
        string conection = "Server=localhost;database=barber_shop2;uid=root;pwd=jhon";
        public HistoricScreen()
        {
            InitializeComponent();

            List<Label> labels = new List<Label>();
            labels.Add(tituloSelecionado);

            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.labels = labels;

            schedule = new Schedule();
        }

        private void HistoricScreen_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                schedule.StartDate = DateTime.Now;

                schedule.GetAllPastSchedules(dgvHistorico);
            }
            catch (Exception ex)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                eMessageBox.ShowDialog();
            }
        }

        private void cbHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            tituloSelecionado.Text = cbHistorico.Text;
            
            try
            {
                switch (cbHistorico.SelectedIndex)
                {
                    case 0:
                        read("SELECT customers.full_name,schedules.service,schedules.horary FROM customers JOIN schedules ON customers.id = schedules.customer_id WHERE horary >= DATE_SUB(CURDATE(), INTERVAL DAYOFWEEK(CURDATE())+6 DAY) AND horary < DATE_ADD(DATE_SUB(CURDATE(), INTERVAL DAYOFWEEK(CURDATE())-1 DAY), INTERVAL 1 DAY);");
                        break;

                    case 1:
                        read("SELECT customers.full_name,schedules.service,schedules.horary FROM customers JOIN schedules ON customers.id = schedules.customer_id\r\nWHERE MONTH(horary) = MONTH(CURDATE()) - 1;");
                        break;

                    case 2:
                        read("SELECT customers.full_name,schedules.service,schedules.horary FROM customers JOIN schedules ON customers.id = schedules.customer_id \r\nWHERE DATE(horary) < CURDATE();"); 
                        break;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                eMessageBox.ShowDialog();
            }
        }
        private void read(string query)
        {
            MySqlConnection conexaoSql = new MySqlConnection(conection);
            conexaoSql.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoSql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvHistorico.DataSource = dt;
        }
    }
}