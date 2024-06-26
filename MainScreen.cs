﻿using FontAwesome.Sharp;
using interdisciplinar2.CustomMessageBoxes;
using interdisciplinar2.Models;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace interdisciplinar2
{
    public partial class MainScreen : Form
    {
        private Form CurrentChildForm;

        private readonly struct RgbColors
        {
            public static readonly Color color1 = Color.FromArgb(225, 177, 44);
            public static readonly Color color2 = Color.FromArgb(47, 53, 66);
            public static readonly Color color3 = Color.FromArgb(253, 138, 114);
            public static readonly Color color4 = Color.FromArgb(95, 77, 221);

        }

        public MainScreen()
        {
            InitializeComponent();

            switch (ProgramTheme.GetTheme())
            {
                case "dark":
                    toggleButton1.ToggleState = ToggleButtonState.Active;
                    break;

                case "light":
                    toggleButton1.ToggleState = ToggleButtonState.Inactive;
                    break;
            }

            this.DoubleBuffered = true;
        }

        private void OpenChildForm(Form childForm)
        {
            CurrentChildForm?.Close();

            CurrentChildForm = childForm;

            if (ProgramTheme.GetTheme() == "light")
            {
                childForm.BackColor = ProgramTheme.LightThemeBackColor;
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelMainForms.Controls.Add(childForm);
            panelMainForms.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void ClickedBtn(IconButton btn)
        {
            UnclickBtn();

            btn.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn.TextAlign = ContentAlignment.MiddleRight;

            panelLeftBtn.Location = new Point(0, btn.Location.Y);
            panelLeftBtn.Visible = true;
        }

        private void UnclickBtn()
        {
            if (pnlDropDown.Visible == true)
            {
                pnlDropDown.Visible = false;

                ibDashboard.Dock = DockStyle.Top;
                ibChangePassword.Dock = DockStyle.Top;
                ibRegisterBarber.Dock = DockStyle.Top;
                ibQuery.Dock = DockStyle.Top;
                ibRegisterClient.Dock = DockStyle.Top;
                ibRegisterService.Dock = DockStyle.Top;
            }

            if (ibSchedule.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                ibSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
                ibSchedule.IconColor = Color.White;
                panelLeftBtn.Visible = false;
            }
            else if (ibSchedules.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                ibSchedules.TextImageRelation = TextImageRelation.ImageBeforeText;
                ibSchedules.IconColor = Color.White;
                panelLeftBtn.Visible = false;
            }
            else if (ibDashboard.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                ibDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
                ibDashboard.IconColor = Color.White;
                panelLeftBtn.Visible = false;
            }
            else if (ibChangePassword.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                ibChangePassword.TextImageRelation = TextImageRelation.ImageBeforeText;
                ibChangePassword.IconColor = Color.White;
                panelLeftBtn.Visible = false;
            }
            else if (ibQuery.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                ibQuery.TextImageRelation = TextImageRelation.ImageBeforeText;
                ibQuery.IconColor = Color.White;
                panelLeftBtn.Visible = false;
            }
            else if (ibRegisterBarber.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                ibRegisterBarber.TextImageRelation = TextImageRelation.ImageBeforeText;
                ibRegisterBarber.IconColor = Color.White;
                panelLeftBtn.Visible = false;
            }
            else if (ibRegisterService.TextImageRelation == TextImageRelation.TextBeforeImage)
            {
                ibRegisterService.TextImageRelation = TextImageRelation.ImageBeforeText;
                ibRegisterService.IconColor = Color.White;
                panelLeftBtn.Visible = false;
            }
            else
            {
                ibRegisterClient.TextImageRelation = TextImageRelation.ImageBeforeText;
                ibRegisterClient.IconColor = Color.White;
                panelLeftBtn.Visible = false;
            }

            
            }

        private void IconFormName(IconButton btn)
        {
            ipbFormIcon.IconChar = btn.IconChar;
            ipbFormIcon.IconColor = btn.IconColor;

            lblFormName.Text = btn.Text;
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.Red;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.BackColor = Color.Transparent;
        }

        private void BtnMouseEnter(IconButton btn)
        {
            btn.BackColor = RgbColors.color1;
        }

        private void BtnMouseLeave(IconButton btn)
        {
            btn.BackColor = RgbColors.color2;
        }

        private void ibSchedule_Click(object sender, EventArgs e)
        {
            panelLeftBtn.BackColor = RgbColors.color1;
            ClickedBtn(ibSchedule);
            ibSchedule.IconColor = RgbColors.color1;

            OpenChildForm(new AgendamentosScreen());

            IconFormName(ibSchedule);
        }

        private void ibSchedule_MouseEnter(object sender, EventArgs e)
        {
            BtnMouseEnter(ibSchedule);
        }

        private void ibSchedule_MouseLeave(object sender, EventArgs e)
        {
            BtnMouseLeave(ibSchedule);
        }

        private void ibSchedules_MouseEnter(object sender, EventArgs e)
        {
            BtnMouseEnter(ibSchedules);
        }

        private void ibSchedules_MouseLeave(object sender, EventArgs e)
        {
            BtnMouseLeave(ibSchedules);
        }

        private void ibSchedules_Click(object sender, EventArgs e)
        {
            panelLeftBtn.BackColor = RgbColors.color1;
            ClickedBtn(ibSchedules);
            ibSchedules.IconColor = RgbColors.color1;

            pnlDropDown.Visible = true;
            pnlDropDown.Location = new Point(0, ibSchedules.Location.Y + 50);

            ibDashboard.Dock = DockStyle.None;
            ibChangePassword.Dock = DockStyle.None;
            ibQuery.Dock = DockStyle.None;
            ibRegisterBarber.Dock = DockStyle.None;
            ibRegisterService.Dock = DockStyle.None;
            ibRegisterClient.Dock = DockStyle.None;

            ibDashboard.Location = new Point(0, pnlDropDown.Location.Y + 70);
            ibChangePassword.Location = new Point(0, ibDashboard.Location.Y + 70);
            ibQuery.Location = new Point(0, ibChangePassword.Location.Y + 70);
            ibRegisterBarber.Location = new Point(0, ibQuery.Location.Y + 70);
            ibRegisterService.Location = new Point(0, ibRegisterBarber.Location.Y + 70);
            ibRegisterClient.Location = new Point(0, ibRegisterService.Location.Y + 70);


            IconFormName(ibSchedules);
        }

        private void ibDashboard_MouseEnter(object sender, EventArgs e)
        {
            BtnMouseEnter(ibDashboard);
        }

        private void ibDashboard_MouseLeave(object sender, EventArgs e)
        {
            BtnMouseLeave(ibDashboard);
        }

        private void ibChangePassword_MouseEnter(object sender, EventArgs e)
        {
            BtnMouseEnter(ibChangePassword);
        }

        private void ibChangePassword_MouseLeave(object sender, EventArgs e)
        {
            BtnMouseLeave(ibChangePassword);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
                CurrentChildForm = null;
            }

            UnclickBtn();
            panelLeftBtn.Visible = false;

            ipbFormIcon.IconChar = IconChar.Home;
            ipbFormIcon.IconColor = Color.White;

            lblFormName.Text = "Home";
        }

        private void ibDashboard_Click(object sender, EventArgs e)
        {
            panelLeftBtn.BackColor = RgbColors.color1;
            ClickedBtn(ibDashboard);
            ibDashboard.IconColor = RgbColors.color1;

            OpenChildForm(new DashboardScreen());

            IconFormName(ibDashboard);
        }

        private void ibChangePassword_Click(object sender, EventArgs e)
        {
            panelLeftBtn.BackColor = RgbColors.color1;
            ClickedBtn(ibChangePassword);
            ibChangePassword.IconColor = RgbColors.color1;

            OpenChildForm(new ChangePasswordScreen());

            IconFormName(ibChangePassword);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern IntPtr SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ipbMaximize_MouseLeave(object sender, EventArgs e)
        {
            ipbMaximize.BackColor = Color.Transparent;
        }

        private void ipbMinimize_MouseLeave(object sender, EventArgs e)
        {
            ipbMinimize.BackColor = Color.Transparent;
        }

        private void ipbMaximize_MouseEnter(object sender, EventArgs e)
        {
            ipbMaximize.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void ipbMinimize_MouseEnter(object sender, EventArgs e)
        {
            ipbMinimize.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void ipbMaximize_Click(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    WindowState = FormWindowState.Maximized;
                    break;

                case FormWindowState.Maximized:
                    WindowState = FormWindowState.Normal;
                    break;
            }
        }

        private void ipbMinimize_Click(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    WindowState = FormWindowState.Minimized;
                    break;

                case FormWindowState.Maximized:
                    WindowState = FormWindowState.Minimized;
                    break;
            }
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            switch (ProgramTheme.GetTheme())
            {
                case "light":
                    panelMainForms.BackColor = ProgramTheme.LightThemeBackColor;
                    clock1.BorderColor = Color.Black;
                    break;

                case "dark":
                    panelMainForms.BackColor = ProgramTheme.DarkThemeBackColor;
                    clock1.BorderColor = Color.White;
                    break;
            }
        }

        private void toggleButton1_Click(object sender, EventArgs e)
        {
            timerToggleButton.Start();

            toggleButton1.Enabled = false;

            System.Threading.Timer timer = new System.Threading.Timer(state =>
            {
                if (toggleButton1.ToggleState != ToggleButtonState.Active)
                {
                    ProgramTheme.SetTheme("light");

                    panelMainForms.BackColor = Color.White;

                    clock1.BorderColor = Color.Black;
                }
                else if (toggleButton1.ToggleState != ToggleButtonState.Inactive)
                {
                    ProgramTheme.SetTheme("dark");

                    panelMainForms.BackColor = ProgramTheme.DarkThemeBackColor;

                    clock1.BorderColor = Color.White;
                }
            }, null, 0, 100);
        }

        private void toggleButton1_ToggleStateChanged(object sender, ToggleStateChangedEventArgs e)
        {
            if (CurrentChildForm != null)
            {
                if (CurrentChildForm is AgendamentosScreen)
                    OpenChildForm(new AgendamentosScreen());
                else if (CurrentChildForm is SchedulesScreen)
                    OpenChildForm(new SchedulesScreen());
                else if (CurrentChildForm is HistoricScreen)
                    OpenChildForm(new HistoricScreen());
                else if (CurrentChildForm is DashboardScreen)
                    OpenChildForm(new DashboardScreen());
                else if (CurrentChildForm is ChangePasswordScreen)
                    OpenChildForm(new ChangePasswordScreen());
                else if (CurrentChildForm is Queries)
                    OpenChildForm(new Queries());
                else if (CurrentChildForm is RegisterBarbers)
                    OpenChildForm(new RegisterBarbers());
                else if (CurrentChildForm is RegisterClients)
                    OpenChildForm(new RegisterClients());
                else if (CurrentChildForm is RegisterServices)
                    OpenChildForm(new RegisterServices());
                else if(CurrentChildForm is SchedulesToday)
                    OpenChildForm(new SchedulesToday());
            }
        }

        private void lblAgendamentos_MouseEnter(object sender, EventArgs e)
        {
            lblAgendamentos.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void lblAgendamentos_MouseLeave(object sender, EventArgs e)
        {
            lblAgendamentos.BackColor = Color.Transparent;
        }

        private void lblHistorico_MouseEnter(object sender, EventArgs e)
        {
            lblHistorico.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void lblHistorico_MouseLeave(object sender, EventArgs e)
        {
            lblHistorico.BackColor = Color.Transparent;
        }

        private void lblAgendamentos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SchedulesScreen());

            UnclickBtn();

            ClickedBtn(ibSchedules);
            ibSchedules.IconColor = RgbColors.color1;

            lblFormName.Text = "Agendamentos Futuros";
        }

        private void lblHistorico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HistoricScreen());

            UnclickBtn();

            ClickedBtn(ibSchedules);
            ibSchedules.IconColor = RgbColors.color2;

            lblFormName.Text = "Histórico";
        }

        private void timerToggleButton_Tick(object sender, EventArgs e)
        {
            toggleButton1.Enabled = true;

            timerToggleButton.Stop();
        }

        private void lblScheduleToday_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SchedulesToday());

            UnclickBtn();

            ClickedBtn(ibSchedules);
            ibSchedules.IconColor = RgbColors.color2;

            lblFormName.Text = "Agendamentos de hoje";
        }

        private void lblScheduleToday_MouseLeave(object sender, EventArgs e)
        {
            lblScheduleToday.BackColor = Color.Transparent;
        }

        private void lblScheduleToday_MouseEnter(object sender, EventArgs e)
        {
            lblScheduleToday.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void ibQuery_Click(object sender, EventArgs e)
        {
            panelLeftBtn.BackColor = RgbColors.color1;
            ClickedBtn(ibQuery);
            ibQuery.IconColor = RgbColors.color1;

            OpenChildForm(new Queries());

            IconFormName(ibQuery);
        }

        private void ibQuery_MouseEnter(object sender, EventArgs e)
        {    
            BtnMouseEnter(ibQuery);
        }

        private void ibQuery_MouseLeave(object sender, EventArgs e)
        {
            BtnMouseLeave(ibQuery);
        }

        private void ibRegisterBarber_Click(object sender, EventArgs e)
        {
            panelLeftBtn.BackColor = RgbColors.color1;
            ClickedBtn(ibRegisterBarber);
            ibRegisterBarber.IconColor = RgbColors.color1;

            OpenChildForm(new RegisterBarbers());

            IconFormName(ibRegisterBarber);
        }

        private void ibRegisterBarber_MouseEnter(object sender, EventArgs e)
        {
            BtnMouseEnter(ibRegisterBarber);
        }

        private void ibRegisterBarber_MouseLeave(object sender, EventArgs e)
        {
            BtnMouseLeave(ibRegisterBarber);
        }

        private void ibRegisterService_Click(object sender, EventArgs e)
        {
            panelLeftBtn.BackColor = RgbColors.color1;
            ClickedBtn(ibRegisterService);
            ibRegisterService.IconColor = RgbColors.color1;

            OpenChildForm(new RegisterServices());

            IconFormName(ibRegisterService);
        }

        private void ibRegisterService_MouseEnter(object sender, EventArgs e)
        {
            BtnMouseEnter(ibRegisterService);
        }

        private void ibRegisterService_MouseLeave(object sender, EventArgs e)
        {
            BtnMouseLeave(ibRegisterService);
        }

        private void ibRegisterClient_Click(object sender, EventArgs e)
        {
            panelLeftBtn.BackColor = RgbColors.color1;
            ClickedBtn(ibRegisterClient);
            ibRegisterClient.IconColor = RgbColors.color1;

            OpenChildForm(new RegisterClients());

            IconFormName(ibRegisterClient);
        }

        private void ibRegisterClient_MouseEnter(object sender, EventArgs e)
        {
            BtnMouseEnter(ibRegisterClient);
        }

        private void ibRegisterClient_MouseLeave(object sender, EventArgs e)
        {
            BtnMouseLeave(ibRegisterClient);
        }
    }
}