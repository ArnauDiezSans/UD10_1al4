using System;

namespace UD10
{
    class Program
    {
        public static void Ejercicio1()
        {
            Cuenta C1 = new Cuenta("Arnau",1000);
            //C1.Titular = "Arnau";
            //C1.Cantidad = 1000;
            Console.WriteLine(C1.ToString());
            C1.Ingresar(100);
            C1.Retirar(50);
            Console.WriteLine(C1.ToString());
        }
        public static void Ejercicio2()
        {        
            Persona P1 = new Persona();
            Console.WriteLine("Introduce el nombre de la Persona 1:");
            P1._nombre = Console.ReadLine();
            Console.WriteLine("Introduce la edad de la Persona 1:");
            P1._edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el sexo de la Persona 1:");
            P1._sexo = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Introduce el peso de la Persona 1:");
            P1._peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la altura de la Persona 1:");
            P1._altura = Convert.ToInt32(Console.ReadLine());

            Persona P2 = new Persona(P1._nombre, P1._edad, P1._sexo);
            P2._altura = 180;
            P2._peso = 100;

            Persona P3 = new Persona();
            P3._nombre = "Arnau";
            P3._edad = 33;
            P3._sexo = 'H';
            P3._peso = 93;
            P3._altura = 160;
            int i= P1.CalcularIMC();
            switch (i) 
            {
                case 0:
                    Console.WriteLine("Persona 1 esta en su peso ideal");
                    break;
                case 1:
                    Console.WriteLine("Persona 1 esta por encima de su peso ideal");
                    break;
                default:
                    Console.WriteLine("Persona 1 esta por debajo de su peso ideal");
                    break;
            }
            i = P2.CalcularIMC();
            switch (i)
            {
                case 0:
                    Console.WriteLine("Persona 2 esta en su peso ideal");
                    break;
                case 1:
                    Console.WriteLine("Persona 2 esta por encima de su peso ideal");
                    break;
                default:
                    Console.WriteLine("Persona 2 esta por debajo de su peso ideal");
                    break;
            }
            i = P3.CalcularIMC();
            switch (i)
            {
                case 0:
                    Console.WriteLine("Persona 3 esta en su peso ideal");
                    break;
                case 1:
                    Console.WriteLine("Persona 3 esta por encima de su peso ideal");
                    break;
                default:
                    Console.WriteLine("Persona 3 esta por debajo de su peso ideal");
                    break;
            }
            if (P1.EsMayorDeEdad())
            {
                Console.WriteLine("Persona 1 es mayor de edad");
            }
            else
            {
                Console.WriteLine("Persona 1 es menor de edad");
            }
            if (P2.EsMayorDeEdad())
            {
                Console.WriteLine("Persona 2 es mayor de edad");
            }
            else
            {
                Console.WriteLine("Persona 2 es menor de edad");
            }
            if (P3.EsMayorDeEdad())
            {
                Console.WriteLine("Persona 3 es mayor de edad");
            }
            else
            {
                Console.WriteLine("Persona 3 es menor de edad");
            }
            P1.ToString();
            P2.ToString();
            P3.ToString();
        }
        public static void Ejercicio3()
        {
            Console.WriteLine("Introduce el tamaño del array");
            int TamañoArray = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el tamaño de los passwords:");
            int TamañoPass = Convert.ToInt32(Console.ReadLine());
            Password[] Libreta = new Password[TamañoArray];
            bool[] LibretaFuerte = new bool[TamañoArray];
            for(int i = 0; i < TamañoArray; i++)
            {
                Libreta[i] = new Password(TamañoPass);
                LibretaFuerte[i] = Password.EsFuerte(Libreta[i]);
                Console.WriteLine("Pass{2} (Tamaño={0}): {1} EsFuerte:{3}", Libreta[i]._longitud, Libreta[i]._contraseña,i+1,LibretaFuerte[i]);
            }
        }
        public static void Ejercicio4()
        {
            
            Electrodomestico A = new Electrodomestico(299, 11, 'C', "rojo");
            //Tienda[0] = A;
            Television B = new Television(false, 60, 599, 25, 'A', "gris");
            //Tienda[1] = B;
            Lavadora C = new Lavadora(9, 399, 60, 'D', "negro");
            //Tienda[2] = C;
            Electrodomestico D = new Electrodomestico(299, 11, 'C', "rojo");
            //Tienda[3] = D;
            Television E = new Television(false, 60, 599, 25, 'A', "gris");
            //Tienda[4] = E;
            Lavadora F = new Lavadora(9, 399, 60, 'D', "negro");
            //Tienda[5] = F;
            Electrodomestico G = new Electrodomestico(299, 11, 'C', "rojo");
            //Tienda[6] = G;
            Television H = new Television(false, 60, 599, 25, 'A', "gris");
            //Tienda[7] = H;
            Lavadora I = new Lavadora(9, 399, 60, 'D', "negro");
            //Tienda[8] = I;
            Electrodomestico J = new Electrodomestico(299, 11, 'C', "rojo");
            //Tienda[9] = J;
            Object[] Tienda = new Object[10] { A, B, C, D, E, F, G, H, I, J };
           
            int PrecioElectrodomesticos = 0, PrecioLavadoras = 0, PrecioTelevisores = 0;
            Television T;
            Lavadora L;
            Electrodomestico EE;
            foreach (Object x in Tienda)
            {
                 EE= (Electrodomestico)x;
                if (x.GetType().Name == "Television")
                {
                    T = (Television)x;
                    PrecioTelevisores = PrecioTelevisores + T.PrecioFinal();
                    T.ToString();
                }
                if (x.GetType().Name == "Lavadora")
                {
                    L = (Lavadora)x;
                    PrecioLavadoras = PrecioLavadoras + L.PrecioFinal();
                    L.ToString();
                }
                if (x.GetType().Name == "Electrodomestico")
                {
                    EE.ToString();
                }
                PrecioElectrodomesticos = PrecioElectrodomesticos + E.PrecioFinal();
            }
            Console.WriteLine("TOTAL:" + PrecioElectrodomesticos + " Lavadoras:" + PrecioLavadoras + " Televisores:" + PrecioTelevisores);

            

        }
        static void Main(string[] args)
        {
            //Ejercicio1();
            //Ejercicio2();
            //Ejercicio3();
            Ejercicio4();
        }
    }
}
