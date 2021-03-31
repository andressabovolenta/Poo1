using System;

namespace POO1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancária contaBancária = new ContaBancária(200);

            contaBancária.Agência = "0123";
            contaBancária.Conta = "456789-0";
            contaBancária.Nome = "Andressa Bovolenta";
            contaBancária.Senha = "098765"

            contaBancária.ImprimirSaldo();

        }
    }
}