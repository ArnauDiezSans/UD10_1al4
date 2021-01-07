using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    class Television : Electrodomestico
    {
        private int Resolucion { get; set; }
        public int _Resolucion { get { return Resolucion; } set { Resolucion = value; } }
        private bool SintonizadorTDT { get; set; }
        public bool _SintonizadorTDT { get { return SintonizadorTDT; } set { SintonizadorTDT = value; } }

        public Television()
        {
            _Color = ConstColor;
            _Consumo = ConstConsumo;
            _PrecioBase = ConstPrecio;
            _Peso = ConstPeso;
            _Resolucion = 20;
            _SintonizadorTDT = false;
        }
        public Television(int Pr, int Pe)
        {
            _Color = ConstColor;
            _Consumo = ConstConsumo;
            _PrecioBase = Pr;
            _Peso = Pe;
            _Resolucion = 20;
            _SintonizadorTDT = false;
        }
        public Television(bool stdt, int Re, int Pr, int Pe, char Con, string Col) /*: base (Pr, Pe, Con, Col)*/
        {
            _Color = Col;
            _Consumo = Con;
            _PrecioBase = Pr;
            _Peso = Pe;
            _Resolucion = Re;
            _SintonizadorTDT = stdt;
        }
        public int precioFinal()
        {
            int auxi = 0;
            if (_Resolucion > 40)
            {
                _PrecioBase = (int)(base.PrecioFinal()*1.3);
                auxi = 1;
            }
            if (_SintonizadorTDT) 
            {
                if (auxi == 1)
                {
                    _PrecioBase = _PrecioBase + 50;
                }
                else
                {
                    _PrecioBase = base.PrecioFinal() + 50;
                }
            }
            return _PrecioBase;
        }
        public new string ToString()
        {
            //string a = "Tipo:" + this.GetType().Name + "\nPrecioBase:" + this._PrecioBase + "\nColor:" + this._Color + "\nConsumo:" + this._Consumo + "\nPeso:" + this._Peso;
            string a = base.ToString() + "\nResolucion:" + this._Resolucion+"\nTDT:"+this._SintonizadorTDT;
            Console.WriteLine(a);
            return a;
        }
    }
}
