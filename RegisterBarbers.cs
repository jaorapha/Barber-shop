using interdisciplinar2.CustomMessageBoxes;
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
using MySql.Data.MySqlClient;
using FontAwesome.Sharp;
using interdisciplinar2.Models;

namespace interdisciplinar2
{
    public partial class RegisterBarbers : Form
    {

        string conection = "server=localhost;database=barber_shop2;uid=root;pwd=jhon";

        private ProgramTheme programTheme;

        public RegisterBarbers()
        {
            InitializeComponent();

            List<Button> buttons = new List<Button>();
            buttons.Add(btnRegister);

            List<Label> labels = new List<Label>();
            labels.Add(lblNameDelete);
            labels.Add(lblSearch);
            labels.Add(lblTitle);
            labels.Add(lblName);

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

                string commandString = "SELECT id,full_name as nome FROM barbers ORDER BY full_name";

                if (txtbSearch.Text != "")
                {
                    commandString = "SELECT id,full_name as nome FROM barbers WHERE full_name LIKE @nome ORDER BY full_name";
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
                        command.CommandText = "SELECT id,full_name as nome FROM barbers ORDER BY full_name";
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
            if(txtName.Text == ""|| txtName.Text == null)
            {
                ErrorMessageBox errorNull = new ErrorMessageBox("Você não informou o nome do barbeiro");
                errorNull.ShowDialog();
            }
            else if (Regex.IsMatch(txtName.Text, "[ ]$") || Regex.IsMatch(txtName.Text, "^[ ]"))
            {
                ErrorMessageBox errorValue = new ErrorMessageBox("O campo não pode começar/terminar com um espaço em branco");
                errorValue.ShowDialog();
            }
            else if(Regex.IsMatch(txtName.Text, "[0-9]"))
            {
                ErrorMessageBox errorNumber = new ErrorMessageBox("O nome dele não pode conter números");
                errorNumber.ShowDialog();
            }
            else if(!Regex.IsMatch(txtName.Text, "^[A-Za-zÁ-Úá-úÀ-Ùà-ùâ-ûÂ-Ûã-õÃ-Õ,. ]+$"))
            {
                ErrorMessageBox errorCaracter = new ErrorMessageBox("O nome pode conter caracteres especiais");
                errorCaracter.ShowDialog();
            }
            else
            {
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(conection);
                    mySqlConnection.Open();
                    MySqlCommand command = new MySqlCommand("INSERT INTO barbers(full_name) VALUES('" + txtName.Text + "')",mySqlConnection);
                    command.ExecuteNonQuery();
                    DoneMessageBox doneMessage = new DoneMessageBox("Barbeiro cadastrado com sucesso");
                    doneMessage.ShowDialog();
                    LoadDatabaseData();
                }
                catch (Exception ex)
                {
                    ErrorMessageBox error = new ErrorMessageBox("Algo deu errado");
                    error.ShowDialog();
                }
            }
        }

        private void ibSearch_Click(object sender, EventArgs e)
        {
            if(txtbSearch.Text == null || txtbSearch.Text == "")
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

        private void RegisterBarbers_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();
            LoadDatabaseData();
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 214;
        }

        private void ibDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MySqlConnection = new MySqlConnection(conection);
                MySqlConnection.Open();
                MySqlCommand comando = new MySqlCommand("DELETE FROM barbers WHERE id = " + int.Parse(txtDelete.Text) + ";", MySqlConnection);
                comando.ExecuteNonQuery();
                DoneMessageBox doneMessage = new DoneMessageBox("Barbeiro apagado com sucesso");
                doneMessage.ShowDialog();
                LoadDatabaseData();
                txtDelete.Text = " ";

            }
            catch (Exception ex)
            {
                ErrorMessageBox errorNotFound = new ErrorMessageBox("Algo deu errado, tente novamente");
                errorNotFound.ShowDialog();
            }
           
        }

        private void RegisterBarbers_Click(object sender, EventArgs e)
        {
            txtDelete.Text = "Insira o nome do barbeiro";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDelete.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }catch(Exception ex) 
            {
                ErrorMessageBox errorNotFound = new ErrorMessageBox("Algo deu errado, tente novamente");
                errorNotFound.ShowDialog();
            }
           
        }
    }
}
