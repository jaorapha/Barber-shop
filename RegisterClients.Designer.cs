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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.lblDelete = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ibDontShowPasswordImage = new FontAwesome.Sharp.IconButton();
            this.ibShowPasswordImage = new FontAwesome.Sharp.IconButton();
            this.maskPhone = new System.Windows.Forms.TextBox();
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
            this.btnRegister.Location = new System.Drawing.Point(53, 372);
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
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.textBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox5.Location = new System.Drawing.Point(420, 377);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(280, 26);
            this.textBox5.TabIndex = 10;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(696, 377);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(31, 26);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(696, 470);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(31, 26);
            this.iconButton2.TabIndex = 12;
            this.iconButton2.UseVisualStyleBackColor = true;
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
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.textBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox6.Location = new System.Drawing.Point(420, 470);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(280, 26);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "Insira o nome de usuário";
            // 
            // ibDontShowPasswordImage
            // 
            this.ibDontShowPasswordImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.ibDontShowPasswordImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDontShowPasswordImage.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.ibDontShowPasswordImage.IconColor = System.Drawing.Color.Black;
            this.ibDontShowPasswordImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDontShowPasswordImage.IconSize = 35;
            this.ibDontShowPasswordImage.Location = new System.Drawing.Point(302, 300);
            this.ibDontShowPasswordImage.Name = "ibDontShowPasswordImage";
            this.ibDontShowPasswordImage.Size = new System.Drawing.Size(31, 26);
            this.ibDontShowPasswordImage.TabIndex = 18;
            this.ibDontShowPasswordImage.UseVisualStyleBackColor = true;
            this.ibDontShowPasswordImage.Click += new System.EventHandler(this.ibDontShowPasswordImage_Click_1);
            // 
            // ibShowPasswordImage
            // 
            this.ibShowPasswordImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.ibShowPasswordImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibShowPasswordImage.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.ibShowPasswordImage.IconColor = System.Drawing.Color.Black;
            this.ibShowPasswordImage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibShowPasswordImage.IconSize = 35;
            this.ibShowPasswordImage.Location = new System.Drawing.Point(302, 300);
            this.ibShowPasswordImage.Name = "ibShowPasswordImage";
            this.ibShowPasswordImage.Size = new System.Drawing.Size(31, 26);
            this.ibShowPasswordImage.TabIndex = 19;
            this.ibShowPasswordImage.UseVisualStyleBackColor = true;
            this.ibShowPasswordImage.Click += new System.EventHandler(this.ibShowPasswordImage_Click_1);
            // 
            // maskPhone
            // 
            this.maskPhone.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.maskPhone.Location = new System.Drawing.Point(53, 242);
            this.maskPhone.Name = "maskPhone";
            this.maskPhone.Size = new System.Drawing.Size(252, 26);
            this.maskPhone.TabIndex = 20;
            // 
            // RegisterClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(850, 527);
            this.Controls.Add(this.maskPhone);
            this.Controls.Add(this.ibDontShowPasswordImage);
            this.Controls.Add(this.ibShowPasswordImage);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.textBox5);
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
        private System.Windows.Forms.TextBox textBox5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.TextBox textBox6;
        private FontAwesome.Sharp.IconButton ibDontShowPasswordImage;
        private FontAwesome.Sharp.IconButton ibShowPasswordImage;
        private System.Windows.Forms.TextBox maskPhone;
    }
}