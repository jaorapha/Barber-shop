using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections;
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
    public partial class SchedulesToday : Form
    {
      
        string conection = "Server=localhost;database=barber_shop2;uid=root;pwd=jhon";
        public SchedulesToday()
        {
            InitializeComponent();
            fillList();
        }

        private void fillList()
        {

            string query = "SELECT customers.full_name,schedules.service,schedules.horary FROM schedules INNER JOIN customers WHERE customers.id =1";

            MySqlConnection conexaoSql = new MySqlConnection(conection);
            MySqlCommand comando = new MySqlCommand(query, conexaoSql);
            MySqlDataReader myReader;

            conexaoSql.Open();
            myReader = comando.ExecuteReader();

            while (myReader.Read())
            {           
              try
              {
                    lblClientName.Text = myReader.GetString("full_name");
                    lblHorary.Text = myReader.GetMySqlDateTime("horary").ToString();
                   string teste =  lblService.Text = myReader.GetString("service").ToString();
                    if (teste == null )
                    {
                        lblService.Text = "serviço não selecionado";
                    }
                    MessageBox.Show(teste);
              } catch(Exception e)
              {
                 
              }
            }
        }
    }
}
