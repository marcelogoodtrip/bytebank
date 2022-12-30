using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int ContasCriadas { get; private set; }

        private int numero_agencia;
        private double saldo;

        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set 
            {
                if(value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }

        public string Conta { get; set; }

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            Console.WriteLine("Deposito Realizado com Sucesso!");
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                Console.WriteLine("Saque Realizado com Sucesso!");
                saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Valor em conta insuficiente!");
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                Console.WriteLine("Valor em conta insuficiente!");
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);

                Console.WriteLine("Transferência realizada com sucesso!");
                return true;
            }
        }

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            } else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + Titular.Nome);
            Console.WriteLine("CPF: " + Titular.Cpf);
            Console.WriteLine("Profissão: " + Titular.Profissao);
            Console.WriteLine("N° Conta: " + Conta);
            Console.WriteLine("N° Agência: " + Numero_agencia);
            Console.WriteLine("Saldo: " + GetSaldo());
        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            this.numero_agencia = numero_agencia;
            this.Conta = conta;
            ContasCriadas++;
        }
    }
}
