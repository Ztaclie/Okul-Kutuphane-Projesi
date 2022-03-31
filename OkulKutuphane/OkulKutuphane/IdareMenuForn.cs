﻿using OkulKutuphane.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OkulKutuphane
{
    public partial class IdareMenuForn : Form
    {
        public IdareMenuForn()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IdareKitapAraPctbx_Click(object sender, EventArgs e)
        {
            IdareKitapAra idr = new IdareKitapAra();
            idr.Show();
            Hide();
        }

        private void StokIslemleriPctbx_Click(object sender, EventArgs e)
        {
            IdareStokIslemleri idr = new IdareStokIslemleri();
            idr.Show();
            Hide();
        }

        private void KitapEmanetPctbx_Click(object sender, EventArgs e)
        {
            KitapEmanet idr = new KitapEmanet();
            idr.Show();
            Hide();
        }
    }
}
