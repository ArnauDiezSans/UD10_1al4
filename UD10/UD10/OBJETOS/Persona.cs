using System;
using System.Collections.Generic;
using System.Text;

namespace UD10
{
    class Persona
    {
        private string nombre { get; set; }
        private int edad { get; set; }
        private string DNI { get; }
        private char sexo { get; set; }
        private int peso { get; set; }
        private int altura { get; set; }
        private const char s = 'H';
        private const int peso_malo = -1;
        private const int peso_debajo = 0;
        private const int peso_sobre = 1;
        private const string LetraDNI= "TRWAGMYFPDXBNJZSQVHLCKE";
        public string _nombre { get { return nombre;  } set { nombre = value; } }
        public int _edad { get { return edad; } set { edad = value; } }
        public char _sexo { get { return sexo; } set { sexo = value; } }
        public int _peso { get { return peso; } set { peso = value; } }
        public int _altura { get { return altura; } set { altura = value; } }



        public Persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.DNI = GeneraDNI();
            this.sexo = s;
            this.peso = 0;
            this.altura = 0;
        }
        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = GeneraDNI();
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
        }
        public Persona(string nombre, int edad, string DNI, char sexo, int peso, int altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.DNI = DNI;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }
        public int CalcularIMC()
        {
            int resultado = peso_malo;
            if ((this.peso / (Math.Pow(this.altura/100,2))) >= 20)
            {
                resultado = peso_debajo;
            }
            if ((this.peso / (Math.Pow(this.altura/100,2))) >= 26)
            {
                resultado = peso_sobre;
            }
            return resultado;
        }
        public bool EsMayorDeEdad()
        {
            bool E = false;
            if (this.edad > 17)
            {
                E = true;
            }
            return E;
        }
        private void comprobarSexo(char sexo)
        {
            if ((this.sexo == 'H')| (this.sexo == 'M'))
            {
                //ok
            }
            else
            {
                this.sexo = 'H';
                Console.WriteLine("Valor sexo seteado a H por defecto");
            }
        }
        public override string ToString()
        {
            string a="Nombre:"+this.nombre+"\nEdad:" + this.edad + "\nDNI:" + this.DNI + "\nSexo:" + this.sexo + "\nPeso:" + this.peso + "\nAltura:" + this.altura;
            //return base.ToString();
            Console.WriteLine(a);
            return a;
        }
        private string GeneraDNI()
        {
            Random r = new Random();
            int c = r.Next(10000000, 99999999);

            return Convert.ToString(c) + LetraDNI[c % 23];
        }

    }
}
