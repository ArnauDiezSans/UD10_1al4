using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    class Cuenta
    {
        public string Titular { get; set; }
        public double Cantidad { get; set; }

        public Cuenta (string T)
        {
            this.Titular = T;
        }
        public Cuenta(string T, double C)
        {
            this.Titular = T;
            this.Cantidad = C;
        }
        public override string ToString()
        {
            string s="Titular: "+this.Titular+"\nCuenta: "+this.Cantidad;
            return s;
        }
        public void Ingresar (double cantidad)
        {
            if (cantidad > 0)
            {
                this.Cantidad = this.Cantidad + cantidad;
            }
        }
        public void Retirar (double cantidad)
        {
            this.Cantidad = this.Cantidad - cantidad;
            if (this.Cantidad < 0)
            {
                this.Cantidad = 0;
            }
        }
    }
}
