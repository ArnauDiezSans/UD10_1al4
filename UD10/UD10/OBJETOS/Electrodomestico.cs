using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    class Electrodomestico
    {
        private int PrecioBase;
        public int _PrecioBase { get { return PrecioBase; } set { PrecioBase = value; } }
        private string Color;
        public string _Color { get { return Color; } set { Color = value; } }
        private char Consumo;
        public char _Consumo { get { return Consumo; } set { Consumo = value; } }
        private int Peso;
        public int _Peso { get { return Peso; } set { Peso = value; } }
        protected const string ConstColor = "blanco";
        protected const char ConstConsumo = 'F';
        protected const int ConstPrecio = 100;
        protected const int ConstPeso = 5;


        public Electrodomestico()
        {
            _Color = ConstColor;
            _Consumo = ConstConsumo;
            _PrecioBase = ConstPrecio;
            _Peso = ConstPeso;
        }
        public Electrodomestico(int Pr, int Pe)
        {
            _Color = ConstColor;
            _Consumo = ConstConsumo;
            _PrecioBase = Pr;
            _Peso = Pe;
        }
        public Electrodomestico(int Pr, int Pe, char Con, string Col)
        {
            _Color = Col;
            _Consumo = Con;
            _PrecioBase = Pr;
            _Peso = Pe;
        }
        public char ValidarConsumo(char c)
        {
            if ((c == 'A') | (c == 'B') | (c == 'C') | (c == 'D') | (c == 'E') | (c == 'F'))
            {
                return c;
            }
            else
            {
                Console.WriteLine("Consumo incorrecto. Valor por defecto 'F'");
                return ConstConsumo;
            }
        }
        public string ValidarColor(string c)
        {
            if ((c == "blanco") | (c == "negro") | (c == "rojo") | (c == "azul") | (c == "gris"))
            {
                return c;
            }
            else
            {
                Console.WriteLine("Color incorrecto. Valor por defecto 'blanco'");
                return ConstColor;
            }
        }
        public int PrecioFinal()
        {
            int BonusConsumo=0, BonusPeso=0;
            this.Consumo = ValidarConsumo(this._Consumo);
            switch (this._Consumo)
            {
                case 'A':
                    BonusConsumo = 100;
                    break;
                case 'B':
                    BonusConsumo = 80;
                    break;
                case 'C':
                    BonusConsumo = 60;
                    break;
                case 'D':
                    BonusConsumo = 50;
                    break;
                case 'E':
                    BonusConsumo = 30;
                    break;
                case 'F':
                    BonusConsumo = 10;
                    break;
            }
            if (this._Peso<20)
            {
                BonusPeso = 10;
            }
            else
            {
                if (this._Peso < 50)
                {
                    BonusPeso = 50;
                }
                else
                {
                    if (this._Peso < 80)
                    {
                        BonusPeso = 80;
                    }
                    else
                    {
                        BonusPeso = 100;
                    }
                }
            }
            this._PrecioBase = this._PrecioBase + BonusPeso + BonusConsumo;
            return this.PrecioBase;
        }
        public new string ToString()
        {
            string a = "Tipo:" + this.GetType().Name + "\nPrecioBase:" + this._PrecioBase + "\nColor:" + this._Color + "\nConsumo:" + this._Consumo + "\nPeso:" + this._Peso;
            //return base.ToString();
            if (this.GetType().Name == "Electrodomestico")
            {
                Console.WriteLine(a);
            }
            return a;
        }
    }
}
