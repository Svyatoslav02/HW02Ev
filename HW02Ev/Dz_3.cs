﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HW02Ev
{
    public partial class Dz_3 : Form
    {
        public Dz_3()
        {
            InitializeComponent();
        }

        private void Dz_3_MouseClick(object sender, MouseEventArgs e)
        {
            string txt = "";
            if (e.Button == MouseButtons.Left) {
                if (ModifierKeys == Keys.Control)
                {
                    Close();
                }
                if ((e.X < 10 || e.X > ClientSize.Width - 10) || (e.Y < 10 || e.Y > ClientSize.Height - 10))
                {
                    txt = "Клік зовні прямокутника";
                }
                else if ((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                {
                    txt = "клін на границі прямокутника";
                }
                else
                {
                    txt = "Клік всередині прямокутника";
                }
                MessageBox.Show(txt, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Button == MouseButtons.Right) {
                Text = $"Розмір розмір клієнтської (робочої) області!Ширина:{ClientSize.Width},висота {ClientSize.Height}";
                Thread.Sleep(2000);
            }
        }

        private void Dz_3_MouseMove(object sender, MouseEventArgs e)
        {
            Text= $"X {e.X} - Y {e.Y}";
        }
    }
}
