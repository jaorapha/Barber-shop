using FontAwesome.Sharp;
using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class AgendamentosScreen : Form
    {
        private ProgramTheme programTheme;

        string conection = "server=localhost;database=barber_shop2;uid=root;pwd=jhon";

        public AgendamentosScreen()
        {
            InitializeComponent();

            List<Button> buttons = new List<Button>();
            buttons.Add(btnCadastrar);

            List<Label> labels = new List<Label>();
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);

            List<IconButton> iconButtons = new List<IconButton>();
            iconButtons.Add(ibSearch);

            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.buttons = buttons;
            programTheme.labels = labels;
            programTheme.iButtons = iconButtons;
            FillDropList("SELECT services.`name` as Serviços FROM services", "Serviços", ref comboCorte);
        }

        private void LoadDatabaseData()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=barber_shop2;uid=root;pwd=jhon");
            try
            {
                connection.Open();

                string commandString = "SELECT customers.full_name, schedules.horary FROM customers JOIN schedules ON customers.id = schedules.customer_id;;";

                if (txtbSearch.Text != "")
                {
                    commandString = "SELECT customers.full_name, schedules.horary FROM customers JOIN schedules ON customers.id = schedules.customer_id WHERE full_name LIKE @nome";
                }

                MySqlDataAdapter adapter = null;

                using (MySqlCommand command = new MySqlCommand(commandString, connection))
                {
                    if (txtbSearch.Text != "")
                    {
                        command.Parameters.AddWithValue("@nome", txtbSearch.Text + "%");
                    }
                    else
                    {
                        command.CommandText = "SELECT customers.full_name, schedules.horary FROM customers JOIN schedules ON customers.id = schedules.customer_id;";
                    }

                    adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Dispose();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
                string[] dados = new string[4] { txtName.Text, comboCorte.Text, maskeDate.Text, maskeHorary.Text };
                int cont = 0;

                foreach (string values in dados)
                {
                    if (values == "" || values == "  /  /" || values == "  :  :")
                    {
                        cont++;
                    }
                };
            if (cont >= 1)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox("Você deixou " + cont + " campo(s) em branco, preencha-o(s)!");
                eMessageBox.ShowDialog();
            }
            else if (!Regex.IsMatch(txtName.Text, "^[A-Za-zÁ-ú ]+[´^~]?$") || !Regex.IsMatch(txtDescription.Text, "^[A-Za-zÁ-ú ]+[´^~]?$"))
            {
                ErrorMessageBox emptyService = new ErrorMessageBox("Preencha os campos apenas com letras por favor");
                emptyService.ShowDialog();
                return;
            }
            else
            {
                string conexao = "server=localhost;database=barber_shop2;uid=root;pwd=jhon;";
                MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                conexaoMysql.Open();
                int[] ids = new int[2];
                readQuery("SELECT customers.id FROM customers WHERE customers.full_name LIKE '" + txtName.Text + "%';", ref ids[0]);
                readQuery("SELECT services.id FROM services WHERE services.`name` = '" + comboCorte.Text + "';", ref ids[1]);
                string finalDate = Date(maskeDate.Text);
                finalDate += "" + maskeHorary.Text;

                if(readField("SELECT customers.full_name FROM customers", "full_name", txtName.Text))
                {
                    ErrorMessageBox notFound = new ErrorMessageBox("Verifique se você escreveu nome certo ou se ele é cadastrado");
                    notFound.ShowDialog();
                    return;
                }
                else if(readField("SELECT horary FROM schedules;", "horary", finalDate))
                {
                    ErrorMessageBox found = new ErrorMessageBox("Já tem um agenmento neste horário,por favor escolha outro");
                    found.ShowDialog();
                    return;
                }
                else
                {
                    MySqlCommand comando = new MySqlCommand("INSERT INTO schedules(customer_id,schedules.service,schedules.horary,schedules.`description`,schedules.service_id) values(" + ids[0] + ",'" + comboCorte.Text + "','" + finalDate + "','" + txtDescription.Text + "'," + ids[1] + ");", conexaoMysql);
                    comando.ExecuteNonQuery();

                    DoneMessageBox dMessageBox = new DoneMessageBox("Agendamento concluído, o horário está marcado!");
                    dMessageBox.Show();

                    txtName.Text = "";
                    comboCorte.Text = null;
                    maskeHorary.Text = "";
                    maskeDate.Text = "";
                    if (txtDescription.Text != "Sem descrição")
                    {
                        txtDescription.Text = "Sem descrição";
                    }
                    LoadDatabaseData();
                }
            }           
        }

        private void AgendamentosScreen_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();

            LoadDatabaseData();
        }

        private void ibSearch_MouseClick(object sender, MouseEventArgs e)
        {
            LoadDatabaseData();
        }

        private void ibSearch_MouseEnter(object sender, EventArgs e)
        {
            ibSearch.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void ibSearch_MouseLeave(object sender, EventArgs e)
        {
            if (ProgramTheme.GetTheme() == "light")
            {
                ibSearch.BackColor = ProgramTheme.LightThemeBtnBackColor;
                ibSearch.IconColor = ProgramTheme.LightThemeForeColor;
            }
            else
            {
                ibSearch.BackColor = ProgramTheme.DarkThemeBackColor;
                ibSearch.IconColor = Color.White;
            }
        }

        private void btnCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrar.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void btnCadastrar_MouseLeave(object sender, EventArgs e)
        {
            if (ProgramTheme.GetTheme() == "light")
            {
                btnCadastrar.BackColor = ProgramTheme.LightThemeBtnBackColor;
                btnCadastrar.ForeColor = ProgramTheme.LightThemeForeColor;
            }
            else
            {
                btnCadastrar.BackColor = ProgramTheme.DarkThemeBackColor;
            }
        }

        private string Date(string value)
        {
            string day, month, year;
            string date = "";

            day = value.Substring(0, 2);
            month = value.Substring(3, 2);
            year = value.Substring(6, 4);

            string[] newDate = { year, month, day };

            foreach (string pass in newDate)
            {
                date += pass;
                if (pass == day)
                {
                    date += " ";
                    break;
                }
                date += "-";
            }
            
            return date;
        }

        private int readQuery(string query, ref int value)
        {
            MySqlConnection MySqlConnection = new MySqlConnection(conection);
            MySqlCommand comand = new MySqlCommand(query, MySqlConnection);
            MySqlDataReader myReader;
            MySqlConnection.Open();
            myReader = comand.ExecuteReader();

            while (myReader.Read())
            {
                value = myReader.GetInt32("id");
            }

            return value;
        }

        private void FillDropList(string query, string field, ref ComboBox list)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(conection))
            {
                MySqlCommand comand = new MySqlCommand(query, mySqlConnection);
                mySqlConnection.Open();
                using (MySqlDataReader myReader = comand.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        list.Items.Add(myReader[field].ToString());
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {    
            string finalDate = Date(maskeDate.Text);
            finalDate += "" + maskeHorary.Text;
            MessageBox.Show(finalDate);
        }

        private void maskeDate_Click(object sender, EventArgs e)
        {
           
        }

        private void txtDescription_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
        }

        private bool readField(string query,string field,string txt)
        {
            bool value = true;
            MySqlConnection MySqlConnection = new MySqlConnection(conection);
            MySqlCommand comand = new MySqlCommand(query, MySqlConnection);
            MySqlDataReader myReader;
            MySqlConnection.Open();
            myReader = comand.ExecuteReader();

            if(field == "full_name")
            {
                while (myReader.Read())
                {
                    if (myReader.GetString(field).Contains(txt))
                    {
                        value = false;
                    }
                }
            }
            else
            {
                while (myReader.Read())
                {
                    if (myReader.GetDateTime(field).ToString().Contains(txt))
                    {
                        value = true;
                    }
                }
            }
            return value;
        }
    }
}