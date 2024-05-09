namespace interdisciplinar2
{
    partial class SchedulesToday
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
            this.panelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelCards
            // 
            this.panelCards.AutoScroll = true;
            this.panelCards.Location = new System.Drawing.Point(-5, 32);
            this.panelCards.Margin = new System.Windows.Forms.Padding(23);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(808, 423);
            this.panelCards.TabIndex = 0;
            // 
            // btnRecharge
            // 
            this.btnRecharge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnRecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecharge.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.btnRecharge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecharge.Location = new System.Drawing.Point(31, 3);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(738, 29);
            this.btnRecharge.TabIndex = 0;
            this.btnRecharge.Text = "Atualizar";
            this.btnRecharge.UseVisualStyleBackColor = false;
            this.btnRecharge.Click += new System.EventHandler(this.btnRecharge_Click);
            // 
            // SchedulesToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRecharge);
            this.Controls.Add(this.panelCards);
            this.Name = "SchedulesToday";
            this.Text = "SchedulesToday";
            this.Load += new System.EventHandler(this.SchedulesToday_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.FlowLayoutPanel panelCards;
        private System.Windows.Forms.Button btnRecharge;
    }
}