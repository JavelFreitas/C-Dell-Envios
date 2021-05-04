using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    class Conta
    {
        public int numeroConta;
        public float saldo;
        public Cliente cliente;
        public void CriarConta(int novoNumero, float novoSaldo, Cliente novoCliente)
        {
            numeroConta = novoNumero;
            saldo = novoSaldo;
            cliente = novoCliente;
        }

        public void Depositar(float acrescimoSaldo)
        {
            saldo += acrescimoSaldo;
            Console.WriteLine($"{acrescimoSaldo} adicionado na conta.");
        }

        public bool Sacar(float saqueSaldo)
        {
            if((saldo - saqueSaldo) <= 0)
            {
                return false;
            }
            return true;
        }

    }
}
