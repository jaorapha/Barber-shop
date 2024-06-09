namespace interdisciplinar2
{
    partial class Queries
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
            this.dgvQuery = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClientActive = new System.Windows.Forms.Button();
            this.btnBarberActive = new System.Windows.Forms.Button();
            this.mostService = new System.Windows.Forms.Button();
            this.ibQueryClient = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuery
            // 
            this.dgvQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuery.Location = new System.Drawing.Point(335, 34);
            this.dgvQuery.Name = "dgvQuery";
            this.dgvQuery.Size = new System.Drawing.Size(453, 300);
            this.dgvQuery.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(387, 367);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(0, 0);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::interdisciplinar2.Properties.Resources.sorte;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 160);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtbSearch
            // 
            this.txtbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtbSearch.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.txtbSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtbSearch.Location = new System.Drawing.Point(364, 401);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(305, 26);
            this.txtbSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(360, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Que barbeiro atendeu o:";
            // 
            // btnClientActive
            // 
            this.btnClientActive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnClientActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientActive.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.btnClientActive.ForeColor = System.Drawing.Color.Snow;
            this.btnClientActive.Location = new System.Drawing.Point(12, 233);
            this.btnClientActive.Name = "btnClientActive";
            this.btnClientActive.Size = new System.Drawing.Size(305, 60);
            this.btnClientActive.TabIndex = 0;
            this.btnClientActive.Text = "barbeiro mais requisitado";
            this.btnClientActive.UseVisualStyleBackColor = true;
            this.btnClientActive.Click += new System.EventHandler(this.btnClientActive_Click);
            // 
            // btnBarberActive
            // 
            this.btnBarberActive.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnBarberActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarberActive.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.btnBarberActive.ForeColor = System.Drawing.Color.Snow;
            this.btnBarberActive.Location = new System.Drawing.Point(12, 340);
            this.btnBarberActive.Name = "btnBarberActive";
            this.btnBarberActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBarberActive.Size = new System.Drawing.Size(305, 60);
            this.btnBarberActive.TabIndex = 1;
            this.btnBarberActive.Text = "Cliente mais atendido";
            this.btnBarberActive.UseVisualStyleBackColor = true;
            this.btnBarberActive.Click += new System.EventHandler(this.btnBarberActive_Click);
            // 
            // mostService
            // 
            this.mostService.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.mostService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostService.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.mostService.ForeColor = System.Drawing.Color.Snow;
            this.mostService.Location = new System.Drawing.Point(12, 447);
            this.mostService.Name = "mostService";
            this.mostService.Size = new System.Drawing.Size(305, 60);
            this.mostService.TabIndex = 2;
            this.mostService.Text = "Serviço mais pedido";
            this.mostService.UseVisualStyleBackColor = true;
            this.mostService.Click += new System.EventHandler(this.mostService_Click);
            // 
            // ibQueryClient
            // 
            this.ibQueryClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.ibQueryClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibQueryClient.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.ibQueryClient.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibQueryClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibQueryClient.IconSize = 24;
            this.ibQueryClient.Location = new System.Drawing.Point(666, 401);
            this.ibQueryClient.Name = "ibQueryClient";
            this.ibQueryClient.Size = new System.Drawing.Size(27, 26);
            this.ibQueryClient.TabIndex = 6;
            this.ibQueryClient.UseVisualStyleBackColor = true;
            this.ibQueryClient.Click += new System.EventHandler(this.ibQueryClient_Click);
            // 
            // Queries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.ibQueryClient);
            this.Controls.Add(this.mostService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBarberActive);
            this.Controls.Add(this.btnClientActive);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dgvQuery);
            this.Name = "Queries";
            this.Text = "Queries";
            this.Load += new System.EventHandler(this.Queries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvQuery;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClientActive;
        private System.Windows.Forms.Button btnBarberActive;
        private System.Windows.Forms.Button mostService;
        private FontAwesome.Sharp.IconButton ibQueryClient;
    }
}