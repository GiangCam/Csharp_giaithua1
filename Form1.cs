﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_giaithua1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double so = Convert.ToDouble(txtso.Text);
            long giaithua = 1;
            for (int i = 1; i <= so; i++) 
            {
                giaithua *= i;
            }
            txtgiaithua.Text = giaithua.ToString(); 
        }
    }
}