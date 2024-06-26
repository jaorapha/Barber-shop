﻿namespace interdisciplinar2
{
    partial class MainScreen
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.ActiveStateCollection activeStateCollection1 = new Syncfusion.Windows.Forms.Tools.ActiveStateCollection();
            Syncfusion.Windows.Forms.Tools.InactiveStateCollection inactiveStateCollection1 = new Syncfusion.Windows.Forms.Tools.InactiveStateCollection();
            Syncfusion.Windows.Forms.Tools.SliderCollection sliderCollection1 = new Syncfusion.Windows.Forms.Tools.SliderCollection();
            Syncfusion.Windows.Forms.Tools.DigitalClockRenderer digitalClockRenderer1 = new Syncfusion.Windows.Forms.Tools.DigitalClockRenderer();
            Syncfusion.Windows.Forms.Tools.ClockRenderer clockRenderer1 = new Syncfusion.Windows.Forms.Tools.ClockRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pnlDropDown = new System.Windows.Forms.Panel();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.lblScheduleToday = new System.Windows.Forms.Label();
            this.lblAgendamentos = new System.Windows.Forms.Label();
            this.ibRegisterClient = new FontAwesome.Sharp.IconButton();
            this.ibRegisterService = new FontAwesome.Sharp.IconButton();
            this.ibRegisterBarber = new FontAwesome.Sharp.IconButton();
            this.ibQuery = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toggleButton1 = new Syncfusion.Windows.Forms.Tools.ToggleButton();
            this.panelLeftBtn = new System.Windows.Forms.Panel();
            this.ibChangePassword = new FontAwesome.Sharp.IconButton();
            this.ibDashboard = new FontAwesome.Sharp.IconButton();
            this.ibSchedules = new FontAwesome.Sharp.IconButton();
            this.ibSchedule = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.ipbMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.ipbMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.lblFormName = new System.Windows.Forms.Label();
            this.ipbFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.panelMainForms = new System.Windows.Forms.Panel();
            this.clock1 = new Syncfusion.Windows.Forms.Tools.Clock();
            this.timerToggleButton = new System.Windows.Forms.Timer(this.components);
            this.panelLeft.SuspendLayout();
            this.pnlDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbFormIcon)).BeginInit();
            this.panelMainForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.panelLeft.Controls.Add(this.pnlDropDown);
            this.panelLeft.Controls.Add(this.ibRegisterClient);
            this.panelLeft.Controls.Add(this.ibRegisterService);
            this.panelLeft.Controls.Add(this.ibRegisterBarber);
            this.panelLeft.Controls.Add(this.ibQuery);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.toggleButton1);
            this.panelLeft.Controls.Add(this.panelLeftBtn);
            this.panelLeft.Controls.Add(this.ibChangePassword);
            this.panelLeft.Controls.Add(this.ibDashboard);
            this.panelLeft.Controls.Add(this.ibSchedules);
            this.panelLeft.Controls.Add(this.ibSchedule);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(220, 707);
            this.panelLeft.TabIndex = 0;
            // 
            // pnlDropDown
            // 
            this.pnlDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlDropDown.Controls.Add(this.lblHistorico);
            this.pnlDropDown.Controls.Add(this.lblScheduleToday);
            this.pnlDropDown.Controls.Add(this.lblAgendamentos);
            this.pnlDropDown.Location = new System.Drawing.Point(0, 435);
            this.pnlDropDown.Name = "pnlDropDown";
            this.pnlDropDown.Size = new System.Drawing.Size(220, 107);
            this.pnlDropDown.TabIndex = 3;
            this.pnlDropDown.Visible = false;
            // 
            // lblHistorico
            // 
            this.lblHistorico.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHistorico.Location = new System.Drawing.Point(0, 35);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(220, 35);
            this.lblHistorico.TabIndex = 4;
            this.lblHistorico.Text = "Histórico";
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHistorico.Click += new System.EventHandler(this.lblHistorico_Click);
            this.lblHistorico.MouseEnter += new System.EventHandler(this.lblHistorico_MouseEnter);
            this.lblHistorico.MouseLeave += new System.EventHandler(this.lblHistorico_MouseLeave);
            // 
            // lblScheduleToday
            // 
            this.lblScheduleToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblScheduleToday.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.lblScheduleToday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblScheduleToday.Location = new System.Drawing.Point(0, 72);
            this.lblScheduleToday.Name = "lblScheduleToday";
            this.lblScheduleToday.Size = new System.Drawing.Size(220, 35);
            this.lblScheduleToday.TabIndex = 4;
            this.lblScheduleToday.Text = "Agendamentos de hoje";
            this.lblScheduleToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScheduleToday.Click += new System.EventHandler(this.lblScheduleToday_Click);
            this.lblScheduleToday.MouseEnter += new System.EventHandler(this.lblScheduleToday_MouseEnter);
            this.lblScheduleToday.MouseLeave += new System.EventHandler(this.lblScheduleToday_MouseLeave);
            // 
            // lblAgendamentos
            // 
            this.lblAgendamentos.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendamentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAgendamentos.Location = new System.Drawing.Point(-1, -3);
            this.lblAgendamentos.Name = "lblAgendamentos";
            this.lblAgendamentos.Size = new System.Drawing.Size(220, 35);
            this.lblAgendamentos.TabIndex = 3;
            this.lblAgendamentos.Text = "Agendamentos Futuros";
            this.lblAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgendamentos.Click += new System.EventHandler(this.lblAgendamentos_Click);
            this.lblAgendamentos.MouseEnter += new System.EventHandler(this.lblAgendamentos_MouseEnter);
            this.lblAgendamentos.MouseLeave += new System.EventHandler(this.lblAgendamentos_MouseLeave);
            // 
            // ibRegisterClient
            // 
            this.ibRegisterClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibRegisterClient.FlatAppearance.BorderSize = 0;
            this.ibRegisterClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibRegisterClient.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibRegisterClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibRegisterClient.IconChar = FontAwesome.Sharp.IconChar.PersonCirclePlus;
            this.ibRegisterClient.IconColor = System.Drawing.Color.White;
            this.ibRegisterClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibRegisterClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibRegisterClient.Location = new System.Drawing.Point(0, 606);
            this.ibRegisterClient.Name = "ibRegisterClient";
            this.ibRegisterClient.Size = new System.Drawing.Size(220, 58);
            this.ibRegisterClient.TabIndex = 4;
            this.ibRegisterClient.Text = "Cadastrar Clientes";
            this.ibRegisterClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibRegisterClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibRegisterClient.UseVisualStyleBackColor = true;
            this.ibRegisterClient.Click += new System.EventHandler(this.ibRegisterClient_Click);
            this.ibRegisterClient.MouseEnter += new System.EventHandler(this.ibRegisterClient_MouseEnter);
            this.ibRegisterClient.MouseLeave += new System.EventHandler(this.ibRegisterClient_MouseLeave);
            // 
            // ibRegisterService
            // 
            this.ibRegisterService.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibRegisterService.FlatAppearance.BorderSize = 0;
            this.ibRegisterService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibRegisterService.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibRegisterService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibRegisterService.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            this.ibRegisterService.IconColor = System.Drawing.Color.White;
            this.ibRegisterService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibRegisterService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibRegisterService.Location = new System.Drawing.Point(0, 548);
            this.ibRegisterService.Name = "ibRegisterService";
            this.ibRegisterService.Size = new System.Drawing.Size(220, 58);
            this.ibRegisterService.TabIndex = 8;
            this.ibRegisterService.Text = "Adicionar Serviço";
            this.ibRegisterService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibRegisterService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibRegisterService.UseVisualStyleBackColor = true;
            this.ibRegisterService.Click += new System.EventHandler(this.ibRegisterService_Click);
            this.ibRegisterService.MouseEnter += new System.EventHandler(this.ibRegisterService_MouseEnter);
            this.ibRegisterService.MouseLeave += new System.EventHandler(this.ibRegisterService_MouseLeave);
            // 
            // ibRegisterBarber
            // 
            this.ibRegisterBarber.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibRegisterBarber.FlatAppearance.BorderSize = 0;
            this.ibRegisterBarber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibRegisterBarber.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibRegisterBarber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibRegisterBarber.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.ibRegisterBarber.IconColor = System.Drawing.Color.White;
            this.ibRegisterBarber.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibRegisterBarber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibRegisterBarber.Location = new System.Drawing.Point(0, 490);
            this.ibRegisterBarber.Name = "ibRegisterBarber";
            this.ibRegisterBarber.Size = new System.Drawing.Size(220, 58);
            this.ibRegisterBarber.TabIndex = 7;
            this.ibRegisterBarber.Text = "Cadastrar Barbeiro";
            this.ibRegisterBarber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibRegisterBarber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibRegisterBarber.UseVisualStyleBackColor = true;
            this.ibRegisterBarber.Click += new System.EventHandler(this.ibRegisterBarber_Click);
            this.ibRegisterBarber.MouseEnter += new System.EventHandler(this.ibRegisterBarber_MouseEnter);
            this.ibRegisterBarber.MouseLeave += new System.EventHandler(this.ibRegisterBarber_MouseLeave);
            // 
            // ibQuery
            // 
            this.ibQuery.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibQuery.FlatAppearance.BorderSize = 0;
            this.ibQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibQuery.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibQuery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibQuery.IconChar = FontAwesome.Sharp.IconChar.ClipboardQuestion;
            this.ibQuery.IconColor = System.Drawing.Color.White;
            this.ibQuery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibQuery.Location = new System.Drawing.Point(0, 432);
            this.ibQuery.Name = "ibQuery";
            this.ibQuery.Size = new System.Drawing.Size(220, 58);
            this.ibQuery.TabIndex = 3;
            this.ibQuery.Text = "Consultas";
            this.ibQuery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibQuery.UseVisualStyleBackColor = true;
            this.ibQuery.Click += new System.EventHandler(this.ibQuery_Click);
            this.ibQuery.MouseEnter += new System.EventHandler(this.ibQuery_MouseEnter);
            this.ibQuery.MouseLeave += new System.EventHandler(this.ibQuery_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modo Escuro";
            // 
            // toggleButton1
            // 
            activeStateCollection1.Text = "DESATIVAR";
            this.toggleButton1.ActiveState = activeStateCollection1;
            this.toggleButton1.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton1.ForeColor = System.Drawing.Color.Black;
            inactiveStateCollection1.Text = "ATIVAR";
            this.toggleButton1.InactiveState = inactiveStateCollection1;
            this.toggleButton1.Location = new System.Drawing.Point(129, 677);
            this.toggleButton1.MinimumSize = new System.Drawing.Size(52, 20);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(75, 30);
            this.toggleButton1.Slider = sliderCollection1;
            this.toggleButton1.TabIndex = 4;
            this.toggleButton1.Text = "toggleButton1";
            this.toggleButton1.ThemeName = "";
            this.toggleButton1.ThemeStyle.ActiveForeColor = System.Drawing.Color.White;
            this.toggleButton1.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.toggleButton1.ThemeStyle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.toggleButton1.ThemeStyle.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleButton1.ToggleStateChanged += new Syncfusion.Windows.Forms.Tools.ToggleStateChangedEventHandler(this.toggleButton1_ToggleStateChanged);
            this.toggleButton1.Click += new System.EventHandler(this.toggleButton1_Click);
            // 
            // panelLeftBtn
            // 
            this.panelLeftBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.panelLeftBtn.Location = new System.Drawing.Point(3, 200);
            this.panelLeftBtn.Name = "panelLeftBtn";
            this.panelLeftBtn.Size = new System.Drawing.Size(7, 58);
            this.panelLeftBtn.TabIndex = 2;
            this.panelLeftBtn.Visible = false;
            // 
            // ibChangePassword
            // 
            this.ibChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibChangePassword.FlatAppearance.BorderSize = 0;
            this.ibChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibChangePassword.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibChangePassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibChangePassword.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.ibChangePassword.IconColor = System.Drawing.Color.White;
            this.ibChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibChangePassword.Location = new System.Drawing.Point(0, 374);
            this.ibChangePassword.Name = "ibChangePassword";
            this.ibChangePassword.Size = new System.Drawing.Size(220, 58);
            this.ibChangePassword.TabIndex = 3;
            this.ibChangePassword.Text = "Alterar Senha";
            this.ibChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibChangePassword.UseVisualStyleBackColor = true;
            this.ibChangePassword.Click += new System.EventHandler(this.ibChangePassword_Click);
            this.ibChangePassword.MouseEnter += new System.EventHandler(this.ibChangePassword_MouseEnter);
            this.ibChangePassword.MouseLeave += new System.EventHandler(this.ibChangePassword_MouseLeave);
            // 
            // ibDashboard
            // 
            this.ibDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibDashboard.FlatAppearance.BorderSize = 0;
            this.ibDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibDashboard.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibDashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.ibDashboard.IconColor = System.Drawing.Color.White;
            this.ibDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibDashboard.Location = new System.Drawing.Point(0, 316);
            this.ibDashboard.Name = "ibDashboard";
            this.ibDashboard.Size = new System.Drawing.Size(220, 58);
            this.ibDashboard.TabIndex = 2;
            this.ibDashboard.Text = "Dashboard";
            this.ibDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibDashboard.UseVisualStyleBackColor = true;
            this.ibDashboard.Click += new System.EventHandler(this.ibDashboard_Click);
            this.ibDashboard.MouseEnter += new System.EventHandler(this.ibDashboard_MouseEnter);
            this.ibDashboard.MouseLeave += new System.EventHandler(this.ibDashboard_MouseLeave);
            // 
            // ibSchedules
            // 
            this.ibSchedules.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibSchedules.FlatAppearance.BorderSize = 0;
            this.ibSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSchedules.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.ibSchedules.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSchedules.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibSchedules.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.ibSchedules.IconColor = System.Drawing.Color.White;
            this.ibSchedules.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSchedules.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSchedules.Location = new System.Drawing.Point(0, 258);
            this.ibSchedules.Name = "ibSchedules";
            this.ibSchedules.Size = new System.Drawing.Size(220, 58);
            this.ibSchedules.TabIndex = 1;
            this.ibSchedules.Text = "Agendamentos";
            this.ibSchedules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSchedules.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSchedules.UseVisualStyleBackColor = true;
            this.ibSchedules.Click += new System.EventHandler(this.ibSchedules_Click);
            this.ibSchedules.MouseEnter += new System.EventHandler(this.ibSchedules_MouseEnter);
            this.ibSchedules.MouseLeave += new System.EventHandler(this.ibSchedules_MouseLeave);
            // 
            // ibSchedule
            // 
            this.ibSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(66)))));
            this.ibSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibSchedule.FlatAppearance.BorderSize = 0;
            this.ibSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibSchedule.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibSchedule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ibSchedule.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ibSchedule.IconColor = System.Drawing.Color.White;
            this.ibSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSchedule.Location = new System.Drawing.Point(0, 200);
            this.ibSchedule.Name = "ibSchedule";
            this.ibSchedule.Size = new System.Drawing.Size(220, 58);
            this.ibSchedule.TabIndex = 1;
            this.ibSchedule.Text = "Agendar";
            this.ibSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ibSchedule.UseVisualStyleBackColor = false;
            this.ibSchedule.Click += new System.EventHandler(this.ibSchedule_Click);
            this.ibSchedule.MouseEnter += new System.EventHandler(this.ibSchedule_MouseEnter);
            this.ibSchedule.MouseLeave += new System.EventHandler(this.ibSchedule_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 200);
            this.panel1.TabIndex = 1;
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logo.Image = global::interdisciplinar2.Properties.Resources.barber_logo_no_bg_removebg_preview;
            this.logo.Location = new System.Drawing.Point(27, 28);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(155, 146);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.panelHeader.Controls.Add(this.ipbMinimize);
            this.panelHeader.Controls.Add(this.ipbMaximize);
            this.panelHeader.Controls.Add(this.lblFormName);
            this.panelHeader.Controls.Add(this.ipbFormIcon);
            this.panelHeader.Controls.Add(this.lblExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(220, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(843, 39);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // ipbMinimize
            // 
            this.ipbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ipbMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ipbMinimize.IconColor = System.Drawing.Color.White;
            this.ipbMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbMinimize.IconSize = 41;
            this.ipbMinimize.Location = new System.Drawing.Point(726, 0);
            this.ipbMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ipbMinimize.Name = "ipbMinimize";
            this.ipbMinimize.Size = new System.Drawing.Size(43, 41);
            this.ipbMinimize.TabIndex = 7;
            this.ipbMinimize.TabStop = false;
            this.ipbMinimize.Click += new System.EventHandler(this.ipbMinimize_Click);
            this.ipbMinimize.MouseEnter += new System.EventHandler(this.ipbMinimize_MouseEnter);
            this.ipbMinimize.MouseLeave += new System.EventHandler(this.ipbMinimize_MouseLeave);
            // 
            // ipbMaximize
            // 
            this.ipbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ipbMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ipbMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.ipbMaximize.IconColor = System.Drawing.Color.White;
            this.ipbMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbMaximize.IconSize = 38;
            this.ipbMaximize.Location = new System.Drawing.Point(769, 0);
            this.ipbMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.ipbMaximize.Name = "ipbMaximize";
            this.ipbMaximize.Size = new System.Drawing.Size(38, 41);
            this.ipbMaximize.TabIndex = 6;
            this.ipbMaximize.TabStop = false;
            this.ipbMaximize.Click += new System.EventHandler(this.ipbMaximize_Click);
            this.ipbMaximize.MouseEnter += new System.EventHandler(this.ipbMaximize_MouseEnter);
            this.ipbMaximize.MouseLeave += new System.EventHandler(this.ipbMaximize_MouseLeave);
            // 
            // lblFormName
            // 
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFormName.Location = new System.Drawing.Point(59, 9);
            this.lblFormName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(60, 28);
            this.lblFormName.TabIndex = 5;
            this.lblFormName.Text = "Home";
            // 
            // ipbFormIcon
            // 
            this.ipbFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.ipbFormIcon.IconChar = FontAwesome.Sharp.IconChar.House;
            this.ipbFormIcon.IconColor = System.Drawing.Color.White;
            this.ipbFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbFormIcon.Location = new System.Drawing.Point(18, 9);
            this.ipbFormIcon.Margin = new System.Windows.Forms.Padding(0);
            this.ipbFormIcon.Name = "ipbFormIcon";
            this.ipbFormIcon.Size = new System.Drawing.Size(32, 32);
            this.ipbFormIcon.TabIndex = 1;
            this.ipbFormIcon.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExit.Location = new System.Drawing.Point(807, -2);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExit.Size = new System.Drawing.Size(36, 43);
            this.lblExit.TabIndex = 0;
            this.lblExit.Text = "X";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseEnter += new System.EventHandler(this.lblExit_MouseEnter);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            // 
            // panelMainForms
            // 
            this.panelMainForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelMainForms.Controls.Add(this.clock1);
            this.panelMainForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainForms.Location = new System.Drawing.Point(220, 39);
            this.panelMainForms.Name = "panelMainForms";
            this.panelMainForms.Size = new System.Drawing.Size(843, 668);
            this.panelMainForms.TabIndex = 2;
            // 
            // clock1
            // 
            this.clock1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clock1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clock1.BeforeTouchSize = new System.Drawing.Size(336, 336);
            this.clock1.BorderColor = System.Drawing.Color.White;
            this.clock1.ClockFormat = "HH:mm:ss";
            this.clock1.ClockFrame = Syncfusion.Windows.Forms.Tools.ClockFrames.RectangularFrame;
            this.clock1.ClockShape = Syncfusion.Windows.Forms.Tools.ClockShapes.Circle;
            this.clock1.ClockType = Syncfusion.Windows.Forms.Tools.ClockTypes.Digital;
            this.clock1.CurrentDateTime = new System.DateTime(2023, 11, 27, 0, 40, 17, 555);
            this.clock1.CustomTime = new System.DateTime(2024, 6, 26, 21, 37, 15, 595);
            this.clock1.DigitalRenderer = digitalClockRenderer1;
            this.clock1.DisplayDates = true;
            this.clock1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(177)))), ((int)(((byte)(44)))));
            this.clock1.Location = new System.Drawing.Point(248, 142);
            this.clock1.MinimumSize = new System.Drawing.Size(75, 75);
            this.clock1.Name = "clock1";
            this.clock1.Now = new System.DateTime(((long)(0)));
            this.clock1.Remainder = new System.DateTime(2023, 11, 27, 0, 40, 17, 555);
            this.clock1.Renderer = clockRenderer1;
            this.clock1.ShowClockFrame = false;
            this.clock1.ShowCustomTimeClock = false;
            this.clock1.ShowHourDesignator = false;
            this.clock1.Size = new System.Drawing.Size(336, 336);
            this.clock1.StopTimer = false;
            this.clock1.TabIndex = 3;
            this.clock1.Text = "clock1";
            // 
            // timerToggleButton
            // 
            this.timerToggleButton.Interval = 1000;
            this.timerToggleButton.Tick += new System.EventHandler(this.timerToggleButton_Tick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1063, 707);
            this.ControlBox = false;
            this.Controls.Add(this.panelMainForms);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLeft);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.pnlDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggleButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbFormIcon)).EndInit();
            this.panelMainForms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private FontAwesome.Sharp.IconButton ibSchedule;
        private FontAwesome.Sharp.IconButton ibSchedules;
        private FontAwesome.Sharp.IconButton ibChangePassword;
        private FontAwesome.Sharp.IconButton ibDashboard;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Panel panelLeftBtn;
        private FontAwesome.Sharp.IconPictureBox ipbFormIcon;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.Panel panelMainForms;
        private FontAwesome.Sharp.IconPictureBox ipbMinimize;
        private FontAwesome.Sharp.IconPictureBox ipbMaximize;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.ToggleButton toggleButton1;
        private System.Windows.Forms.Panel pnlDropDown;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label lblAgendamentos;
        private System.Windows.Forms.Timer timerToggleButton;
        private Syncfusion.Windows.Forms.Tools.Clock clock1;
        private System.Windows.Forms.Label lblScheduleToday;
        private FontAwesome.Sharp.IconButton ibQuery;
        private FontAwesome.Sharp.IconButton ibRegisterService;
        private FontAwesome.Sharp.IconButton ibRegisterBarber;
        private FontAwesome.Sharp.IconButton ibRegisterClient;
    }
}