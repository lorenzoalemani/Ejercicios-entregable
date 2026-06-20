using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_BANCARIO
{
    public abstract class Cuenta
    {
        public int NumCuenta { get; private set; }
        public string Nombre { get; private set; }
        public double Saldo { get; protected set; }
        public string Tipo  { get; set;}
        protected Cuenta(int num, string nom, double sal)
        {
            NumCuenta = num;
            Nombre = nom;
            Saldo = sal;
        }

        public void Depositar (double deposito)
        {
            Saldo += deposito;
        }
        public virtual void Retirar (double retiro)
        {
            Saldo -= retiro;
        }
    }
}
