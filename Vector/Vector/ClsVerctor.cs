using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vector
{
    class ClsVerctor
    {
        // Propiedades del Vector
        private int[] Vector;
        private int lg;

        // Contructor ->Inicia las propiedades
        public ClsVerctor()
        {
            Vector = new int[100];
            lg = 0;
        }
        // Metodos (propiedades o funciones)
        public void adicionar(int valor)
        {
            Vector[lg] = valor;
            lg = lg + 1;
        }
        // obtener el valor en la posicion p
        public int obtenervalor(int pos) {
            return Vector[pos];
        }
        // longitud del vector
        public int longitud() {
            return lg;
        }
    }
}
