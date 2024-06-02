using FontAwesome.Sharp;
using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using K4os.Compression.LZ4.Streams.Internal;
using MySql.Data.MySqlClient;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class Queries : Form
    {
        string conection = "Server=localhost;database=barber_shop2;uid=root;pwd=jhon";

        private ProgramTheme programTheme;

        public Queries()
        {
            InitializeComponent();
            List<Button> buttons = new List<Button>();
            buttons.Add(btnBarberActive);
            buttons.Add(btnClientActive);
            buttons.Add(mostService);

            List<Label> labels = new List<Label>();
            labels.Add(label1);
            
            List<IconButton> iconButtons = new List<IconButton>();
            iconButtons.Add(ibQueryClient);
          

            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.buttons = buttons;
            programTheme.labels = labels;
            programTheme.iButtons = iconButtons;
        }

        private void read(string query)
        {
            MySqlConnection conexaoSql = new MySqlConnection(conection);
            conexaoSql.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoSql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvQuery.DataSource = dt;
        }

        private void btnClientActive_Click(object sender, EventArgs e)
        {
            string query = "SELECT barbers.full_name AS Barbeiros,COUNT(schedules.barber_id) AS Atendimentos  FROM barbers INNER JOIN schedules ON barbers.id = schedules.barber_id GROUP BY schedules.barber_id ORDER BY COUNT(schedules.barber_id) DESC;";
            read(query);
        }
    
        private void btnBarberActive_Click(object sender, EventArgs e)
        {
            string query = "SELECT customers.full_name AS Cliente, COUNT(schedules.customer_id) AS Agendamentos FROM customers INNER JOIN schedules ON customers.id = schedules.customer_id GROUP BY schedules.customer_id;";
            read(query);
        }

        private void mostService_Click(object sender, EventArgs e)
        {
            string query = "SELECT services.`name` AS Serviço, COUNT(service) AS Requisições  FROM services INNER JOIN schedules ON schedules.service_id = services.id GROUP BY services.`name` ORDER BY COUNT(service) DESC;";
            read(query);
        }

        private void ibQueryClient_Click(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(conection);
            mySqlConnection.Open();
            MySqlCommand comand = new MySqlCommand("SELECT full_name FROM customers;", mySqlConnection);
            MySqlDataReader myReader;
            myReader = comand.ExecuteReader();
            if (txtbSearch.Text == null || txtbSearch.Text == "")
            {
                ErrorMessageBox dMessageBox = new ErrorMessageBox("O campo está em branco, o preencha por favor!");
                dMessageBox.ShowDialog();
            }
            else
            {
                while (myReader.Read())
                {
                    if (!myReader.GetString("full_name").Contains(txtbSearch.Text))
                    {
                        ErrorMessageBox notFound = new ErrorMessageBox("Esse cliente não foi cadastrado");
                        notFound.ShowDialog();
                        return;
                    }
                    else
                    {
                        string query = "SELECT customers.full_name AS Cliente,barbers.full_name AS Barbeiro FROM barbers INNER JOIN schedules ON schedules.barber_id = barbers.id INNER JOIN customers ON customers.id = schedules.customer_id WHERE customers.full_name LIKE '" + txtbSearch.Text + "%';";
                        read(query);
                        return;
                    }
                }
            }
        }

        private void Queries_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();
        }
    }
}
