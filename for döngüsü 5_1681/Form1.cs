﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngüsü_5_1681
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbSayilar.Items.Clear();
            int sayi1 = Convert.ToInt32(txtBaslangic.Text);
            int sayi2 = Convert.ToInt32(txtBitir.Text);
            int sayi3 = Convert.ToInt32(txtDegisim.Text);
            for(int i = sayi1;i <= sayi2; i = i + sayi3)
            {
                lbSayilar.Items.Add(i);
            }
        }
    }
}
