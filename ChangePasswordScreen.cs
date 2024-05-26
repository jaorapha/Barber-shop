using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class ChangePasswordScreen : Form
    {
        private ProgramTheme programTheme;

        public ChangePasswordScreen()
        {
            InitializeComponent();

            List<Label> labels = new List<Label>();
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);

            List<Button> buttons = new List<Button>();
            buttons.Add(btnChangePassword);

            programTheme = new ProgramTheme();
            programTheme.form = this;
            programTheme.labels = labels;
            programTheme.buttons = buttons;
        }

        private void AlterarSenhaScreen_Load(object sender, EventArgs e)
        {
            programTheme.LoadTheme();
        }

        private void btnChangePassword_MouseEnter(object sender, EventArgs e)
        {
            btnChangePassword.BackColor = Color.FromArgb(225, 177, 44);
        }

        private void btnChangePassword_MouseLeave(object sender, EventArgs e)
        {
            if (ProgramTheme.GetTheme() == "light")
            {
                btnChangePassword.BackColor = ProgramTheme.LightThemeBtnBackColor;
                btnChangePassword.ForeColor = ProgramTheme.LightThemeForeColor;
            }
            else
            {
                btnChangePassword.BackColor = ProgramTheme.DarkThemeBackColor;
                btnChangePassword.ForeColor = Color.FromName("ControlLightLight");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            MySqlConnection mysql = new MySqlConnection("server=localhost;database=barber_shop2;uid=root;pwd=jhon");
            try
            {
                mysql.Open();

                this.Cursor = Cursors.WaitCursor;

                MySqlDataReader reader = null;

                string typedPassword = txtbPassword.Text;
                string confirmPassword = txtbConfirmPassword.Text;
                string newPassword = txtbNewPassword.Text;

                bool isPasswordValid = false;

                using (MySqlCommand command = new MySqlCommand("SELECT `password` AS senha from barbers where barbers.id = 1;", mysql))
                {
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string dbPassword = reader.GetString("senha");

                        if (typedPassword == dbPassword)
                        {
                            if (typedPassword == confirmPassword)
                            {
                                isPasswordValid = true;
                            }
                            else
                            {
                                ErrorMessageBox eMessageBox = new ErrorMessageBox("As senhas não coincidem!");
                                eMessageBox.ShowDialog();
                            }
                        }
                        else
                        {
                            ErrorMessageBox eMessageBox = new ErrorMessageBox("Senha atual incorreta!");
                            eMessageBox.ShowDialog();
                        }
                    }

                    reader.Close();

                    if (isPasswordValid)
                    {
                        using (MySqlCommand command2 = new MySqlCommand("update barbers set `password` = @NovaSenhaBarbeiro where `password` = @SenhaBarbeiro;", mysql))
                        {
                            command2.Parameters.AddWithValue("@NovaSenhaBarbeiro", newPassword);
                            command2.Parameters.AddWithValue("@SenhaBarbeiro", typedPassword);

                            command2.ExecuteNonQuery();

                            DoneMessageBox dMessageBox = new DoneMessageBox("Senha alterada com sucesso!");
                            dMessageBox.ShowDialog();
                            txtbConfirmPassword.Text = "";
                            txtbNewPassword.Text = "";
                            txtbPassword.Text = "";
                        }
                    }

                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                ErrorMessageBox eMessageBox = new ErrorMessageBox(ex.Message);
                eMessageBox.ShowDialog();
            }
            finally
            {
                if (mysql.State == System.Data.ConnectionState.Open)
                {
                    mysql.Close();
                }
                mysql.Dispose();
            }
        }
    }
}