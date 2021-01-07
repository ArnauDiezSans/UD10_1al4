using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    class Lavadora : Electrodomestico
    {
        private int Carga { get; set; }
        public int _Carga { get { return Carga; } set { Carga = value; } }
        public const int ConstCarga = 5;

        public Lavadora()
        {
            _Color = ConstColor;
            _Consumo = ConstConsumo;
            _PrecioBase = ConstPrecio;
            _Peso = ConstPeso;
            _Carga = ConstCarga;
        }
        public Lavadora(int Pr, int Pe)
        {
            _Color = ConstColor;
            _Consumo = ConstConsumo;
            _PrecioBase = Pr;
            _Peso = Pe;
            _Carga = ConstCarga;
        }
        public Lavadora(int Ca, int Pr, int Pe, char Con, string Col) /*: base (Pr, Pe, Con, Col)*/
        {
            _Color = Col;
            _Consumo = Con;
            _PrecioBase = Pr;
            _Peso = Pe;
            _Carga = Ca;
        }
        public int precioFinal()
        {
            if (_Carga > 30)
            {
               return _PrecioBase = base.PrecioFinal() + 50;
            }
            else
            {
               return _PrecioBase = base.PrecioFinal();
            }
        }
        public new string ToString()
        {
            //string a = "Tipo:" + this.GetType().Name + "\nPrecioBase:" + this._PrecioBase + "\nColor:" + this._Color + "\nConsumo:" + this._Consumo + "\nPeso:" + this._Peso;
            string a=  base.ToString()+"\nCarga:"+this._Carga;
            Console.WriteLine(a);
            return a;
        }
    }
}
