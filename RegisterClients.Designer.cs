namespace interdisciplinar2
{
    partial class RegisterClients
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.ibSearch = new FontAwesome.Sharp.IconButton();
            this.ibDelete = new FontAwesome.Sharp.IconButton();
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 24F);
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(228, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(342, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cadastrar Cliente";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblName.ForeColor = System.Drawing.Color.Snow;
            this.lblName.Location = new System.Drawing.Point(49, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 21);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblUser.ForeColor = System.Drawing.Color.Snow;
            this.lblUser.Location = new System.Drawing.Point(49, 145);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(145, 21);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Nome de usuário";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblpassword.ForeColor = System.Drawing.Color.Snow;
            this.lblpassword.Location = new System.Drawing.Point(49, 271);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(55, 21);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Senha";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblPhone.ForeColor = System.Drawing.Color.Snow;
            this.lblPhone.Location = new System.Drawing.Point(49, 208);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 21);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Telelefone";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtName.Location = new System.Drawing.Point(53, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtUser.Location = new System.Drawing.Point(53, 174);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(252, 26);
            this.txtUser.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtPassword.Location = new System.Drawing.Point(53, 300);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 26);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 241);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.btnRegister.ForeColor = System.Drawing.Color.Snow;
            this.btnRegister.Location = new System.Drawing.Point(53, 419);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(263, 52);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Cadastar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblSearch.ForeColor = System.Drawing.Color.Snow;
            this.lblSearch.Location = new System.Drawing.Point(416, 353);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(154, 21);
            this.lblSearch.TabIndex = 9;
            this.lblSearch.Text = "Procurar Cliente";
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtbSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtbSearch.Location = new System.Drawing.Point(420, 377);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(280, 26);
            this.txtbSearch.TabIndex = 10;
            // 
            // ibSearch
            // 
            this.ibSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.ibSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ibSearch.IconColor = System.Drawing.Color.Black;
            this.ibSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSearch.IconSize = 20;
            this.ibSearch.Location = new System.Drawing.Point(696, 377);
            this.ibSearch.Name = "ibSearch";
            this.ibSearch.Size = new System.Drawing.Size(31, 26);
            this.ibSearch.TabIndex = 11;
            this.ibSearch.UseVisualStyleBackColor = true;
            this.ibSearch.Click += new System.EventHandler(this.ibSearch_Click);
            // 
            // ibDelete
            // 
            this.ibDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.ibDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDelete.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.ibDelete.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ibDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ibDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDelete.IconSize = 20;
            this.ibDelete.Location = new System.Drawing.Point(696, 470);
            this.ibDelete.Name = "ibDelete";
            this.ibDelete.Size = new System.Drawing.Size(31, 26);
            this.ibDelete.TabIndex = 12;
            this.ibDelete.UseVisualStyleBackColor = true;
            this.ibDelete.Click += new System.EventHandler(this.ibDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblDelete.ForeColor = System.Drawing.Color.Snow;
            this.lblDelete.Location = new System.Drawing.Point(416, 435);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(145, 21);
            this.lblDelete.TabIndex = 13;
            this.lblDelete.Text = "Excluir Cliente";
            // 
            // txtDelete
            // 
            this.txtDelete.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDelete.Location = new System.Drawing.Point(420, 470);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(280, 26);
            this.txtDelete.TabIndex = 14;
            this.txtDelete.Text = "Insira o nome de usuário";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtPhone.Location = new System.Drawing.Point(53, 237);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(252, 26);
            this.txtPhone.TabIndex = 20;
            // 
            // txtConfirm
            // 
            this.txtConfirm.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtConfirm.Location = new System.Drawing.Point(53, 363);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(252, 26);
            this.txtConfirm.TabIndex = 21;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblConfirm.ForeColor = System.Drawing.Color.Snow;
            this.lblConfirm.Location = new System.Drawing.Point(50, 334);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(145, 21);
            this.lblConfirm.TabIndex = 22;
            this.lblConfirm.Text = "Confirmar Senha";
            // 
            // RegisterClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(850, 527);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.ibDelete);
            this.Controls.Add(this.ibSearch);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "RegisterClients";
            this.Text = "RegisterClients";
            this.Load += new System.EventHandler(this.RegisterClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtbSearch;
        private FontAwesome.Sharp.IconButton ibSearch;
        private FontAwesome.Sharp.IconButton ibDelete;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Label lblConfirm;
    }
}