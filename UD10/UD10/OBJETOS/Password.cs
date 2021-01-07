using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UD10
{
        class Password
        {
            // ATRIBUTOS
            private int longitud { get; set; }
            private string contraseña { get; set; }
            public int _longitud { get { return longitud; } set { longitud = value; } }
            public string _contraseña { get { return contraseña; } set { contraseña = value; } }

            private static Random Aleatorio = new Random();
            const string contraseñaRandom = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789";
            // CONSTRUCTORES
            public Password()
            {
                this.longitud = 8;
                this.contraseña = contraseña;
            }

            public Password(int longitud)
            {
                this.longitud = longitud;
                this.contraseña = new string(Enumerable.Repeat(contraseñaRandom, longitud).Select(s => s[Aleatorio.Next(s.Length)]).ToArray()); // genera una contraseña cogiendo valores aleatorios del string contraseñaRandom
            }

            // METODO
            /*public static void TestPassword()
            {
                Password pass1 = new Password();
                Password pass2 = new Password(14);

                Console.WriteLine("Pass1 (tamaño={0}): {1}", pass1.longitud, pass1.contraseña);
                Console.WriteLine("Pass1 (tamaño={0}): {1}", pass2.longitud, pass2.contraseña);
            }*/
            public static bool EsFuerte(Password P)
        {
            int mayus = 0;
            for (int i = 0; i < P.contraseña.Length; i++)
            {
                if (char.IsUpper(P.contraseña[i])) mayus++;
            }
            int minus = 0;
            for (int i = 0; i < P.contraseña.Length; i++)
            {
                if (char.IsLower(P.contraseña[i])) minus++;
            }
            int digit = 0;
            for (int i = 0; i < P.contraseña.Length; i++)
            {
                if (char.IsDigit(P.contraseña[i])) digit++;
            }

            if ((mayus > 2) && (minus > 1) && (digit > 5))
            {
                return true;
            }
            return false;
        }
        }
    
}
