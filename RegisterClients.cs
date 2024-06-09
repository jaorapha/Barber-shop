using interdisciplinar2.CustomMessageBoxes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace interdisciplinar2
{
    public partial class RegisterClients : Form
    {
        public RegisterClients()
        {
            InitializeComponent();
        }
        string conection = "server=localhost;database=barber_shop2;uid=root;pwd=jhon";

        private void LoadDatabaseData()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=barber_shop2;uid=root;pwd=jhon");
            try
            {
                connection.Open();

                string commandString = "SELECT full_name,user_name FROM customers ORDER BY full_name;";

                if (txtbSearch.Text != "")
                {
                    commandString = "SELECT full_name,user_name FROM customers WHERE full_name LIKE @nome ORDER BY full_name";
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
                        command.CommandText = "SELECT full_name,user_name FROM customers ORDER BY full_name;";
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

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string conection = "server=localhost;database=barber_shop2;uid=root;pwd=jhon";

            string validNumber = @"^119\d{8}$";

            string[] fieldsNUll = new string[] { txtName.Text, txtPassword.Text, txtPhone.Text, txtUser.Text };
            int count = 0;

            foreach (string pass in fieldsNUll)
            {
                if (pass == null || pass == "" || pass == "        -")
                {
                    count++;
                }
            }
            if (count > 0)
            {
                ErrorMessageBox fieldNull = new ErrorMessageBox("Tem " + count + " campos vazios, os preencha por favor");
                fieldNull.ShowDialog();
            }
            else if (Regex.IsMatch(txtName.Text, "[0-9]"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Este campo não permite números");
                errorValue.ShowDialog();
            }
            else if (!Regex.IsMatch(txtUser.Text, "^[A-Za-zÁ-Úá-úÀ-Ùà-ùâ-ûÂ-Ûã-õÃ-Õ,.0-9 ]+$") || !Regex.IsMatch(txtName.Text, "^[A-Za-zÁ-Úá-úÀ-Ùà-ùâ-ûÂ-Ûã-õÃ-Õ ]+$"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Não utilize símbolos nos campos usuário e nome");
                errorValue.ShowDialog();
            }
            else if (Regex.IsMatch(txtName.Text, "^[ ]|[ ]$") || Regex.IsMatch(txtPhone.Text, "^[ ]|[ ]$") || Regex.IsMatch(txtUser.Text, "^[ ]|[ ]$") || Regex.IsMatch(txtPassword.Text, "^[ ]|[ ]$") )
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("O campo não pode começar/terminar com espaço");
                errorValue.ShowDialog();
            }
            else if (!Regex.IsMatch(txtPhone.Text, validNumber))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Número de telefone inválido");
                errorValue.ShowDialog();
            }
            else if(!Regex.IsMatch(txtPassword.Text, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*º<>,^.'\"ª´`|\\#?&])[A-Za-z\\d@$!#º¨°<^>,.'\"ª´`|\\%*?&]{8,}$"))
            {
                ErrorMessageBox passwordWeak = new ErrorMessageBox("O mínimo de caracteres é 8 a senha deve conter letra maiúscula,símbolos e números");
                passwordWeak.ShowDialog();
            }
            else if (txtConfirm.Text != txtPassword.Text )
            {
                ErrorMessageBox errorConfirm = new ErrorMessageBox("Você errou a confirmação de senha");
                errorConfirm.ShowDialog();
            }
            else
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(conection))
                {
                    mySqlConnection.Open();

                    using (MySqlCommand command = new MySqlCommand("SELECT user_name,tel FROM customers", mySqlConnection))
                    {
                        using (MySqlDataReader myReader = command.ExecuteReader())
                        {
                            while (myReader.Read())
                            {
                                if (myReader.GetString("user_name").Contains(txtUser.Text))
                                {
                                    ErrorMessageBox erroFind = new ErrorMessageBox("nome de usuário em uso");
                                    erroFind.ShowDialog();
                                    return;
                                }
                                else if (myReader.GetString("tel").Contains(txtPhone.Text))
                                {
                                    ErrorMessageBox erroFind = new ErrorMessageBox("um usuário já cadastrou esse número");
                                    erroFind.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }

                    using (MySqlCommand insertCommand = new MySqlCommand("INSERT INTO customers(full_name, user_name, tel, `password`) VALUES ('"+ txtName.Text +"','"+ txtUser.Text +"','"+ txtPhone.Text +"','"+ txtPassword.Text +"')", mySqlConnection))
                    {
                        insertCommand.ExecuteNonQuery();
                        DoneMessageBox doneBox = new DoneMessageBox("Cliente cadastrado com sucesso");
                        doneBox.ShowDialog();
                        txtPassword.Text = "";
                        txtUser.Text = "";
                        txtName.Text = "";
                        txtPhone.Text = "";
                        txtConfirm.Text = "";
                        LoadDatabaseData();
                    }
                }
            }
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
            if (txtDelete.Text == "" || txtDelete.Text == null || txtDelete.Text == "Insira o nome de usuário")
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("Digite o nome de usuário");
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
                MySqlCommand comand = new MySqlCommand("SELECT id,user_name FROM customers", MySqlConnection);
                MySqlDataReader myReader = comand.ExecuteReader();

                while (myReader.Read())
                {
                    if (myReader.GetString("user_name").Contains(txtDelete.Text))
                    {
                        id = myReader.GetInt32("id");
                        MySqlConnection.Close();
                        MySqlConnection.Open();
                        try
                        {
                            using (MySqlCommand comandoNew = new MySqlCommand("DELETE FROM customers WHERE id = " + id + ";", MySqlConnection))
                            {
                                comandoNew.ExecuteNonQuery();
                                DoneMessageBox doneBox = new DoneMessageBox("Clinte Apagado com sucesso");
                                doneBox.ShowDialog();
                                LoadDatabaseData();
                                txtDelete.Text = "";
                            }
                        }
                        catch (Exception ex)
                        {
                            ErrorMessageBox error = new ErrorMessageBox("Algo deu errado");
                            error.ShowDialog();
                        }
                        return;
                    }
                }

                ErrorMessageBox errorNotFound = new ErrorMessageBox("Cliente não cadastrado");
                errorNotFound.ShowDialog();
            }
        }

        private void RegisterClients_Load(object sender, EventArgs e)
        {
            LoadDatabaseData();
        }
    }
}
