﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vector
{
    public partial class Form1 : Form
    {
        // creando una intalacion de mi class Vector
        ClsVerctor v = new ClsVerctor();
        public Form1()
        {
            InitializeComponent();
        }
        private void mostrarVector() {
            lbResultado.Text = "[";
            for (int i = 0; i < v.longitud(); i++) {
                lbResultado.Text = lbResultado.Text + v.obtenervalor(i) + ",";
            }
            lbResultado.Text = lbResultado.Text + "]";
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(txtvalor.Text);
            v.adicionar(x);
            mostrarVector();
        }
    }
}
