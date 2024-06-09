using FontAwesome.Sharp;
using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;


namespace interdisciplinar2
{
    public partial class RegisterServices : Form
    {
        string conection = "server=localhost;database=barber_shop2;uid=root;pwd=jhon";
        
        private ProgramTheme programTheme;

        public RegisterServices()
        {
            InitializeComponent();
            List<Button> buttons = new List<Button>();
            buttons.Add(btnCadastrar);

            List<Label> labels = new List<Label>();
            labels.Add(lblTitle);
            labels.Add(lblCategory);
            labels.Add(lblDescripton);
            labels.Add(lblName);
            labels.Add(lblPrice);
            labels.Add(lblSearch);
            labels.Add(lblTitle);

            List<IconButton> iconButtons = new List<IconButton>();
            iconButtons.Add(ibSearch);


            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.buttons = buttons;
            programTheme.labels = labels;
            programTheme.iButtons = iconButtons;
        }

        private void LoadDatabaseData()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=barber_shop2;uid=root;pwd=jhon");
            try
            {
                connection.Open();

                string commandString = "SELECT services.`name` AS nome, service_prices.price AS preço FROM services LEFT JOIN service_prices ON service_prices.id = price_id ORDER BY services.category;";

                if (txtbSearch.Text != "")
                {
                    commandString = "SELECT services.`name` AS nome, service_prices.price FROM services LEFT JOIN service_prices ON service_prices.id = price_id WHERE services.`name` LIKE @nome ORDER BY services.category";
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
                        command.CommandText = "SELECT services.`name` AS nome, service_prices.price AS preço FROM services LEFT JOIN service_prices ON service_prices.id = price_id ORDER BY services.category;";
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
            string[] fieldsNUll = new string[] { txtName.Text, maskDuration.Text, txtDescription.Text, txtPrice.Text, txtCategory.Text };
            int count = 0;

            foreach (string pass in fieldsNUll)
            {
                if (pass == null || pass == "" || pass == "  :  :")
                {
                    count++;
                }
            }
            if (count > 0)
            {
                ErrorMessageBox fieldNull = new ErrorMessageBox("Tem " + count + " campos vazios, os preencha por favor");
                fieldNull.ShowDialog();
            }
            else if (Regex.IsMatch(txtName.Text, "[0-9]") || Regex.IsMatch(txtDescription.Text, "[0-9]") || Regex.IsMatch(txtCategory.Text, "[0-9]"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Somente o Campo preço pode conter Números");
                errorValue.ShowDialog();
            }
            else if (!Regex.IsMatch(txtCategory.Text, "^[A-Za-zÁ-Úá-úÀ-Ùà-ùâ-ûÂ-Ûã-õÃ-Õ,. ]+$") || !Regex.IsMatch(txtDescription.Text, "^[A-Za-zÁ-Úá-úÀ-Ùà-ùâ-ûÂ-Ûã-õÃ-Õ,. ]+$") || !Regex.IsMatch(txtName.Text, "^[A-Za-zÁ-Úá-úÀ-Ùà-ùâ-ûÂ-Ûã-õÃ-Õ,. ]+$"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Utilize apenas letras nos campos, exceto no campo preço");
                errorValue.ShowDialog();
            }
            else if (!Regex.IsMatch(txtPrice.Text, "^[1-9][0-9]{0,2},[0-9]{2}$"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Preço inválido");
                errorValue.ShowDialog();
            }
            else if (Regex.IsMatch(txtCategory.Text, "^[ ]|[ ]$") || Regex.IsMatch(txtName.Text, "^[ ]|[ ]$") || Regex.IsMatch(txtDescription.Text, "^[ ]|[ ]$") ||  Regex.IsMatch(txtDescription.Text, "^[ ]|[ ]$"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("O campo não pode começar/terminar com um espaço em branco");
                errorValue.ShowDialog();
            }
            else if(!Regex.IsMatch(maskDuration.Text, "^(?:(?!00:00)([01]\\d|2[0-3]):([0-5]\\d):([0-5]\\d))$"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Horário inválido");
                errorValue.ShowDialog();
            }
            else
            {
                int idBank = 0;

                decimal price = Convert.ToDecimal(txtPrice.Text, CultureInfo.CurrentCulture);

                using (MySqlConnection MySqlConnection = new MySqlConnection(conection))
                {
                    MySqlConnection.Open();

                    MySqlCommand comand = new MySqlCommand("SELECT id, price FROM service_prices", MySqlConnection);
                    MySqlCommand FindName = new MySqlCommand("SELECT services.`name` AS nome FROM services", MySqlConnection);

                    using (MySqlDataReader ReaderName = FindName.ExecuteReader())
                    {
                        while (ReaderName.Read())
                        {
                            if (ReaderName.GetString("nome").Contains(txtName.Text))
                            {
                                ErrorMessageBox messageName = new ErrorMessageBox("Este serviço já foi cadastrado");
                                messageName.ShowDialog();
                                return;
                            }
                        }
                    }
                    using (MySqlDataReader myReader = comand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            if (myReader.GetDecimal("price").Equals(price))
                            {
                                idBank = myReader.GetInt32("id");
                                MySqlConnection.Close();
                                MySqlConnection.Open();
                                using (MySqlCommand comandoNew = new MySqlCommand("INSERT INTO services (category, `name`, `description`, duration, price_id) VALUES('" + txtCategory.Text + "','" + txtName.Text + "','" + txtDescription.Text + "','" + maskDuration.Text + "', " + idBank + ");", MySqlConnection))
                                {
                                    comandoNew.ExecuteNonQuery();
                                    DoneMessageBox doneBox = new DoneMessageBox("Serviço registrado com sucesso");
                                    doneBox.ShowDialog();
                                    clearFields();
                                    LoadDatabaseData();
                                }
                                return;
                            }
                        }
                    }

                    string priceFormatted = price.ToString(CultureInfo.InvariantCulture);

                    using (MySqlCommand comandoNotFound = new MySqlCommand("INSERT INTO service_prices (price) VALUES(@price);", MySqlConnection))
                    {
                        comandoNotFound.Parameters.AddWithValue("@price", priceFormatted);
                        comandoNotFound.ExecuteNonQuery();
                    }

                    using (MySqlDataReader myReader = comand.ExecuteReader())
                    {
                        while (myReader.Read())
                        {
                            if (myReader.GetDecimal("price").Equals(price))
                            {
                                idBank = myReader.GetInt32("id");
                                break;
                            }
                        }
                    }
                    try
                    {
                        using (MySqlCommand comando = new MySqlCommand("INSERT INTO services (category, `name`, `description`, duration, price_id) VALUES('" + txtCategory.Text + "','" + txtName.Text + "','" + txtDescription.Text + "','" + maskDuration.Text + "', " + idBank + ");", MySqlConnection))
                        {
                            comando.ExecuteNonQuery();
                            DoneMessageBox doneBox = new DoneMessageBox("Serviço registrado com sucesso");
                            doneBox.ShowDialog();
                            clearFields();
                            LoadDatabaseData();
                        }

                    }
                    catch (Exception ex)
                    {
                        ErrorMessageBox error = new ErrorMessageBox("Algo deu errado,tente novamente");
                        error.ShowDialog();
                    }
                }
            }
        }

        private void clearFields()
        {
            txtCategory.Text = "";
            txtDescription.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            maskDuration.Text = null;
        }

        private void RegisterServices_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();

            LoadDatabaseData();
        }

        private void ibSearch_Click(object sender, EventArgs e)
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

        private void ibDelete_Click(object sender, EventArgs e)
        {
            if (txtDelete.Text == "" || txtDelete.Text == null || txtDelete.Text == "Insira o nome do serviço")
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Digite o nome do barbeiro");
                errorValue.ShowDialog();
            }
            else if (!Regex.IsMatch(txtDelete.Text, "^[A-Za-zÁ-Úá-úÀ-Ùà-ùâ-ûÂ-Ûã-õÃ-Õ ]+$"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Apenas letras neste campo");
                errorValue.ShowDialog();
            }
            else if (Regex.IsMatch(txtDelete.Text, "[ ]$") || Regex.IsMatch(txtDelete.Text, "^[ ]"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("O campo não pode começar/terminar com um espaço em branco");
                errorValue.ShowDialog();
            }
            else 
            {
                int id = 0;
                MySqlConnection MySqlConnection = new MySqlConnection(conection);
                MySqlConnection.Open();
                MySqlCommand comand = new MySqlCommand("SELECT services.id,services.`name` AS nome FROM services", MySqlConnection);
                MySqlDataReader myReader = comand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.GetString("nome").Contains(txtDelete.Text))
                    {
                       id =  myReader.GetInt32("id");
                       MySqlConnection.Close();
                       MySqlConnection.Open();
                        try
                        {
                            using (MySqlCommand comandoNew = new MySqlCommand("DELETE FROM services WHERE id = " + id + ";", MySqlConnection))
                            {
                                comandoNew.ExecuteNonQuery();
                                DoneMessageBox doneBox = new DoneMessageBox("Serviço Apagado com sucesso");
                                doneBox.ShowDialog();
                                LoadDatabaseData();
                                txtDelete.Text = "";
                            }
                        }catch(Exception ex)
                        {
                            ErrorMessageBox error = new ErrorMessageBox("Algo deu errado");
                            error.ShowDialog();
                        }
                        return;
                    }
                }

                ErrorMessageBox errorNotFound = new ErrorMessageBox("Serviço não cadastrado");
                errorNotFound.ShowDialog();
            }
        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            txtDelete.Text = "";
        }

        private void RegisterServices_Click(object sender, EventArgs e)
        {
            txtDelete.Text = "Insira o nome do serviço";
        }
    }
}
