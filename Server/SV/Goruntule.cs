﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SV
{
    public partial class Goruntule : Form
    {
        public Goruntule(string baslik, string icerik)
        {
            InitializeComponent();
            Text = "Şu kişinin SMS'ini okuyorsunuz: " + baslik;
            richTextBox1.Text = icerik;
        }
    }
}
