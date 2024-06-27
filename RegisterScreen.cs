using FontAwesome.Sharp;
using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto.Prng;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Xml;

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
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(lblHorary);
            labels.Add(lblDescription);

            List<IconButton> iconButtons = new List<IconButton>();
            iconButtons.Add(ibSearch);

            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.buttons = buttons;
            programTheme.labels = labels;
            programTheme.iButtons = iconButtons;
            FillDropList("SELECT services.`name` as Serviços FROM services", "Serviços", ref comboCorte);
            FillDropList("SELECT full_name as barbeiros FROM barbers", "barbeiros", ref comboBarber);
        }

        private void LoadDatabaseData()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=barber_shop2;uid=root;pwd=jhon");
            try
            {
                connection.Open();

                string commandString = "SELECT schedules.id, customers.full_name as nome, schedules.horary as horário FROM customers  INNER JOIN schedules ON customers.id = schedules.customer_id ORDER BY schedules.horary;";

                if (txtbSearch.Text != "")
                {
                    commandString = "SELECT  schedules.id, customers.full_name as nome, schedules.horary as horário FROM customers JOIN schedules ON customers.id = schedules.customer_id WHERE full_name LIKE @nome ORDER BY schedules.horary";
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
                        command.CommandText = "SELECT  schedules.id, customers.full_name as nome, schedules.horary as horário FROM customers JOIN schedules ON customers.id = schedules.customer_id ORDER BY schedules.horary;";
                    }

                    adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvSchedules.DataSource = dt;
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
            else if (Regex.IsMatch(txtName.Text, "^[ ]|[ ]$") || Regex.IsMatch(txtDescription.Text, "^[ ]|[ ]$"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("O campo não pode começar/terminar com espaço");
                errorValue.ShowDialog();
            }
            else
            {
                try
                {
                    string conexao = "server=localhost;database=barber_shop2;uid=root;pwd=jhon;";
                    MySqlConnection conexaoMysql = new MySqlConnection(conexao);
                    conexaoMysql.Open();
                    int[] ids = new int[3];
                    readQuery("SELECT customers.id FROM customers WHERE customers.full_name LIKE '" + txtName.Text + "%';", ref ids[0]);
                    readQuery("SELECT services.id FROM services WHERE services.`name` = '" + comboCorte.Text + "';", ref ids[1]);
                    readQuery("SELECT id FROM barbers WHERE full_name = '" + comboBarber.Text + "';",ref ids[2]);
                    string finalDate = Date(maskeDate.Text);
                    DateTime appointmentDateTime = Convert.ToDateTime(maskeDate.Text + " " + maskeHorary.Text);
                    DateTime startLimit = Convert.ToDateTime(maskeDate.Text + " " + "08:00:00");
                    DateTime endLimit = Convert.ToDateTime(maskeDate.Text + " " + "18:30:00");

                    if (readField("SELECT customers.full_name FROM customers", "full_name", txtName.Text))
                    {
                        ErrorMessageBox notFound = new ErrorMessageBox("Verifique se você escreveu nome certo ou se ele é cadastrado");
                        notFound.ShowDialog();
                        return;
                    }
                    else if (readField("SELECT horary FROM schedules;", "horary", finalDate))
                    {
                        ErrorMessageBox found = new ErrorMessageBox("Este horário está  indisponível");
                        found.ShowDialog();
                        return;
                    }
                    else if (intervalHorary())
                    {
                        ErrorMessageBox found = new ErrorMessageBox("Este horário está indisponível");
                        found.ShowDialog();
                        return;
                    }
                    else if (Convert.ToDateTime(maskeDate.Text + " " + maskeHorary.Text) < DateTime.Now)
                    {
                        ErrorMessageBox found = new ErrorMessageBox("Não pode marcar um agendamento neste horário");
                        found.ShowDialog();
                        return;
                    }
                    else if(appointmentDateTime < startLimit || appointmentDateTime > endLimit)
                    {
                        ErrorMessageBox found = new ErrorMessageBox("O barbeiro não atende nesta hora");
                        found.ShowDialog();
                        return;
                    }
                    else
                    {
                        if(comboBarber.Text != " " || comboBarber.Text != null)
                        {
                            MySqlCommand comando = new MySqlCommand("INSERT INTO schedules(customer_id,schedules.service,schedules.horary,schedules.`description`,schedules.service_id,barber_id,created_at,updated_at) values(" + ids[0] + ",'" + comboCorte.Text + "','" + finalDate + "','" + txtDescription.Text + "'," + ids[1] + ","+ ids[2] + ", '" + Date(DateTime.Now.ToString()) + "','" + Date(DateTime.Now.ToString()) + "');", conexaoMysql);
                            comando.ExecuteNonQuery();
                        }
                        else
                        {
                            MySqlCommand comando = new MySqlCommand("INSERT INTO schedules(customer_id,schedules.service,schedules.horary,schedules.`description`,schedules.service_id, created_at,updated_at) values(" + ids[0] + ",'" + comboCorte.Text + "','" + finalDate + "','" + txtDescription.Text + "'," + ids[1] + ", '" + Date(DateTime.Now.ToString()) + "','" + Date(DateTime.Now.ToString()) + "');", conexaoMysql);
                            comando.ExecuteNonQuery();
                        }
                       
                        DoneMessageBox dMessageBox = new DoneMessageBox("Agendamento concluído, o horário está marcado!");
                        dMessageBox.Show();

                        txtName.Text = "";
                        comboCorte.Text = null;
                        maskeHorary.Text = "";
                        maskeDate.Text = "";
                        comboBarber.Text = null;
                        if (txtDescription.Text != "Sem descrição")
                        {
                            txtDescription.Text = "Sem descrição";
                        }
                        LoadDatabaseData();
                    }
                    conexaoMysql.Close();
                }
                catch (Exception erro)
                {
                    ErrorMessageBox eMessageBox = new ErrorMessageBox(erro.ToString());
                    eMessageBox.ShowDialog();
                }              
            }
        }

        private void AgendamentosScreen_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();

            LoadDatabaseData();
            dgvSchedules.Columns[0].Width = 50;
            dgvSchedules.Columns[1].Width = 100;
            dgvSchedules.Columns[2].Width = 160;
        }

        private void ibSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbSearch.Text == null || txtbSearch.Text == "")
            {
                LoadDatabaseData();
            }
            else if (!Regex.IsMatch(txtbSearch.Text, "^[A-Za-zÁ-Úá-úÀ-Ùà-ùâ-ûÂ-Ûã-õÃ-Õ  ]+$"))
            {
                ErrorMessageBox errorValeu = new ErrorMessageBox("Apenas letras neste campo");
                errorValeu.ShowDialog();
            }
            else if (Regex.IsMatch(txtbSearch.Text, "[ ]$") || Regex.IsMatch(txtbSearch.Text, "^[ ]"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("O campo não pode começar/terminar com um espaço em branco");
                errorValue.ShowDialog();
            }
            else
            {
                LoadDatabaseData();
            }
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
            if (value == DateTime.Now.ToString())
            {               
                day = value.Substring(0, 2);
                month = value.Substring(3, 2);
                year = value.Substring(6, 4);
                string hour = DateTime.Now.Hour.ToString();
                String minutes = DateTime.Now.Minute.ToString();
                String seconds = DateTime.Now.Second.ToString();
                date = year + "-" + month + "-" + day + " " + hour + ":" + minutes + ":" + seconds;
            }
            else
            {             
                day = value.Substring(0, 2);
                month = value.Substring(3, 2);
                year = value.Substring(6, 4);
                string horary = maskeHorary.Text;

                date = year + "-" + month + "-" + day + " ";
                date += horary;
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
            MySqlConnection.Close();
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

        private void txtDescription_Click(object sender, EventArgs e)
        {
            txtDescription.Text = "";
        }

        private bool readField(string query, string field, string txt)
        {
            bool value = true;
            MySqlConnection MySqlConnection = new MySqlConnection(conection);
            MySqlCommand comand = new MySqlCommand(query, MySqlConnection);
            MySqlDataReader myReader;
            MySqlConnection.Open();
            myReader = comand.ExecuteReader();

            if (field == "full_name")
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
                if (!myReader.HasRows)
                {
                    value = false;
                }
                else
                {
                    while (myReader.Read())
                    {
                        if (myReader.GetDateTime(field).ToString("yyyy-MM-dd HH:mm:ss").Contains(txt))
                        {
                            value = true;
                            break;
                        }
                        else
                        {
                            value = false;
                        }
                    }
                }          
            }
            MySqlConnection.Close();
            return value;
        }

        private void comboCorte_Click(object sender, EventArgs e)
        {
            comboCorte.Items.Clear();

            FillDropList("SELECT services.`name` as Serviços FROM services", "Serviços", ref comboCorte);
        }

        private bool intervalHorary()
        {
            
            bool found = false;
            MySqlConnection mySql = new MySqlConnection(conection);
            mySql.Open();

            MySqlCommand comand = new MySqlCommand("SELECT category,services.duration as duration,horary FROM schedules INNER JOIN services ON services.id = schedules.service_id WHERE DATE(horary) = CURDATE();", mySql);
            MySqlDataReader readerHorary;

            readerHorary = comand.ExecuteReader();
            if (!readerHorary.HasRows)
            {
                found = false;
            }
            else
            {
                while (readerHorary.Read())
                {
                    try
                    {
                        string date = maskeDate.Text;
                        string dateBank = readerHorary.GetDateTime("horary").ToString().Substring(0, 10);
                        int hour = int.Parse(maskeHorary.Text.Substring(0, 2));
                        int minutes = int.Parse(maskeHorary.Text.Substring(3, 2));
                        TimeSpan hourLocal = new TimeSpan(hour, minutes, 0);
                        TimeSpan hourBank = new TimeSpan(readerHorary.GetDateTime("horary").Hour, readerHorary.GetDateTime("horary").Minute, 0);
                        TimeSpan result = hourBank - hourLocal;
                        if (hourLocal > hourBank)
                        {
                            result = hourLocal - hourBank;
                        }
                        if (dateBank == date)
                        {
                            if (result < readerHorary.GetTimeSpan("duration"))
                            {

                                found = true;
                                break;
                            }

                        }
                    }
                    catch (Exception e)
                    {
                        if (readerHorary.IsDBNull(readerHorary.GetOrdinal("descrição")))
                        {
                            MessageBox.Show("Algo deu errado, verifique as informações");
                        }
                    }

                }
            }
            mySql.Close();
            return found;
        }

        private void ibDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection MySqlConnection = new MySqlConnection(conection))
                {
                    MySqlConnection.Open();
                 
                    MySqlCommand selectCommand = new MySqlCommand("SELECT customers.tel FROM schedules INNER JOIN customers ON customers.id = schedules.customer_id WHERE schedules.id = @scheduleId;", MySqlConnection);
                    selectCommand.Parameters.AddWithValue("@scheduleId", int.Parse(txtDelete.Text));

                    object phoneNumber = selectCommand.ExecuteScalar();

                    if (phoneNumber != null)
                    {

                      DialogResult  =  MessageBox.Show("Número de Telefone do Cliente: " + phoneNumber.ToString(), "Número de Telefone", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                        if (DialogResult == DialogResult.OK)
                        {
                            MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM schedules WHERE id = @scheduleId;", MySqlConnection);
                            deleteCommand.Parameters.AddWithValue("@scheduleId", int.Parse(txtDelete.Text));
                            int rowsAffected = deleteCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                DoneMessageBox doneBox = new DoneMessageBox("Agendamento Apagado com sucesso");
                                doneBox.ShowDialog();

                                LoadDatabaseData(); 
                            }
                            else
                            {
                                MessageBox.Show("Não foi possível apagar o agendamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            return;
                        }           
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível encontrar o número de telefone do cliente associado ao agendamento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    MySqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox errorBox = new ErrorMessageBox("Ocorreu um erro ao apagar o agendamento: " + ex.Message);
                errorBox.ShowDialog();
            }
        }

        private void dgvSchedules_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDelete.Text = dgvSchedules.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                ErrorMessageBox errorNotFound = new ErrorMessageBox("Algo deu errado, tente novamente");
                errorNotFound.ShowDialog();
            }
        }

        private void comboBarber_Click(object sender, EventArgs e)
        {
            comboBarber.Items.Clear();

            FillDropList("SELECT full_name as barbeiros FROM barbers", "barbeiros", ref comboBarber); ;
        }
    }
}