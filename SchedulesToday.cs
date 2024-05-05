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
            
        }

        private Panel Card;

        private TextBox txtService;

        private Button btnBack;

        private DataGridView dgvServices;

        List<Control> controlsRemove = new List<Control>();

        List<Control> allCards = new List<Control>();

        private void SchedulesToday_Load(object sender, EventArgs e)
        {
            string query = "SELECT customers.full_name,schedules.service, schedules.horary FROM schedules INNER JOIN customers WHERE customers.id =1";

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
                Label lblFunctionary = new System.Windows.Forms.Label();
                Label lblTitle = new System.Windows.Forms.Label();
                Button btnReject = new System.Windows.Forms.Button();
                Button btnAccept = new System.Windows.Forms.Button();
                TextBox txtFunctionary = new System.Windows.Forms.TextBox();
                txtService = new System.Windows.Forms.TextBox();
                Button btnEdit = new System.Windows.Forms.Button();
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
                lblTitle.Size = new System.Drawing.Size(360, 32);
                lblTitle.TabIndex = 10;
                lblTitle.Text = "Novo Agendamento";
                lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                #endregion

                #region Botões
                //btnReject
                btnReject.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
                btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnReject.Font = new System.Drawing.Font("Cascadia Code", 12F);
                btnReject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                btnReject.Location = new System.Drawing.Point(217, 245);
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
                btnAccept.Location = new System.Drawing.Point(29, 245);
                btnAccept.Name = "btnAccept";
                btnAccept.Size = new System.Drawing.Size(106, 32);
                btnAccept.TabIndex = 9;
                btnAccept.Text = "Aceitar";
                btnAccept.UseVisualStyleBackColor = true;

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

                #region txt
                txtFunctionary.Font = new System.Drawing.Font("Cascadia Code", 10F);
                txtFunctionary.Location = new System.Drawing.Point(106, 198);
                txtFunctionary.Name = "txtFunctionary";
                txtFunctionary.Size = new System.Drawing.Size(170, 23);
                txtFunctionary.TabIndex = 7;
                txtFunctionary.Text = "txt Functionary";
                #endregion

                #region Card
                Card = new System.Windows.Forms.Panel();
                Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
                Card.Controls.Add(pictureUser);
                Card.Controls.Add(lblClientName);
                Card.Controls.Add(lblHaircut);
                Card.Controls.Add(lblService);
                Card.Controls.Add(lblSchedule);
                Card.Controls.Add(lblHorary);
                Card.Controls.Add(lblBarber);
                Card.Controls.Add(txtFunctionary);
                Card.Controls.Add(btnReject);
                Card.Controls.Add(btnAccept);
                Card.Controls.Add(lblTitle);
                Card.Controls.Add(btnEdit);
                Card.Location = new System.Drawing.Point(3, 3);
                Card.Name = "Card";
                Card.Size = new System.Drawing.Size(360, 293);
                Card.Margin = new System.Windows.Forms.Padding(7);
                Card.TabIndex = 0;
                Card.DoubleClick += Card_DoubleClick;
                // Card.Enabled = false;
                #endregion

                try
                {
                    lblClientName.Text = myReader.GetString("full_name");
                    lblService.Text = myReader.GetString("service");
                    lblHorary.Text = myReader.GetDateTime("horary").ToString();
                    this.panelCards.Controls.Add(Card);
                }
                catch (Exception ex)
                {
                    if (ex is System.Data.SqlTypes.SqlNullValueException)
                    {
                        #region txtService 
                        txtService = new System.Windows.Forms.TextBox();
                        txtService.Location = new System.Drawing.Point(78, 108);
                        txtService.Name = "txtService";
                        txtService.Size = new System.Drawing.Size(170, 26);
                        txtService.TabIndex = 12;
                        txtService.Text = "TXTservice";
                        #endregion

                        Card.Controls.Remove(lblService);
                        Card.Controls.Add(txtService);

                        lblClientName.Text = myReader.GetString("full_name");
                        lblHorary.Text = myReader.GetDateTime("horary").ToString();

                        this.panelCards.Controls.Add(Card);
                    }
                }
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Control pass in this.panelCards.Controls)
            {
                foreach (Control value in pass.Controls)
                {
                    if (value == sender)
                    {
                        this.panelCards.Controls.RemoveAt(count);
                        return;
                    }
                }
                count++;
            }

        }

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            int count = 0;

            foreach (Control pass in panelCards.Controls)
            {
                if (pass == sender)
                {
                    break;
                }

                count++;
            }

            MessageBox.Show("Esse é o índice" + count);
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

            MessageBox.Show("este é o índice " + count);

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
            dgvServices = new System.Windows.Forms.DataGridView();
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
            btnBack = new System.Windows.Forms.Button();
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
        }
    }
}
