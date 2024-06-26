﻿using Syncfusion.Windows.Forms.Tools;
using System.Windows.Forms;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRecharge = new System.Windows.Forms.Button();
            this.panelCards.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCards
            // 
            this.panelCards.AutoScroll = true;
            this.panelCards.AutoSize = true;
            this.panelCards.Controls.Add(this.panel1);
            this.panelCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCards.Location = new System.Drawing.Point(0, 0);
            this.panelCards.Margin = new System.Windows.Forms.Padding(23);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(800, 450);
            this.panelCards.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRecharge);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 49);
            this.panel1.TabIndex = 1;
            // 
            // btnRecharge
            // 
            this.btnRecharge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.btnRecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecharge.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.btnRecharge.ForeColor = System.Drawing.Color.Snow;
            this.btnRecharge.Location = new System.Drawing.Point(3, 9);
            this.btnRecharge.Name = "btnRecharge";
            this.btnRecharge.Size = new System.Drawing.Size(167, 29);
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
            this.Controls.Add(this.panelCards);
            this.Name = "SchedulesToday";
            this.Text = "SchedulesToday";
            this.Load += new System.EventHandler(this.SchedulesToday_Load);
            this.panelCards.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.FlowLayoutPanel panelCards;
        private System.Windows.Forms.Button btnRecharge;
        private System.Windows.Forms.ComboBox dropListBarbers;
        private System.Windows.Forms.ComboBox dropListServices;
        private Panel panel1;
    }
}