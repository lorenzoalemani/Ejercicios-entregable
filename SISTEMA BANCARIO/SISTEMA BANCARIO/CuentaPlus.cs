using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_BANCARIO
{
    public class CuentaPlus : Cuenta
    {
        public CuentaPlus(int num, string nom, double sal, string tip) : base (num, nom, sal)
        {
            
            Tipo = tip;
        }
        public override void Retirar(double monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("El monto debe ser mayor a 0.");
            }
            else
            {
                double comision = monto * 0.025;
                double total = monto + comision;

                if (Saldo >= total)
                {
                    Saldo -= total;
                    Console.WriteLine($"Retiro realizado. Se descontaron ${total} incluyendo comisión.");
                }
                else
                {
                    Console.WriteLine("Operación rechazada: saldo insuficiente.");
                }
            }
        }
    }
}
