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

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string conection = "server=localhost;database=barber_shop2;uid=root;pwd=jhon";

            string[] fieldsNUll = new string[] { txtName.Text, txtPassword.Text, maskPhone.Text, txtUser.Text };
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
                                else if (myReader.GetString("tel").Contains(maskPhone.Text))
                                {
                                    ErrorMessageBox erroFind = new ErrorMessageBox("um usuário já cadastrou esse número");
                                    erroFind.ShowDialog();
                                    return;
                                }
                            }
                        }
                    }

                    using (MySqlCommand insertCommand = new MySqlCommand("INSERT INTO customers(full_name, user_name, tel, `password`) VALUES ('"+ txtName.Text +"','"+ txtUser.Text +"','"+ maskPhone.Text +"','"+ txtPassword.Text +"')", mySqlConnection))
                    {
                        insertCommand.ExecuteNonQuery();
                        DoneMessageBox doneBox = new DoneMessageBox("Cliente cadastrado com sucesso");
                        doneBox.ShowDialog();
                        txtPassword.Text = "";
                        txtUser.Text = "";
                        txtName.Text = "";
              
                    }
                }
            }
        }   

        private void ibShowPasswordImage_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;

            ibShowPasswordImage.Visible = true;
            ibDontShowPasswordImage.Visible = true;
        }

        private void ibDontShowPasswordImage_Click_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;

            ibDontShowPasswordImage.Visible = false;
            ibShowPasswordImage.Visible = true;
        }
    }
}
