using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_de_correccion
{
    public class Vehiculo
    {
        public string Marca { get; set; }

        public Vehiculo(string marca)
        {
            Marca = marca;
        }
    }

    public class Auto : Vehiculo
    {
        public int Puertas { get; set; }

        
        public Auto(string marca, int puertas) : base(marca)
        {
            Puertas = puertas;
        }
    }

    

public class Calculadora
    {
        
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        
        public double Sumar(double x, double y)
        {
            return x + y;
        }
    }

    

public class Trabajador
    {
        
        public virtual void RealizarTarea()
        {
            Console.WriteLine("El trabajador hace tareas generales.");
        }
    }

    public class Programador : Trabajador
    {
        
        public override void RealizarTarea()
        {
            Console.WriteLine("El programador escribe código en C#.");
        }
    }

   

public class Termometro
    {
        
        public double Temperatura { get; private set; }

        public Termometro()
        {
            Temperatura = 20.0; 
        }

        public void Actualizar(double lecturaSensor)
        {
           
            if (lecturaSensor >= -50.0 && lecturaSensor <= 100.0)
            {
                Temperatura = lecturaSensor; 
            }
            else
            {
                Console.WriteLine("Error: Lectura extrema ignorada.");
            }
        }
    }
    

public interface INotificable
    {
        void EnviarMensaje(string texto);
        void Resetear();
    }

    
    public class CorreoElectronico : INotificable
    {
        public void EnviarMensaje(string texto)
        {
            Console.WriteLine($"Enviando mail: {texto}");
        }

        
        public void Resetear()
        {
        }
    }
    

public class Motor
    {
        public void Encender() { Console.WriteLine("Encendido!"); }
    }

    public class Coche
    {
        public Motor MotorDelCoche { get; set; }
        public Coche()
        {
            MotorDelCoche = new Motor();
        }
        public void Arrancar()
        {
            MotorDelCoche.Encender();
        }
    }


}
