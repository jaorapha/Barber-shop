namespace interdisciplinar2
{
    partial class RegisterBarbers
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.ibDelete = new FontAwesome.Sharp.IconButton();
            this.lblNameDelete = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.ibSearch = new FontAwesome.Sharp.IconButton();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::interdisciplinar2.Properties.Resources.sorte;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 160);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(451, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(310, 268);
            this.dataGridView1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(20, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome do barbeiro";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtName.Location = new System.Drawing.Point(23, 290);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 26);
            this.txtName.TabIndex = 10;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Code", 24F);
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(312, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(399, 43);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Cadastro de barbeiro";
            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.btnRegister.ForeColor = System.Drawing.Color.Snow;
            this.btnRegister.Location = new System.Drawing.Point(23, 344);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(305, 60);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Cadastarar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtDelete.Location = new System.Drawing.Point(459, 520);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(261, 26);
            this.txtDelete.TabIndex = 13;
            this.txtDelete.Text = "Insira o nome do barbeiro";
            this.txtDelete.Click += new System.EventHandler(this.txtDelete_Click);
            // 
            // ibDelete
            // 
            this.ibDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.ibDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDelete.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.ibDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ibDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDelete.IconSize = 20;
            this.ibDelete.Location = new System.Drawing.Point(716, 520);
            this.ibDelete.Name = "ibDelete";
            this.ibDelete.Size = new System.Drawing.Size(27, 26);
            this.ibDelete.TabIndex = 14;
            this.ibDelete.UseVisualStyleBackColor = true;
            this.ibDelete.Click += new System.EventHandler(this.ibDelete_Click);
            // 
            // lblNameDelete
            // 
            this.lblNameDelete.AutoSize = true;
            this.lblNameDelete.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblNameDelete.ForeColor = System.Drawing.Color.Snow;
            this.lblNameDelete.Location = new System.Drawing.Point(460, 480);
            this.lblNameDelete.Name = "lblNameDelete";
            this.lblNameDelete.Size = new System.Drawing.Size(154, 21);
            this.lblNameDelete.TabIndex = 15;
            this.lblNameDelete.Text = "Excluir barbeiro";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblSearch.ForeColor = System.Drawing.Color.Snow;
            this.lblSearch.Location = new System.Drawing.Point(451, 395);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(163, 21);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Procurar Barbeiro";
            // 
            // ibSearch
            // 
            this.ibSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.ibSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ibSearch.IconColor = System.Drawing.Color.Black;
            this.ibSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSearch.IconSize = 20;
            this.ibSearch.Location = new System.Drawing.Point(716, 435);
            this.ibSearch.Name = "ibSearch";
            this.ibSearch.Size = new System.Drawing.Size(31, 26);
            this.ibSearch.TabIndex = 18;
            this.ibSearch.UseVisualStyleBackColor = true;
            this.ibSearch.Click += new System.EventHandler(this.ibSearch_Click);
            // 
            // txtbSearch
            // 
            this.txtbSearch.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtbSearch.Location = new System.Drawing.Point(459, 435);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(261, 26);
            this.txtbSearch.TabIndex = 17;
            // 
            // RegisterBarbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(916, 574);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.ibSearch);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.lblNameDelete);
            this.Controls.Add(this.ibDelete);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegisterBarbers";
            this.Text = "RegisterBarbers";
            this.Load += new System.EventHandler(this.RegisterBarbers_Load);
            this.Click += new System.EventHandler(this.RegisterBarbers_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtDelete;
        private FontAwesome.Sharp.IconButton ibDelete;
        private System.Windows.Forms.Label lblNameDelete;
        private System.Windows.Forms.Label lblSearch;
        private FontAwesome.Sharp.IconButton ibSearch;
        private System.Windows.Forms.TextBox txtbSearch;
    }
}