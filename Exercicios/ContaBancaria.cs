using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    class ContaBancaria
    {
        public int NConta { get; set; }
        public string Nome { get; set; }
        public int Saldo { get; set; }

        public ContaBancaria(int nuConta, string tit)
        {
            NConta = nuConta;
            Nome = tit;
        }

        public ContaBancaria(int nuConta, string tit, int saldo): this (nuConta, tit)
        {
            Saldo = saldo;
        }             

        public void Deposito(int deposito)
        {
            Saldo += deposito;
        }

        public void Saque (int saque)
        {
            Saldo -= saque + 5;
        }
    }
}
