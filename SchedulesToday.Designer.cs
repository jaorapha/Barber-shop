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
            this.labelFalse = new System.Windows.Forms.Label();
            this.request = new System.Windows.Forms.GroupBox();
            this.lblHorary = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.request.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFalse
            // 
            this.labelFalse.AutoSize = true;
            this.labelFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelFalse.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFalse.Location = new System.Drawing.Point(360, 210);
            this.labelFalse.Name = "labelFalse";
            this.labelFalse.Size = new System.Drawing.Size(0, 31);
            this.labelFalse.TabIndex = 0;
            // 
            // request
            // 
            this.request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.request.Controls.Add(this.lblHorary);
            this.request.Controls.Add(this.lblService);
            this.request.Controls.Add(this.lblClientName);
            this.request.Controls.Add(this.label3);
            this.request.Controls.Add(this.label2);
            this.request.Controls.Add(this.label1);
            this.request.Cursor = System.Windows.Forms.Cursors.Default;
            this.request.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.request.Location = new System.Drawing.Point(22, 12);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(322, 218);
            this.request.TabIndex = 1;
            this.request.TabStop = false;
            // 
            // lblHorary
            // 
            this.lblHorary.AutoSize = true;
            this.lblHorary.Font = new System.Drawing.Font("Cascadia Code", 14.25F);
            this.lblHorary.Location = new System.Drawing.Point(108, 139);
            this.lblHorary.Name = "lblHorary";
            this.lblHorary.Size = new System.Drawing.Size(188, 25);
            this.lblHorary.TabIndex = 5;
            this.lblHorary.Text = "Horário do corte";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Cascadia Code", 14.25F);
            this.lblService.Location = new System.Drawing.Point(122, 99);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(144, 25);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "qual o corte";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Cascadia Code", 14.25F);
            this.lblClientName.Location = new System.Drawing.Point(108, 59);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(177, 25);
            this.lblClientName.TabIndex = 3;
            this.lblClientName.Text = "nome do cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Corte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horário:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // SchedulesToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.request);
            this.Controls.Add(this.labelFalse);
            this.Name = "SchedulesToday";
            this.Text = "SchedulesToday";
            this.request.ResumeLayout(false);
            this.request.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFalse;
        private System.Windows.Forms.GroupBox request;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHorary;
        private System.Windows.Forms.Label lblService;
    }
}