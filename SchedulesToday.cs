using Microsoft.Win32;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Tls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;


namespace interdisciplinar2
{
    public partial class SchedulesToday : Form
    {
      
        string conection = "Server=localhost;database=barber_shop2;uid=root;pwd=jhon";

        private ComboBox dropListBarbers;

        private ComboBox dropListServices;

        //private ComboBox dropListServices;

        public SchedulesToday()
        {
            InitializeComponent();
        }

        List<Control> controlsRemove = new List<Control>();

        List<Control> allCards = new List<Control>();

        private void SchedulesToday_Load(object sender, EventArgs e)
        {
            string query = "SELECT customers.full_name,schedules.service,schedules.horary,schedules.`description` AS descrição FROM schedules INNER JOIN customers ON schedules.customer_id = customers.id WHERE DATE(schedules.horary) = CURDATE();";

            MySqlConnection conexaoSql = new MySqlConnection(conection);
            MySqlCommand comando = new MySqlCommand(query, conexaoSql);
            MySqlDataReader myReader;

            conexaoSql.Open();
            myReader = comando.ExecuteReader();

            while (myReader.Read())
            {
                #region Instâncias
                PictureBox pictureUser = new System.Windows.Forms.PictureBox();
                Label lblClientName = new System.Windows.Forms.Label();
                Label lblHaircut = new System.Windows.Forms.Label();
                Label lblService = new System.Windows.Forms.Label();
                Label lblSchedule = new System.Windows.Forms.Label();
                Label lblHorary = new System.Windows.Forms.Label();
                Label lblBarber = new System.Windows.Forms.Label();
                Label lblTitle = new System.Windows.Forms.Label();               
                Button btnAccept = new System.Windows.Forms.Button();
                Button btnReject = new System.Windows.Forms.Button();
                Button btnEdit = new System.Windows.Forms.Button();
                Label lblDescription = new System.Windows.Forms.Label();
                TextBox txtDescription = new System.Windows.Forms.TextBox();
                dropListBarbers = new System.Windows.Forms.ComboBox();
                dropListServices = new System.Windows.Forms.ComboBox();
                Panel Card = new System.Windows.Forms.Panel();
                #endregion

                #region droplistBarbers
                FillDropList("SELECT barbers.full_name FROM barbers", "full_name", ref dropListBarbers);
                #endregion

                #region dropListserviços
                FillDropList("SELECT services.`name` as Serviços FROM services", "Serviços", ref dropListServices);
                #endregion

                #region imgUser
                pictureUser.Image = global::interdisciplinar2.Properties.Resources.dark_human_icon;
                pictureUser.Location = new System.Drawing.Point(12, 53);
                pictureUser.Name = "pictureBox1";
                pictureUser.Size = new System.Drawing.Size(37, 42);
                pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureUser.TabIndex = 0;
                pictureUser.TabStop = false;
                #endregion   

                #region Labels 
                //lblClient
                lblClientName.AutoSize = true;
                lblClientName.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblClientName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblClientName.Location = new System.Drawing.Point(55, 63);
                lblClientName.Name = "lblClientName";
                lblClientName.Size = new System.Drawing.Size(145, 21);
                lblClientName.TabIndex = 1;
                lblClientName.Text = "Nome do cliente";

                //lblHaircut
                lblHaircut.AutoSize = true;
                lblHaircut.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblHaircut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblHaircut.Location = new System.Drawing.Point(8, 108);
                lblHaircut.Name = "lblHaircut";
                lblHaircut.Size = new System.Drawing.Size(64, 21);
                lblHaircut.TabIndex = 2;
                lblHaircut.Text = "Corte:";

                //lblService
                lblService.AutoSize = true;
                lblService.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblService.Location = new System.Drawing.Point(78, 108);
                lblService.Name = "lblService";
                lblService.Size = new System.Drawing.Size(73, 21);
                lblService.TabIndex = 3;
                lblService.Text = "Serviço";

                //lblSchedule
                lblSchedule.AutoSize = true;
                lblSchedule.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblSchedule.Location = new System.Drawing.Point(8, 153);
                lblSchedule.Name = "lblSchedule";
                lblSchedule.Size = new System.Drawing.Size(136, 21);
                lblSchedule.TabIndex = 4;
                lblSchedule.Text = "Agendado para:";

                //lblHorary
                lblHorary.AutoSize = true;
                lblHorary.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblHorary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblHorary.Location = new System.Drawing.Point(150, 151);
                lblHorary.Name = "lblHorary";
                lblHorary.Size = new System.Drawing.Size(73, 21);
                lblHorary.TabIndex = 5;
                lblHorary.Text = "Horário";


                //lblBarber
                lblBarber.AutoSize = true;
                lblBarber.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblBarber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblBarber.Location = new System.Drawing.Point(9, 198);
                lblBarber.Name = "lblBarber";
                lblBarber.Size = new System.Drawing.Size(91, 21);
                lblBarber.TabIndex = 6;
                lblBarber.Text = "Barbeiro:";

                //lblTitle
                lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
                lblTitle.Location = new System.Drawing.Point(0, 0);
                lblTitle.Name = "lblTitle";
                lblTitle.Size = new System.Drawing.Size(396, 32);
                lblTitle.TabIndex = 10;
                lblTitle.Text = "Novo Agendamento";
                lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                //lblDescription
                lblDescription.AutoSize = true;
                lblDescription.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblDescription.Location = new System.Drawing.Point(9, 243);
                lblDescription.Name = "lblDescription";
                lblDescription.Size = new System.Drawing.Size(181, 21);
                lblDescription.TabIndex = 13;
                lblDescription.Text = "Descrição do corte:";

                //lblBdDescription
                txtDescription.Font = new System.Drawing.Font("Cascadia Code", 12F);
                txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
                txtDescription.Location = new System.Drawing.Point(3, 267);
                txtDescription.Name = "lblBdDescription";
                txtDescription.Size = new System.Drawing.Size(387, 60);
                txtDescription.TabIndex = 14;
                txtDescription.Text = "Descrição";
                txtDescription.Enabled = false;
                txtDescription.Multiline = true;
                txtDescription.BorderStyle = BorderStyle.None;
                #endregion

                #region Botões
                //btnReject

                btnReject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
                btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnReject.Font = new System.Drawing.Font("Cascadia Code", 12F);
                btnReject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btnReject.Location = new System.Drawing.Point(235, 334);
                btnReject.Name = "btnReject";
                btnReject.Size = new System.Drawing.Size(106, 32);
                btnReject.TabIndex = 8;
                btnReject.Text = "Recusar";
                btnReject.UseVisualStyleBackColor = true;
                btnReject.Click += btnReject_Click;

                //btnAccept
                btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
                btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnAccept.Font = new System.Drawing.Font("Cascadia Code", 12F);
                btnAccept.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btnAccept.Location = new System.Drawing.Point(40, 334);
                btnAccept.Name = "btnAccept";
                btnAccept.Size = new System.Drawing.Size(106, 32);
                btnAccept.TabIndex = 9;
                btnAccept.Text = "Aceitar";
                btnAccept.UseVisualStyleBackColor = true;
                btnAccept.Click += Accept_Click;

                //edit
                btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
                btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnEdit.Font = new System.Drawing.Font("Cascadia Code", 12F);
                btnEdit.Location = new System.Drawing.Point(283, 45);
                btnEdit.Name = "btnEdit";
                btnEdit.Size = new System.Drawing.Size(74, 33);
                btnEdit.TabIndex = 0;
                btnEdit.Text = "Editar";
                btnEdit.UseVisualStyleBackColor = false;
                btnEdit.Click += btnEdit_Click;
                #endregion

                #region Combobox
                //barber
                dropListBarbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
                dropListBarbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                dropListBarbers.Font = new System.Drawing.Font("Cascadia Code", 10F);
                dropListBarbers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                dropListBarbers.FormattingEnabled = true;
                dropListBarbers.Location = new System.Drawing.Point(106, 198);
                dropListBarbers.Name = "dropListBarbers";
                dropListBarbers.Size = new System.Drawing.Size(221, 25);
                dropListBarbers.TabIndex = 0;
                dropListBarbers.Enabled = false;
                dropListBarbers.Click += new System.EventHandler(this.dropListBarbers_Click);

                //service 
                dropListServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
                dropListServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                dropListServices.Font = new System.Drawing.Font("Cascadia Code", 10F);
                dropListServices.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                dropListServices.FormattingEnabled = true;
                dropListServices.Location = new System.Drawing.Point(78, 108);
                dropListServices.Name = "dropListServices";
                dropListServices.Size = new System.Drawing.Size(217, 25);
                dropListServices.TabIndex = 1;
                dropListServices.Enabled = false;               
                dropListServices.Click += new System.EventHandler(this.dropListServices_Click);
                #endregion

                #region Card
                Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
                Card.Controls.Add(pictureUser);
                Card.Controls.Add(lblClientName);
                Card.Controls.Add(lblHaircut);
                Card.Controls.Add(dropListServices);
                Card.Controls.Add(lblSchedule);
                Card.Controls.Add(lblHorary);
                Card.Controls.Add(lblBarber);
                Card.Controls.Add(dropListBarbers); 
                Card.Controls.Add(btnReject);        
                Card.Controls.Add(btnAccept);
                Card.Controls.Add(lblTitle);
                Card.Controls.Add(btnEdit);
                Card.Controls.Add(lblDescription);
                Card.Controls.Add(txtDescription);             
                Card.Location = new System.Drawing.Point(3, 3);
                Card.Name = "Card";
                Card.Size = new System.Drawing.Size(357, 377);
                Card.Margin = new System.Windows.Forms.Padding(7);
                Card.AutoSize = false;
                Card.TabIndex = 0;
                Card.DoubleClick += Card_DoubleClick;
                #endregion

                try
                {
                    lblClientName.Text = myReader.GetString("full_name");                   
                    dropListServices.Text = myReader.GetString("service");                       
                    lblHorary.Text = myReader.GetDateTime("horary").ToString();                 
                    txtDescription.Text = myReader.GetString("descrição");  
                    this.panelCards.Controls.Add(Card);
                }
                catch (Exception ex)
                {

                    if (ex is System.Data.SqlTypes.SqlNullValueException)
                    {
                        lblClientName.Text = myReader.GetString("full_name");

                        if (myReader.IsDBNull(myReader.GetOrdinal("service")))
                        {
                            dropListServices.Text = "Serviço não escolhido";
                        }
                        else
                        {
                            dropListServices.Text = myReader.GetString("service");
                        }

                        lblHorary.Text = myReader.GetDateTime("horary").ToString();


                        if (myReader.IsDBNull(myReader.GetOrdinal("descrição")))
                        {
                            txtDescription.Text = "Sem descrição";
                        }
                        else
                        {
                            txtDescription.Text = myReader.GetString("descrição");
                        }
                        this.panelCards.Controls.Add(Card);
                    }
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool stop = false;
            string querySchedule = "";
            int id = 0;
           
            foreach (Control pass in this.panelCards.Controls)
            {
                foreach (Control value in pass.Controls)
                {
                    if (value == sender)
                    {
                        querySchedule = "SELECT schedules.id FROM schedules WHERE schedules.horary LIKE '" + Date(pass.Controls[5].Text) + "%';";
                        this.panelCards.Controls.RemoveAt(count);
                        stop = true;
                    }
                }
                if (stop == true)
                {
                    break;
                }

               count++;
            }

            readQuery(querySchedule, ref id);

            string query = "DELETE  FROM schedules WHERE id = "+ id +";" ;

            MySqlConnection mySqlconnection = new MySqlConnection(conection);
            mySqlconnection.Open();
            MySqlCommand comand = new MySqlCommand(query, mySqlconnection);
            comand.ExecuteNonQuery();
        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            int count = 0;
            int valor = 0;

            foreach (Control pass in panelCards.Controls)
            {
                if(pass == sender)
                {
                    foreach (Control value in pass.Controls)
                    {
                        MessageBox.Show(value.ToString() + "está no índice " + valor);
                        valor++;
                    }
                }
                count++;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool stop = false;

            string query = "SELECT services.id, services.`name` FROM services;";

            foreach (Control pass in this.panelCards.Controls)
            {
                foreach (Control value in pass.Controls)
                {
                    if (value == sender)
                    {
                        pass.Controls[8].Enabled=false;
                        pass.Controls[8].Visible = false;
                        pass.Controls[9].Size = new System.Drawing.Size(305, 32);
                        pass.Controls[9].Location = new System.Drawing.Point(26, 333);
                        pass.Controls[3].Enabled = true;
                        pass.Controls[7].Enabled = true;   
                        stop = true;
                        break;
                    }
                }
                if (stop == false)
                {
                    count++;
                }

                allCards.Add(pass);
            }

            foreach (Control pass in this.panelCards.Controls)
            {
                int index = this.panelCards.Controls.GetChildIndex(pass);

                if (index != count)
                {
                    controlsRemove.Add(pass);
                }
            }

            foreach (Control pass in controlsRemove)
            {
                this.panelCards.Controls.Remove(pass);
            }

            #region instânciaDGV
            DataGridView dgvServices = new System.Windows.Forms.DataGridView();
            dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServices.Location = new System.Drawing.Point(3, 3);
            dgvServices.Name = "dgvServices";
            dgvServices.Size = new System.Drawing.Size(270, 308);
            dgvServices.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            dgvServices.TabIndex = 0;
            #endregion            

            MySqlConnection conexaoSql = new MySqlConnection(conection);
            conexaoSql.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexaoSql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvServices.DataSource = dt;

            this.panelCards.Controls.Add(dgvServices);

            #region btnCancelar
            Button btnBack = new System.Windows.Forms.Button();
            btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("Cascadia Code", 12F);
            btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnBack.Location = new System.Drawing.Point(66, 267);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(181, 50);
            btnBack.TabIndex = 1;
            btnBack.Text = "Cancelar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += cancel_Click;
            this.panelCards.Controls.Add(btnBack);
            #endregion     

            this.panelCards.Refresh();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult back = MessageBox.Show("Você deseja mesmo cancelar? as alterações não serão salvas", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (back == DialogResult.Yes)
            {
                this.panelCards.Controls.Clear();

                foreach (Control pass in allCards)
                {
                    this.panelCards.Controls.Add(pass);
                }
                allCards.Clear();
                controlsRemove.Clear();
            }

            foreach(Control pass in this.panelCards.Controls)
            {
                if (pass.Controls[8].Visible == false &&  pass.Controls[8].Enabled == false)
                {
                    pass.Controls[8].Visible = true;
                    pass.Controls[8].Enabled = true;
                    pass.Controls[9].Size = new System.Drawing.Size(106, 32);
                    pass.Controls[9].Location = new System.Drawing.Point(40, 334);
                    pass.Controls[3].Enabled = false;
                    pass.Controls[7].Enabled = false;
                }
            }   
            
        }

        private void Accept_Click(object sender, EventArgs e)
       {
            int count = 0;
            bool stop = false;
            string queryBarber = "";
            string queryCustomer = "";
            string queryTxtService = "";
            string queryService = "";
            string queryIdSchedule = "";
            int[] ids = new int[4];
            string update;

            foreach (Control pass in panelCards.Controls)
            {
                foreach (Control passing in pass.Controls)
                {
                    if (passing == sender)
                    {
                        queryBarber = "SELECT barbers.id FROM barbers WHERE barbers.full_name LIKE '" + pass.Controls[7].Text + "%';";
                        queryCustomer = "SELECT customers.id FROM customers WHERE customers.full_name LIKE '" + pass.Controls[1].Text + "%';";
                        if (pass.Controls[3].Name == "lblService")
                        {
                            queryService =  "SELECT services.id FROM services WHERE services.`name` = '" + pass.Controls[3].Text + "';";
                        }
                        else
                        {
                            queryTxtService = "SELECT services.id FROM services WHERE services.`name` = '" + pass.Controls[3].Text + "';";
                        }
                        queryIdSchedule = "SELECT schedules.id FROM schedules WHERE schedules.horary LIKE '" + Date(pass.Controls[5].Text) + "%';";                       
                        stop = true;
                        break;                       
                    }    
                }
                if (stop)
                {
                    break;
                }
                count++;
            }

            Control selectCard = this.panelCards.Controls[count];

            readQuery(queryBarber, ref ids[0]);
            readQuery(queryCustomer, ref ids[1]);
            if(queryService != "")
            {
                readQuery(queryService, ref ids[2]);
            }
            else
            {
                readQuery(queryTxtService, ref ids[2]);
            }
            readQuery(queryIdSchedule, ref ids[3]);


            try
            {
                update = "UPDATE schedules SET schedules.horary='" + Date(selectCard.Controls[5].Text) + "',schedules.service='" + selectCard.Controls[3].Text + "',schedules.`description`='" + selectCard.Controls[13].Text + "',schedules.barber_id=" + ids[0] + ",schedules.customer_id=" + ids[1] + ",schedules.service_id=" + ids[2] + " WHERE schedules.id = " + ids[3] + ";";
                MySqlConnection MySqlConnection = new MySqlConnection(conection);
                MySqlConnection.Open();
                MySqlCommand comand = new MySqlCommand(update, MySqlConnection);
                comand.ExecuteNonQuery();
            }catch(Exception ex)
            {
                MessageBox.Show("algo deu errado");
            }
       }

        private int readQuery(string query,ref int value)
        {
            MySqlConnection MySqlConnection = new MySqlConnection(conection);           
            MySqlCommand comand = new MySqlCommand(query,MySqlConnection);
            MySqlDataReader myReader;
            MySqlConnection.Open();
            myReader = comand.ExecuteReader();

            while (myReader.Read())
            {
                value = myReader.GetInt16("id");
            }

            return value;
        }

        private string Date(string value)
        {
            string day, month, year;
            string date="";

            day = value.Substring(0,2);
            month = value.Substring(3, 2);
            year = value.Substring(6, 4);
            string horary = value.Substring(11, 8);

            string[] newDate = { year, month, day };

            foreach(string pass in newDate)
            {
                date += pass;
                if(pass == day)
                {
                    date += " ";
                    break;
                }
                date += "-";
            }
            date += horary;

            return date;
        }

        private void dropListBarbers_Click(object sender, EventArgs e)
        {
            dropListBarbers.Items.Clear();

            FillDropList("SELECT barbers.full_name FROM barbers", "full_name", ref dropListBarbers);
        }

        private void FillDropList(string query,string field,ref ComboBox list)
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

        private void dropListServices_Click(object sender, EventArgs e)
        {
           dropListServices.Items.Clear();

           FillDropList("SELECT services.`name` as Serviços FROM services", "Serviços", ref dropListServices);
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {
            this.panelCards.Controls.Clear();

            string query = "SELECT customers.full_name,schedules.service,schedules.horary,schedules.`description` AS descrição FROM schedules INNER JOIN customers ON schedules.customer_id = customers.id WHERE DATE(schedules.horary) = CURDATE();";

            MySqlConnection conexaoSql = new MySqlConnection(conection);
            MySqlCommand comando = new MySqlCommand(query, conexaoSql);
            MySqlDataReader myReader;

            conexaoSql.Open();
            myReader = comando.ExecuteReader();

            while (myReader.Read())
            {
                #region Instâncias
                PictureBox pictureUser = new System.Windows.Forms.PictureBox();
                Label lblClientName = new System.Windows.Forms.Label();
                Label lblHaircut = new System.Windows.Forms.Label();
                Label lblService = new System.Windows.Forms.Label();
                Label lblSchedule = new System.Windows.Forms.Label();
                Label lblHorary = new System.Windows.Forms.Label();
                Label lblBarber = new System.Windows.Forms.Label();
                Label lblTitle = new System.Windows.Forms.Label();
                Button btnAccept = new System.Windows.Forms.Button();
                Button btnReject = new System.Windows.Forms.Button();
                Button btnEdit = new System.Windows.Forms.Button();
                Label lblDescription = new System.Windows.Forms.Label();
                TextBox txtDescription = new System.Windows.Forms.TextBox();
                dropListBarbers = new System.Windows.Forms.ComboBox();
                dropListServices = new System.Windows.Forms.ComboBox();
                Panel Card = new System.Windows.Forms.Panel();
                #endregion

                #region droplistBarbers
                FillDropList("SELECT barbers.full_name FROM barbers", "full_name", ref dropListBarbers);
                #endregion

                #region dropListserviços
                FillDropList("SELECT services.`name` as Serviços FROM services", "Serviços", ref dropListServices);
                #endregion

                #region imgUser
                pictureUser.Image = global::interdisciplinar2.Properties.Resources.dark_human_icon;
                pictureUser.Location = new System.Drawing.Point(12, 53);
                pictureUser.Name = "pictureBox1";
                pictureUser.Size = new System.Drawing.Size(37, 42);
                pictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pictureUser.TabIndex = 0;
                pictureUser.TabStop = false;
                #endregion   

                #region Labels 
                //lblClient
                lblClientName.AutoSize = true;
                lblClientName.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblClientName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblClientName.Location = new System.Drawing.Point(55, 63);
                lblClientName.Name = "lblClientName";
                lblClientName.Size = new System.Drawing.Size(145, 21);
                lblClientName.TabIndex = 1;
                lblClientName.Text = "Nome do cliente";

                //lblHaircut
                lblHaircut.AutoSize = true;
                lblHaircut.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblHaircut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblHaircut.Location = new System.Drawing.Point(8, 108);
                lblHaircut.Name = "lblHaircut";
                lblHaircut.Size = new System.Drawing.Size(64, 21);
                lblHaircut.TabIndex = 2;
                lblHaircut.Text = "Corte:";

                //lblService
                lblService.AutoSize = true;
                lblService.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblService.Location = new System.Drawing.Point(78, 108);
                lblService.Name = "lblService";
                lblService.Size = new System.Drawing.Size(73, 21);
                lblService.TabIndex = 3;
                lblService.Text = "Serviço";

                //lblSchedule
                lblSchedule.AutoSize = true;
                lblSchedule.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblSchedule.Location = new System.Drawing.Point(8, 153);
                lblSchedule.Name = "lblSchedule";
                lblSchedule.Size = new System.Drawing.Size(136, 21);
                lblSchedule.TabIndex = 4;
                lblSchedule.Text = "Agendado para:";

                //lblHorary
                lblHorary.AutoSize = true;
                lblHorary.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblHorary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblHorary.Location = new System.Drawing.Point(150, 151);
                lblHorary.Name = "lblHorary";
                lblHorary.Size = new System.Drawing.Size(73, 21);
                lblHorary.TabIndex = 5;
                lblHorary.Text = "Horário";


                //lblBarber
                lblBarber.AutoSize = true;
                lblBarber.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblBarber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblBarber.Location = new System.Drawing.Point(9, 198);
                lblBarber.Name = "lblBarber";
                lblBarber.Size = new System.Drawing.Size(91, 21);
                lblBarber.TabIndex = 6;
                lblBarber.Text = "Barbeiro:";

                //lblTitle
                lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
                lblTitle.Location = new System.Drawing.Point(0, 0);
                lblTitle.Name = "lblTitle";
                lblTitle.Size = new System.Drawing.Size(396, 32);
                lblTitle.TabIndex = 10;
                lblTitle.Text = "Novo Agendamento";
                lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                //lblDescription
                lblDescription.AutoSize = true;
                lblDescription.Font = new System.Drawing.Font("Cascadia Code", 12F);
                lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                lblDescription.Location = new System.Drawing.Point(9, 243);
                lblDescription.Name = "lblDescription";
                lblDescription.Size = new System.Drawing.Size(181, 21);
                lblDescription.TabIndex = 13;
                lblDescription.Text = "Descrição do corte:";

                //lblBdDescription
                txtDescription.Font = new System.Drawing.Font("Cascadia Code", 12F);
                txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
                txtDescription.Location = new System.Drawing.Point(3, 267);
                txtDescription.Name = "lblBdDescription";
                txtDescription.Size = new System.Drawing.Size(387, 60);
                txtDescription.TabIndex = 14;
                txtDescription.Text = "Descrição";
                txtDescription.Enabled = false;
                txtDescription.Multiline = true;
                txtDescription.BorderStyle = BorderStyle.None;
                #endregion

                #region Botões
                //btnReject

                btnReject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
                btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnReject.Font = new System.Drawing.Font("Cascadia Code", 12F);
                btnReject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btnReject.Location = new System.Drawing.Point(235, 334);
                btnReject.Name = "btnReject";
                btnReject.Size = new System.Drawing.Size(106, 32);
                btnReject.TabIndex = 8;
                btnReject.Text = "Recusar";
                btnReject.UseVisualStyleBackColor = true;
                btnReject.Click += btnReject_Click;

                //btnAccept
                btnAccept.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
                btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnAccept.Font = new System.Drawing.Font("Cascadia Code", 12F);
                btnAccept.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btnAccept.Location = new System.Drawing.Point(40, 334);
                btnAccept.Name = "btnAccept";
                btnAccept.Size = new System.Drawing.Size(106, 32);
                btnAccept.TabIndex = 9;
                btnAccept.Text = "Aceitar";
                btnAccept.UseVisualStyleBackColor = true;
                btnAccept.Click += Accept_Click;

                //edit
                btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
                btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnEdit.Font = new System.Drawing.Font("Cascadia Code", 12F);
                btnEdit.Location = new System.Drawing.Point(283, 45);
                btnEdit.Name = "btnEdit";
                btnEdit.Size = new System.Drawing.Size(74, 33);
                btnEdit.TabIndex = 0;
                btnEdit.Text = "Editar";
                btnEdit.UseVisualStyleBackColor = false;
                btnEdit.Click += btnEdit_Click;
                #endregion

                #region Combobox
                //barber
                dropListBarbers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
                dropListBarbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                dropListBarbers.Font = new System.Drawing.Font("Cascadia Code", 10F);
                dropListBarbers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                dropListBarbers.FormattingEnabled = true;
                dropListBarbers.Location = new System.Drawing.Point(106, 198);
                dropListBarbers.Name = "dropListBarbers";
                dropListBarbers.Size = new System.Drawing.Size(221, 25);
                dropListBarbers.TabIndex = 0;
                dropListBarbers.Enabled = false;
                dropListBarbers.Click += new System.EventHandler(this.dropListBarbers_Click);

                //service 
                dropListServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
                dropListServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                dropListServices.Font = new System.Drawing.Font("Cascadia Code", 10F);
                dropListServices.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                dropListServices.FormattingEnabled = true;
                dropListServices.Location = new System.Drawing.Point(78, 108);
                dropListServices.Name = "dropListServices";
                dropListServices.Size = new System.Drawing.Size(217, 25);
                dropListServices.TabIndex = 1;
                dropListServices.Enabled = false;
                dropListServices.Click += new System.EventHandler(this.dropListServices_Click);
                #endregion

                #region Card
                Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
                Card.Controls.Add(pictureUser);
                Card.Controls.Add(lblClientName);
                Card.Controls.Add(lblHaircut);
                Card.Controls.Add(dropListServices);
                Card.Controls.Add(lblSchedule);
                Card.Controls.Add(lblHorary);
                Card.Controls.Add(lblBarber);
                Card.Controls.Add(dropListBarbers);
                Card.Controls.Add(btnReject);
                Card.Controls.Add(btnAccept);
                Card.Controls.Add(lblTitle);
                Card.Controls.Add(btnEdit);
                Card.Controls.Add(lblDescription);
                Card.Controls.Add(txtDescription);
                Card.Location = new System.Drawing.Point(3, 3);
                Card.Name = "Card";
                Card.Size = new System.Drawing.Size(357, 377);
                Card.Margin = new System.Windows.Forms.Padding(7);
                Card.AutoSize = false;
                Card.TabIndex = 0;
                Card.DoubleClick += Card_DoubleClick;
                #endregion

                try
                {
                    lblClientName.Text = myReader.GetString("full_name");
                    dropListServices.Text = myReader.GetString("service");
                    lblHorary.Text = myReader.GetDateTime("horary").ToString();
                    txtDescription.Text = myReader.GetString("descrição");
                    this.panelCards.Controls.Add(Card);
                }
                catch (Exception ex)
                {

                    if (ex is System.Data.SqlTypes.SqlNullValueException)
                    {
                        lblClientName.Text = myReader.GetString("full_name");

                        if (myReader.IsDBNull(myReader.GetOrdinal("service")))
                        {
                            dropListServices.Text = "Serviço não escolhido";
                        }
                        else
                        {
                            dropListServices.Text = myReader.GetString("service");
                        }

                        lblHorary.Text = myReader.GetDateTime("horary").ToString();


                        if (myReader.IsDBNull(myReader.GetOrdinal("descrição")))
                        {
                            txtDescription.Text = "Sem descrição";
                        }
                        else
                        {
                            txtDescription.Text = myReader.GetString("descrição");
                        }
                        this.panelCards.Controls.Add(Card);
                    }
                }
            }
        }
    }
}
