using System.Windows.Forms;

namespace interdisciplinar2
{
    partial class AgendamentosScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ibSearch = new FontAwesome.Sharp.IconButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.comboCorte = new System.Windows.Forms.ComboBox();
            this.maskeDate = new System.Windows.Forms.MaskedTextBox();
            this.maskeHorary = new System.Windows.Forms.MaskedTextBox();
            this.lblHorary = new System.Windows.Forms.Label();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.lblBarber = new System.Windows.Forms.Label();
            this.comboBarber = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.ibDelete = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Snow;
            this.btnCadastrar.Location = new System.Drawing.Point(49, 445);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(356, 67);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Agendar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            this.btnCadastrar.MouseEnter += new System.EventHandler(this.btnCadastrar_MouseEnter);
            this.btnCadastrar.MouseLeave += new System.EventHandler(this.btnCadastrar_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(142, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agendamento";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtName.Location = new System.Drawing.Point(42, 127);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(395, 26);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(39, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Corte ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(39, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(38, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome do Cliente";
            // 
            // ibSearch
            // 
            this.ibSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ibSearch.BackColor = System.Drawing.Color.Transparent;
            this.ibSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.ibSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ibSearch.IconColor = System.Drawing.Color.White;
            this.ibSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSearch.IconSize = 24;
            this.ibSearch.Location = new System.Drawing.Point(690, 367);
            this.ibSearch.Name = "ibSearch";
            this.ibSearch.Size = new System.Drawing.Size(39, 30);
            this.ibSearch.TabIndex = 10;
            this.ibSearch.UseVisualStyleBackColor = false;
            this.ibSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ibSearch_MouseClick);
            this.ibSearch.MouseEnter += new System.EventHandler(this.ibSearch_MouseEnter);
            this.ibSearch.MouseLeave += new System.EventHandler(this.ibSearch_MouseLeave);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtDescription.Location = new System.Drawing.Point(43, 400);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(395, 26);
            this.txtDescription.TabIndex = 12;
            this.txtDescription.Text = "Sem Descrição";
            this.txtDescription.Click += new System.EventHandler(this.txtDescription_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblDescription.ForeColor = System.Drawing.Color.Snow;
            this.lblDescription.Location = new System.Drawing.Point(38, 367);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(91, 21);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Descrição";
            // 
            // comboCorte
            // 
            this.comboCorte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCorte.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.comboCorte.FormattingEnabled = true;
            this.comboCorte.Location = new System.Drawing.Point(42, 184);
            this.comboCorte.Name = "comboCorte";
            this.comboCorte.Size = new System.Drawing.Size(395, 29);
            this.comboCorte.TabIndex = 14;
            this.comboCorte.Click += new System.EventHandler(this.comboCorte_Click);
            // 
            // maskeDate
            // 
            this.maskeDate.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.maskeDate.Location = new System.Drawing.Point(43, 328);
            this.maskeDate.Mask = "00/00/0000";
            this.maskeDate.Name = "maskeDate";
            this.maskeDate.Size = new System.Drawing.Size(107, 26);
            this.maskeDate.TabIndex = 15;
            this.maskeDate.ValidatingType = typeof(System.DateTime);
            // 
            // maskeHorary
            // 
            this.maskeHorary.Font = new System.Drawing.Font("Cascadia Mono", 12F);
            this.maskeHorary.Location = new System.Drawing.Point(256, 328);
            this.maskeHorary.Mask = "00:00:00";
            this.maskeHorary.Name = "maskeHorary";
            this.maskeHorary.Size = new System.Drawing.Size(107, 26);
            this.maskeHorary.TabIndex = 16;
            // 
            // lblHorary
            // 
            this.lblHorary.AutoSize = true;
            this.lblHorary.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblHorary.ForeColor = System.Drawing.Color.Snow;
            this.lblHorary.Location = new System.Drawing.Point(252, 294);
            this.lblHorary.Name = "lblHorary";
            this.lblHorary.Size = new System.Drawing.Size(73, 21);
            this.lblHorary.TabIndex = 17;
            this.lblHorary.Text = "Horario";
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dgvSchedules.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSchedules.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.EnableHeadersVisualStyles = false;
            this.dgvSchedules.Location = new System.Drawing.Point(470, 19);
            this.dgvSchedules.Name = "dgvSchedules";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cascadia Code", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedules.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Snow;
            this.dgvSchedules.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvSchedules.Size = new System.Drawing.Size(366, 281);
            this.dgvSchedules.TabIndex = 21;
            this.dgvSchedules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSchedules_CellContentClick_1);
            // 
            // lblBarber
            // 
            this.lblBarber.AutoSize = true;
            this.lblBarber.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblBarber.ForeColor = System.Drawing.Color.Snow;
            this.lblBarber.Location = new System.Drawing.Point(39, 225);
            this.lblBarber.Name = "lblBarber";
            this.lblBarber.Size = new System.Drawing.Size(172, 21);
            this.lblBarber.TabIndex = 22;
            this.lblBarber.Text = "Escolha o barbeiro";
            // 
            // comboBarber
            // 
            this.comboBarber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBarber.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.comboBarber.FormattingEnabled = true;
            this.comboBarber.Location = new System.Drawing.Point(42, 262);
            this.comboBarber.Name = "comboBarber";
            this.comboBarber.Size = new System.Drawing.Size(395, 29);
            this.comboBarber.TabIndex = 24;
            this.comboBarber.Click += new System.EventHandler(this.comboBarber_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(495, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Agendamenot do: ";
            // 
            // txtbSearch
            // 
            this.txtbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbSearch.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.Location = new System.Drawing.Point(499, 367);
            this.txtbSearch.Multiline = true;
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(196, 30);
            this.txtbSearch.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(502, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Excluir agendamento ";
            // 
            // txtDelete
            // 
            this.txtDelete.Enabled = false;
            this.txtDelete.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtDelete.Location = new System.Drawing.Point(506, 463);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(68, 26);
            this.txtDelete.TabIndex = 19;
            // 
            // ibDelete
            // 
            this.ibDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.ibDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDelete.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ibDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ibDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDelete.IconSize = 24;
            this.ibDelete.Location = new System.Drawing.Point(566, 463);
            this.ibDelete.Name = "ibDelete";
            this.ibDelete.Size = new System.Drawing.Size(39, 26);
            this.ibDelete.TabIndex = 20;
            this.ibDelete.UseVisualStyleBackColor = true;
            this.ibDelete.Click += new System.EventHandler(this.ibDelete_Click);
            // 
            // AgendamentosScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(770, 501);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBarber);
            this.Controls.Add(this.dgvSchedules);
            this.Controls.Add(this.ibDelete);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHorary);
            this.Controls.Add(this.maskeHorary);
            this.Controls.Add(this.maskeDate);
            this.Controls.Add(this.comboCorte);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.ibSearch);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblBarber);
            this.Name = "AgendamentosScreen";
            this.Text = "AgendamentosScreen";
            this.Load += new System.EventHandler(this.AgendamentosScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton ibSearch;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox comboCorte;
        private MaskedTextBox maskeDate;
        private MaskedTextBox maskeHorary;
        private Label lblHorary;
        private DataGridView dgvSchedules;
        private Label lblBarber;
        private ComboBox comboBarber;
        private Label label6;
        private TextBox txtbSearch;
        private Label label5;
        private TextBox txtDelete;
        private FontAwesome.Sharp.IconButton ibDelete;
    }
}