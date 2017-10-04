using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrayerAlarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Minimized;               //start as minimized
            //this.FormBorderStyle = FormBorderStyle.SizableToolWindow;   //hide from alt tab
            this.ShowInTaskbar = false;                                 //hide from taskbar
        }


        /*******************************************************************************************
         * behavior when window is resized
         * hide form and show icon in system tray if minimized
         * show form and remove icon from system tray if normal
        *******************************************************************************************/
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                Form1_goMinimize();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                Form1_goNormal();
            }
        }

        /*******************************************************************************************
         * behavior when icon in system tray is clicked
         * show form
        *******************************************************************************************/
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }


        /*******************************************************************************************
         * hide form and show icon in system tray if minimized
        *******************************************************************************************/
        public void Form1_goMinimize()
        {
            notifyIcon1.BalloonTipTitle = "Minimize to Tray App";
            notifyIcon1.BalloonTipText = "You have successfully minimized your form.";

            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(500);
            this.Hide();
        }

        /*******************************************************************************************
         * hide notification icon from tray when windows form is normal
        *******************************************************************************************/
        private void Form1_goNormal()
        {
            notifyIcon1.Visible = false;
        }
    }
}
