using System;
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

        private void MostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarVector();
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertir();
            mostrarVector();
        }

        private void cantparesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.cantpares();
            MessageBox.Show("cant. de elementos pares: " + c.ToString() );
        }

        private void ordenarDeMenorAMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.OrdenarMenorAmayor();
            mostrarVector();
        }

        private void eliminarPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt16(txtvalor.Text);
            v.EliminarElementoPos(p);
            mostrarVector();
        }

        private void invertirCadaElementoVectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v.invertirCadaElementoVector();
            mostrarVector();
        }

        private void elementosPrimosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.ElementosPrimo();
            MessageBox.Show("cantidad de elementos primos: " + c.ToString());
        }

        private void elementoCapicuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int c = v.ElementosCapicua();
            MessageBox.Show("cantidad de elemento capicua: " + c.ToString());

        }

   
    }
}
