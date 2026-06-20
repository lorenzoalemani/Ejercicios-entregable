using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SISTEMA_BANCARIO;
namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Cuenta> lista = new List<Cuenta> ();
            Console.WriteLine("¡Bienvenido!");
            int opcion = 0;

            while (true)
            {
                Console.WriteLine("\n--- SISTEMA GESTIÓN Bancario ---");
                Console.WriteLine("1. crear una cuenta");
                Console.WriteLine("2. realizar una operacion");
                Console.WriteLine("3. consultar una cuenta ");
                Console.WriteLine("4. mostrar todas las cuentas");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                // Si elige la opción de salida, salir.
                if (opcion == 5)
                {
                    break;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("que tipo de cuenta quiere crear? 1 = estandar  | |   2 = Plus");
                        int tipo = int.Parse(Console.ReadLine());

                        Console.WriteLine("ingrese el numero de cuenta");
                        int numero = int.Parse(Console.ReadLine());
                        bool existe = false;
                        foreach(Cuenta cuenta in lista)
                        {
                            if(cuenta.NumCuenta == numero)
                            {
                                Console.WriteLine("ese numero de cuenta ya existe. haz todo de nuevo");
                                
                                existe = true;
                            }
                            
                        }
                        if (existe == false)
                        {
                            Console.WriteLine("ingrese el nombre del titular");
                            string nombre = Console.ReadLine();

                            Console.WriteLine("ingrese su saldo incial");
                            double saldo = int.Parse(Console.ReadLine());
                            if(saldo >= 0)
                            {
                                if (tipo == 1)
                                {
                                    string tipoo = "estandar";
                                    cuentaestandar cuentilla = new cuentaestandar(numero, nombre, saldo, tipoo);
                                    lista.Add(cuentilla);
                                }
                                else if (tipo == 2)
                                {
                                    string tipoo = "plus";
                                    CuentaPlus cuentaza = new CuentaPlus(numero, nombre, saldo, tipoo);
                                    lista.Add(cuentaza);
                                }
                            }
                            else
                            {
                                Console.WriteLine("indicar un saldo que sea 0 o mayor");
                                break;
                            }
                            
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("que operacion quiere hacer? 1 = depositar ||  2 = retirar");
                        int operacion = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el monto con el q va a operar");
                        double monto = int.Parse(Console.ReadLine());
                        if(operacion == 1)
                        {
                            Console.WriteLine("ingrese el numero de cuenta con la que quiere operar");
                            int numerobuscar = int.Parse(Console.ReadLine());
                            foreach(Cuenta cuenta in lista)
                            {
                                if(cuenta.NumCuenta == numerobuscar)
                                {
                                    cuenta.Depositar(monto);
                                }
                                else
                                {
                                    Console.WriteLine("no se encontro la cuenta");

                                }
                            }
                        }
                        else if( operacion == 2)
                        {
                            Console.WriteLine("ingrese el numero de cuenta con la que quiere operar");
                            int numerobuscar = int.Parse(Console.ReadLine());
                            foreach(Cuenta cuenta in lista)
                            {
                                if(cuenta.NumCuenta == numerobuscar && cuenta.Tipo == "estandar")
                                {
                                        
                                        cuenta.Retirar(monto);
                                    break;
                                   
                                } 
                                else if(cuenta.NumCuenta == numerobuscar && cuenta.Tipo == "plus")
                                {
                                    
                                        cuenta.Retirar(monto);
                                    break;
                                   
                                    
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("ingrese el numero de cuenta a consultar");
                        int numeroconsulta = int.Parse(Console.ReadLine());
                        foreach( Cuenta cuenta in lista)
                        {
                            if (cuenta.NumCuenta == numeroconsulta)
                            {
                                Console.WriteLine($"NUMERO CUENTA{cuenta.NumCuenta} || TITULAR : {cuenta.Nombre} || TIPO CUENTA:{cuenta.Tipo} || SALDO: {cuenta.Saldo}");
                            }
                            else { Console.WriteLine("cuenta no encontrada");
                                break;
                            }
                        }

                        
                        break;
                    case 4:
                        foreach(Cuenta cuenta in lista)
                        {
                            Console.WriteLine($"NUMERO CUENTA{cuenta.NumCuenta} || TITULAR : {cuenta.Nombre} || TIPO CUENTA:{cuenta.Tipo} || SALDO: {cuenta.Saldo}");
                        }
                        break;
                }
            }

            Console.WriteLine("Cierre SISTEMA GESTION BANCARIA");
        }

    }
}

